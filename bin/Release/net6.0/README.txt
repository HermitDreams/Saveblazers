SAVEBLAZERS FIRST RELEASE

Currently takes cleansave2.txt, randomizes the starting perk, and then turns it into tempsave2.

Copy contents of the zip to your Caveblazers savefile (should be in Appdata\Local\Caveblazers), make sure you have your save2 and stat2 backed up, then rename tempsave2 to save2. You might see three lines of debug pop up very briefly. This means it worked! Probably.

Oh and make sure you have Steam Cloud Save turned off.

Okay that's all it does right now. No fancy UI, no toggling everything willy-nilly.
This is the first time I've told VS to build me a release so lemme know what goes wrong.


CONTENTS

= jsons, pdb, and dll =

Boilerplate stuff VS Studio put in when building the EXE. It won't run without them!

= cleansave2.txt =

A premade save file that has gone through the tutorial, into the caves, and quit out. The exe uses this as the base when changing your perk.

= tempsave2.sav =

The exe will spit this out as the result of cleansave2.txt being given a random perk. This needs the "temp" removed in order for the game to use it. You won't have to do the tutorial, but you won't get a random outfit and the guy asking you to kill slimes will harass you.

= Saveblazers.exe =

Double-click this. It's safe. Bit dirty though.

= Saveblazers.ico =

I just wanted to give the exe a nice look that's all