namespace Design.Patterns.Sandbox.Behavioural.ChainOfResponsibility
{
    public abstract class Handler
    {
        protected Handler? Next { get; private set; }

        public void SetNext(Handler next)
        {
            Next = next;
        }

        public abstract string Handle(string request);
    }
}
