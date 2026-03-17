using System;

namespace Ursinite
{
    public static partial class Guard
    {
        #region Null =====================================================================================

        /// <summary>
        /// Throws an exception if the provided object is null or equivalent to null.
        /// </summary>
        public static void ThrowIfNull<T>(T item)
        {
            if (item == null) {
                throw new ArgumentNullException("Guard: Recieved null argument, which is not permitted. Check call stack for details.");
            }
        }

        #endregion Null =====================================================================================

        #region Math Methods =====================================================================================

        /// <summary>
        /// Throws an exception if the specified value is greater than zero.
        /// </summary>
        public static void ThrowIfGreaterThanZero(int input)
        {
            if (input > 0) {
                throw new ArgumentOutOfRangeException("GUARD: Argument is greater than zero, which is not permitted. Check call stack for details.");
            }
        }

        /// <summary>
        /// Throws an exception if the specified value is greater than zero.
        /// </summary>
        public static void ThrowIfGreaterThanZero(float input)
        {
            if (input > 0) {
                throw new ArgumentOutOfRangeException("GUARD: Argument is greater than zero, which is not permitted. Check call stack for details.");
            }
        }

        /// <summary>
        /// Throws an exception if the specified value is less than than zero.
        /// </summary>
        public static void ThrowIfLessThanZero(int input)
        {
            if (input < 0) {
                throw new ArgumentOutOfRangeException("GUARD: Argument is less than zero, which is not permitted. Check call stack for details.");
            }
        }

        /// <summary>
        /// Throws an exception if the specified value is less than than zero.
        /// </summary>
        public static void ThrowIfLessThanZero(float input)
        {
            if (input < 0) {
                throw new ArgumentOutOfRangeException("GUARD: Argument is less than zero, which is not permitted. Check call stack for details.");
            }
        }

        #endregion Math Methods =====================================================================================
    }
}