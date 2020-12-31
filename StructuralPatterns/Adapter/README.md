# Intent
Adapter is a structural design pattern that allows objects with incompatible interfaces to collaborate.

# Structure
![https://refactoring.guru/design-patterns/singleton](./Structure.png)

Copyright: [Refactoring Guru](https://refactoring.guru/design-patterns/singleton)

# Notes 
* This pattern can be used to adapt the third-party or legacy libraries that cannot be easily to updated.
* In this sample, the adapter class inherits the "interface" `RoundPeg` and contains a reference to the `SquarePeg` instance.