using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplication1
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            
            Console.WriteLine("Inicio de generador ATNS");
            
            PatronesATNS todosATNS = new PatronesATNS();
 //           System.IO.File.WriteAllText(@"D:\Proyecto_Andes\Git\rostering\Pruebas\patrones.txt", todosATNS.text);
            todosATNS.diasLibres() ;
//           System.IO.File.WriteAllText(@"D:\Proyecto_Andes\Git\rostering\Pruebas\patrones_dias_Libres.txt", todosATNS.text);
//            todosATNS.diasSalientes();
            todosATNS.turnos11horas();
            todosATNS.clean();
            todosATNS.nuevoText();
//            System.IO.File.WriteAllText(@"D:\Proyecto_Andes\Git\rostering\Pruebas\patrones_dias_libres_limpios.txt", todosATNS.text);
            //descomentar para ver salida
            //Console.Write(todosATNS.toText);

            //Descomentar para generar archivos
            //System.IO.File.WriteAllText(@"D:\Proyecto_Andes\Git\rostering\Pruebas\patrones.txt", todosATNS.toText);

            string newline = Console.ReadLine();
        }    
    }
}
