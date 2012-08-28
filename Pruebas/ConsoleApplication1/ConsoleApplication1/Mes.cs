using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplication1
{
    public class Mes : Patron
    {
        public Patron[] semanas;
        
        public Mes() {
            this.semanas = new Patron[4];
        }

        public Mes(Patron[] nueva_semanas){
            this.semanas= new Patron[4];
            for (int i = 0; i < 4; i++){
                this.semanas[i] = nueva_semanas[i];
            }
        }

        public override string toString(){
            string res="";
            for (int i = 0; i < 4; i++) {
                res +=this.semanas[i].toString() + "\n";
            }
            return res;
        }

        public void agregarSemana(Patron nueva_semana){
            for (int i = 0; i < 4; i++){
                if (this.semanas[i] == null){
                    this.semanas[i] = nueva_semana;
                    return;
                }
            }
            Console.WriteLine("Error: nueva semana "+nueva_semana.toString()+" no agregada");
        }

        public void nuevoMes(Patron[] todos) {
            this.agregarSemana(todos[0]);
            for (int i = 1; i < 4; i++)
            {
                for (int j = 0; j < todos.Length - 1 && todos[j] != null; j++)
                {
                    int a = todos[j].dia[7];
                    if (this.semanas[i - 1].dia[8] + todos[j].dia[7] <= 5)
                    {
                        this.agregarSemana(todos[j]);
                        j = 0;
                        break;
                    }
                }
            }
        }

        public void nuevoMesRandom(Patron [] todos) { 
            Patron[] nuevo= new Patron[todos.Length];
            Random random = new Random();
            int total = 0, contador_semanas=0;
            
            for (int i = 0; i < todos.Length && todos[i] != null; i++){
                total++;//patrones reales
                nuevo[i] = todos[i];
                //Console.WriteLine(nuevo[i].toString());
            }
            
            int indice = random.Next(0, total);
            this.agregarSemana(todos[indice]);
            nuevo[indice] = null;
            contador_semanas++;

            while(contador_semanas<4) {
                indice = random.Next(0, total);
                while (nuevo[indice] == null){
                    indice = random.Next(0, total);
                }
                if (this.semanas[contador_semanas-1].dia[8] + todos[indice].dia[7] <= 5) {
                    this.agregarSemana(todos[indice]);
                   // Console.WriteLine("patron agregado: "+todos[indice].toString());
                    nuevo[indice] = null;
                    contador_semanas++;
                }
            }


            Console.WriteLine(this.toString());
        }
        public void clear(){
            this.semanas = new Patron[4];
        }


    }

}
