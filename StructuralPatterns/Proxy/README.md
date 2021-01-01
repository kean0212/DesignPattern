# Intent
Proxy is a structural design patter that lets you provide a substitute or placeholder for another object. A proxy controls access to the original object, allowing you to perform something either before or after the request gets through to the original object.

# Structure
![https://refactoring.guru/design-patterns/proxy](./Structure.png)

Copyright: [Refactoring Guru](https://refactoring.guru/design-patterns/proxy)

# Notes 
* Both the proxy and the service implements the interface minimizing the change required on client side.
* One way to adapt this pattern is extracting a common interface. If it's not feasible, create a proxy class inheriting from the service class.
* This pattern can be used for lazy initialization for resource-consuming services. Delay the initialization only when it's really needed.
* Access control on the service by adding some authZ logic in the proxy before invoking the service.
* Other applicabilities include: local execution of a remote service (handlingall the nasty details), logging requests, caching request results, and smart reference (the proxy plays an proactive role on determining if the service is still needed or not).
* The difference between **decorator** and **proxy** is that proxy managing the lifecyle of the service while the client controls it in decorator pattern.