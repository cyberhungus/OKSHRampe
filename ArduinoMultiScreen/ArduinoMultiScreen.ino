
//needed for serial communication system
const byte numChars = 64;
char receivedChars[numChars];

boolean newData = false;
int dataNumber = 0;

//definitions for servo - connect servo control wire to 9 (or change this field)

int relayPinA = 25;
int relayPinB = 26;

//Connect Sensors to these pins, or change fields
int SensorAPin = 14;
int SensorBPin = 27;
int SensorCPin = 16;
int SensorDPin = 17;


//holds message to send
String toSend = "0000";


void setup() {
  Serial.begin(2000000);
  Serial.println("<Arduino is ready>");

  //make sensor pins input pins
  pinMode(SensorAPin, INPUT_PULLUP);
  pinMode(SensorBPin, INPUT_PULLUP);
  pinMode(SensorCPin, INPUT_PULLUP);
  pinMode(SensorDPin, INPUT_PULLUP);

  pinMode(relayPinA, OUTPUT);
pinMode(relayPinB, OUTPUT);


}

void loop() {
  recvWithStartEndMarkers();
  showNewData();
  readSensors();
  
  //startMotorTest();
}

//checks the sensors and modifiies toSend string
void readSensors() {
  int state = 0;
  //erster Sensor
  state = digitalRead(SensorAPin);
  // Serial.println("Sensor A: " + state);
  if (state == 0) {
    toSend[0] = '1';
    Serial.println("<1000>");
  }
  else {
    toSend[0] = '0';
  }
  //zweiter sensor
  state = digitalRead(SensorBPin);
  //  Serial.println("Sensor B: " + state);
  if (state == 0) {
    toSend[1] = '1';
    Serial.println("<0100>");
  }
  else {
    toSend[1] = '0';
  }
  //dritter sensor
  state = digitalRead(SensorCPin);
  //Serial.println("Sensor C: " + state);
  if (state == 0) {
    toSend[2] = '1';
    Serial.println("<0010>");
  }
  else {
    toSend[2] = '0';
  }
  //vierter sensor
  state = digitalRead(SensorDPin);
  // Serial.println("Sensor D: " + state);
  if (state == 0) {
    toSend[3] = '1';
    Serial.println("<0001>");
  }
  else {
    toSend[3] = '0';
  }
}

//sends message with < and > added
void sendNewData() {
  Serial.println("<0010>");
  toSend = "0000";
}

//receives messages dilineated by < and > symbols
void recvWithStartEndMarkers() {
  static boolean recvInProgress = false;
  static byte ndx = 0;
  char startMarker = '<';
  char endMarker = '>';
  char rc;

  while (Serial.available() > 0 && newData == false) {
    rc = Serial.read();

    if (recvInProgress == true) {
      if (rc != endMarker) {
        receivedChars[ndx] = rc;
        ndx++;
        if (ndx >= numChars) {
          ndx = numChars - 1;
        }
      } else {
        receivedChars[ndx] = '\0';  // terminate the string
        recvInProgress = false;
        ndx = 0;
        newData = true;
      }
    }

    else if (rc == startMarker) {
      recvInProgress = true;
    }
  }
}

//when a complete message was received, this function is called
//analyses received message and moves motor
void showNewData() {
  if (newData == true) {
    newData = false;
    String incomingByte = String(receivedChars);
    //check if system SHOULD act on this message
    if (incomingByte.substring(0, 4).equals("SYS-")) {
      //GET PARAMETERS as string
      String relayString = incomingByte.substring(4, 7);
      int relayint = relayString.toInt();
      if (relayint > 50 && relayint <=100) {
        updateRelay(true);
      }
      else {
        updateRelay(false);
      }
      if (relayint == 101) {
        Serial.println("<1000>");

      }
      if (relayint == 102) {
        Serial.println("<0100>");

      }
      if (relayint == 103) {
        Serial.println("<0010>");

      }
      if (relayint == 104) {
        Serial.println("<0001>");

      }

      

    }
  }
}

//transfers motor position to motor


void updateRelay(boolean A) {
  if (A == false) {
    digitalWrite(relayPinA, HIGH);
    digitalWrite(relayPinB, HIGH);
  }
  else {
    digitalWrite(relayPinA, LOW);
    digitalWrite(relayPinB, LOW);
  }
}
