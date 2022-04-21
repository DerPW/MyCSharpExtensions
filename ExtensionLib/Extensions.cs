using System;
using System.Collections.Generic;

namespace MyCSharpExtensions
{
    public static class StringExtensions
    {
        public static bool IsNullOrWhiteSpace(this string @string) => string.IsNullOrWhiteSpace(@string);
    }
    public static class Int32Extensions { }
    public static class DoubleExtensions { }
    public static class ArrayExtensinos { }
    public static class EnumExtensions
    {
        public static string GetDescription<T>(this T @value) where T : struct, System.IConvertible
        {
            var type = typeof(T);
            var memInfo = type.GetMember(@value.ToString());
            if (memInfo.Length > 0)
            {
                var attributes = memInfo[0].GetCustomAttributes(typeof(System.ComponentModel.DescriptionAttribute), false);
                if (attributes.Length > 0)
                {
                    return ((System.ComponentModel.DescriptionAttribute)attributes[0]).Description;
                }
            }
            return @value.ToString();
        }
    }
    public static class EnumerableExtensions
    {
        public static IEnumerable<int> Range(int start, int count, int step)
        {
            var list = new List<int>();

            for (int i = start; i < count; i += step)
            {
                list.Add(i);
            }

            return list;
        }
    }
}