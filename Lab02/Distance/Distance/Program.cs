using System;

namespace Distance
{
    public struct Distance
    {
        public long feet;
        public float inch;

    }
    class Program
    {
        static void Main(string[] args)
        {
            Distance a, b, c;
            Console.WriteLine("Введите футы первой переменной:");
            a.feet = long.Parse(Console.ReadLine());
            Console.WriteLine("Введите дюймы первой переменной:");
            a.inch = float.Parse(Console.ReadLine());
            Console.WriteLine("Введите футы второй переменной:");
            b.feet = long.Parse(Console.ReadLine());
            Console.WriteLine("Введите дюймы второй переменной:");
            b.inch = float.Parse(Console.ReadLine());
            c.feet = a.feet + b.feet + (int)(a.inch + b.inch) / 12;
            c.inch = (a.inch + b.inch) % 12;
            Console.WriteLine("Третья переменная равна {0} '- {1}\"", c.feet,c.inch);
        }
    }
}
