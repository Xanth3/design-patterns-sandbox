using System.Collections.Generic;

namespace DesignPatterns.Sandbox.Behavioural.Observer
{
    public class ConcreteObserver : IObserver
    {
        public List<string> ReceivedMessages { get; } = new();

        public void Update(string message)
        {
            ReceivedMessages.Add(message);
        }
    }
}
