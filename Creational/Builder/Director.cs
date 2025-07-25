namespace Design.Patterns.Sandbox.Creational.Builder
{
    public class Director
    {
        public void Construct(IBuilder builder)
        {
            builder.Reset();
            builder.SetPartA("Alpha");
            builder.SetPartB(42);
        }
    }
}
