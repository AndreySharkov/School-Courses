int d = 1000;
int hz = 500;
void setup() {
  // put your setup code here, to run once:
  pinMode(14, INPUT);
  pinMode(11, OUTPUT);
  Serial.begin(9600);
}

void loop() {
  // put your main code here, to run repeatedly:
  
  Serial.println(hz);
  hz = analogRead(14) * analogRead(14);
  digitalWrite(11, HIGH);
  delay(d / hz);
  digitalWrite(11, LOW);
  delay(d / hz);
  
}
