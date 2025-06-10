namespace Design.Patterns.Sandbox.Structural.Adapter
{
    // The Adaptee contains some useful behavior, but its interface is incompatible with the client.
    public class Adaptee
    {
        public string GetSpecificRequest()
        {
            return "Specific request from Adaptee";
        }
    }
}