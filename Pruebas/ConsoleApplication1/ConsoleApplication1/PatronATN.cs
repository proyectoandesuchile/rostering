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

            for (int a = 0; a < 4; a++) { //Iterador de turnos de turnos
                for (int i = 0; i < 7; i++) { //Iterador sobre dias
                    patron.turno[i] = aux[a];
                    for (int b = 0; b < 4; b++) {
                        for (int j = 1; j < 7; j++) {
                            if (i == 0 || i == 1 || (i == 3 && libres<2)) //si el turno anterior es A, T o L (y me quedan libres que poner)
                            {   
                                patron.turno[j] = aux[b];//entonces puedo usar cualquier turno
                                if (b == 3)//si acabo de poner un dia libre, descuento 
                                    libres++;
                            }
                            else {  //el dia anterior fue turno noche
                                if (b == 3 && libres <2) {//y estoy posicionando un turno libre
                                    patron.turno[j] = aux[b];
                                    libres++;
                                }
                                if (b == 2) //sino, la unica posibilidad es poner otro turno noche
                                {
                                    patron.turno[j] = aux[b];
                                }
                                else //keep walking, nothing to do here ~~ (no queda ninguna posibilidad para rellenar el dia, no deberia ocurrir nunca)
                                    continue;
                            }//else
                        }//for j
                    }//for b
                    //cuando termino de iterar sobre el 2º termino guardo la partida y reseteo
                    final[contador_final++] = patron;

                    //falta resetear;:

                }//for i
            }//for a

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
