using System.Collections.Generic;

namespace System
{
    /// <summary>
    /// wrap string extensions methods class
    /// </summary>
    public static class WrapExtensions
    {
        /// <summary>
        /// wraps a given string at a given length into an ienumerable of chopped strings split on the last white space
        /// </summary>
        /// <param name="input">the string that you wish to chop</param>
        /// <param name="maxLength">the max length that you wish to chop at</param>
        /// <returns>an ienumerable of chopped strings</returns>
        public static IEnumerable<string> Wrap(this string input, int maxLength)
        {
            do
            {
                if (input.Length < maxLength)
                {
                    if(!string.IsNullOrEmpty(input))
                        yield return input;
                    break;
                }
                var trimmedString = input.Substring(0, maxLength);

                if (trimmedString.Length != 0)
                {
                    var requiredLength = Math.Min(trimmedString.Length, trimmedString.LastIndexOf(" ", StringComparison.Ordinal));
                    if(requiredLength > 0)
                        trimmedString = trimmedString.Substring(0, requiredLength);
                }

                input = input.Replace(trimmedString, "").Trim();

                if(!string.IsNullOrEmpty(trimmedString))
                    yield return trimmedString;

            } while (true);
        }
    }
}
