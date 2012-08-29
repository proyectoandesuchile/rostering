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

        public PatronATN[] patronATN_total(string patrones) { //por conveniencia esta hecho una estructura co n 
            PatronATN[] patronATN = new PatronATN[patrones.Length / 9];//9 es el largo de una linea
            string linea="";
            for (int i = 0; i < patronATN.Length-1; i++) { 
                linea= patrones.Substring(i*9,7);
                patronATN[i] = new PatronATN();
                for(int j=0; j<linea.Length; j++){//los ultimos caracteres de una linea son 2 chars que hacen el salto de linea
                    patronATN[i].turno[j] = linea.Substring(j,1);
                }
            }
            return patronATN;
        }

        public string todosATN()
        { //patron tiene largo 9, warning
            string resultado_string="";
            
            resultado_string += resto(6, "A") + resto(6, "T") + resto(6, "N") + resto(6, "L");
            return resultado_string;

        }

        public string resto(int dias, string anterior) {//el que hace la magia de verdad
            string result="";
            if (dias > 1)
            {
                result+= resto(dias-1, anterior+"A");
                result+= resto(dias-1, anterior+"T");
                result+= resto(dias-1, anterior+"N");
                result+= resto(dias-1, anterior+"L");
            }
            else {
                result+= anterior+ "A"+ Environment.NewLine+ 
                         anterior+ "T"+ Environment.NewLine+
                         anterior+ "N"+ Environment.NewLine+
                         anterior+ "L"+ Environment.NewLine
                    ;
                
            }

            return result;
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

        public Boolean existe(string Base, string buscado)
        {
            if (Base.IndexOf(buscado) != -1)
                return true;
            else
                return false;
        }
    }
}
