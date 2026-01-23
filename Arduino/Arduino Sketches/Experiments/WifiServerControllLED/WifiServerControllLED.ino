#include <WiFi.h>

//const char* ssid = "A1_A6F540";
//const char* password = "ba659b86";
// const char* ssid = "SoftUni_Svetlina_Students";
// const char* password = "9v9HuLByWb";
const char* ssid = "JERICONDENZATOR";
const char* password = "Jerofil123";



WiFiServer server(80);

int LED1 = 39; 
int LED2 = 40; 

void setup() {
  pinMode(LED1, OUTPUT);
  pinMode(LED2, OUTPUT);

  Serial.begin(115200);
  delay(10);

  Serial.println();
  Serial.print("Connecting to ");
  Serial.println(ssid);

  WiFi.begin(ssid, password);

  while (WiFi.status() != WL_CONNECTED) {
    delay(500);
    Serial.print(".");
  }

  Serial.println("");
  Serial.println("WiFi connected");
  Serial.println("IP address: ");
  Serial.println(WiFi.localIP());

  server.begin();
  digitalWrite(39, HIGH);
  digitalWrite(40, HIGH);
}

void loop() {
  WiFiClient client = server.available();
  if (client) {
    Serial.println("New client connected.");
    while (client.connected()) {
      if (client.available()) {
        String command = client.readStringUntil('\n');
        Serial.print("Received command: ");
        Serial.println(command);

        
        if (command.indexOf("1ON") != -1) {
          digitalWrite(LED1, HIGH);
        } else if (command.indexOf("1OFF") != -1) {
          digitalWrite(LED1, LOW);
        } else if (command.indexOf("2ON") != -1) {
          digitalWrite(LED2, HIGH);
        } else if (command.indexOf("2OFF") != -1) {
          digitalWrite(LED2, LOW);
        }

        client.println("Command received!");
      }
    }
    client.stop();
    Serial.println("Client disconnected.");
  }
}
