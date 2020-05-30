using System;
using System.Collections.Generic;
using System.Text;

namespace People
{
    public abstract class Person
    {

        public string surname { get; protected set; }
        public DateTime date { get; protected set; }
        public Person(string surname, DateTime date)
        {
            this.surname = surname;
            this.date = date;

        }
        public double Age()
        {
            return Math.Round(((float)DateTime.Now.Year + ((float)DateTime.Now.Month) / 12) - ((float)date.Year + ((float)date.Month) / 12), 1);
        }
        public virtual void Print()
        {
            Console.WriteLine("\nПерсональная информация:" +
                              "\nФамилия: {0}" +
                              "\nДата рождения: {1}", surname, date.Date);
        }
    }
}
