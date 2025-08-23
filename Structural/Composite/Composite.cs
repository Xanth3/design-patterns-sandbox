using System.Collections.Generic;
using System.Linq;

namespace Design.Patterns.Sandbox.Structural.Composite
{
    public class Composite : IComponent
    {
        private readonly List<IComponent> _children = new();
        public string Name { get; }
        public Composite(string name) => Name = name;
        public string Operation()
        {
            var childOps = _children.Select(c => c.Operation());
            return $"Composite: {Name} contains [{string.Join(", ", childOps)}]";
        }
        public void Add(IComponent component) => _children.Add(component);
        public void Remove(IComponent component) => _children.Remove(component);
        public IEnumerable<IComponent> GetChildren() => _children;
    }
}
