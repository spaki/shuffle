using System;
using System.Collections.Generic;
using System.Linq;

namespace Shuffle
{
    public static class ExtensionMethods
    {
        public static IOrderedEnumerable<T> Shuffle<T>(this IEnumerable<T> items) => items.OrderBy(e => Guid.NewGuid());
    }
}
