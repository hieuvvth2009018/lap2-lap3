using System;
using System.Text;
using Lab1.BaiLab5;
using lab5.ex2;

namespace DefaultNamespace
{
    public class MainThread
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Which item would you like to order?");
                Console.WriteLine("----------------------------------");
                Console.WriteLine("1: Grocery goods");
                Console.WriteLine("2: Bakery products");
                Console.WriteLine("3: Thoat");
                Console.WriteLine("----------------------------------");
                int choice = Convert.ToInt32(Console.ReadLine());
                Order order = new Order();
                
                
                switch (choice)
                {
                    case 1:
                        order.Ord_grocery();
                        Console.WriteLine("You have chosen to buy the product at the grocery store");
                        break;
                    case 2:
                        order.Ord_bakery();
                        Console.WriteLine("You have chosen to buy products at the bakery shop");
                        break;
                }

                Console.ReadLine();
                if (choice == 3)
                {
                    Console.WriteLine("good by!!!");
                    break;
                }
            }
        }
    }
}
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
     /*Console.OutputEncoding = Encoding.UTF8;

     Console.WriteLine("vui lòng nhập tên");
     var name = Console.ReadLine();
     Console.WriteLine("vui lòng nhập salary");
    var salary = double.Parse(Console.ReadLine());
    Console.WriteLine("vui lòng nhập bonus");
     var bonus = double.Parse(Console.ReadLine());
     var seniorLecture = new Exception.SeniorLecture
    {
         name = name,
         Salary = salary,
         Bonus = bonus
     };

     try
     {
         CheckAmount(seniorLecture);
     }
     catch (Exception.AmountException e)
     {
         Console.WriteLine(e);
         throw;
     }

     public static void CheckAmount(Exception.SeniorLecture seniorLecture)
     {
         if (seniorLecture.Salary < 60000)
         {
             throw new Exception.AmountException(
                 $"mức lương của giảng viên {seniorLecture.Name} tối thiểu phải từ 60000");
         }
         else if (seniorLecture.Bonus > 10000)
         {
             throw new Exception.AmountException()(
                 $"mức thưởng của giảng viên {seniorLecture.Name} tối đa không quá 10000");
         }
         else
         {
             Console.WriteLine("Okie");
         }
     }*/