using System;
namespace phương_trình_bậc_2
{
    internal class phươngtrinhbachai
    {
        public static void Main(string[] args)
        {
            static void Main(string[] agrs)
                    {
                        Console.Write("Nhap  a = ");
                        float a = float.Parse(Console.ReadLine());
                        Console.Write("Nhap  b = ");
                        float b = float.Parse(Console.ReadLine());
                        Console.Write("Nhap  c = ");
                        float c = float.Parse(Console.ReadLine());

                        Console.WriteLine("{0}x^2 + {1}x + {2} = 0",a,b,c);

                        if (a == 0)
                        {
                            if (b == 0)
                            {
                                if (c == 0)
                                {
                                    Console.WriteLine("Phuong trinh vo so nghiem");
                                }
                                else
                                {
                                    Console.WriteLine("Phuong trinh vo nghiem");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Phuong trinh co 1 nghiem: x = {0}", (-c / b));
                            }
                        }
                        else
                        {

                            float delta = b * b - 4 * a * c;
                            float x1;
                            float x2;

                            if (delta > 0)
                            {
                                x1 = (float)((-b + Math.Sqrt(delta)) / (2 * a));
                                x2 = (float)((-b - Math.Sqrt(delta)) / (2 * a));
                                Console.WriteLine("Phuong trinh co 2 nghiem la: x1 = {0} và x2 = {1}", x1, x2);

                            }
                            else if (delta == 0)
                            {
                                x1 = (-b / (2 * a));
                                Console.WriteLine("Phuong trinh co nghiem kep la: x1 = x2 = {0} ", x1);

                            }
                            else
                            {
                                Console.WriteLine("Phuong trinh vo nghiem");
                            }
                        }
                        Console.ReadKey();
                    }      
                }
            }
        }