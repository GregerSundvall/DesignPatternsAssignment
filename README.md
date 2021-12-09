# GamePatternsAssignment


Greger Sundvall

Not really a game but rather just a scene with a few features. 
For different reasons I ended up making a simple scene and then try to come up with features that make use of every juicy piece of patters etc in the course. I'm pretty sure I understand the theory behind everything but I found it very hard to artificially come up with real world implementations from the kinda dry descriptions/examples available everywhere. Maybe I had been better off taking an existing project and modifying it... Anyway here's what I intentionally and non-intentionally came up with;


Rain.cs has an object pool for raindrops.

When creating the flower sprites in Flowers.cs I instantiate a prefab without a sprite and then I assign
the same sprite to all of them. Flyweight..?

Singleton based inventory class in Resources.cs.

I have some methods that call methods in other classes that sets values in the other classes. This seems kinda "facadish" or somehing..? Also even though it's kinda nice to "use" it I guess it can be overcomplicating stuff a bit too... Input is welcome.

Unity is using serialization (and deserialization) in a bunch of places like the stuff in the inspector but I have not used it "manually" anywhere.

I have tried my best to do everything with separation of concerns in mind. Which also brings us to;
My code does not have a lot of inheritance, it's just that most classes inherit from Monobehaviour which means they ARE a Monobehaviour. (I'm sure there's a plethora of inheritance in the underlying unity/c# code though.)
Instead I used mostly composition, where classes HAVE instances of other classes.

I think I always only have a single source of truth (in this project...). Values are stored in one place only, and not in several places that (hopefully) gets updated.

Peace
