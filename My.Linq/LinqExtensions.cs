using System;
using System.Collections.Generic;

namespace My.Linq
{
    public static class LinqExtensions
    {
        public static IEnumerable<T> Where<T>(this IEnumerable<T> list, Func<T, bool> filter)
        {
            foreach (var item in list)
            {
                if (filter(item))
                    yield return item;
            }
        }

        public static bool Any<T>(this IEnumerable<T> list)
        {
            foreach (var _ in list)
                return true;
            return false;
        }

        public static bool Any<T>(this IEnumerable<T> list, Func<T, bool> filter)
        {
            foreach (var item in list)
            {
                if (filter(item))
                    return true;
            }

            return false;
        }
    }
}
