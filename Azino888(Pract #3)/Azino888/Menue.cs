using System;
using System.Collections.Generic;
using System.Text;

namespace Azino888
{
    class Menue
    {
        private char ch = 'k';
        private Chet chet = new Chet();

        public void Menu(ref int value)
        {
            while (true){
                Console.WriteLine(" ");
                Console.WriteLine("Хотите начать играть, пополнить свой баланс или выйти?(p/c/q)");
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
                    chet.Bet(ref value);
                }
                else if (ch == 'c')
                {
                    Check(ref value);
                }
                else if (ch == 'q')
                {
                    break;
                }
            }
        }
        void Check(ref int value)
        {
            Console.WriteLine("Ваш баланс равен {0}", value);
            Console.WriteLine("Для пополнения баланса введите сумму пополнения, и бросьте деньги в монитор.");
            value += int.Parse(Console.ReadLine());
            Menu(ref value);
        }
    }
}
