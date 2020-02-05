using System.Collections.Generic;
using System.Linq;

namespace System
{
    
    public static class RandomStringExtensions
    {
        public static string Read(this RandomString str)
        {
            if (!str._isRandomized)
            {
                str.randomize();
            }
            return new string(str._buff);
        }

        public static void UpdateFormat(this RandomString str, AlphanumericFormat format, bool included)
        {
            var has = str._positions.ContainsKey(format);
            if (included && !has)
                str._positions.Add(format, 0);
            if (!included && has)
                str._positions.Remove(format);
            str.handleSize();
        }

        public static void SetSpecialChars(this RandomString str, char[] specialChars)
        {
            var pattern = @"!@#$%^&*(),.?""'`:;\\\/{}|<>=\-+~_\[\]¬¦".ToCharArray();
            if(specialChars.Any(c => !pattern.Contains(c)))
                throw new Exception($"The special character array contains a non special character '{ string.Join(",", specialChars)}'");
            str._specialChars = specialChars;
        }

        public static void SetSize(this RandomString str, int size)
        {
            str._size = size;
            if (str._size < 1)
                throw new InvalidCastException($"The size of this string cannot be below 1");
            str.handleSize();
        }

        internal static void handleSize(this RandomString str)
        {
            if (str._minSize > str._size)
                throw new InvalidCastException($"minimum size of this string must be { str._minSize }");
        }

        private static void randomize(this RandomString str)
        {
            str._buff = new char[str._size];
            for (var iterate = 0; iterate < str._size; iterate++)
            {
                var i = str.RandomNumber(1, 100);
                str.rngChar((i <= 25 ? AlphanumericFormat.Numeric : i <= 55 ? AlphanumericFormat.Uppercase : i <= 85 ? AlphanumericFormat.Lowercase : AlphanumericFormat.NonAlphanumeric), iterate);
            }
            str.ensureAllChars();
            str._isRandomized = true;
        }


        private static void ensureAllChars(this RandomString str)
        {
            var length = str._positions.Count;
            for (var i = 0; i < length; i++)
            {
                var posKvp = str._positions.ElementAt(i);
                if (posKvp.Value == null)
                    str.rngChar(posKvp.Key, str.getUnusedPosition(posKvp.Key));
            }
        }

        private static void rngChar(this RandomString str, AlphanumericFormat format, int position)
        {
            var byteBuffer = 0;
            switch (format)
            {
                case AlphanumericFormat.Numeric:
                    byteBuffer = str.RandomNumber(0, 9);
                    break;
                case AlphanumericFormat.Lowercase:
                case AlphanumericFormat.Uppercase:
                    byteBuffer = str.RandomNumber(0, 26);
                    break;
                default:
                    byteBuffer = str.RandomNumber(0, str._specialChars.Length);
                    break;
            }

            str.generateChar(format, position, byteBuffer);
        }

        private static void generateChar(this RandomString str, AlphanumericFormat format, int position, int byteBuffer)
        {
            if (format != AlphanumericFormat.NonAlphanumeric)
                str._buff[position] = (char)(format + byteBuffer);

            else
                str._buff[position] = str._specialChars[byteBuffer];

            str._positions[format] = position;
        }

        private static int getUnusedPosition(this RandomString str, AlphanumericFormat format)
        {
            do
            {
                var i = str.RandomNumber(0, str._size);
                if (str.checkPositions(i))
                {
                    return i;
                }
            } while (true);
        }

        private static bool checkPositions(this RandomString str, int position)
        {
            return str._positions.All(p => p.Value != position);
        }
    }
    
}
