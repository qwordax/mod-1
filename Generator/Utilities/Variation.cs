using System;
using System.Collections.Generic;

namespace Generator.Utilities
{
    /// <summary>
    /// Represents a class of computing variation.
    /// </summary>
    public static class Variation
    {
        public static Double Compute(List<UInt64> values)
        {
            Double result = 0.0;

            Double mean = Mean.Compute(values);

            foreach (UInt64 value in values)
            {
                result += (value - mean) * (value - mean);
            }

            return result / values.Count;
        }
    }
}
