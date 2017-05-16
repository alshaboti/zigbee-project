// This with modbus and it is working

#include <ModbusMaster.h>

// instantiate ModbusMaster object as slave ID 120
// defaults to serial port 0 since no port was specified
ModbusMaster node(1,120);

int testLed=13;

// command comes from pc 
String UARTString = "";
// all command chars has been read
boolean UARTComplete = false;


// command comes from pc 
String RFString = "";
// all command chars has been read
boolean RFComplete = false;


void setup()
{
  // initialize Modbus communication baud rate
  pinMode(10,OUTPUT);
  
  Serial2.begin(9600);// for xbee

  node.begin(9600);
  
  Serial.begin(9600);
  Serial.print("start...");
}

 uint8_t j, result;
 uint16_t data[11];

void loop()
{
  
  if (ModbusReading())
  {
    for (j=0; j < 11; j=j+2)
    {
//      Serial.print("data");
      Serial.print (j+10);
      Serial.print("=");
      Serial.print(data[j]);      
      if(j<10)
      Serial.print(",");

    }
    Serial.println();
  }
  else{
    Serial.print("Error:");
    Serial.println(result);
  
  }
 // After UARTString is processed, it must be cleaned
  if(UARTComplete)
   {
     // process received data
    UARTDataReceived(); 
    // then clean it 
    UARTString = "";
    UARTComplete = false;      
   }
   
   if(RFComplete)
   {
    // process received data
    RFDataReceived();  
    // then clean it 
    RFString = "";
    RFComplete = false;      
   }  

  
}//loop

boolean ModbusReading()
{
    result = node.readHoldingRegisters(10, 20);
  
  // do something with data if read is successful
  if (result == node.ku8MBSuccess)
  {
    for (j=0; j < 11; j=j+2)
    {
      data[j] = node.getResponseBuffer(j);
/*      Serial.print("data");
      Serial.print (j);
      Serial.print("= ");
      Serial.println(data[j]);      */
    }
    return true;
  }
  else{
//    Serial.print("Error: ");
  //  Serial.println(result);
  return false;
  }

}



/*
As it is, serialEvent() called automatically for Serial
also there are serialEvent1(), serialEvent2() 
andSerialEvent3() for Serial1,2,3
*/
void serialEvent(){
  while (Serial.available()){
    // get the new byte:
    char inChar = (char)Serial.read(); 
    // add it to the UARTString:
    UARTString += inChar;
    // if the incoming character is a #, set a flag
    // so the main loop can do something about it:
    if (inChar == '#') {
      UARTComplete = true;     
    }      
  }// end while loop
}
// RF (for xbee)
void serialEvent2() {
  while (Serial2.available()) {
    // get the new byte:
    char inChar = (char)Serial2.read(); 
    // add it to the RFString:
    RFString += inChar;
    // if the incoming character is a newline, set a flag
    // so the main loop can do something about it:
    if (inChar == '\n') {
      RFComplete = true;
    } 
  }
}

void UARTDataReceived()
{
   if(UARTString.compareTo("L#")==0 || UARTString.compareTo("M#")==0 || UARTString.compareTo("H#")==0)
   {
     // for debugging purpose
     digitalWrite(testLed,HIGH);
     // send it via RF and clean
     Serial2.print(UARTString); 
   }
}

//GPS reading
void RFDataReceived()
{
  //forward it to UART serial port
    Serial.println(RFString);
    digitalWrite(testLed,HIGH);
}
