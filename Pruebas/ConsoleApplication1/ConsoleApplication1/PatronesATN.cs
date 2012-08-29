using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplication1
{
    public class PatronesATNS : PatronATNS 
    {
        public PatronATNS[] patrones;
        public string text;

        public PatronesATNS() //constructor
        {
            string todos = todosLosPatronesATN();
            this.text = todos;
            this.patrones = new PatronATNS[todos.Length / 9];//9 es el largo de una linea, 7 dias+ caracteres \n\r {revisar en caso de exportar}
            string linea = "";
            for (int i = 0; i < this.patrones.Length; i++)
            {
                
                linea = todos.Substring(i * 9, 7);
                this.patrones[i] = new PatronATNS();
                for (int j = 0; j < linea.Length; j++)
                {//los ultimos caracteres de una linea son 2 chars que hacen el salto de linea
                    this.patrones[i].turno[j] = linea.Substring(j, 1);
                }
            }
        }

        public string todosLosPatronesATN()//funcion de apoyo al constructor
        { 
            string resultado_string = "";
            resultado_string += resto(6, "A") + resto(6, "T") + resto(6, "N") + resto(6, "L");
            return resultado_string;

        }

        public string resto(int dias, string anterior)//el que hace la magia de verdad
        {
            string result = "";
            if (dias > 1)
            {
                result += resto(dias - 1, anterior + "A");
                result += resto(dias - 1, anterior + "T");
                result += resto(dias - 1, anterior + "N");
                result += resto(dias - 1, anterior + "L");
                result += resto(dias - 1, anterior + "S");
            }
            else
            {
                result += anterior + "A" + Environment.NewLine +
                         anterior + "T" + Environment.NewLine +
                         anterior + "N" + Environment.NewLine +
                         anterior + "L" + Environment.NewLine +
                         anterior + "S" + Environment.NewLine
                    ;

            }

            return result;
        }

        public virtual void diasTrabajados(PatronATNS[] todos) //
        {
        }
    }
}
