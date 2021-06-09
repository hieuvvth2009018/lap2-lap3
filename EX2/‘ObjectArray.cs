﻿using System;
using lap3._2;

namespace EX2
{
    internal class Employee
    {
        private int empID;

        public Employee(int i)
        {
            throw new NotImplementedException();
        }

        // constructor

        public override string ToString()
        {
            return empID.ToString();
        }
    }

    class ObjectArray
    {
        public void Run()
        {
            int[] intArray;
            Employee[] empArray;
            intArray = new int[5];
            empArray = new Employee[3];

            // populate the array
            for (int i = 0; i < empArray.Length; i++)
            {
                empArray[i] = new Employee(i + 5);

            }

            Console.WriteLine("The int array...");
            for (int i = 0; i < intArray.Length; i++)
            {
                Console.WriteLine(intArray[i].ToString());
            }

            Console.WriteLine("\nThe employee array...");
            for (int i = 0; i < empArray.Length; i++)
            {
                Console.WriteLine(empArray[i].ToString());
            }
        }

        static void Main(string[] args)
        {
            ObjectArray array = new ObjectArray();
            array.Run();
            Console.ReadLine();
        }
    }
}
