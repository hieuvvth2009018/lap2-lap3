using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace phuongtrinhbac2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập số A:");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhập số B:");
            float b = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhập số C:");
            float c = float.Parse(Console.ReadLine());
            float delta = (b/2) * (b/2) - a*c;
            Console.WriteLine("Phương trình nhập vào là:\n {0}x^2 + {1}x + {2} = 0 ",a,b,c);
            Console.WriteLine("Delta Phẩy = {0}", delta);

            if(delta < 0)
            {
                Console.WriteLine("Phương trình vô nghiêm.");
            }
            else if(delta == 0)
            {
                float x = (-b / 2) /a;
                Console.WriteLine("Phương trình có nghiệm kép x1 = x2 = {0}",x);

            }
            else
            {
                double x1 = 0;
                double x2 = 0;
                x1 = ((-b / 2) - Math.Sqrt(delta)) / a;
                x2 = ((-b / 2) + Math.Sqrt(delta)) / a;

                Console.WriteLine("Phương trình có 2 nghiệm phân biệt:");
                Console.WriteLine("x1 ={0}", x1);
                Console.WriteLine("x2 ={0}", x2);
            }

            Console.ReadKey();

        }
    }
}