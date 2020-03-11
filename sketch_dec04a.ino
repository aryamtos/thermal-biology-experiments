//Entradas
#define boiaFria 12
#define boiaPrinci 13
int temp= 5;


//Saídas
#define green 6
#define red 7
#define blue 8
#define ar 11
#define bombaCircula 9
#define bombaFria 10 
#define zero 2
#define triac 4

#define Ts 1000
unsigned long Tinicio; //instante de inicializar o loop
float Tref=0.0;
int modo=0;
int erro;



void setup() {
Serial.begin(9600);


  
}

void loop() {

Tinicio = millis();
 leSerial();

 
//o 4 define 4 casas decimais - usar isso p garantir resolução suficiente
if(Tref>=30.0){erro=1;}
else{erro=0;}
Serial.print(Tref+5.0,5);
Serial.print(";");
Serial.print(Tref,5);
Serial.print(";");
Serial.println(modo);
//Serial.println("B");

if(millis()-Tinicio <= Ts){delay(Ts-(millis()-Tinicio));}

}


String leStringSerial(){
  String conteudo = "";
    char caractere;
  
  // Enquanto receber algo pela serial
  while(Serial.available() > 0) {
    // Lê byte da serial
    caractere = Serial.read();
    // Ignora caractere de quebra de linha
    if (caractere != '\n'){  
      // Concatena valores
      conteudo.concat(caractere);
      
    }
    // Aguarda buffer serial ler próximo caractere
    delay(1);
  }
       
  return conteudo;
}

void leSerial(){
if (Serial.available() > 0){
    // Lê toda string recebida 
 String temp = leStringSerial();
 
  int index = temp.indexOf(';');
            String u1_str = temp.substring(0,index);
            String u2_str = temp.substring(index+1);
      
              Tref = atof(u1_str.c_str());
              modo = atof(u2_str.c_str()); //posso n precisar disso
           
}
}
