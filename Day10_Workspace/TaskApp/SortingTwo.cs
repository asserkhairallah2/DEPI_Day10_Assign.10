using System;

namespace TaskApp
{
    #region SortingTwo
    static class SortingTwo<T>
    {
        public static void Sort(T[] items, Func<T, T, bool> shouldSwap)
        {
            if (items == null)
            {
                throw new ArgumentNullException(nameof(items));
            }

            if (shouldSwap == null)
            {
                throw new ArgumentNullException(nameof(shouldSwap));
            }

            for (int i = 0; i < items.Length - 1; i++)
            {
                for (int j = 0; j < items.Length - 1 - i; j++)
                {
                    if (shouldSwap(items[j], items[j + 1]))
                    {
                        GenericMethods.Swap(ref items[j], ref items[j + 1]);
                    }
                }
            }
        }
    }
    #endregion
}
