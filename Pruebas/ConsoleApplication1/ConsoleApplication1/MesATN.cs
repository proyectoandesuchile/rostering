using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplication1
{
    public class MesATN : PatronATN
    {
        public PatronATN[] semanas;

        public MesATN() {
            this.semanas = new PatronATN[4];
        }


    }
}
