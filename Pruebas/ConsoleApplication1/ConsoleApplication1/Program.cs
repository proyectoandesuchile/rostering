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
            
            //descomentar para ver salida
            //Console.Write(todosATNS.toText);

            //Descomentar para generar archivos
            //System.IO.File.WriteAllText(@"D:\Proyecto_Andes\Git\rostering\Pruebas\patrones.txt", todosATNS.toText);


            
            string newline = Console.ReadLine();
        }    
    }
}
