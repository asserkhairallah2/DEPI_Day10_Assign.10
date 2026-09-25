using System;
using System.Collections.Generic;

namespace TaskApp
{
    #region StringLengthComparer
    class StringLengthComparer : IComparer<string>
    {
        public int Compare(string first, string second)
        {
            int firstLength = first == null ? 0 : first.Length;
            int secondLength = second == null ? 0 : second.Length;

            return firstLength.CompareTo(secondLength);
        }
    }
    #endregion

    #region EmployeeSalaryNameComparer
    class EmployeeSalaryNameComparer : IComparer<Employee>
    {
        public int Compare(Employee first, Employee second)
        {
            if (first == null && second == null)
            {
                return 0;
            }

            if (first == null)
            {
                return -1;
            }

            if (second == null)
            {
                return 1;
            }

            int salaryComparison = first.Salary.CompareTo(second.Salary);

            if (salaryComparison != 0)
            {
                return salaryComparison;
            }

            return string.Compare(first.Name, second.Name, StringComparison.OrdinalIgnoreCase);
        }
    }
    #endregion
}
