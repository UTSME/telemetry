bool STATUS_LED = 0;
int STATUS_TIMER = 50000;
int stsCount = 0;

void setup() {

  Serial1.begin(9600);
  Serial.begin(9600);
  //Serial.println("Begin");

  pinMode(13, OUTPUT);

}

void loop() {
   
    // start transmitting after a startup delay.  Note: this will rollover to 0 eventually so not best way to handle

    if(Serial1.available()) {
      
      Serial.println(Serial1.read(), BYTE);

   } else {
      Serial.println("NODT");
   }

    if (stsCount > STATUS_TIMER) {
      stsCount = 0;
      STATUS_LED = !STATUS_LED;
    } else {
      stsCount++;
    }

    digitalWrite(13, STATUS_LED);

}
