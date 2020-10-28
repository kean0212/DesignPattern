# Intent
Factory method is a creational pattern which provides an interface of creating objects in superclass, but allows the subclasses to alter the type of the objects through overriding.

# Sample structure
![Sample](./Structure.png)

Copyright: [Refactoring Guru](https://refactoring.guru/design-patterns/factory-method)

# Code structure
                   Dialog (IButton created, Render() implmeneted)
                    /   \
                   /     \
                  /       \
            HtmlDialog    WindowsDialog
           (HtmlButton)  (WindowsButton)

# Summary
1. The products should have the same base class or implement the same interface.
1. The factory method resides in the superclass.
1. The return type of the facotry method should be the base or interface.
1. The subclasses should override the factory method by returning the corresponding object with the same method signature. 
1. The outside methods can manipulate the objects through the methods in the superclass while the actual type of the object is the one specified in subclass.