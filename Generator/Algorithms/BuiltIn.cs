using System;

namespace Generator.Algorithms
{
    /// <summary>
    /// Represents a built-in <see cref="Random"/> class.
    /// </summary>
    public class BuiltIn : IRandomable
    {
        private Random random = new Random();

        public BuiltIn() { }

        public UInt64 Next()
        {
            Byte[] bytes = new Byte[64];
            random.NextBytes(bytes);

            return BitConverter.ToUInt64(bytes);
        }
    }
}
