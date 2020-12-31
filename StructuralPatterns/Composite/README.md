# Intent
Composite is a structural design pattern that lets you compose objects into a tree structure and then work with the structure as if it's an individual object.

# Structure
![https://refactoring.guru/design-patterns/composite](./Structure.png)

Copyright: [Refactoring Guru](https://refactoring.guru/design-patterns/composite)

# Steps
1. Make sure that the core model of the app can be represented as a tree structure.
1. Declare the common interface implemented by the leaf class and the container class(non-leaf).
1. Create the leaf class.
1. Create the container class which contains an array of the **common interface**.
1. Define and implement the methods for adding and removing child elements in the container class.

# Notes 
* This design pattern is applicable to the scenario of tree structure.
* In this pattern, the container class hands over the major handling logic to the sub-node.