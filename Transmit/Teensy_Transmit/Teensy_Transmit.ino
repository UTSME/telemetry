int counter = 0;
String msg = "";
String STOPBIT = "#";

bool STATUS_LED = 0;
int STATUS_TIMER = 5;
int stsCount = 0;

void setup() {

  Serial1.begin(9600);
  Serial.begin(9600);

  pinMode(13, OUTPUT);

}

void loop() {

  msg = String("SPD-") + counter + STOPBIT;

  Serial1.print(msg);
  Serial.println(msg);

  counter++;

  if (counter > 1000) {
    counter = 0;
  }


  if (stsCount > STATUS_TIMER) {
      stsCount = 0;
      STATUS_LED = !STATUS_LED;
  } else {
      stsCount++;
  }

    digitalWrite(13, STATUS_LED);

    delay(100);

}
