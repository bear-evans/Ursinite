using System.Collections.Generic;

namespace Ursinite
{
    public static class CollectionExtensions
    {
        #region List Extensions =============================================================================

        /// <summary> Checks if the item is already present in the list, and adds it if not. </summary>
        /// <returns> True if the item was successfully added, false if it was a duplicate. </returns>
        public static bool TryAddUnlessDuplicate<T>(this List<T> list, T item)
        {
            if (list.Contains(item)) {
                return false;
            }
            list.Add(item);
            return true;
        }

        /// <summary>
        /// Removes the specified item from the list if it exists.
        /// </summary>
        /// <remarks>If the item does not exist in the list, the method makes no changes and returns
        /// false.</remarks>
        /// <typeparam name="T">The type of elements contained in the list.</typeparam>
        /// <param name="list">A reference to the list from which the item will be removed.</param>
        /// <param name="item">The item to remove from the list.</param>
        /// <returns>true if the item was found and removed from the list; otherwise, false.</returns>
        public static bool TryRemoveIfExists<T>(this List<T> list, T item)
        {
            if (!list.Contains(item)) {
                return false;
            }
            _ = list.Remove(item);
            return true;
        }

        #endregion List Extensions =============================================================================
    }
}