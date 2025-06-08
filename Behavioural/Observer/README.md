# Observer Pattern

The Observer pattern defines a one-to-many dependency between objects so that when one object changes state, all its dependents are notified and updated automatically.

## Description

Useful for implementing distributed event handling systems, such as UI listeners, logging hooks, or message broadcasting.

## Usage

```csharp
var subject = new ConcreteSubject();
var observer1 = new ConcreteObserver();
subject.Attach(observer1);

subject.Notify("Hello observers!");
