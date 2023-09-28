using System;
using System.Collections.Generic;

namespace Generator.Utilities
{
    /// <summary>
    /// Representing a class of computing the variation.
    /// </summary>
    public static class Variation
    {
        public static Double Compute(List<UInt64> values)
        {
            Double result = 0.0;

            Double expect = Expectation.Compute(values);

            foreach (UInt64 value in values)
            {
                result += (value - expect) * (value - expect);
            }

            return result / values.Count;
        }
    }
}
