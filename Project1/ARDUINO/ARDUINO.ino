int LDR = A0;  // LDR PIN
int Led = 8; // Led Pin
int LDR_value = 0; //Va;ue of LDR that will be read
char name ; // The recieving character
void setup() {
  
    Serial.begin(9600);
    pinMode ( Led , OUTPUT );
    pinMode ( LDR , INPUT );
}

void loop() 
{   

    // c sharp code
    if(Serial.available()!=0)
    { 
          name = Serial.read();
          if ( name == '1')
          {
            digitalWrite(Led,HIGH);
          }
          if (name =='2')
          {
          //LDR code
          LDR_value = analogRead(LDR); 
          Serial.println( LDR_value );
          }
          if (name == '3')
          {
            digitalWrite(Led,LOW);
          }
    };
  
    
}
