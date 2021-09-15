#include <Mouse.h>
#define DRUM1 0    // Our analog pin
#define DRUM2 1

void setup() {
  //configure pin 3 as an input and enable pull-up
  pinMode(3, INPUT_PULLUP);
  // initialize the drums' inputs:
  pinMode(DRUM1, INPUT);
  pinMode(DRUM2, INPUT);
  
  Serial.begin(9600);  // Initializing the serial port at 9600 baud

  // initialize mouse control:
  Mouse.begin();
}

void loop() {
  //read the pushbutton value into a variable
  int switchVal = digitalRead(3);

  // read the piezos:
  float upState = analogRead(DRUM1);
  float downState = analogRead(DRUM2);

  Serial.println(upState);
  Serial.println(downState);

  float  yPosDistance = (-upState);
  float  yNegDistance = (downState);

  if(switchVal == LOW){
    // if Y is non-zero, move:
    if (upState > 50 && upState > downState) {
      Mouse.move(0, yPosDistance, 0);
     delay(10);
    }
    else if (downState > 50 && downState > upState) {
      Mouse.move(0, yNegDistance, 0);
      delay(10);
    }
    // a delay so the mouse doesn't move too fast:
    delay(100);
    }
}
