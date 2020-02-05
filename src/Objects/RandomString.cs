using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace System
{
    public class RandomString
    {
        private RNGCryptoServiceProvider _rng = new RNGCryptoServiceProvider();

        internal int RandomNumber(int min, int max)
        {
            byte[] _buffer = new byte[4];
            _rng.GetBytes(_buffer);
            int rand;
            do
            {
                rand = BitConverter.ToInt32(_buffer, 0) & Int32.MaxValue;
            } while (rand >= max * (Int32.MaxValue / max));
            return rand % max;
        }

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
