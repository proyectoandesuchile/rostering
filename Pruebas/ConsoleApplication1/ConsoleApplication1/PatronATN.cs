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
            PatronATN [] final= new PatronATN[1000];
            int libres=0, libres_ayer=0;
            int contador_final=0;

            for (int a = 0; a < 4; a++) { //Iterador de turnos de turnos
                
                for (int i = 0; i < 6; i++) { //Iterador sobre dias
                    
                    patron.turno[i] = aux[a];
                    if (a == 3) {
                        libres_ayer++;
                    }

                    if (a == 3 && libres_ayer>2) {
                        continue;
                    }

                    for (int b = 0; b < 4; b++) {
                        for (int j = i+1; j < 7; j++) {
                            if (i == 0 || i == 1 || i == 3) //si el turno anterior es A, T o L 
                            {
                                if (b == 3 && (libres_ayer+libres) < 2) { //si tendria que poner un libre y tengo libres disponibles
                                    libres++;
                                    patron.turno[j] = aux[b];
                                }
                                if (b != 3) { //si no es un libre el que tengo que colocar, da lo mismo
                                    patron.turno[j] = aux[b];
                                }
                            }
                            else {  //el dia anterior fue turno noche
                                if (b == 3 && (libres_ayer+libres) < 2)
                                {//y estoy posicionando un turno libre
                                    patron.turno[j] = aux[b];
                                    libres++;
                                }
                                if (b == 2) //sino, la unica posibilidad es poner otro turno noche
                                {
                                    patron.turno[j] = aux[b];
                                }
                                else //keep walking, nothing to do here (no queda ninguna posibilidad para rellenar el dia, no deberia ocurrir nunca)
                                    continue;
                            }//else
                            
                        }//for j
                        Console.WriteLine(patron.toString());
                        final[contador_final++] = patron;
                        libres = 0;
                        
                    }//for b
                    //cuando termino de iterar sobre el 2º termino guardo la partida y reseteo
                    //if (patron.esValido()){
                        
                    //}

                    //falta resetear;:

                }//for i
            }//for a
            Console.WriteLine(""+contador_final);
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
