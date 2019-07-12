
//Variables timer
unsigned long curentTime,timer [8] ;
unsigned long loop_timer, timer_timer;
unsigned long stepper_timer[4]  ; 
float acceleration_duration =  1;
unsigned long t0[4] ;
unsigned long timer_moteur[4] ;

//variables position 
byte state_stepper[4] = {0,0,0,0} ;
float position_moteur[4] = {180,220,90,180} ;
int stepps_during_acceleration [4] ;
float position_moteur_initiale[4]  ;

float angle_by_step [4] = {0.195 , 0.0246405096, 0.14532872, 1};
//13/60 * 1.8 /2 
//10/17 * 7/17 * 7/17 * 7/51 * 1.8
//10/17 * 7/51 * 1.8


//Variables deplacement
float vitesse_stepper[4] ;
int sens_stepper[4] ;  
int vitesse_moteur[4] = {300, 300, 300, 300};
int vitesse_mini = 200 ;
int vitesse_max[4] = {800, 2200, 2200, 1000} ; 
unsigned int consigne_moteur[4] = {180,220,90,180} ;
float acceleration [4] ={(vitesse_max[0]-vitesse_mini)/sq(acceleration_duration), (vitesse_max[1]-vitesse_mini)/sq(acceleration_duration), (vitesse_max[2]-vitesse_mini)/sq(acceleration_duration), (vitesse_max[3]-vitesse_mini)/sq(acceleration_duration)};
int phase[4] = {1, 1, 1, 1} ;

//Variables Séries
byte nb_donne_tampon = 0 ;
int tampon[4] = {180,220,90,180};
String mot ="" ;
bool data_available = false ;

//Variables qu gére alim moteurs par relais
bool relais = true ;

//////////////////////////////////////////

int step_ = 0;

void bouge(int stepper, int sens)
{
  digitalWrite(23+2*stepper, sens);
  digitalWrite(22+2*stepper, HIGH);
  delayMicroseconds(50);
  digitalWrite(22+2*stepper, LOW);
}

void reset_a_stepper(int stepper_number)
{
  t0[stepper_number] = millis();
  phase[stepper_number] = 1 ;
  position_moteur_initiale[stepper_number] = position_moteur[stepper_number] ;
}



/////////////////////////////////////////////////////////////////////////
void setup() 
{
  for (int n =5 ; n <40; n++)pinMode(n, OUTPUT);
  Serial.begin(9600);  
  loop_timer= micros();
  //On start les timers moteurs
  for(int i = 0; i <4; i++)timer_moteur[i] = micros();
  
}

void loop() 
{
  //On lit les données disponible
  while(Serial.available()>0)
  {
    char msg = Serial.read();    
    if(msg == '\n')data_available = true ;
    else mot.concat(msg) ;    
  } 
  //Une fois qu'on a toutes les donnée, on peut mettre a jour les consignes moteurs  if(data_available)
  if(data_available == true)
  { 
    //On traite les données reçu
    digitalWrite(13, 255);
    data_available = false;
    int nombre = mot.toInt();    
    int indice = nombre & 15 ;
    nombre -= indice ;    
    nombre = nombre >> 4; 
    
    //Si on a un indice de 10 cela implique que les données a suivre iront en mémoire tampon
    if( indice == 10){
     analogWrite(13, 100);
      nb_donne_tampon = nombre ; 
    }
   
    //Si l'indice est de 11 cela signifie que l'on intervient sur le relais d'alimentation
    else if (indice ==11) relais = nombre;

    //Si l indice vaut plus de  12 sela implique qu'on change les vitesses max des moteurs 
    else if (indice == 12)vitesse_max[0] = nombre ; 
    else if (indice == 13)vitesse_max[1] = nombre ; 
    else if (indice == 14)vitesse_max[2] = nombre ; 
    else if (indice == 15)vitesse_max[3] = nombre ; 
    
    //Si on doit mettre des données dans la mémoire tampon
    else if (nb_donne_tampon > 0)
    {
      float temps[4] ;
      float distance[4] ; 
      float temp_max ;
      tampon[indice] = nombre ;
      nb_donne_tampon -- ;
      if (nb_donne_tampon == 0 )
      {
        for (byte i = 0 ; i < 3 ; i++)
        {
          distance[i] = abs(tampon[i] - position_moteur[i])/angle_by_step[i];
          temps[i] =  distance[i] / vitesse_max[i];
        }
        temp_max = max(max(temps[0], temps[1]), temps[2]);
         
        for (byte i = 0 ; i < 3 ; i++)
        {
          consigne_moteur[i] = tampon[i];
          vitesse_moteur[i] = distance[i] / temp_max;
        }
      }
    }
    
    //Si on peut utlisé les données tel qu'elles sont.
    else
    {
      vitesse_moteur[indice] = vitesse_max[indice];
      consigne_moteur[indice] = nombre ;
      tampon[indice] = nombre ;
      reset_a_stepper(indice);
    }
    
    //On reset le "mot"
    mot = "";
    
  }
  
  

  
  
  

  //On va vers faire la consigne avec la vitesse calculer avant
  for(int m=0; m<4; m++)
  {
    if(timer_moteur[m]+2000000/vitesse_moteur[m]<micros())
    {
      if((consigne_moteur[m] - position_moteur[m])<angle_by_step[m] && (consigne_moteur[m] - position_moteur[m])>-angle_by_step[m]);
      else {
        if(consigne_moteur[m] - position_moteur[m] > 0 )
        {
          bouge(m, 1);
          position_moteur[m] += angle_by_step[m] ; 
        }
        else {
          bouge(m, 0);
          position_moteur[m] -= angle_by_step[m] ; 
        }
      }
      timer_moteur[m] = micros();
    }
    
    
  }

}
