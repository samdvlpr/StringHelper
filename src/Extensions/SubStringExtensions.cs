
namespace System
{
    /// <summary>
    /// SubString extensions for strings
    /// </summary>
    public static class SubStringExtensions
    {
        /// <summary>
        /// Retrieves a string of the common text of two strings from end to begin until the first difference
        /// </summary>
        /// <param name="value1">First string</param>
        /// <param name="value2">Second string</param>
        /// <param name="stringComparison">determines the string comparision options</param>
        /// <returns>The common string of text until the first difference from the end.</returns>
        public static string SubStringEndToDifference(this string value1, string value2, StringComparison? stringComparison = null)
        {
            var countFromEnd = value1.CountEndToDifference(value2, stringComparison);

            return value1.Substring(value1.Length - countFromEnd);
        }

        /// <summary>
        /// Retrieves a string of the common test of two strings from start to end until the first difference
        /// </summary>
        /// <param name="value1">First string</param>
        /// <param name="value2">Second string</param>
        /// <param name="stringComparison">determines the string comparision options</param>
        /// <returns>The common string of text until the first difference from the start.</returns>
        public static string SubStringStartToDifference(this string value1, string value2, StringComparison? stringComparison = null)
        {
            var countFromStart = value1.CountStartToDifference(value2, stringComparison);

            return value1.Substring(0, countFromStart);
        }
    }
}
