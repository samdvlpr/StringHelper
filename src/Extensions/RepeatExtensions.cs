using System.Linq;

namespace System
{
    /// <summary>
    /// repeat string extensions class
    /// </summary>
    public static class RepeatExtensions
    {
        /// <summary>
        /// Repeats a given string for a given number of repetitions
        /// </summary>
        /// <param name="input">the string you wish to repeat</param>
        /// <param name="repetitions">the number of repetitions</param>
        /// <returns>the final repeated string</returns>
        public static string Repeat(this string input, int repetitions)
        {
            return string.Concat(Enumerable.Repeat(input, repetitions));
        }
    }
}
