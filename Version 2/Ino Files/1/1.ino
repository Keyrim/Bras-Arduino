//designed for an arduino mega
//pair numbers are for a step signal and an idd number are for a sens signal

#define first_pin 22
#define number_of_motor 4


void setup()
{
    //Initialize our output pin for our motors
    for(int i = 0; i<2*number_of_motor; i++)pinMode(first_pin+i, OUTPUT);

    digitalWrite(25, HIGH);
    
}

void loop()
{
    digitalWrite(24, HIGH);
    digitalWrite(24, LOW);
    delayMicroseconds(1000);
}