namespace MyCSharpExtensions
{
    public static class StringExtensions
    {
        /// <summary>
        /// Indicates whether a specific string is <see langword="null"/>, empty, or consists only of white-space characters.
        /// </summary>
        /// <returns>
        /// <see langword="true"/> if the <paramref name="value"/> is <see langword="null"/> or <see cref="System.String.Empty"/>, or if <paramref name="value"/> consists exclusively of white-space characters.
        /// </returns>
        public static bool IsNullOrWhiteSpace(this string value) => string.IsNullOrWhiteSpace(value);
    }
    public static class Int32Extensions { }
    public static class DoubleExtensions { }
    public static class ArrayExtensinos
    {
        /// <summary>
        /// Sorts the elements in an entire <see cref="Array"/> using the <see cref="IComparable"/> generic interface implementation of each element of the <see cref="Array"/>.
        /// </summary>
        public static void Sort<T>(this T[] array)
        {
            Array.Sort(array);
        }

        /// <summary>
        /// Sorts the elements in an <see cref="Array"/> using the specified <see cref="Comparer{T}"/>.
        /// </summary>
        /// <exception cref="ArgumentNullException"/>
        /// <exception cref="ArgumentException"/>
        public static void Sort<T>(this T[] array, Comparison<T> comparison)
        {
            Array.Sort(array, comparison);
        }
    }
    public static class EnumExtensions
    {
        public static string GetDescription<T>(this T @value)
            where T : struct, IConvertible
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

            for (int i = 0; i < count; i++)
            {
                list.Add(start);
                start += step;
            }

            return list;
        }
    }
}