using System;

namespace lap3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            atom atom = new atom();
            while (true)
            {
                atom.accept();
                Console.WriteLine("chon 1 tiếp tục ,chọn 2 để dừng  ");
                int choice = int.Parse(Console.ReadLine());
                if (choice!=1)
                {
                    break;
                }
            }
            atom.Display();
        }
        }
    }
