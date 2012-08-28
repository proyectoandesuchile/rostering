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
            PatronATN [] final= new PatronATN[10000];
            string toFile = "";
            int libres=0, libres_ayer=0;
            int contador_final=0;

            for (int a = 0; a < 4; a++) { //Iterador de turnos
                for (int i = 0; i < 5; i++) { //Iterador sobre dias
                    patron.turno[i] = aux[a];
                    for (int b = 0; b < 4; b++) {//Iterador sobre turnos 2
                        for (int j = i+1; j < 6; j++) {//Iterador sobre 2 dia
                            patron.turno[j] = aux[b];
                            for (int c = 0; c < 4; c++) {
                                for (int k = j + 1; k < 7; k++) {
                                    patron.turno[k] = aux[c];
                                    Console.WriteLine(patron.toString());
                                    toFile += patron.toString()+Environment.NewLine;
                                    final[contador_final++] = patron;
                                }
                            }
                            
                        }
                        
                    }
                }
            }
            System.IO.File.WriteAllText(@"D:\Proyecto_Andes\Git\rostering\Pruebas\patrones.txt", toFile);
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
