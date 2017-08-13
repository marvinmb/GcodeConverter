# GcodeConverter
Gcode converter from LaserWEB generated Gcode to Marlin compatible Gcode

Gcode from LaserWEb application
  
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
