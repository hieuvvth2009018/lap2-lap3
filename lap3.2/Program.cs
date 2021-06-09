using System;

namespace lap3._2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Employee employe = new Employee();
            Console.WriteLine("please enter first name: ");
            employe.Firname = Console.ReadLine();
            Console.WriteLine("please enter last name: ");
            employe.Lastname = Console.ReadLine();
            Console.WriteLine("please enter address name: ");
            employe.Address = Console.ReadLine();
            Console.WriteLine("please enter sin name: ");
            employe.sin = long.Parse(Console.ReadLine());
            Console.WriteLine("please enter salary name: ");
            employe.salary = double.Parse(Console.ReadLine());
            employe.ToString();
            double a = double.Parse(Console.ReadLine());
            employe.tienthuong(a);
        }
    }
}