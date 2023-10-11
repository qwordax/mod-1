using System;
using System.Collections.Generic;

namespace Generator.Utilities
{
    /// <summary>
    /// Represents a class of computing expectation.
    /// </summary>
    public static class Mean
    {
        public static Double Compute(List<UInt64> values)
        {
            Double result = 0.0;

            foreach (UInt64 value in values)
            {
                result += value;
            }

            return result / values.Count;
        }
    }
}
