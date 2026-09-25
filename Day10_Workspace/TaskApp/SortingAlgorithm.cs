using System;

namespace TaskApp
{
    #region SortingAlgorithm
    static class SortingAlgorithm<T> where T : IComparable<T>, ICloneable
    {
        public static void Sort(T[] items)
        {
            if (items == null)
            {
                throw new ArgumentNullException(nameof(items));
            }

            T[] workingItems = CloneItems(items);

            for (int i = 0; i < workingItems.Length - 1; i++)
            {
                for (int j = 0; j < workingItems.Length - 1 - i; j++)
                {
                    if (workingItems[j].CompareTo(workingItems[j + 1]) > 0)
                    {
                        GenericMethods.Swap(ref workingItems[j], ref workingItems[j + 1]);
                    }
                }
            }

            Array.Copy(workingItems, items, items.Length);
        }

        private static T[] CloneItems(T[] items)
        {
            T[] clonedItems = new T[items.Length];

            for (int i = 0; i < items.Length; i++)
            {
                clonedItems[i] = (T)items[i].Clone();
            }

            return clonedItems;
        }
    }
    #endregion
}
