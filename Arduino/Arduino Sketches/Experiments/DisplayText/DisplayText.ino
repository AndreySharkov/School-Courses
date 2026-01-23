#include <SPI.h>
#include <Wire.h>
#include <Adafruit_GFX.h>
#include <Adafruit_SSD1306.h>

#define SCREEN_WIDTH 128 
#define SCREEN_HEIGHT 64 
#define OLED_RESET     -1 // Reset pin # (or -1 if sharing Arduino reset pin)
#define SCREEN_ADDRESS 0x3C ///< See datasheet for Address; 0x3D for 128x64, 0x3C for 128x32
Adafruit_SSD1306 display(SCREEN_WIDTH, SCREEN_HEIGHT, &Wire, OLED_RESET);
int counter=0;
String dir="";
unsigned long lastRun=0;

void setup() {
  Serial.begin(9600);
  if(!display.begin(SSD1306_SWITCHCAPVCC, SCREEN_ADDRESS)) {
    for(;;); 
  }
  display.display();
  display.clearDisplay();
  attachInterrupt (digitalPinToInterrupt (3), shaftMoved, FALLING) ;
  pinMode(4, INPUT);

}

void loop() {
  display.setTextSize(2); 
  display.setTextColor(SSD1306_WHITE);
  display.setCursor(0, 0);
  display.println(counter);
  display.println(dir);
  display.display(); 
  display.clearDisplay(); 
  
  
}
void shaftMoved() {
  if (millis()-lastRun>5) {
    if (digitalRead (4) ==1) {
      counter--;
      dir="CCW";
    }
    if (digitalRead (4) ==0) {
      counter++;
      dir="CW";
    }
    lastRun = millis();
  }
}
