using System;

namespace Generator.Algorithms
{
    /// <summary>
    /// Defines a method to generate next <see cref="UInt64"/>.
    /// </summary>
    public interface IRandomable
    {
        UInt64 Next();
    }
}
