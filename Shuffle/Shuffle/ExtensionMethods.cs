using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shuffle
{
    public static class ExtensionMethods
    {
        public static IOrderedEnumerable<T> Shuffle<T>(this IEnumerable<T> items)
        {
            return items.OrderBy(e => Guid.NewGuid());
        }
    }
}
