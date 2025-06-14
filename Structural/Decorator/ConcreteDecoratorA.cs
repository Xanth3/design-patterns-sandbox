namespace Design.Patterns.Sandbox.Structural.Decorator
{
    public class ConcreteDecoratorA : Decorator
    {
        public ConcreteDecoratorA(IComponent component) : base(component) { }

        public override string Operation()
        {
            return $"DecoratorA({base.Operation()})";
        }
    }
}