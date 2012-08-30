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

            todosATNS.aplicarFiltros();

            todosATNS.clean();
            todosATNS.nuevoText();
            
            
            /*descomentar para ver salida*/
//            Console.Write(todosATNS.text);

            /*Descomentar para generar archivos*/
//            System.IO.File.WriteAllText(@"D:\Proyecto_Andes\Git\rostering\Pruebas\patrones.txt", todosATNS.text);

            
            string newline = Console.ReadLine();
        }    
    }
}
