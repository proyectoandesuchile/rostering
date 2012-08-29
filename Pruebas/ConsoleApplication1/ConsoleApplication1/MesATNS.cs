using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplication1
{
    public class MesATN : PatronATNS
    {
        public PatronATNS[] semanas;

        public MesATN() {
            this.semanas = new PatronATNS[4];
        }


    }
}
