using System;

namespace TaskApp
{
    #region Employee
    class Employee : IComparable<Employee>, ICloneable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee(int id, string name, double salary)
        {
            Id = id;
            Name = name ?? string.Empty;
            Salary = salary;
        }

        public int CompareTo(Employee other)
        {
            if (other == null)
            {
                return 1;
            }

            return Salary.CompareTo(other.Salary);
        }

        public virtual object Clone()
        {
            return new Employee(Id, Name, Salary);
        }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Salary: {Salary:0.##}";
        }
    }
    #endregion
}
