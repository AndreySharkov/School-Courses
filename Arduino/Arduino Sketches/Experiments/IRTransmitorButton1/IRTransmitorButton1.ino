#include <IRremote.h>

const int RECV_PIN = 3;
const int LED_PIN = 7;

IRrecv irrecv(RECV_PIN);


decode_results results;
// Variable for whether or not the LED should be turned on 
bool shouldTurnLedOn = false;
// The expected hex value for triggering the LED state
const unsigned long expectedHex = 0xFEA857;


void setup()
{
  // Start serial
  Serial.begin(9600);
  // Enable IR incoming
  irrecv.enableIRIn();
  // Set pin mode for LED PIN to output 
  pinMode(LED_PIN, OUTPUT);
}

void loop()
{
  
  if (shouldTurnLedOn)
  {
    digitalWrite(LED_PIN, HIGH);
  }
  else 
  {
    digitalWrite(LED_PIN, LOW);
  }
  
  if (irrecv.decode(&results))
  {
    Serial.println(results.value, HEX);
    
    if (results.value == expectedHex)
    {
      shouldTurnLedon = !shouldTurnLedon;
    }
    
    irrecv.resume();
  }
  

}