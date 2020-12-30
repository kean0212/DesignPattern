# Intent
Prototype is a creational design pattern lets you ensure that a class has only one instance, while providing a global access point to this instance.

# Structure
![https://refactoring.guru/design-patterns/singleton](./Structure.png)

Copyright: [Refactoring Guru](https://refactoring.guru/design-patterns/singleton)

# Notes 
* The class contains a **static** field referencing the single instance and **static** method producing the reference of the single instance.
* The constructor of the class should be private to avoid other ways of creating such an object.