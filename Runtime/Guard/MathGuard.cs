using System;

namespace Ursinite
{
    public static partial class Guard
    {
        #region Math Methods =====================================================================================

        /// <summary>
        /// Validates that the provided value is not negative. If the value is negative, an <see cref="ArgumentException"/> is thrown.
        /// </summary>
        /// <param name="value">The integer value to validate.</param>
        public static void AgainstNegative(int value)
        {
            if (value < 0) {
                throw new ArgumentException($"Guard: Input value {value} is negative, which is not permitted.");
            }
        }

        #endregion Math Methods =====================================================================================
    }
}