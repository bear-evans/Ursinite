using System;

namespace Ursinite
{
    /// <summary>
    /// An object that contains multiple values with varying probabilities.
    /// </summary>
    public class ProbabilisticValue<T>
    {
        private T[] values;
        private float[] probabilities;
    }
}