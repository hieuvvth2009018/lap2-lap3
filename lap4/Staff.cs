using System;

namespace lap4
{
    public class Staff: Employee
    {
        public int Title { get; set; }
        public override string ToString()
        {
            return $"Department : {Department}, Salary : {Salary}, DateHired : {DateHired}, Title : {Title}";
        }

        public override double CalculBonus()

        {
            double result;
            result = Salary * 0.06;
            return result;
        }

        public override void CalculateVacation()
        {
            Console.WriteLine("vui long nhap so năm cống hiến ");
            int year = Convert.ToInt32(Console.ReadLine());
            if (year>=5)
            {
                Console.WriteLine("được nghỉ 4 tuần "); 
            }
            else
            {
                Console.WriteLine("được nghỉ 3 tuần ");
            }
        }
    }
}