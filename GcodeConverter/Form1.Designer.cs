namespace GcodeConverter
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.ofDlg = new System.Windows.Forms.OpenFileDialog();
            this.lb = new System.Windows.Forms.ListBox();
            this.convert = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.laserON = new System.Windows.Forms.TextBox();
            this.laserOFF = new System.Windows.Forms.TextBox();
            this.pwmEnabled = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lb2 = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.starttime = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.starttime)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(29, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(621, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "Choose LaserWEB Gcode files";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ofDlg
            // 
            this.ofDlg.FileName = "*.gcode";
            // 
            // lb
            // 
            this.lb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb.FormattingEnabled = true;
            this.lb.Location = new System.Drawing.Point(29, 90);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(621, 82);
            this.lb.TabIndex = 1;
            // 
            // convert
            // 
            this.convert.Location = new System.Drawing.Point(29, 200);
            this.convert.Name = "convert";
            this.convert.Size = new System.Drawing.Size(285, 35);
            this.convert.TabIndex = 2;
            this.convert.Text = "Convert to Marlin Gcode";
            this.convert.UseVisualStyleBackColor = true;
            this.convert.Click += new System.EventHandler(this.Convert_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(337, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Laser ON command:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(337, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Laser OFF command:";
            // 
            // laserON
            // 
            this.laserON.Location = new System.Drawing.Point(447, 193);
            this.laserON.Name = "laserON";
            this.laserON.Size = new System.Drawing.Size(63, 20);
            this.laserON.TabIndex = 4;
            this.laserON.Text = "M106";
            // 
            // laserOFF
            // 
            this.laserOFF.Location = new System.Drawing.Point(447, 220);
            this.laserOFF.Name = "laserOFF";
            this.laserOFF.Size = new System.Drawing.Size(63, 20);
            this.laserOFF.TabIndex = 4;
            this.laserOFF.Text = "M107";
            this.laserOFF.TextChanged += new System.EventHandler(this.laserOFF_TextChanged);
            // 
            // pwmEnabled
            // 
            this.pwmEnabled.AutoSize = true;
            this.pwmEnabled.Checked = true;
            this.pwmEnabled.CheckState = System.Windows.Forms.CheckState.Checked;
            this.pwmEnabled.Location = new System.Drawing.Point(535, 192);
            this.pwmEnabled.Name = "pwmEnabled";
            this.pwmEnabled.Size = new System.Drawing.Size(129, 17);
            this.pwmEnabled.TabIndex = 5;
            this.pwmEnabled.Text = "PWM control enabled";
            this.pwmEnabled.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Input Files";
            // 
            // lb2
            // 
            this.lb2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb2.FormattingEnabled = true;
            this.lb2.Location = new System.Drawing.Point(29, 286);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(621, 82);
            this.lb2.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Output Files";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(337, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Laser start time [ms]:";
            // 
            // starttime
            // 
            this.starttime.Location = new System.Drawing.Point(447, 250);
            this.starttime.Name = "starttime";
            this.starttime.Size = new System.Drawing.Size(63, 20);
            this.starttime.TabIndex = 10;
            this.starttime.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 414);
            this.Controls.Add(this.starttime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pwmEnabled);
            this.Controls.Add(this.laserOFF);
            this.Controls.Add(this.laserON);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.convert);
            this.Controls.Add(this.lb);
            this.Controls.Add(this.button1);
            this.MinimumSize = new System.Drawing.Size(690, 450);
            this.Name = "Form1";
            this.Text = "LaserWEB Gcode to Marlin Gcode";
            ((System.ComponentModel.ISupportInitialize)(this.starttime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog ofDlg;
        private System.Windows.Forms.ListBox lb;
        private System.Windows.Forms.Button convert;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox laserON;
        private System.Windows.Forms.TextBox laserOFF;
        private System.Windows.Forms.CheckBox pwmEnabled;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lb2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown starttime;
    }
}

