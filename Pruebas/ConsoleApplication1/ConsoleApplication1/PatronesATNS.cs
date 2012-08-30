using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplication1
{
    public class PatronesATNS 
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
            resultado_string += resto(6, "A") + resto(6, "T") + resto(6, "N") + resto(6, "L");// + resto(6, "S");
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
                //result += resto(dias - 1, anterior + "S");
            }
            else
            {
                result += anterior + "A" + Environment.NewLine +
                         anterior + "T" + Environment.NewLine +
                         anterior + "N" + Environment.NewLine +
                         anterior + "L" + Environment.NewLine 
                         //anterior + "S" + Environment.NewLine
                    ;

            }

            return result;
        }

        
        /*algoritmo de revisar cada patron*/
        public void aplicarFiltros(){
            for (int i = 0; i < this.patrones.Length; i++) {
                //algoritmos de revisiones de semana
                //diasLibres
                this.diasLibres(i);
                this.turnos11horas(i);
                /*Agregar nuevas reglas de limpieza de patrones semanales aqui
                 */
            }
        }

        /*Filtros de patrones semanales*/

        public void diasLibres(int i)/*Considerando turnos de 5x2*/
        {
            if (this.patrones[i] == null){
                return;}
            int libres = 0;
            for(int j=0; j< this.patrones[i].turno.Length; j++){
                if (this.patrones[i].turno[j].Equals("L"))
                    libres++;
            }
            if (libres < 2)
                this.patrones[i] = null;
        }

        public void turnos11horas(int i) /*11 horas de descanso como minimo entre turnos*/
        {
            if (this.patrones[i] == null)
                return;
           
            string dia_previo=this.patrones[i].turno[0];
            for (int j = 1; j < this.patrones[i].turno.Length; j++)
            {
                if (dia_previo.Equals("N") && (this.patrones[i].turno[j].Equals("N") || this.patrones[i].turno[j].Equals("L")))
                    continue;
                else if (dia_previo.Equals("N")){
                    this.patrones[i] = null;
                    break;
                }
            }
        }
        
        /*Fin de Filtros semanales*/

        /*funciones auxiliares*/

        public void clean()
        {
            int contador=0,aux=0;
            
            for (int i = 0; i < this.patrones.Length; i++) {
                if (this.patrones[i] != null)
                    contador++;
            }

            PatronATNS[] nuevos_patrones = new PatronATNS[contador];
            for (int i = 0; i < this.patrones.Length; i++) {
                if (this.patrones[i] != null){
                    nuevos_patrones[aux] = this.patrones[i];
                    aux++;
                }
            }
            this.patrones = nuevos_patrones;
        }

        public void nuevoText() {
            string t = "";
            for (int i = 0; i < this.patrones.Length; i++ ){
                for (int j = 0; j < this.patrones[i].turno.Length; j++) {
                    t += this.patrones[i].turno[j];
                }
                t += Environment.NewLine;
            }
            this.text = t;
        }

        /* fin de funciones auxiliares*/



        /*funciones deprecadas*/
        
        public void turnos11horas_deprecated() 
        {
            for (int i = 0; i < this.patrones.Length; i++)
            {
                if (this.patrones[i] == null)
                    continue;
                string dia_previo=this.patrones[i].turno[0];
                for (int j = 1; j < this.patrones[i].turno.Length; j++) { 
                    
                    if(dia_previo.Equals("N") && (this.patrones[i].turno[j].Equals("N") || this.patrones[i].turno[j].Equals("L")))
                        continue;
                    if (dia_previo.Equals("N"))
                    {
                        this.patrones[i] = null;
                        break;
                    }
                }
            }
        }

        public void diasLibres_deprecated() 
        {
            for (int i = 0; i < this.patrones.Length; i++)
            {
                int libres = 0;

                if (this.patrones[i] == null)
                    continue;

                for (int j = 0; j < this.patrones[i].turno.Length; j++)
                {
                    /* en caso de que se quiera que TENGAN 2 dias libres
                     * if (libres==2 && this.patrones[i].turno[j].Equals("L")){
                        this.patrones[i]=null;
                        break;
                    }*/

                    if (this.patrones[i].turno[j].Equals("L"))
                        libres++;
                }
                if (libres < 2) //si tienes menos de 2 libres en una semana, patron invalido
                    this.patrones[i] = null;
            }
        }

        public void diasSalientes_deprecated()
         {
             for (int i = 0; i < this.patrones.Length; i++) {
                 int noches=0;
                 if (this.patrones[i] == null)
                     continue;

                 for (int j = 0; j < this.patrones[i].turno.Length; j++) {
                    
                     if(noches<4 && this.patrones[i].turno[j].Equals("S")){
                         this.patrones[i] = null;
                         break;
                     }
                     if (this.patrones[i].turno[j].Equals("N"))
                     {
                         noches++;
                     }
                 }
             }
         }
        /*fin de funciones deprecadas*/

    }
}
