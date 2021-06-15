using System;
using Lab1.BaiLab5;

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
            
    