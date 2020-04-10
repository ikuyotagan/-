using System;
using System.Runtime.Serialization.Formatters;

namespace Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());

            // while:

            Console.Write("\nwhile: \t\t");
            int i = 1;
            while (i <= n)
            {
                Console.Write(" " + i);
                i += 2;
            }

            // do while:

            Console.Write("\ndo while: \t");
            i = 1;
            do
            {
                Console.Write(" " + i);
                i += 2;
            }
            while (i <= n);

            // for:

            Console.Write("\nFor: \t\t");
            for (i = 1; i <= n; i += 2)
            {
                Console.Write(" " + i);
            }

            Console.Write("\n");
            double x, x1, x2, y;
            x1 = double.Parse(Console.ReadLine());
            x2 = double.Parse(Console.ReadLine());
            x = x1;
            Console.Write("x    y\n");
            do
            {
                y = Math.Sin(x);
                Console.Write("{0:0.00} {1}\n", x, y);
                x = x + 0.01;
            }
            while (x <= x2);
            Console.Write("\n");
            

            double x, x1, x2, y;
            x1 = double.Parse(Console.ReadLine());
            x2 = double.Parse(Console.ReadLine());
            x = x1;
            Console.Write("x    y\n");
            while (x <= x2)
            {
                y = Math.Sin(x);
                Console.Write("{0:0.00} {1}\n", x, y);
                x = x + 0.01;
            }

            int a, b, temp;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            temp = a;
            do
            {
                a = temp;
                if (a < b)
                {
                    temp = a;
                    a = b;
                    b = temp;
                }

                temp = a - b;
                a = b;
            } while (temp != b);
            Console.Write(a);

            int a, b, temp;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            temp = a;
            while (temp != b)
            { 
                a = temp;
                if (a < b)
                {
                    temp = a;
                    a = b;
                    b = temp;
                }
                temp = a - b;
                a = b;
            }
            Console.Write(a);

            int k, m, s = 0;
            k = int.Parse(Console.ReadLine());
            m = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 100; i++)
            {
                if (i > k && i < m) continue;
                s += i;
            }
            Console.Write(s);
            */

            double x;
            int n;
            Console.Write("Введите колличество выстрелов:");
            n = int.Parse(Console.ReadLine());
            int[,] xy = new int[2,n];
            Random rand = new Random();
            int x0 = rand.Next(-10, 10);
            int y0 = rand.Next(-10, 10);
            int x1 = rand.Next(-10, 10);
            int y1 = rand.Next(-10, 10);
            int s = 0;
            Console.Write("Введите координаты:\n");
            for (int i = 0; i < n; i++)
            {
                xy[0, i] = int.Parse(Console.ReadLine());
                xy[1, i] = int.Parse(Console.ReadLine());
                int xtemp = xy[0, i] - x1;
                int ytemp = xy[1, i] - y1;
                if (1 > (xtemp* xtemp + ytemp* ytemp)) continue;
                if (1 > ((xy[0, i] - x0) * (xy[0, i] - x0) + (xy[1, i] - y0) * (xy[1, i] - y0))) s = +5;
                if (4 > ((xy[0, i] - x0) * (xy[0, i] - x0) + (xy[1, i] - y0) * (xy[1, i] - y0))) s = +5;
            }
            Console.Write(s);
        }
    }
}
