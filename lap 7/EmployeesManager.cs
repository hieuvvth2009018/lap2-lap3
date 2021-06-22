using System;
using System.Collections.Generic;

namespace lap_7
{
    public class EmployeesManager
    {
         private Dictionary<string, Employees> _Employeess = new Dictionary<string, Employees>();
        public void Create()
        {
            Console.WriteLine("Vui lòng nhập id: ");
            var id = Console.ReadLine();
            Console.WriteLine("Vui lòng nhập tên: ");
            var name = Console.ReadLine();
            Console.WriteLine("Vui lòng nhập tuổi: ");
            var age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Vui lòng nhập lương: ");
            var salary = double.Parse(Console.ReadLine());
            _Employeess.Add(id,new Employees()
            {
                Name = name,
                Age = age,
                Salary = salary
            });
        }
        public void Display ()
        {
            foreach (var list in _Employeess)
            {
                Console.WriteLine($"id: {list.Key},{list.Value}");
            }
        }

        public void Update()
        {
            Console.WriteLine("Vui lòng nhập id: ");
            var id = Console.ReadLine();
            if (_Employeess.ContainsKey(id))
            {
                Console.WriteLine("Vui lòng sửa tên: ");
                var name = Console.ReadLine();
                Console.WriteLine("Vui lòng sửa tuổi: ");
                var age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Vui lòng sửa lương: ");
                var salary = double.Parse(Console.ReadLine());
                _Employeess[id].Name = name;
                _Employeess[id].Age = age;
                _Employeess[id].Salary = salary;
            }
            else
            {
                Console.WriteLine("Nhân viên không tồn tại!");
            }
        }

        public void Delete()
        {
            Console.WriteLine("Vui lòng nhập id: ");
            var id = Console.ReadLine();
            if (_Employeess.ContainsKey(id))
            {
                _Employeess.Remove(id);
                Console.WriteLine("Xóa thông tin thành công.");
            }
            else
            {
                Console.WriteLine("Nhân viên không tồn tại!");
            }
        }
    }
    }
