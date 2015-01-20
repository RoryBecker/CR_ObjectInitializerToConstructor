'Object Initializer To Constructor' for CodeRush
===
 
This Refactoring / CodeProvider combination provide the user with the ability to convert an Object Initializer into a constructor call

The refactoring will perform the following conversion:

ie from...

    var myBox = new Box() {Height = 22, Width = 44, Depth = 88}

..into..

    var myBox = new Box(22, 44, 88)

The CodeProvider will additionally create the required constructor.

Usage 
======

Place your caret on any part of the right hand expression...

    new Box() {Height = 22, Width = 44, Depth = 88}

...and select either "**Create (and convert initializer to) Constructor Call**" or "**Convert Initializer to Constructor Call**" as appropriate
