using System.Collections.Generic;

namespace Design.Patterns.Sandbox.Structural.Composite
{
    public class Leaf : IComponent
    {
        public string Name { get; }
        public Leaf(string name) => Name = name;
        public string Operation() => $"Leaf: {Name}";
        public void Add(IComponent component) { }
        public void Remove(IComponent component) { }
        public IEnumerable<IComponent> GetChildren() => new List<IComponent>();
    }
}
