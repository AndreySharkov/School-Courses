
#include <LiquidCrystal_I2C.h>

LiquidCrystal_I2C lcd(0x27,16,2); 


void setup() {
  lcd.init();
  lcd.clear();         
  lcd.backlight();      
  Serial.begin(9600);
  char name[] = "Andrey";
  
  lcd.print("65, 110, 100, 114, 101, 121");
  
  
}

void loop() {
  if (Serial.available() > 0) {
    
    String inputString = Serial.readString();
    lcd.clear();
    for (int i = 0; i < inputString.length(); i += 16) {
      lcd.setCursor(0, i / 16);
      if (i + 16 < inputString.length()) {
        
        lcd.print(inputString.substring(i, i + 16));
      } 
      else {
        if (inputString.length() > 0) {
        inputString.remove(inputString.length() - 1);
      }
        lcd.print(inputString.substring(i));
      }
    }
  }

  
}