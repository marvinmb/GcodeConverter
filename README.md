# GcodeConverter
Gcode converter from [LaserWEB4](https://github.com/LaserWeb/LaserWeb4) generated Gcode to Marlin compatible Gcode
I use my old 3D printer with RAMPS and Marlin fimware for laser engraving and cutting, but pretty good program LASER WEB is not compatible with Marlin firmware, I hope, that is only temporary solution and Laser WEB will support Marlin firmware soon.  
sorry only for Windows (Visual Studio 2017)  
[windows binary](../blob/master/gcodeconverter.exe)

Gcode from LaserWEB application
  
  G0 X34.26 Y63.52 S0.0000  
  G1 X34.36 S0.0196  
  X34.56 S0.0627  
  X34.76 S0.5882

to Marlin compatible form
  
  M107  
  G0 X34.26 Y63.52   
  M106 S4  
  G1 X34.36   
  M106 S15  
  G1 X34.56   
  M106 S149 ; S0.5882  
  G4 P50    ; laser start time, added by GcodeConvertor  
  G1 X34.76 

Version 1.0
  * make verbose Gcode command, **X10 S1.0** is converted to **M106 S255** and **G1 X10**
  * if laser start time > 0 then command **G4 Pxx** is added
  * when PWM is disabled converter uses  **M106** without **S** parameter
  * you can customize **LASER ON** and **OFF** commands (for RAMPS D9 output for PWM )
  * multiple **X** commands without **S** parametr are converted to single command **G1 Xlast_position**, all the same for **Y** command
