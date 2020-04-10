using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Triangle
{
    class Operation
    {
        public static double Square(int a, int b, int c)
        {
            bool ok = Existance(a, b, c);
            if (ok == false) 
                return 0;
            double p = (a + b + c)/2.0;
            double s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return s;
        }

        private static bool Existance(int a, int b, int c)
        {
            bool ok = true;
            if ((a >= (b + c) || b >= (a + c)) || c >= (a + b)) ok = false;
            return ok;
        }
        public static double Square(int a)
        {
            double p = 3 * a / 2.0;
            double s = Math.Sqrt(p * (p - a) * (p - a) * (p - a));
            return s;
        }
        public static int Root(int a, int b, int c, ref double x1, ref double x2)
        {
            int d = b * b - 4 * a * c;
            if (d < 0) return -1;
            if (d == 0)
            {
                x1 = (-b) / (2.0*a);
                x2 = x1;
                return 0;
            }
            else
            {
                x1 = (-b + Math.Sqrt(d)) / (2.0 * a);
                x2 = (-b - Math.Sqrt(d)) / (2.0 * a);
            }
            return 1;
        }
    }
}
