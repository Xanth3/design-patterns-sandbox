namespace Design.Patterns.Sandbox.Behavioural.Command
{
    public class Receiver
    {
        public string ActionPerformed { get; private set; } = string.Empty;

        public void Action()
        {
            ActionPerformed = "Action has been performed";
        }
    }
}
