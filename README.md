# Ursinite Utilities
Custom addon library for Unity development.

## Installation

## Usage

## Features
Ursinite is a collection of utilities and extensions for Unity development.

### Extensions

Ursinite adds extension methods for pre-existing Unity and C# types.

#### Math Extensions
Extensions to integers, floats, Vectors, and other mathematical objects.
* `float.ToRadians`: Implements Unity's Mathf.Deg2Rad as a float extension.
* `Vector2.GetPointOnCircle`: Returns a Vector2 representing the point on a circle (centered on the calling Vector2) of the provided distance and angle.
#### Collection Extensions
Extensions to Lists, Dictionaries, and other collections.

* `List.TryAddUnlessDuplicate:` Adds an item to a list if it doesn't already exist, returning a boolean indicating success.

* `List.TryRemoveIfExists:` Removes an item from a list if it exists. Returns a boolean indicating success for conditional logic.

### Utilities
Ursinite also adds new classes and data objects to perform useful functions.

#### Static Helpers
These classes provide helper functions accessed through their type. They cannot (or at least should not) be instantiated.
* **FileHandler**: Provides rudimentary file system manipulation. Provides little error handling in its current state.
* **Guard:** A utility for managing and enforcing constraints on variables, simplifying the process of running common checks. 
  * Includes both methods that throw exceptions (Against___), ones that alter or coerce the value to fit the constraints (Enforce_____), or return a boolean back to the caller for specialized logic (Validate______).
* **Bearithmatic**: A class for more advanced or specific math functions. Currently has functions for converting between Vector2Int coordinates and an index of a flat array representing a grid of provided Vector2Int dimensions.
#### Instatiated Objects
These objects are instantiated to perform a function.
* **Pomodoro Timer:** A stopwatch-like object that can be created with a duration, started, stopped, and reset. `IsElapsed` returns true if the time has elapsed; useful for limiting looped async calls or coroutines based on actual time rather than number of loops.