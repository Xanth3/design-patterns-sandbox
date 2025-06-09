using System.Collections.Generic;

namespace Design.Patterns.Sandbox.Behavioural.Observer
{
    public class ConcreteSubject : ISubject
    {
        private readonly List<IObserver> _observers = new();

        public void Attach(IObserver observer)
        {
            if (!_observers.Contains(observer))
                _observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void Notify(string message)
        {
            foreach (var observer in _observers)
            {
                observer.Update(message);
            }
        }
    }
}
