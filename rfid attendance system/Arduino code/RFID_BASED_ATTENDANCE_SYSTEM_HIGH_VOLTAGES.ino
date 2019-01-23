#include <SPI.h>
#include <MFRC522.h>
#include <SoftwareSerial.h>
SoftwareSerial mySerial(6, 3);
char msg;
char call;
String c;

#define RST_PIN         5
#define SS_PIN          10
MFRC522 mfrc522(SS_PIN, RST_PIN);

void setup()
{
Serial.begin(9600);
mySerial.begin(9600); 
SPI.begin();
mfrc522.PCD_Init();
}

void loop() {
RfidScan();
if(Serial.available()>0)
{
  c=Serial.readString();
  sendMessage(c);
}

}

void dump_byte_array(byte *buffer, byte bufferSize) {
for (byte i = 0; i < bufferSize; i++) {
Serial.print(buffer[i] < 0x10 ? " 0" : " ");
Serial.print(buffer[i], DEC);

 
}
Serial.println();


delay(1000);
}

void RfidScan()
{
if ( ! mfrc522.PICC_IsNewCardPresent())
return;

if ( ! mfrc522.PICC_ReadCardSerial())
return;
dump_byte_array(mfrc522.uid.uidByte, mfrc522.uid.size);
}

void sendMessage(String a)
{
    //String a;
 // a=Serial.readString();
// Serial.println(a);
 String d = "AT+CMGS=\"" + a + '"' + "\r";
 
 mySerial.println("AT+CMGF=1");    //Sets the GSM Module in Text Mode
  delay(1000);  // Delay of 1000 milli seconds or 1 second
  //mySerial.println("AT+CMGS=\""); // Replace x with mobile number
  //mySerial.print(c);
  mySerial.print(d);
  delay(1000);
  mySerial.println("your child is present today");// The SMS text you want to send
 
  delay(100);
   mySerial.println((char)26);// ASCII code of CTRL+Z
  delay(1000);
  

}



