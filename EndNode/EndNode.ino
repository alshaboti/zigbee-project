/*
These are farouq and Mohammed
This is an EndDevice program which has to send <longitude,latitude,id,gas>
gas must be -1 for all non-gas sensing devices, id is the id of the worker

L#: low gas consentration (No GPS reading need, No alarm)
M#: midum gas consentration (GPS reading Required, No alarm)
H#: high gas consentration (Alarm and GPS reading required)

Keep switch to UART because RF used Serial not serial1 or 2 or 3
*/

#include <TinyGPS++.h>
#include <SoftwareSerial.h>
#include <Narcoleptic.h>

// The TinyGPS++ object for GPS reading
TinyGPSPlus gps;
int RXPin = 10;
int TXPin = 9;
SoftwareSerial gpsSerial(RXPin, TXPin);
static const int GPSBaud = 4800;

// for receiving data via RF
String RFString="";
boolean RFComplete=false;
// xbee status
int xbeeStatus = 8;
// make MCU sleep once in each xbee sleeping cycle
boolean mcuSleep=false;

// Always gas=-1, they are not responsible for gas reading
int gas=-1;
// worker ID number, change it for reach worker
int workerID=2; 
// for gps reading ever period of time
long timer=0;
/* 
an averag waker works 5km/h (i.e. 10m/7s)
fasters runner runs 36km/h
*/
int period = 0; 


// gps data
double oldLat=0,  newLat=0, oldLong=0,  newLong=0;

//testLed
int testLed = 12;

//for Alarm
#define buzzerPin 11
long alarmDelay = 500;

void setup()
{
  Serial.begin(9600); // for RF 
  gpsSerial.begin(GPSBaud); // for GPS 
  
  pinMode(testLed,OUTPUT);
  pinMode(buzzerPin,OUTPUT);
  pinMode(xbeeStatus,INPUT);
  //initialization
   alarmDelay =millis();
   timer = millis();
   
}

void loop()
{
  if(digitalRead(xbeeStatus)==HIGH)
  {

   mainLoop(); // call main function
   
   //digitalWrite(testLed,HIGH);
   mcuSleep=false;
  }else if(!mcuSleep && (period ==0 || period > 10000) )// if there is an Alarm don't let MCU goes to sleep
  {
  //digitalWrite(testLed,LOW);
  Narcoleptic.delay(2650);
  mcuSleep = true;
  }
  
  
}

void mainLoop()
{
 // check RF receiver
  if(RFComplete)
   {
     RfDataReceived();
     RFString ="";
     RFComplete = false;    
   }

/* Read GPS data ever period of time
period is changed .*/
  if( (period !=0) && (timer + period < millis())) 
  {
      ReadGPS(); 
      
/*      Serial.println("324324234,3423423432,2,-1");
      timer = millis();*/
  }
    
  
  //Check alarm
  if( (period !=0) && (period < 10000) && (alarmDelay + 500 < millis())) //high gas level
    warnning();

}

// read from RF serial
/*
As it is, serialEvent() called automatically for Serial
also there are serialEvent1(), serialEvent2() 
and serialEvent3() for Serial1,2,3
*/
void serialEvent(){
  while (Serial.available()){
    // get the new byte:
    char inChar = (char)Serial.read(); 
    // add it to the cmdString:
    RFString += inChar;
    // if the incoming character is a #, set a flag
    // so the main loop can do something about it:
    if (inChar == '#') {
      RFComplete = true;
    }    
  }
}
void RfDataReceived()
{
    if(RFString.compareTo("L#")==0) // low gas consentration, stop sending GPS location
    {
      period = 0; 
     digitalWrite(testLed,LOW);
    }
    else
    if(RFString.compareTo("M#")==0) // medium gas consentration
    {
      period = 12000; 
     
     digitalWrite(testLed,HIGH);
    }
    else
    if(RFString.compareTo("H#")==0) // High gas consentration
    {
      period = 3000; 
      
     digitalWrite(testLed,HIGH);
    }    

}


void ReadGPS()
{
 while (gpsSerial.available() > 0)
   if (gps.encode(gpsSerial.read()))
     if (gps.location.isValid())
  {  
    newLat = gps.location.lat();
    newLong = gps.location.lng();
 
   // if(dataValidation())
   {
    Serial.print( newLong * 10000 );
    Serial.print(",");
    Serial.print( newLat * 10000); 
    Serial.print(",");
    Serial.print(workerID);
    Serial.print(",");
    Serial.println(gas); 
    } 
     timer = millis();

  }    
}

// Alarm
void warnning()
{
   tone(buzzerPin,3100,200);   
   alarmDelay = millis();
}

//data Aggregation
// compare the old and new position to determine either to send or not
boolean dataValidation()
{
  if(abs(oldLat-newLat)>0.0001 || abs(oldLong-newLong)>0.0001)
  {
      return true;
  }
     return false;
}


