using System;
using System.Collections.Generic;
using System.Text;

namespace People
{
    public class Manager: Person, IEmployee
    {
        public string fac { get; protected set; } 
        public string func { get; protected set; }
        public int salary { get; }
        public bool VacationStatus { get; set; }
        public Manager(string fac, string func, string surname, DateTime date) : base(surname, date)
        { 
            this.fac = fac;
            this.func = func;
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine("Факультет: {0}\nДолжность: {1}", fac, func);
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