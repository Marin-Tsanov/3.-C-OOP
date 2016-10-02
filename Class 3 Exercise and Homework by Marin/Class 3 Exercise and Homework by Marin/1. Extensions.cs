using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Class_3_Exercise_and_Homework_by_Marin
{
    public static class Extensions
    {
        public static int WordCount(this string str)
        {
            return str.Split(new char[] { ' ', '.', '?' },
            StringSplitOptions.RemoveEmptyEntries).Length;
        }

        public static void IncreaseWidth(this IList<int> list, int amout)
        {
            for (int i = 0; i < list.Count; i++)
            {
                list[i] += amout;
            }
        }

        public static string ToString<T>(this IEnumerable<T> enumeration)
        {
            var result = new StringBuilder();
            result.Append("[ ");
            foreach (var item in enumeration)
            {
                result.Append(item);
                result.Append(" ");
            }
            result.Append("]");
            return result.ToString();
        }

        public static int WordOccurences(this string input, string word)
        {
            var count = Regex.Matches(input, "\\b" + word + "\\b", RegexOptions.IgnoreCase).Count;
            return count;
        }
    }
}
