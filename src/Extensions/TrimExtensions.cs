
namespace System
{
    /// <summary>
    /// Trimming extensions for strings
    /// </summary>
    public static class TrimExtensions
    {
        /// <summary>
        /// Retrieves a string of text with the common text removed from the end.
        /// </summary>
        /// <param name="value1">First string</param>
        /// <param name="value2">Second string</param>
        /// <param name="stringComparison">determines the string comparision options</param>
        /// <returns>The strings of text minus the common text between the two removed from the end.</returns>
        public static Tuple<string, string> TrimEndToDifference(this string value1, string value2, StringComparison? stringComparison = null)
        {
            var countFromEnd = value1.CountEndToDifference(value2, stringComparison);

            return new Tuple<string, string>(value1.Substring(0, value1.Length - countFromEnd), value2.Substring(0, value2.Length - countFromEnd));
        }
    }
}
