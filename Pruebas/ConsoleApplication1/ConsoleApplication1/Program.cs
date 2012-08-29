using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplication1
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            int []original= new int[7];
            int aux=0;
            for(int i=0; i<7;i++){
                    original[i]=1;
            }
            Patron[] mes = new Patron[4];
            Patron[] todos= new Patron[25];

            //recorro con un 0 fijo y el 2 moviendose
            for(int i=0; i<6;i++){
                    original[i]=0;
                    for(int j=i+1;j<7;j++){
                        original[j]=0;
                        
                        int[]a= {original[0],original[1],original[2],original[3],original[4],original[5],original[6],i,(5-j+1)};
                        todos[aux]=new Patron(a);

                        //Console.WriteLine("");
                        aux++;
                        original[j]=1;
                    }
                    original[i]=1;
            }
            Mes mes1 = new Mes();

            mes1.nuevoMes(todos);
            //int numero_mes = 0;

            //Console.WriteLine("Mes propuesto");
            //Console.Write(mes1.toString());
            //Console.WriteLine("Fin");

            /*Mes mes2 = new Mes();
            Console.WriteLine("Mes aleatorio nº: " + numero_mes++);
            mes2.nuevoMesRandom(todos);
            Console.WriteLine("Presione enter para nuevo mes");
            string newline = Console.ReadLine();
            while(newline!=null){
                mes2.clear();
                Console.WriteLine("Mes aleatorio nº: "+numero_mes++);
                mes2.nuevoMesRandom(todos);
                Console.WriteLine("Presione enter para nuevo mes");
                newline = Console.ReadLine(); 
            }*/

            PatronATN patronATN = new PatronATN();
            Console.WriteLine("incio de generador ATN");
            //Console.WriteLine(patronATN.todosATN());
            string patron_final = patronATN.todosATN();
            
            PatronATN[] resultado = patronATN.patronATN_total(patron_final);
            
            //System.IO.File.WriteAllText(@"D:\Proyecto_Andes\Git\rostering\Pruebas\patrones.txt", patron_final);

            Console.WriteLine("primera linea antes del salto de linea: "+ patron_final.Substring(0,7));
            Console.WriteLine("segunda linea despues del primer salto de linea: "+ patron_final.Substring(9,7));
            Console.WriteLine("Ingrese patron a buscar: ");
            string newline = Console.ReadLine();
            while (newline != null)
            {
                if( patron_final.IndexOf(newline) > -1){
                    Console.WriteLine("Patron encontrado");
                }

                else{
                    Console.WriteLine("Patron NO encontrado");
                }


                Console.WriteLine("Ingrese nuevo patron a buscar");
                newline = Console.ReadLine(); 
            
            }

        }    
    }
}
