# Intent
Prototype is a creational design pattern lets you **copy** existing objects without making your code dependent on their classes, meaning that I don't need to know the implementation of the class.

# Structure
![https://refactoring.guru/design-patterns/builder](./Structure.png)

Copyright: [Refactoring Guru](https://refactoring.guru/design-patterns/prototype)

# Notes 
* The base class should have an abstract method named **Clone()**
* The classes should have a constructor taking an ojbect of the class as a source.
* The constructors of the subclasses should invoke the corresponding constructor of the base class to handle the cloning of the private fields of the base class.
* This pattern prevents the developer from knowing the implementation of the class to be cloned in a good way.
* This pattern can be used to generate clones of a pre-configured complex object. For example, it can be very useful in testing scenarios.