using System;
using System.Collections.Generic;
using System.Text;

namespace System
{
    public class RandomString
    {
        public RandomString(int size = 20, AlphanumericFormat[] formats = null)
        {
            _size = size;
            if (formats != null)
                foreach (var alphanumericFormat in formats)
                {
                    _positions.Add(alphanumericFormat, null);
                }
            else
                _positions = new Dictionary<AlphanumericFormat, int?>()
                {
                    { AlphanumericFormat.NonAlphanumeric, null },
                    { AlphanumericFormat.Numeric, null },
                    { AlphanumericFormat.Uppercase, null },
                    { AlphanumericFormat.Lowercase, null }
                };
            this.handleSize();
        }

        internal bool _isRandomized;

        internal int _size;

        internal char[] _buff;

        internal readonly Dictionary<AlphanumericFormat, int?> _positions;

        internal int _minSize => _positions.Count;

        internal char[] _specialChars = "!@#$%^&*()_-+=[{]};:>|./?".ToCharArray();

        public static implicit operator string(RandomString str)
        {
            return str.Read();
        }

    }
}
