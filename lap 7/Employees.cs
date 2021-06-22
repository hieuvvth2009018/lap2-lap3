namespace lap_7
{
    public class Employees
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public double Salary { get; set; }

            public override string ToString()
            {
                return $"Tên : {Name}, Tuổi : {Age}, Lương : {Salary}";
            }
        }
    } 