using System;
using System.Collections.Generic;
using System.Text;

namespace People
{
    public class Teacher: Person, IEmployee
    {
        public string fac { get; protected set; }
        public string func { get; protected set; }
        public int exp { get; protected set; }
        public int salary { get; }
        public bool VacationStatus { get; set; }
        public Teacher(string fac, string func, int exp, string surname, DateTime date) : base(surname, date)
        {
            this.fac = fac;
            this.func = func;
            this.exp = exp;
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine("Факультет: {0}\nДолжность: {1}\nСтаж (в годах): {2}", fac, func, exp);
        }
        public void TakeVacation()
        {
            this.VacationStatus = true;
        }

        public void EndVacation()
        {
            this.VacationStatus = false;
        }
    }
}
