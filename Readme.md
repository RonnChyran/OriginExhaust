OriginExhaust
=========
OriginExhaust is a simple .NET 4.5 library to create wrappers for Origin based off the Managed Origin implementation found in [Battlelogium](https://github.com/ron975/Battlelogium/commit/a691390822bb9358a1b23a5d718553fce5d81e7d) and some code from [SimpleGameRelauncher](https://github.com/ron975/HawkenExhaust/blob/master/HawkenExhaust/SimpleGameReLauncher.cs). It allows for Steam Overlay hooking to Origin games by automatically relaunching Origin before launching the game. 

Examples
---------
Included is an example for Titanfall. To create an OriginExhaust wrapper, one needs to find the Origin LaunchGame ID and the main executable name for a game. The LaunchGame ID can be found by logging the command line parameters sent to Origin when a game is launched.

Simply start a new instance of the `Exhaust` class by calling `new Exhaust(exeName, originId).Start();` Where exeName is the name of the main executable without the extension, and originId is the LaunchGame ID of the Origin game.

For example, the `Exhaust` instance for Titanfall looks like this
`new Exhaust("Titanfall", "1011172").Start();`

License
--------
Any parts of OriginExhaust that are present in Battlelogium are considered GPLv3 unless used as part of OriginExhaust, where it is considered licensed under LGPLv3.
