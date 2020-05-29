using System;
using System.IO;
namespace Azino888
{
    class Azino888
    {
        static void Main(string[] args)
        {
            Menue Menu = new Menue();
            int value = -1;
            Console.WriteLine("Добро пожаловать в Azino888");
            Console.WriteLine("Введите начальный баланс: ");
            value = int.Parse(Console.ReadLine());
            Menu.Menu(ref value);
        }
    }
}
