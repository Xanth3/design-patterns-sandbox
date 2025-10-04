namespace Design.Patterns.Sandbox.Behavioural.ChainOfResponsibility
{
    public class ConcreteHandlerB : Handler
    {
        public override string Handle(string request)
        {
            if (request == "B")
                return "Handled by B";
            return Next?.Handle(request) ?? "Not handled";
        }
    }
}
