using System;
using System.Collections.Generic;

namespace lap3
{
    public class atom
    {
        public int number { get; set; }
        public String symblo { get; set; }
        public String fluname { get; set; }
        public Double weigh { get; set; }
        private List<atom> _listAtionic = new List<atom>();

        public bool accept()
        {
            Console.WriteLine("please enter ation number: ");
            var nummber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please enter symbol: ");
            var symbol = Console.ReadLine();
            Console.WriteLine("please enter full name ");
            var fullname = Console.ReadLine();
            Console.WriteLine("please enter weghi: ");
            var wheigh = Convert.ToDouble(Console.ReadLine());
            _listAtionic.Add(new atom()
            {
                number = number,
                symblo = symblo,
                fluname = fluname,
                weigh = weigh,
            });

            return true;
        }

        public void Display()
        {
            for (int i = 0; i < _listAtionic.Count; i++)

            {
                atom atom = _listAtionic[i];
                if (_listAtionic.Count > 10)
                {
                    Console.WriteLine("chi nhan toi da 10 phan tu ");
                    return;
                }
                else
                {
                    Console.WriteLine(
                        $"number{atom.number},symblo{atom.symblo},fullname{atom.fluname},number{atom.number}");

                }
            }
        }
    }
}