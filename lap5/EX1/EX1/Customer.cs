using System;

namespace Lab1.BaiLab5
{
    public class Customer
    {
        public string Name { get; set; }
        public void getName()
        {
            Console.WriteLine("Enter you name.");
            Name = Console.ReadLine();
        }
    }
}