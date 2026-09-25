using System;
using System.Collections.Generic;

namespace TaskApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // RunTask01();
            // RunTask02();
            // RunTask03();
            // RunTask04();
            // RunTask05();
            // RunTask06();
            // RunTask07();
            // RunTask08();
            // RunTask09();
            // RunTask10();
            // RunTask11();
            // RunTask12();
            // RunTask13();
            // RunTask14();
            // RunTask15();
            // RunTask16();
            // RunTask17();
            // RunTask18();
            // RunTask19();
            // RunTask20();
        }

        #region Task01
        private static void RunTask01()
        {
            Console.WriteLine("Task 01: Sorting employees by salary");

            Employee[] employees =
            {
                new Employee(1, "Alice", 75000),
                new Employee(2, "Mohamed", 52000),
                new Employee(3, "Nour", 91000)
            };

            PrintEmployees(employees);

            SortingAlgorithm<Employee>.Sort(employees);

            Console.WriteLine("Sorted by salary:");
            PrintEmployees(employees);
        }
        #endregion

        #region Task02
        private static void RunTask02()
        {
            Console.WriteLine("Task 02: Dynamic descending integer sorting");

            int[] numbers = { 4, 9, 2, 7, 1, 8 };
            SortingTwo<int>.Sort(numbers, (left, right) => left < right);

            PrintIntegers(numbers);
        }
        #endregion

        #region Task03
        private static void RunTask03()
        {
            Console.WriteLine("Task 03: Sorting strings by length");

            string[] names = { "Mohamed", "Ali", "Ibrahim", "Zed" };
            StringLengthComparer comparer = new StringLengthComparer();

            SortingTwo<string>.Sort(names, (left, right) => comparer.Compare(left, right) > 0);

            PrintStrings(names);
        }
        #endregion

        #region Task04
        private static void RunTask04()
        {
            Console.WriteLine("Task 04: Sorting managers by salary");

            Manager[] managers =
            {
                new Manager(1, "Sara", 90000, "Engineering"),
                new Manager(2, "Omar", 65000, "Finance"),
                new Manager(3, "Mona", 78000, "Operations")
            };

            SortingAlgorithm<Manager>.Sort(managers);

            PrintEmployees(managers);
        }
        #endregion

        #region Task05
        private static void RunTask05()
        {
            Console.WriteLine("Task 05: Sorting employees by name length with Func");

            Employee[] employees =
            {
                new Employee(1, "Ali", 50000),
                new Employee(2, "Mohamed", 70000),
                new Employee(3, "Mona", 60000)
            };

            Func<Employee, Employee, bool> shouldSwap =
                (left, right) => left.Name.Length > right.Name.Length;

            SortingTwo<Employee>.Sort(employees, shouldSwap);

            PrintEmployees(employees);
        }
        #endregion

        #region Task06
        private static void RunTask06()
        {
            Console.WriteLine("Task 06: Anonymous function and lambda sorting");

            int[] anonymousNumbers = { 8, 3, 6, 1, 5 };
            Array.Sort(anonymousNumbers, delegate(int left, int right)
            {
                return left.CompareTo(right);
            });

            int[] lambdaNumbers = { 8, 3, 6, 1, 5 };
            Array.Sort(lambdaNumbers, (left, right) => left.CompareTo(right));

            Console.Write("Anonymous function result: ");
            PrintIntegers(anonymousNumbers);
            Console.Write("Lambda result: ");
            PrintIntegers(lambdaNumbers);
        }
        #endregion

        #region Task07
        private static void RunTask07()
        {
            Console.WriteLine("Task 07: Generic Swap method");

            int[] numbers = { 10, 20 };
            GenericMethods.Swap(ref numbers[0], ref numbers[1]);

            PrintIntegers(numbers);
        }
        #endregion

        #region Task08
        private static void RunTask08()
        {
            Console.WriteLine("Task 08: Sorting by salary and then name");

            Employee[] employees =
            {
                new Employee(1, "Zara", 60000),
                new Employee(2, "Adam", 60000),
                new Employee(3, "Mona", 50000),
                new Employee(4, "Bayan", 70000)
            };

            EmployeeSalaryNameComparer comparer = new EmployeeSalaryNameComparer();
            SortingTwo<Employee>.Sort(employees, (left, right) => comparer.Compare(left, right) > 0);

            PrintEmployees(employees);
        }
        #endregion

        #region Task09
        private static void RunTask09()
        {
            Console.WriteLine("Task 09: Default values");

            int defaultInt = GenericMethods.GetDefault<int>();
            string defaultString = GenericMethods.GetDefault<string>();
            Employee defaultEmployee = GenericMethods.GetDefault<Employee>();

            Console.WriteLine($"Default int: {defaultInt}");
            Console.WriteLine($"Default string: {(defaultString == null ? "null" : defaultString)}");
            Console.WriteLine($"Default Employee: {(defaultEmployee == null ? "null" : defaultEmployee.ToString())}");
        }
        #endregion

        #region Task10
        private static void RunTask10()
        {
            Console.WriteLine("Task 10: ICloneable constraint and array copying");

            Employee[] employees =
            {
                new Employee(1, "Sara", 82000),
                new Employee(2, "Hassan", 61000),
                new Employee(3, "Mona", 74000)
            };

            Employee originalFirstEmployee = employees[0];
            SortingAlgorithm<Employee>.Sort(employees);

            Console.WriteLine($"The sorted array contains cloned employees: {!object.ReferenceEquals(originalFirstEmployee, employees[0])}");
            PrintEmployees(employees);
        }
        #endregion

        #region Task11
        private static void RunTask11()
        {
            Console.WriteLine("Task 11: String transformation delegate");

            List<string> words = new List<string> { "delegate", "generic", "lambda" };
            StringTransform toUpper = DelegateOperations.ToUpper;
            StringTransform reverse = DelegateOperations.Reverse;

            List<string> upperWords = DelegateOperations.ApplyStringTransform(words, toUpper);
            List<string> reversedWords = DelegateOperations.ApplyStringTransform(words, reverse);

            Console.WriteLine($"Uppercase: {string.Join(", ", upperWords)}");
            Console.WriteLine($"Reversed: {string.Join(", ", reversedWords)}");
        }
        #endregion

        #region Task12
        private static void RunTask12()
        {
            Console.WriteLine("Task 12: Integer operation delegate");

            IntegerOperation add = DelegateOperations.Add;
            IntegerOperation subtract = DelegateOperations.Subtract;
            IntegerOperation multiply = DelegateOperations.Multiply;
            IntegerOperation divide = DelegateOperations.Divide;

            Console.WriteLine($"Add: {add(12, 4)}");
            Console.WriteLine($"Subtract: {subtract(12, 4)}");
            Console.WriteLine($"Multiply: {multiply(12, 4)}");
            Console.WriteLine($"Divide: {divide(12, 4)}");
        }
        #endregion

        #region Task13
        private static void RunTask13()
        {
            Console.WriteLine("Task 13: Generic transformation delegate");

            List<int> numbers = new List<int> { 10, 20, 30, 40 };
            TransformDelegate<int, string> convertToString = number => number.ToString();
            List<string> convertedNumbers = DelegateOperations.ApplyTransform(numbers, convertToString);

            Console.WriteLine(string.Join(", ", convertedNumbers));
        }
        #endregion

        #region Task14
        private static void RunTask14()
        {
            Console.WriteLine("Task 14: Func for calculating squares");

            List<int> numbers = new List<int> { 2, 3, 4, 5 };
            Func<int, int> square = DelegateOperations.Square;
            List<int> squares = numbers.ConvertAll(number => square(number));

            Console.WriteLine(string.Join(", ", squares));
        }
        #endregion

        #region Task15
        private static void RunTask15()
        {
            Console.WriteLine("Task 15: Action for printing strings");

            List<string> messages = new List<string> { "First message", "Second message", "Third message" };
            Action<string> printMessage = message => Console.WriteLine(message);

            foreach (string message in messages)
            {
                printMessage(message);
            }
        }
        #endregion

        #region Task16
        private static void RunTask16()
        {
            Console.WriteLine("Task 16: Predicate for filtering even numbers");

            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };
            Predicate<int> isEven = DelegateOperations.IsEven;
            List<int> evenNumbers = numbers.FindAll(isEven);

            Console.WriteLine(string.Join(", ", evenNumbers));
        }
        #endregion

        #region Task17
        private static void RunTask17()
        {
            Console.WriteLine("Task 17: Anonymous functions for string filtering");

            List<string> words = new List<string> { "CSharp", "delegate", "functional", "sharp" };
            List<string> startsWithC = words.FindAll(delegate(string word)
            {
                return word.StartsWith("C", StringComparison.OrdinalIgnoreCase);
            });
            List<string> containsSharp = words.FindAll(delegate(string word)
            {
                return word.IndexOf("sharp", StringComparison.OrdinalIgnoreCase) >= 0;
            });

            Console.WriteLine($"Starts with C: {string.Join(", ", startsWithC)}");
            Console.WriteLine($"Contains sharp: {string.Join(", ", containsSharp)}");
        }
        #endregion

        #region Task18
        private static void RunTask18()
        {
            Console.WriteLine("Task 18: Anonymous functions for integer operations");

            Func<int, int, int> add = delegate(int first, int second)
            {
                return first + second;
            };
            Func<int, int, int> subtract = delegate(int first, int second)
            {
                return first - second;
            };
            Func<int, int, int> multiply = delegate(int first, int second)
            {
                return first * second;
            };

            Console.WriteLine($"Add: {add(15, 6)}");
            Console.WriteLine($"Subtract: {subtract(15, 6)}");
            Console.WriteLine($"Multiply: {multiply(15, 6)}");
        }
        #endregion

        #region Task19
        private static void RunTask19()
        {
            Console.WriteLine("Task 19: Lambdas for string filtering");

            List<string> names = new List<string> { "Ali", "Mohamed", "Mona", "Ehab", "Sara" };
            List<string> longNames = names.FindAll(name => name.Length > 3);
            List<string> namesContainingE = names.FindAll(
                name => name.IndexOf('e', StringComparison.OrdinalIgnoreCase) >= 0);

            Console.WriteLine($"Longer than three characters: {string.Join(", ", longNames)}");
            Console.WriteLine($"Contains e: {string.Join(", ", namesContainingE)}");
        }
        #endregion

        #region Task20
        private static void RunTask20()
        {
            Console.WriteLine("Task 20: Lambdas for double operations");

            Func<double, double, double> divide = (first, second) => first / second;
            Func<double, double, double> power = (value, exponent) => Math.Pow(value, exponent);

            Console.WriteLine($"Divide: {divide(10.0, 2.0)}");
            Console.WriteLine($"Power: {power(2.0, 3.0)}");
        }
        #endregion

        #region OutputHelpers
        private static void PrintEmployees(IEnumerable<Employee> employees)
        {
            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee);
            }
        }

        private static void PrintIntegers(IEnumerable<int> values)
        {
            Console.WriteLine(string.Join(", ", values));
        }

        private static void PrintStrings(IEnumerable<string> values)
        {
            Console.WriteLine(string.Join(", ", values));
        }
        #endregion
    }
}
