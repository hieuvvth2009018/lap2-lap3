using System;

namespace Lab5._2.EX2
{
    public class Exercise
    {
        public class AmountException : Exception
        {
            public AmountException()
            { }
            public AmountException(string message):base(message)
            { }
        }

        public class SeniorLecture
        {
            public double Salary { get; set; }
            public double Bonus { get; set; }
            public string Name { get; set; }
        }
    }
}