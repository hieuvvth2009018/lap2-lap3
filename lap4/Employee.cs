using System;

namespace lap4
{
    public abstract class Employee : Person

    {

        public string Department { get; set; }
        public double Salary { get; set; }
        public string DateHired { get; set; }

        public override string ToString()
        {
            return
                $"Name, Phone : {Phone}, Address : {Address}, Email : {Email}, Deprtment : {Department}, Salary : {Salary}, DtadeHired : {DateHired}";
        }

        public abstract double CalculBonus();
        public abstract void CalculateVacation();
    }
}