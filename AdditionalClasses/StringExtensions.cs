using System;
using System.Text;
using System.Text.RegularExpressions;

namespace AdditionalClasses
{
    public static class StringExtensions
    {
        public static string InspectConverting(this string value, string fromSet, string toSet)
        {
            StringBuilder sb = new StringBuilder(value);
            if (fromSet.Length != toSet.Length)
            {
                throw new Exception("Length of both params must be the same!");
            }

            for (int i = 0; i < fromSet.Length; i++)
            {
                sb.Replace(fromSet[i], toSet[i]);
            }

            return sb.ToString();
        }

        public static string TrimEnd(this string input, string suffixToRemove)
        {
            if (input != null && suffixToRemove != null
              && input.EndsWith(suffixToRemove))
            {
                return input.Substring(0, input.Length - suffixToRemove.Length);
            }
            else return input;
        }

        public static int InspectTallying(this string value, string condition)
        {
            int count = 0;
            Regex reg = new Regex(@"^");
            if (condition.StartsWith("FOR CHARACTERS BEFORE"))
            {
                reg = new Regex(@"\w");
            }
            else if (condition.StartsWith("FOR ALL"))
            {
                string neededValue = condition.Replace("FOR ALL", "").Trim().Trim(new char[] { '\'' });
                reg = new Regex(neededValue);
            }
            MatchCollection matches = reg.Matches(value);
            count = matches.Count;
            return count;
        }
    }
}
