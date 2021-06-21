using System;
using System.ComponentModel;

namespace EventAndDelegate
{
    internal  abstract class Program
    {
        public delegate void Increment(ref int x);

        public static void Add2(ref int x)
        {
            x += 2;
        }

        public static void Add3(ref int x)
        {
            x += 3;
        }

        public static void Main()
        {
            Increment increment = new Increment(Add2) ;
            increment += Add3;
            increment += Add2;
            int x = 5;
            increment(ref x);
            Console.ReadLine();

        }
    }
}

        /*
        public delegate int hieudelegate(int a, int b, int c);

        public static int tinhtongbaso(int a, int b, int c)
        {
            return a + b + c;
        }

        public static void main()
        {
            hieudelegate hieudelegate = new hieudelegate(tinhtongbaso);
            var resul = hieudelegate(1, 2, 3);
            Console.WriteLine(resul);
        }
    }
    
}
*/
    


            
                