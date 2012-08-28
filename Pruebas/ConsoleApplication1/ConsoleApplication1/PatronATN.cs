using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplication1
{
    public class PatronATN
    {
        string[] turno;

        public PatronATN(){
            this.turno = new string[7];
        }

        public PatronATN[] todos(){
            string[] aux={"A","T","N","L"};
            PatronATN patron=new PatronATN();
            PatronATN [] final= new PatronATN[100];
            int libres=0;
            int contador_final=0;

            
            for (int a = 0; a < 4; a++) {
                for (int i = 0; i < 7; i++){
                    if (libres == 2)
                        continue;
                    else{                     
                        patron.turno[i] =  aux[a]+" ";
                        if (a == 3) {
                            libres++;
                        }
                    }
                }
                if (patron.esValido())
                {
                    Console.WriteLine(patron.toString());
                    final[contador_final] = patron;
                }
                patron = new PatronATN();
            }
            
            return final;
        }

        public Boolean esValido() {
            for (int i = 0; i < this.turno.Length-1; i++ ){
                if (this.turno[i] == null)
                    return false;
            }
            return true;
        }
        public string toString(){
            string resultado = "";
            for (int i = 0; i < this.turno.Length; i++){
                resultado += this.turno[i];
            }
            return resultado;
        }
    }
}
