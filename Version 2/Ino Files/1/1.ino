//designed for an arduino mega
//pair numbers are for a step signal and an idd number are for a sens signal

#define first_pin 22
#define number_of_motor 4

//EVery stepper has his own ratio
float step_to_degrees[4] = {0.06, 0.166667, 1, 1 };
//This value is in stepp, not in degrees
int order[4] = {0,0, 0, 0};



void setup()
{
    //Initialize our output pin for our motors
    for(int i = 0; i<2*number_of_motor; i++)pinMode(first_pin+i, OUTPUT);

    digitalWrite(25, HIGH);
    
}

void loop()
{
    
    
    //Here is where we ask the motor to moove
    
    for()
}