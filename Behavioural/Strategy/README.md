# Strategy Pattern

The Strategy pattern defines a family of algorithms, encapsulates each one, and makes them interchangeable.

## Description

Useful when you want to define a class behaviour or its algorithm independently from clients that use it.

## Usage

```csharp
var context = new CompressionContext(new ZipCompression());
Console.WriteLine(context.CompressData("myfile"));
