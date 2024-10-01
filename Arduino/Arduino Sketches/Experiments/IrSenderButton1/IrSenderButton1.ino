#include <IRremote.hpp>


const int switchPin = 0;
int buttonState = 0;

IRsend irsend;

void setup() {
  // put your setup code here, to run once:
  pinMode(switchPin, INPUT);
}

void loop() {
  buttonState = digitalRead(switchPin) ;

  if (buttonState == HIGH)
  {
    irsend.sendNEC(0xFEA857, 32);
  }

  delay(200);


}
