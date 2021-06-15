using System;

namespace Lab1.BaiLab5
{
    public class Order
    {
        public string Name { get; set; }
        public void Ord_grocery()
        {
            Customer customer = new Customer();
            customer.getName();
            Console.WriteLine($"{customer.Name}");
            Console.WriteLine("You have ordered grocery items");
            Name = Console.ReadLine();
            Console.WriteLine($"banh da dat: {Name}");
        }
        
        public void Ord_bakery()
        {
            Customer customer = new Customer();
            customer.getName();
            Console.WriteLine($"{customer.Name}");
            Console.WriteLine("You have ordered bakery items");
            Name = Console.ReadLine();
            Console.WriteLine($"ban da chon tap hoa:{Name}");
        }
    }
}