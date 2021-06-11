using System;

namespace lap4
{
    public class Faculty : Employee
    {
        public string OfficeHour { get; set; }
        public int Rank { get; set; }

        public override string ToString()
        {
            return
                $"Department : {Department}, Salary : {Salary}, DateHired : {DateHired}, OfficeHour : {OfficeHour}, Rank : {Rank}";
        }

        public override double CalculBonus()
        {
            double result;
            result = Salary * 0.05 + 1000;
            return result;
        }

        public override void CalculateVacation()
        {
            Console.WriteLine("vui long hnhap so nam lam viec ");
            int year = Convert.ToInt32(Console.ReadLine());
            if (year > 3 && Rank == 1)
            {
                Console.WriteLine("duoc nghi phep 6 tuan");
            }
            else if (year>3)
            {
                Console.WriteLine("duoc nghi phep 5 tuan");
            }
        }
    }
}