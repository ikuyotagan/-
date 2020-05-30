using System;
using System.Collections.Generic;
using System.Text;

namespace People
{
    public class Student: Person
    {
        public string fac { get; protected set; }
        public string group { get; protected set; }
        public Student(string fac, string group, string surname, DateTime date) : base(surname, date)
        {
            this.fac = fac;
            this.group = group;
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine("Факультет: {0}\nГруппа: {1}", fac, group);
        }
    }
}
