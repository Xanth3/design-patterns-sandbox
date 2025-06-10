namespace Design.Patterns.Sandbox.Structural.Adapter
{
    // The Adapter makes the Adaptee's interface compatible with the Target's interface.
    public class Adapter : ITarget
    {
        private readonly Adaptee _adaptee;

        public Adapter(Adaptee adaptee)
        {
            _adaptee = adaptee;
        }

        public string GetRequest()
        {
            // Adapt the Adaptee's method to the Target's interface
            return _adaptee.GetSpecificRequest();
        }
    }
}