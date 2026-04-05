# Changelog

All notable changes to this project will be documented in this file.

The format is based on [Keep a Changelog](https://keepachangelog.com/en/1.1.0/),
and this project adheres to [Semantic Versioning](https://semver.org/spec/v2.0.0.html).

## [0.1.1] - 2026-03-16

### Added

- Added Bearithmatic for math functions.
	- Added *GetIndexFromCoordinates()* and *GetCoordinatesFromIndex()* for converting between 2D coordinates and 1D arrays to assist with gridded data.
- Added CollectionExtensions for extension methods on collections, currently only Lists.
	- Added *TryAddUnlessDuplicate()* and *TryRemoveIfExists()* for safely adding or removing items from Lists or branching logic depending on if it exists already.
- Guard class now contains an array of *ThrowIf________* for various number conditions. These are subject to change as I code and determine new ways to handle these common checks.



### Changed

- Changed the name to Ursinite. The namespace is now simply *Ursinite* instead of *TheBearDev.Ursinity*. I suspect namespace collisions will not be a problem.
- Editor and Runtime assemblies have been made to differentiate editor-only and runtime code.
	- The editor assembly is under the namespace *Ursinite.Editor*.

## [0.1.0] - 2024-06-10

### Added

- Initial release.
