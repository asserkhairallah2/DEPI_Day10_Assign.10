using System;
using System.Collections.Generic;

namespace TaskApp
{
    #region CustomDelegates
    public delegate string StringTransform(string value);

    public delegate int IntegerOperation(int first, int second);

    public delegate TResult TransformDelegate<in T, out TResult>(T value);
    #endregion

    #region DelegateOperations
    static class DelegateOperations
    {
        public static string ToUpper(string value)
        {
            return value == null ? string.Empty : value.ToUpperInvariant();
        }

        public static string Reverse(string value)
        {
            if (value == null)
            {
                return string.Empty;
            }

            char[] characters = value.ToCharArray();
            Array.Reverse(characters);

            return new string(characters);
        }

        public static int Add(int first, int second)
        {
            return first + second;
        }

        public static int Subtract(int first, int second)
        {
            return first - second;
        }

        public static int Multiply(int first, int second)
        {
            return first * second;
        }

        public static int Divide(int first, int second)
        {
            if (second == 0)
            {
                throw new DivideByZeroException();
            }

            return first / second;
        }

        public static int Square(int value)
        {
            return value * value;
        }

        public static bool IsEven(int value)
        {
            return value % 2 == 0;
        }

        public static List<string> ApplyStringTransform(IList<string> values, StringTransform transform)
        {
            if (values == null)
            {
                throw new ArgumentNullException(nameof(values));
            }

            if (transform == null)
            {
                throw new ArgumentNullException(nameof(transform));
            }

            List<string> transformedValues = new List<string>();

            foreach (string value in values)
            {
                transformedValues.Add(transform(value));
            }

            return transformedValues;
        }

        public static List<TResult> ApplyTransform<T, TResult>(
            IList<T> values,
            TransformDelegate<T, TResult> transform)
        {
            if (values == null)
            {
                throw new ArgumentNullException(nameof(values));
            }

            if (transform == null)
            {
                throw new ArgumentNullException(nameof(transform));
            }

            List<TResult> transformedValues = new List<TResult>();

            foreach (T value in values)
            {
                transformedValues.Add(transform(value));
            }

            return transformedValues;
        }
    }
    #endregion
}
