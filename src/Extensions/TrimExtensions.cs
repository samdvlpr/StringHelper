
namespace System
{
    /// <summary>
    /// Trimming extensions for strings
    /// </summary>
    public static class TrimExtensions
    {
        /// <summary>
        /// Retrieves a string of text with the common text removed from the end until the first difference.
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

        /// <summary>
        /// Retrieves a string of text with the common text removed from the start until the first difference.
        /// </summary>
        /// <param name="value1">First string</param>
        /// <param name="value2">Second string</param>
        /// <param name="stringComparison">determines the string comparision options</param>
        /// <returns>The strings of text minus the common text between the two removed from the start.</returns>
        public static Tuple<string, string> TrimStartToDifference(this string value1, string value2, StringComparison? stringComparison = null)
        {
            var countFromStart = value1.CountStartToDifference(value2, stringComparison);

            return new Tuple<string, string>(value1.Substring(countFromStart, value1.Length - countFromStart), value2.Substring(countFromStart, value2.Length - countFromStart));
        }

        /// <summary>
        /// Retrieves a string of text with the common text removed from the start and end. Both side stopping on the first difference.
        /// </summary>
        /// <param name="value1">First string</param>
        /// <param name="value2">Second string</param>
        /// <param name="stringComparison">determines the string comparision options</param>
        /// <returns>The strings of text minus the common text between the two removed from the start and end.</returns>
        public static Tuple<string, string> TrimToDifference(this string value1, string value2, StringComparison? stringComparison = null)
        {
            if (value1 == value2) return new Tuple<string, string>("", "");
            
            var (Tvalue1, Tvalue2) = value1.TrimStartToDifference(value2, stringComparison);

            var (Tvalue3, Tvalue4) = Tvalue1.TrimEndToDifference(Tvalue2, stringComparison);

            return new Tuple<string, string>(Tvalue3, Tvalue4);
        }
    }
}
