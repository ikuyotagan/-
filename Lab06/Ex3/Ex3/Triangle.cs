using System;
using System.Collections.Generic;
using System.Text;

namespace Ex3
{
    class Triangle
    {
        public int a { get; set; }
        public int b { get; set; }
        public int c { get; set; }

        public Triangle(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            if (a + c <= b || a + b <= c || b + c <= a)
            {
                throw new Exception();
            }
        }
        public int Perimetr()
        {
            return this.c + this.b + this.a;
        }

        public double Ploschad()
        {
            int p = this.Perimetr() / 2;
            return Math.Sqrt(p * (p - this.a) * (p - this.b) * (p - this.c));
        }
    }
}
