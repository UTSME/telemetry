char incomingByte = 0;   // for incoming serial data

void setup() {

  Serial1.begin(9600);
  Serial.begin(9600);
  //Serial.println("Begin");

  pinMode(13, OUTPUT);

}

void loop() {
   
    // start transmitting after a startup delay.  Note: this will rollover to 0 eventually so not best way to handle

    //if(Serial1.available()) {
    //  Serial.println(Serial1.read(), BYTE);
   // } else {
   //   Serial.println("No Data!");
   // }

    Serial.println(Serial1.available());
    Serial.println(Serial1.read());

    digitalWrite(13, HIGH);

    delay(500);

    digitalWrite(13, LOW);

    delay(500);
}
