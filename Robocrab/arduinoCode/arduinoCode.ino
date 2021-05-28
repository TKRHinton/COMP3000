#include <Servo.h>
Servo motor;//motor one
Servo motor2;//motor one
char input;

void setup() {
  // put your setup code here, to run once:

  Serial.begin(9600);
  motor.attach(3);
  motor2.attach(5);

  delay(2000);

  Serial.println("Type Somthing");
}

void loop() {
  // put your main code here, to run repeatedly:

  String string;
  String outputString;
  String rapSpeed;
  String rapDuration;
  String rapAngle;
  String rapRotation;

//  while (Serial.available()){
//    delay(5)
//    if(Serial)
//  }

  if(Serial.available()) {

    outputString = Serial.readStringUntil('\n');
    Serial.print("You typed ");
    Serial.print(outputString);

   // motor.write(0);
   // delay(1000);
   // motor.write(180);
   
  }

  if (outputString == "open")
  {
    motor.write(0);
    delay(1000);
  }

   if (outputString == "close")
  {
    motor.write(180);
    delay(1000);
  }

   if (outputString == "reset")
  {
    motor.write(90);
    delay(1000);
  }

  if (outputString == "test")
  {
    
    for (int i = 0; i <= 100; i++) {
       Serial.print("Test ");
       motor2.write(90);
       delay(200);
       motor2.write(110);
       delay(200);
     }
  }

  if (outputString == "rap")
  {
    delay(25);
    rapSpeed = Serial.readStringUntil('\n');
    delay(25);
    rapDuration = Serial.readStringUntil('\n');
    delay(20);
    rapAngle = Serial.readStringUntil('\n');
    delay(20);
    rapRotation = Serial.readStringUntil('\n');

    motor2.write(rapAngle.toInt());
    delay(500);
    
    for (int i = 0; i <= rapDuration.toInt(); i++) {
       motor2.write(rapAngle.toInt());
       delay(rapSpeed.toInt());
       motor2.write((rapAngle.toInt() + rapRotation.toInt()));
       delay(rapSpeed.toInt());
     }
  }



}