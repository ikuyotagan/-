using System;
using System.Collections.Generic;
using System.Text;

namespace Ex7
{
    class ArithmeticProgression : Progression
    {
        public int a { get; set; }
        public int d { get; set; }
        public ArithmeticProgression(int a,int d)
        {
            this.a = a;
            this.d = d;
        }
        public override int GetElement(int k)
        {
            return a + d * (k - 1);
        }
    }
}
