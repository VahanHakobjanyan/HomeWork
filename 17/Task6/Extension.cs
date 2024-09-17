using System;
using System.Collections.Generic;

namespace Task6
{
    public static class CustomExtension
    {
        public static IEnumerable<T> CustomWhere<T>(this IEnumerable<T> source, Func<T, bool> predicate)
        {
            if (source == null) throw new ArgumentNullException("source is null here");
            if (predicate == null) throw new ArgumentNullException("predicate is null here");

            foreach (var item in source)
            {
                if (predicate(item))
                {
                    yield return item;
                }
            }
        }
    }
}
