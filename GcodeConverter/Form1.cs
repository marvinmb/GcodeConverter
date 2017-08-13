/**
 * Gcode converter
 * Copyright (C) 2017 Milan Peksa
 *
 *
 * This program is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with this program.  If not, see <http://www.gnu.org/licenses/>.
 *
 */


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GcodeConverter
{
    public partial class Form1 : Form
    {
        string[] fns;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lb.Items.Clear();
            lb2.Items.Clear();
            ofDlg.Multiselect = true;
            var dr=ofDlg.ShowDialog();
            if (dr == DialogResult.OK)
            {
                fns = ofDlg.FileNames;
                foreach (string s in fns) lb.Items.Add(s);
            }
            else
                fns = null;
        }

        private void laserOFF_TextChanged(object sender, EventArgs e)
        {

        }

        private void Convert_Click(object sender, EventArgs e)
        {
            string lineOfText;
            string LastCmd = "";
            StringBuilder os=new StringBuilder();
            foreach (string f in fns)
            {
                
                    string of = System.IO.Path.GetDirectoryName(f) + "\\" + System.IO.Path.GetFileNameWithoutExtension(f) + ".marlin" + System.IO.Path.GetExtension(f);
                    System.IO.FileStream fs,fsw;
                    using (fs = new System.IO.FileStream(f, System.IO.FileMode.Open, System.IO.FileAccess.Read))
                    {
                        using (fsw = new System.IO.FileStream(of, System.IO.FileMode.Create, System.IO.FileAccess.Write))
                        {
                            double lastspeed = 9999;
                           
                            var file = new System.IO.StreamReader(fs, System.Text.Encoding.UTF8, true);
                            var fileW = new System.IO.StreamWriter(fsw, System.Text.Encoding.UTF8);
                            while ((lineOfText = file.ReadLine()) != null)
                            { 
                                restart:
                                bool comment = false;
                                bool cmdflag = false;
                                bool speedflag = false;
                                os.Clear();
                                double speed=0.0;
                                string comapp = "";
                                var rc= lineOfText.Trim().Split(';')[0];
                                if (lineOfText.Trim().Split(';').Length>1)// save comment 
                                {
                                    for (int k=1;k<lineOfText.Trim().Split(';').Length;k++)
                                    {
                                    comapp +=";" + lineOfText.Trim().Split(';')[k];
                                    }
                                }
                                var ss = rc.Trim().Split(' ');
                                if (ss[0].Length > 0)
                                {
                                    
                                    if (ss[0][0] == 'G') { LastCmd = ss[0]; cmdflag = true; }
                                    if (ss[0][0] == 'X' && ss.Length < 2 && !cmdflag) 
                                    {
                                        repeatreading:
                                        String tmp = file.ReadLine();
                                        if (tmp!= null && tmp.Trim().Length>2)
                                        {

                                            if (tmp[0] == 'X' && ss.Length < 2)
                                            {
                                            lineOfText = tmp;
                                            goto repeatreading;

                                            }
                                            else
                                            {
                                            fileW.WriteLine(LastCmd + ' ' + lineOfText);
                                            lineOfText = tmp;
                                            goto restart;
                                            }
                                            

                                        }
                                        else
                                        fileW.WriteLine(LastCmd + ' ' + lineOfText);
                                        lineOfText = "  "; 
                                        goto restart;
                                    }
                                if (ss[0][0] == 'Y' && ss.Length < 2 && !cmdflag)
                                {
                                repeatreading:
                                    String tmp = file.ReadLine();
                                    if (tmp != null && tmp.Trim().Length > 2)
                                    {

                                        if (tmp[0] == 'Y' && ss.Length < 2)
                                        {
                                            lineOfText = tmp;
                                            goto repeatreading;

                                        }
                                        else
                                        {
                                            fileW.WriteLine(LastCmd + ' ' + lineOfText);
                                            lineOfText = tmp;
                                            goto restart;
                                        }


                                    }
                                    else
                                        fileW.WriteLine(LastCmd + ' ' + lineOfText);
                                    lineOfText = "  ";
                                    goto restart;
                                }


                                if ( ss[0].ToUpper()[0] != 'M') // only G and M  commands are alowed for proper function
                                    {
                                        if (!cmdflag) os.Append(LastCmd + ' ');
                                        foreach (string ps in ss)
                                        {
                                        
                                            if (ps.Length == 0)
                                                os.Append(" ");
                                            else
                                            {
                                                if (ps[0] == ';') comment = true;
                                                if (ps.ToUpper()[0] != 'S' || comment)
                                                {
                                                    os.Append(ps + " ");
                                                }
                                                else
                                                {  // S attribut
                                                    speedflag = true;
                                                    bool rt = Double.TryParse(ps.Substring(1), System.Globalization.NumberStyles.Number, System.Globalization.CultureInfo.CreateSpecificCulture("en-US"), out speed);
                                                    if (!rt) speed = lastspeed;

                                                }
                                            }
                                        }

                                        if (lastspeed != speed && speedflag)
                                        {
                                        if (speed > 0)
                                        { 
                                            if (pwmEnabled.Checked)
                                                fileW.WriteLine(laserON.Text + " S" + ((int)(speed * 255.0)).ToString());
                                            else
                                                fileW.WriteLine(laserON.Text);
                                            if (starttime.Value>0 && speed>0.5) fileW.WriteLine("G4 P" + starttime.Value.ToString());
                                        }
                                        else
                                        {

                                            fileW.WriteLine(laserOFF.Text);
                                        }
                                            lastspeed = speed;
                                        }
                                        else
                                        {
                                        if (LastCmd.Contains("G0") && lastspeed == 1)// for G0 commands without S attribute
                                        {
                                            fileW.WriteLine(laserOFF.Text);
                                            lastspeed = 0;
                                        }
                                        if (LastCmd.Contains("G1") && lastspeed == 0)// for G1 commands without S attribute
                                        {
                                            fileW.WriteLine(laserON.Text + " S255");
                                            if (starttime.Value > 0 && speed > 0.5) fileW.WriteLine("G4 P" + starttime.Value.ToString());
                                            lastspeed = 1;
                                        }
                                    }
                                

                                    }
                                    else
                                        os.Append(rc);
                                }
                                fileW.WriteLine(os + comapp);
                               
                            }
                            fileW.WriteLine(laserOFF.Text);
                            fileW.Flush();

                        }
                    }

                lb2.Items.Add(of);






            }


        }
    }
}
