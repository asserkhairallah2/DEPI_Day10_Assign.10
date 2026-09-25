using System;

namespace TaskApp
{
    #region Manager
    class Manager : Employee, IComparable<Manager>
    {
        public string Department { get; set; }

        public Manager(int id, string name, double salary, string department)
            : base(id, name, salary)
        {
            Department = department ?? string.Empty;
        }

        public int CompareTo(Manager other)
        {
            if (other == null)
            {
                return 1;
            }

            return Salary.CompareTo(other.Salary);
        }

        public override object Clone()
        {
            return new Manager(Id, Name, Salary, Department);
        }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Salary: {Salary:0.##}, Department: {Department}";
        }
    }
    #endregion
}
