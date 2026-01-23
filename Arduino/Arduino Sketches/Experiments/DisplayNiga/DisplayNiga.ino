#include "SevSeg.h"
SevSeg sevseg; 

void setup(){
  byte numDigits = 4;
  byte digitPins[] = {10, 11, 12, 13};
  byte segmentPins[] = {9, 8, 7, 6, 5, 4, 3, 2};

  bool resistorsOnSegments = true; 
  bool updateWithDelaysIn = true;
  byte hardwareConfig = COMMON_CATHODE; 
  sevseg.begin(hardwareConfig, numDigits, digitPins, segmentPins, resistorsOnSegments);
  sevseg.setBrightness(100);
}

void loop(){
    
  //sevseg.setNumber(444); 
  
  sevseg.setChars("jeri");
  sevseg.refreshDisplay(); 
  
      
    
}