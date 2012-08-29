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

        public string todosATN(){ //patron tiene largo 9, warning
            string[] aux={"A","T","N","L"};
            PatronATN patronATN=new PatronATN();
            PatronATN[] resultado = new PatronATN[10000];


            string resultado_string="";

            resultado_string += resto(6, "A ") + resto(6, "T ") + resto(6, "N ") + resto(6, "L ");

            //Console.WriteLine(resultado_string);

            return resultado_string;

        }

        public string resto(int dias, string anterior) {
            string result="";
            if (dias > 1)
            {
                result+= resto(dias-1, anterior+"A ");
                result+= resto(dias-1, anterior+"T ");
                result+= resto(dias-1, anterior+"N ");
                result+= resto(dias-1, anterior+"L ");
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
