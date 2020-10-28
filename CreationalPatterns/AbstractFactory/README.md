# Intent
Abstract factory is a creational design pattern which creates **families** of related objects without specifying their concrete classes.

# Structure
![https://refactoring.guru/design-patterns/abstract-factory](./Structure.png)
Copyright: [Refactoring Guru](https://refactoring.guru/design-patterns/abstract-factory)

# Summary
1. Declare the interfaces for the products, one per product variant.
1. Implement the product interfaces in the concrete product classes.
1. Extract the common factory to an factory interface.
1. Declare the creation methods returning the product interfaces in the factory interface.
1. In the concrete factory classes, implement the creation methods.
1. Returning the interfaces decouples the client logic and the concrete products.