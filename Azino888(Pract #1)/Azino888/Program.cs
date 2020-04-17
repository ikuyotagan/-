using System;
using System.IO;
namespace Azino888
{
    class Azino888
    {
        static void Menu(ref int value)
        {
            Console.WriteLine(" ");
            Console.WriteLine("Хотите начать играть, пополнить свой баланс или выйти?(p/c/q)");
            char ch = 'k';
            while (ch != 'p' || ch != 'c' || ch != 'q')
            {
                try
                {
                    ch = char.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Неверный формат ввода");
                    Console.WriteLine("Допускается вводить только буквы p, q и c");
                }
                if (ch == 'p' || ch == 'c' || ch == 'q')
                {
                    break;
                }
            }
            if (ch == 'p')
            {
                Bet(ref value);
            } else if (ch == 'c')
            {
                Check(ref value);
            }
        }

        static void Check(ref int value)
        {
            Console.WriteLine("Ваш баланс равен {0}", value);
            Console.WriteLine("Для пополнения баланса введите сумму пополнения, и бросьте деньги в монитор.");
            value += int.Parse(Console.ReadLine());
            Menu(ref value);
        }
        static void Bet(ref int value)
        {
            Console.WriteLine("Установите сумму ставки:");
            int summ = int.Parse(Console.ReadLine());
            while (summ <= 0 || summ > value) {
                Console.WriteLine("Недопустимый размер ставки.");
                Console.WriteLine("Введите ставку больше нуля, но не больше вашего капитала ");
                summ = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Выберите сторону? (0 - чётные, 1 - нечётные)");
            int choice = -1;
            while (choice < 1 || choice > 0) {
                try {
                    choice = int.Parse(Console.ReadLine());
                }
                catch {
                    Console.WriteLine("Неверный формат выбора стороны");
                    continue;
                }
                if (choice == 1 || choice == 0) {
                    break;
                }
                Console.WriteLine("Допускается вводить только числа 1 и 0");
            }

            Random rand = new Random();
            if (rand.Next() % 2 == choice) {
                Console.WriteLine("Вы выиграли! Теперь ваш баланс составляет {0}",value+summ);
                value += summ;
            }
            else {
                Console.WriteLine("Вы проиграли! Теперь ваш баланс составляет {0}", value - summ);
                value -= summ;
            }
            Console.WriteLine("Хотите продолжить игру?(y/n):");
            char ch = 'k';
            while (ch != 'y' || ch != 'n') {
                try {
                    ch = char.Parse(Console.ReadLine());
                }
                catch {
                    Console.WriteLine("Неверный формат ввода");
                    Console.WriteLine("Допускается вводить только буквы y и n");
                }
                if (ch == 'y' || ch == 'n') {
                    break;
                }
            }
            if (ch == 'y') {
                Bet(ref value);
            }
            else {
                Menu(ref value);
            }
        }
        static void Main(string[] args)
        {
            int value = -1;
            Console.WriteLine("Добро пожаловать в Azino888");
            Console.WriteLine("Введите начальный баланс: ");
            value = int.Parse(Console.ReadLine());
            Menu(ref value);
        }
    }
}
