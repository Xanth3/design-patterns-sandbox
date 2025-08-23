using System.Collections.Generic;

namespace Design.Patterns.Sandbox.Structural.Composite
{
    public interface IComponent
    {
        string Operation();
        void Add(IComponent component);
        void Remove(IComponent component);
        IEnumerable<IComponent> GetChildren();
    }
}
