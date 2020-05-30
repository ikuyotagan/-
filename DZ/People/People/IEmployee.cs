using System;
using System.Collections.Generic;
using System.Text;

namespace People
{
    public interface IEmployee
    {
        string surname { get; }
        int salary { get; }
        DateTime date { get; }
        void TakeVacation();
        void EndVacation();

        bool VacationStatus { get; }
    }
}
