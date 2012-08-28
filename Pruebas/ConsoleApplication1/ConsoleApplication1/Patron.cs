using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplication1
{
    public class Patron
    {
        public int[] dia;
        public Patron() {
            this.dia = new int[9];
        }
        public Patron(int []a) {
            this.dia = new int[9];
            for (int i = 0; i < a.Length; i++) {
                this.dia[i] = a[i];
                //Console.Write(this.dia[i] + " ");
            }
        }

        public virtual string toStringPatron() { 
            string res="";
            for (int i = 0; i < 9; i++)
                res += this.dia[i]+" ";
            return res;
        }

        public virtual string toString() { 
            string res="";
            for(int i=0; i < 7; i++)
                res+=this.dia[i]+" ";
            return res;
        }
    }
}
