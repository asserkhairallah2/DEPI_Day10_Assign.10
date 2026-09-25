using System;

namespace TaskApp
{
    #region GenericMethods
    static class GenericMethods
    {
        public static void Swap<T>(ref T first, ref T second)
        {
            T temporary = first;
            first = second;
            second = temporary;
        }

        public static T GetDefault<T>()
        {
            return default(T);
        }
    }
    #endregion
}
