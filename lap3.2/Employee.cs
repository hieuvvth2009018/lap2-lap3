using System;
using System.Text;

namespace lap3._2
{
    public class Employee
    {
        public String Firname { get; set; }
        public String Lastname { get; set; }
        public  String Address { get; set; }
        public long sin { get; set; }
        public double salary { get; set; }

        public void tostrinh()
        {
            Console.WriteLine($"Fullame: {Firname} {Lastname},address {Address}, Sin {sin}, Salary {salary}");
        }

        public void tienthuong(double percentage)
        {
            Console.OutputEncoding= Encoding.UTF8;
            Console.WriteLine($"tienthuong = {salary *percentage}");
        }
    }
    }
