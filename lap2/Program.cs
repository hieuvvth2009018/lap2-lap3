using System;
using System.Text;

namespace lap2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            String s = Console.ReadLine();
            int a = int.Parse(s.Substring(0, 1));
            int b = int.Parse(s.Substring(1, 1));
            int c = int.Parse(s.Substring(2, 1));
            int d = int.Parse(s.Substring(3, 1));
            int e = int.Parse(s.Substring(4, 1));
            int f = int.Parse(s.Substring(5, 1));
            int g = int.Parse(s.Substring(6, 1));
            int h = int.Parse(s.Substring(7, 1));
            int k = int.Parse(s.Substring(8, 1));
            String u = $"{b * 2}{d * 2}{f * 2}{h * 2}";
            int z = a + c + e + g;
            int sun = 0;
            int q = int.Parse(u);
            while (q !=0)
            {
                sun = sun + q % 10;
                q /= 10;
            }

            int total = sun + 2;
            Console.WriteLine(total % 10);
            int x = 0;
            for (int i = 0; i < 10; i++)
            {
                if (total % 10 +i==10)
                {
                    x = i;
                }                
            }
            Console.WriteLine(x);
            if (x==k)
            {
                Console.WriteLine("đã duoc");
            }
            else
            {
                Console.WriteLine("không được");
            }
        }
    }

}

