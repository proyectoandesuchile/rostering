using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplication1
{
    public class PatronATNS
    {
        public string[] turno;

        public PatronATNS(){
            this.turno = new string[7];
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
