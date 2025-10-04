namespace Design.Patterns.Sandbox.Behavioural.ChainOfResponsibility
{
    public class ConcreteHandlerA : Handler
    {
        public override string Handle(string request)
        {
            if (request == "A")
                return "Handled by A";
            return Next?.Handle(request) ?? "Not handled";
        }
    }
}
