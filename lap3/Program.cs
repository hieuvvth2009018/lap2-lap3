using System;
using System.Text;

namespace lap3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine(  );
            atom atom = new atom();
            while (true)
            {
                atom.accept();
                Console.WriteLine("chọn 1 để tiếp tục ,chọn 2 để dừng ");
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
