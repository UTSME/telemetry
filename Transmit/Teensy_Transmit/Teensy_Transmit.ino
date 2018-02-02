int counter = 0;
String msg = "";

void setup() {

  Serial1.begin(9600);
  Serial.begin(9600);

}

void loop() {

  msg = String("Hello - ") + counter;

  Serial1.println(msg);
  Serial.println(msg);

  counter++;
  delay(100);

  if (counter > 1000) {
    counter = 0;
  }

}
