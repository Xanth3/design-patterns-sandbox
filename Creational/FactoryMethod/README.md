# Factory Method Pattern

The Factory Method pattern defines an interface for creating an object, but lets subclasses alter the type of objects that will be created.

## Description

Useful when the exact type of object to create isn’t known until runtime or when the creation logic is shared but the result should vary.

## Usage

```csharp
Logistics logistics = new RoadLogistics();
Console.WriteLine(logistics.Deliver()); // Shipped by land (Truck)
