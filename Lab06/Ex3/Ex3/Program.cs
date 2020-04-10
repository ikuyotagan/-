using System;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle t1 = new Triangle(3,4,5);
            Console.WriteLine(t1.Perimetr());
            Console.WriteLine(t1.Ploschad());
        }
    }
}
