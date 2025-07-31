namespace Design.Patterns.Sandbox.Structural.Proxy
{
    public class Proxy : ISubject
    {
        private readonly RealSubject _realSubject;
        public bool AccessGranted { get; set; } = true;

        public Proxy(RealSubject realSubject)
        {
            _realSubject = realSubject;
        }

        public string Request()
        {
            if (!AccessGranted)
                return "Proxy: Access denied.";
            
            return _realSubject.Request();
        }
    }
}
