using System;
namespace Square
{
    class Square
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите периметр");
                string temp = Console.ReadLine();
                int P = Int32.Parse(temp);
                int a = P / 3;
                int p = P / 2;
                double S = Math.Sqrt(p * (p - a) * (p - a) * (p - a));
                Console.WriteLine("{0:0.00}", S);
            }
            catch (Exception e)
            {
                Console.WriteLine("An wrong perimetr exception was thrown: {0}", e.Message);
            }
        }
    }
}
