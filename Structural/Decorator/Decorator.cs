namespace Design.Patterns.Sandbox.Structural.Decorator
{
    public abstract class Decorator : IComponent
    {
        protected readonly IComponent _component;

        protected Decorator(IComponent component)
        {
            _component = component;
        }

        public virtual string Operation() => _component.Operation();
    }
}