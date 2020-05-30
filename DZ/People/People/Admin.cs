using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace People
{
    public class Admin :Person, IEmployee
    {
        public string lab { get; protected set; }
        public int salary { get; }
        public bool VacationStatus { get; set; }
        public Admin(string lab, string surname, DateTime date) : base(surname, date)
        {
            this.lab = lab;
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine("Лаборатория: {0}", lab);
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
