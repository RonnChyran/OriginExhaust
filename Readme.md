OriginExhaust
=========
OriginExhaust is a simple .NET 4.5 library used to create wrappers for Origin. It is based on the Managed Origin implementation found in [Battlelogium](https://github.com/ron975/Battlelogium/commit/a691390822bb9358a1b23a5d718553fce5d81e7d) and code from [SimpleGameRelauncher](https://github.com/ron975/HawkenExhaust/blob/master/HawkenExhaust/SimpleGameReLauncher.cs). OriginExhaust enables Steam Overlay hooking to Origin games by automatically relaunching Origin before starting the game. 

Examples
---------
OriginExhaust can be used for a game such as Titanfall. Find the Origin LaunchGame ID and the game's main executable name to create an OriginExhaust wrapper. The LaunchGame ID can be found by logging the command line parameters sent to Origin when a game is launched.

Simply start a new instance of the `Exhaust` class by calling `new Exhaust(exeName, originId).Start();` The exeName parameter is the name of the main executable without the extension, and originId is the LaunchGame ID of the Origin game.

Example: the `Exhaust` instance for Titanfall looks like
`new Exhaust("Titanfall", "1011172").Start();`

License
--------
Any parts of OriginExhaust that are present in Battlelogium are considered GPLv3 unless used as part of OriginExhaust, where it is considered licensed under LGPLv3.
