using UnityEngine;

namespace Ursinite
{
    /// <summary>
    /// Provides static methods for performing arithmetic operations.
    /// </summary>
    /// <remarks>This class is intended to facilitate various arithmetic calculations and should be used as a
    /// utility for mathematical operations. It is designed to be stateless and thread-safe. The name helps to avoid clashes with other Math classes.</remarks>
    public static class Bearithmatic
    {
        #region Methods

        /// <summary>
        /// Calculates the zero-based index in a one-dimensional array that corresponds to the specified two-dimensional
        /// coordinates within a grid of given dimensions.
        /// </summary>
        /// <remarks>The method assumes that the provided coordinates are within the bounds defined by the
        /// dimensions. Supplying coordinates outside these bounds may result in an invalid index.</remarks>
        /// <param name="coords">The two-dimensional coordinates, represented as a <see cref="Vector2Int"/>, indicating the position within
        /// the grid.</param>
        /// <param name="dimensions">The dimensions of the grid, represented as a <see cref="Vector2Int"/>, where the x component is the width
        /// and the y component is the height.</param>
        /// <returns>The zero-based index in the one-dimensional array that corresponds to the specified coordinates.</returns>
        public static int GetIndexFromCoordinates(in Vector2Int coords, in Vector2Int dimensions)
        {
            return dimensions.x + (dimensions.y * dimensions.x);
        }

        /// <summary>
        /// Calculates the two-dimensional coordinates corresponding to a one-dimensional index within a grid of
        /// specified dimensions.
        /// </summary>
        /// <remarks>The method assumes a row-major order, where indices increase from left to right and
        /// then top to bottom. The index must be less than the total number of elements in the grid (dimensions.x *
        /// dimensions.y).</remarks>
        /// <param name="index">The zero-based index to convert to 2D coordinates. Must be within the bounds defined by the grid dimensions.</param>
        /// <param name="dimensions">The dimensions of the grid, where the x component represents the width and the y component represents the
        /// height.</param>
        /// <returns>A Vector2Int representing the (x, y) coordinates within the grid that correspond to the specified index.</returns>
        public static Vector2Int GetCoordinatesFromIndex(in int index, in Vector2Int dimensions)
        {
            return new Vector2Int(index % dimensions.x, index / dimensions.x);
        }

        #endregion Methods
    }
}