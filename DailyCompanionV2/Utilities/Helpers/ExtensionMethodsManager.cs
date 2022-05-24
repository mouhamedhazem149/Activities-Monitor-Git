using System;
using System.Collections.Generic;

namespace DailyCompanionV2.Utilities
{
    public static partial class HM_Manager
    {
        public static bool IsBetween(this DateTime? dt, DateTime from, DateTime to) => dt.HasValue && dt.Value >= from && dt.Value <= to;
        public static bool IsBetween(this DateTime dt, DateTime from, DateTime to) => dt >= from && dt <= to;
        public static int SafeCount<T>(this IList<T> list) => list == null ? 0 : list.Count;
        public static int SafeCount<T>(this ICollection<T> collection) => collection == null ? 0 : collection.Count;
    }
}
