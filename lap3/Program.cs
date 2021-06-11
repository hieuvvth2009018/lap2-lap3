using System;
using System.Text;

namespace lap3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var atoms = new atom[10];
            Console.WriteLine("Atomic Information");
            Console.WriteLine("==================");
            var count = 0;
            for (int i = 0; i < 10; i++)
            {
                var atom = new atom();
                var result = atom.accept();
                if (!result || atom.number == 0)
                {
                    break;
                }

                atoms[i] = atom;
                count++;
            }

            Console.WriteLine("No Sym Name Weight");
            Console.WriteLine("------------------------------------");
            for (int i = 0; i < count; i++)
            {
                atoms[i].Display();
            }
        }
    }
}
    
