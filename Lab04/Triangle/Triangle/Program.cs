using System;

namespace Triangle
{
    class Program
    {
        static void Main(string[] args)
        {/*
            Console.WriteLine("Треугольник равносторонний(0/1)?");
            int i = int.Parse(Console.ReadLine());
            if (i == 0)
            {
                Console.WriteLine("Введите три стороны:");
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                int c = int.Parse(Console.ReadLine());
                Console.WriteLine(Operation.Square(a, b, c));
            }
            else
            {
                Console.WriteLine("Введите сторону:");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine(Operation.Square(a));
            }
            */
            double x1=0, x2=0;
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int f = Operation.Root(a, b, c, ref x1, ref x2);
            if (f == -1)
            {
                Console.WriteLine("Корней уравнения с коэффициентами a = {0}, b = {1}, c = {2} нет.", a, b, c);
            }
            if (f == 0)
            {
                Console.WriteLine("Корень уравнения с коэффициентами a = {0}, b = {1}, c = {2} равен x1 = x2 = {3}", a, b, c, x1);
            }
            if (f == 1)
            {
                Console.WriteLine("Корни уравнения с коэффициентами a = {0}, b = {1}, c = {2} равны x1 = {3}, x2 = {4}.", a, b, c, x1, x2);
            }
        }
    }
}
