using System;

namespace Ex3
{
    class Ex3
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int [] a = new int[n];
            float sr = 0;
            int sum = 0,
                summin = 0,
                sumplus = 0,
                sumch = 0,
                sumnech = 0,
                max = -999999,
                mini = -1,
                min = 999999,
                maxi = -1,
                pro = 1;
            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
                sum += a[i];
                sr = sum / n;
                if (a[i] > 0) sumplus += a[i];
                if (a[i] < 0) summin += a[i];
                if (i % 2 == 0) sumch += a[i];
                if (i % 2 == 1) sumnech += a[i];
                if (max < a[i])
                {
                    max = a[i];
                    maxi = i;
                }

                if (min > a[i])
                {
                    min = a[i];
                    mini = i;
                }
            }

            for (int i = Math.Min(mini,maxi) ; i < Math.Max(mini, maxi); i++)
            {
                pro *= a[i];
            }
            Console.WriteLine("Сумма элементов: {0}",sum);
            Console.WriteLine("Сумма положительных элементов: {0}", sumplus);
            Console.WriteLine("Сумма отрицательных элементов: {0}", summin);
            Console.WriteLine("Среднее значение элемента: {0}", sr);
            Console.WriteLine("Сумма элементов под четным номером: {0}", sumch);
            Console.WriteLine("Сумма элементов под нечетным номером: {0}", sumnech);
            Console.WriteLine("Максимальный элемент под номером {1} равен: {0}", max, maxi);
            Console.WriteLine("Минимальный элемент под номером {1} равен: {0}", min, mini);
            Console.WriteLine("Произведение элементов между ними: {0}", pro);
        }
    }
}
