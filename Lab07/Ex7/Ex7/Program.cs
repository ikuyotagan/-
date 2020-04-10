using System;

namespace Ex7
{
    class Program
    {
        static void Main(string[] args)
        {
            ArithmeticProgression A = new ArithmeticProgression(3,1);
            GeometricProgression B = new GeometricProgression(3, 2);
            Console.WriteLine(A.GetElement(5));
            Console.WriteLine(B.GetElement(5));
        }
    }
}
