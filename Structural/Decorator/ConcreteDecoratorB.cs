namespace Design.Patterns.Sandbox.Structural.Decorator
{
    public class ConcreteDecoratorB : Decorator
    {
        public ConcreteDecoratorB(IComponent component) : base(component) { }

        public override string Operation()
        {
            return $"DecoratorB({base.Operation()})";
        }
    }
}