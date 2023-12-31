﻿using System;

namespace Generator.Algorithms
{
    /// <summary>
    /// Represents a pseudo-random number generator based on
    /// the linear feedback shift register.
    /// </summary>
    public class LFSR : IRandomable
    {
        private UInt64 X { get; set; }

        public LFSR(UInt64 x)
        { 
            X = x;
        }

        public UInt64 Next()
        {
            UInt64 bit = X ^ (X >> 2) ^ (X >> 5) ^ (X >> 7) & 0x1;
            return X = (bit << 63) | (X >> 1);
        }
    }
}
