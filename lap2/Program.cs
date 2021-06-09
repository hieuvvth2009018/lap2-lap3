using System;

namespace lap2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("vui long nhap sin");
            int n = int.Parse(Console.ReadLine());
            int sun = 0;
            if (n.ToString().Length != 9)
            {
                Console.WriteLine("chuong trinh chi nhan 9 so ");
            }
            else
            {
                while (n != 0)
                {
                    sun = sun + n % 10;
                    n = n / 10;
                }

                int total = sun % 10;
                if (total == 0)
                {
                    Console.WriteLine("this is vailde sin");
                }
            }
        }
    }
}