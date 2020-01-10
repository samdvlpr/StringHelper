
namespace System
{
    /// <summary>
    /// Count extensions for strings
    /// </summary>
    public static class CountExtensions
    {
        /// <summary>
        /// Determines the common length of two strings from end to begin until the first difference
        /// </summary>
        /// <param name="value1">First string</param>
        /// <param name="value2">Second string</param>
        /// <param name="stringComparison">determines the string comparision options</param>
        /// <returns>The number of characters common from the end</returns>
        public static int CountEndToDifference(this string value1, string value2, StringComparison? stringComparison = null)
        {
            // Performance analysis: https://neil.fraser.name/news/2007/10/09/
            var value1_len = value1.Length;
            var value2_len = value2.Length;
            var n = Math.Min(value1_len, value2_len);
            for (var i = 1; i <= n; i++)
            {

                if ((stringComparison == null ? (value1[value1_len - i] != value2[value2_len - i]) : (!string.Equals(value1[value1_len - i].ToString(), value2[value2_len - i].ToString(), (StringComparison)stringComparison))))
                {
                    return i - 1;
                }
            }
            return n;
        }


        /// <summary>
        /// Determines the common length of two strings from start to end until the first difference
        /// </summary>
        /// <param name="value1">First string</param>
        /// <param name="value2">Second string</param>
        /// <param name="stringComparison">determines the string comparision options</param>
        /// <returns>The number of characters common from the start</returns>
        public static int CountStartToDifference(this string value1, string value2, StringComparison? stringComparison = null)
        {
            // Performance analysis: https://neil.fraser.name/news/2007/10/09/
            var n = Math.Min(value1.Length, value2.Length);
            for (var i = 0; i < n; i++)
            {
                if ((stringComparison == null ? (value1[i] != value2[i]) : (!string.Equals(value1[i].ToString(), value2[i].ToString(), (StringComparison)stringComparison))))
                {
                    return i;
                }
            }
            return n;
        }
    }
}
