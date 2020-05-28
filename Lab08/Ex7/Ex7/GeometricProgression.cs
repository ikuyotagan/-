using System;
using System.Collections.Generic;
using System.Text;

namespace Ex7
{
    class GeometricProgression : IProgression
    {
        public int a { get; set; }
        public int q { get; set; }

        public GeometricProgression(int a, int q)
        {
            this.a = a;
            this.q = q;
        }
        public int GetElement(int k)
        {
            return (int)(a * Math.Pow(q, k - 1));
        }
    }
}
