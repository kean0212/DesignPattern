# Intent
Flyweight is a structural design pattern that lets you fit more objects into the available amount of RAM by sharing **common** parts of state between multiple objects instead of keeping all of the data in each object.

# Structure
![https://refactoring.guru/design-patterns/flyweight](./Structure.png)

Copyright: [Refactoring Guru](https://refactoring.guru/design-patterns/flyweight)

# Notes
* Intrinsic state: the fields that contain unchanging data duplicated across many objects.
* Extrinsic state: the fields that contain data unique to each object.
* This design patter applies when a large volume data sharing the same intrinsic data.
* The class containing intrinsic fields should be **immutable** as it should be context-agnostic.
* Factory pattern can be used to create flyweight objects. Return the reference if it's in the cache. Otherwise, create one, put it in the cache, and return it.