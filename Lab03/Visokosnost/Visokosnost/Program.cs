using System;

namespace Visokosnost
{
    class Program
    {
        static void Main(string[] args)
        {
            int y = int.Parse(Console.ReadLine());
            if (((y % 4 == 0) && (y % 100 != 0)) || (y % 400 == 0))
            {
                Console.WriteLine("Год високосный");
            } else Console.WriteLine("Год не високосный");
        }
    }
}
