int s1 = 3;
int s2 = 5;
int s3 = 6;
int s4 = 9;
int s5 = 10;
int s6 = 11;
char myCol[20];
int value=100;
int buzzerval; //Value for buzzer output

void setup() 
{  
   Serial.begin (9600);
   pinMode(s1, OUTPUT);    
   pinMode(s2, OUTPUT);   
   pinMode(s3, OUTPUT);
   pinMode(s4, OUTPUT);    
   pinMode(s5, OUTPUT);   
   pinMode(s6, OUTPUT);   
  
   digitalWrite(s1, LOW);
   digitalWrite(s2, LOW);
   digitalWrite(s4, LOW); 
   digitalWrite(s4, LOW);
   digitalWrite(s5, LOW);
   digitalWrite(s6, LOW);
   Serial.setTimeout(50);

    // Var to hold character input
    //string myChar;
    //int buzzerVal; // Input value
    //int value; //Converted
}

void loop() 
{
  //Convert to 2v then add a range 0-100% for vibrate
  //As Analog uses range of 0-1024 we need to modify the inputs
  //2v = 410,
   
  if (Serial.available())
  {
      Serial.readBytesUntil(" ", myCol, 2); //Read String Input
      value = Serial.parseInt(); 
      buzzerval = map(value, 0, 100, 30, 230);
    //buzzerval = map(value, 0, 100, 40, 1000);
    /*
    Serial.print("LED IS ");
    Serial.print(myCol);
    Serial.print(" Value is ");
    Serial.print(value);  
    Serial.print(" B Value is ");
    Serial.println(buzzerval);  
    */
    }
    
    if(strcmp(myCol,"s1")==0)
    {
         analogWrite(s1, buzzerval);
    }
    if(strcmp(myCol,"s2")==0)
    {
         
         analogWrite(s2, buzzerval); 
    }
    if(strcmp(myCol,"s3")==0)
    {
         analogWrite(s3, buzzerval); 
    }
    if(strcmp(myCol,"s4")==0)
    {       
       analogWrite(s4, buzzerval);
    }
    if(strcmp(myCol,"s5")==0)
    {       
       analogWrite(s5, buzzerval);
    }
    if(strcmp(myCol,"s6")==0)
    {       
       analogWrite(s6, buzzerval);
    }
 

   delay(50);
}

