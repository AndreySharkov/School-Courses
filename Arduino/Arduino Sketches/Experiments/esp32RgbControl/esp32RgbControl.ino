
void setup() {
  // No need to initialize the RGB LED
}

// the loop function runs over and over again forever
void loop() {

  
  
  for (int i = 0; i <= 255; i++) {
    neopixelWrite(RGB_BUILTIN,i, 3, 3); 
    delay(20);
  }
  for (int i = 0; i <= 255; i++) {
    neopixelWrite(RGB_BUILTIN,255, i, 3); 
    delay(20);
  }

  for (int i = 255; i <= 3; i--) {
    neopixelWrite(RGB_BUILTIN,i, 255, 3); 
    delay(20);
  }
  for (int i = 0; i <= 255; i++) {
    neopixelWrite(RGB_BUILTIN,3, 255, i); 
    delay(20);
  }
  for (int i = 255; i <= 3; i--) {
    neopixelWrite(RGB_BUILTIN,3, i, 255); 
    delay(20);
  }
  for (int i = 255; i <= 3; i--) {
    neopixelWrite(RGB_BUILTIN,3, 3, i); 
    delay(20);
  }  
  
  

}
