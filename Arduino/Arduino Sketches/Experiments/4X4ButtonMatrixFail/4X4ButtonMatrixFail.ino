#define c1 9
#define c2 8
#define c3 7
#define c4 6
#define r1 10
#define r2 11
#define r3 12
#define r4 13
#include <LiquidCrystal_I2C.h>

LiquidCrystal_I2C lcd(0x27,16,2);

int rollStep = 0;
void setup() {
  // put your setup code here, to run once:
  lcd.init();
  lcd.clear();         
  lcd.backlight();
  Serial.begin(9600);
  pinMode(c1, INPUT);
  pinMode(c2, INPUT);
  pinMode(c3, INPUT);
  pinMode(c4, INPUT);
  pinMode(r1, OUTPUT);
  pinMode(r2, OUTPUT);
  pinMode(r3, OUTPUT);
  pinMode(r4, OUTPUT);
  
}

void loop() {
  // put your main code here, to run repeatedly:
  digitalWrite(r1, HIGH);
  int jeri = MatrixButton(rollStep);
  
  if (rollStep >= 4) {
    rollStep = 0;
  }
  rollStep++;
}


int MatrixButton(int r) {
  int c = 0;
  switch (r) {
    case 1:
    Serial.println(c1);
    Serial.println(digitalRead(c1));
    digitalWrite(r1, HIGH);
    digitalWrite(r2, LOW);
    digitalWrite(r3, LOW);
    digitalWrite(r4, LOW);
    if (digitalRead(c1) == 0) {
      c = 1;
    }
    if (digitalRead(c2) == 0) {
      c = 2;
    }
    if (digitalRead(c3) == 0) {
      c = 3;
    }
    if (digitalRead(c4) == 0) {
      c = 4;
    }
    
    switch (c) {
        case 1:
          return 1;
        break;
        case 2:
          return 2;
        break;
        case 3:
          return 3;
        break;
        case 4:
          return 4;
        break;
        default:
         return 0;
        break;
    }
    break;
    case 2:
    Serial.println(c2);
    Serial.println(digitalRead(c2));
    digitalWrite(r1, LOW);
    digitalWrite(r2, HIGH);
    digitalWrite(r3, LOW);
    digitalWrite(r4, LOW);
    if (digitalRead(c1) == 0) {
      c = 1;
    }
    if (digitalRead(c2) == 0) {
      c = 2;
    }
    if (digitalRead(c3) == 0) {
      c = 3;
    }
    if (digitalRead(c4) == 0) {
      c = 4;
    }
    switch (c) {
        case 1:
          return 5;
        break;
        case 2:
          return 6;
        break;
        case 3:
          return 7;
        break;
        case 4:
          return 8;
        break;
        default:
         return 0;
        break;
    }
    
    break;
    case 3:
    Serial.println(c3);
    Serial.println(digitalRead(c3));
    digitalWrite(r1, LOW);
    digitalWrite(r2, LOW);
    digitalWrite(r3, HIGH);
    digitalWrite(r4, LOW);
    if (digitalRead(c1) == 0) {
      c = 1;
    }
    if (digitalRead(c2) == 0) {
      c = 2;
    }
    if (digitalRead(c3) == 0) {
      c = 3;
    }
    if (digitalRead(c4) == 0) {
      c = 4;
    }
    switch (c) {
        case 1:
          return 9;
        break;
        case 2:
          return 10;
        break;
        case 3:
          return 11;
        break;
        case 4:
          return 12;
        break;
        default:
         return 0;
        break;
    }
    
    break;
    case 4:
    Serial.println(c4);
    Serial.println(digitalRead(c4));
    
    digitalWrite(r1, LOW);
    digitalWrite(r2, LOW);
    digitalWrite(r3, LOW);
    digitalWrite(r4, HIGH);
    if (digitalRead(c1) == 0) {
      c = 1;
    }
    if (digitalRead(c2) == 0) {
      c = 2;
    }
    if (digitalRead(c3) == 0) {
      c = 3;
    }
    if (digitalRead(c4) == 0) {
      c = 4;
    }
    switch (c) {
        case 1:
          return 13;
        break;
        case 2:
          return 14;
        break;
        case 3:
          return 15;
        break;
        case 4:
          return 16;
        break;
        default:
         return 0;
        break;
    }
    
    break;
  }
  
}
