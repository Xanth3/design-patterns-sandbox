namespace Design.Patterns.Sandbox.Structural.Proxy
{
    public class RealSubject : ISubject
    {
        public string Request()
        {
            return "RealSubject: Handling request.";
        }
    }
}
