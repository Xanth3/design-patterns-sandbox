using Xunit;
using Design.Patterns.Sandbox.Behavioural.Observer;

namespace Design.Patterns.Sandbox.Tests
{
    public class ObserverTests
    {
        [Fact]
        public void Observer_Should_Receive_Message()
        {
            var subject = new ConcreteSubject();
            var observer = new ConcreteObserver();

            subject.Attach(observer);
            subject.Notify("Event A");

            Assert.Single(observer.ReceivedMessages);
            Assert.Contains("Event A", observer.ReceivedMessages);
        }

        [Fact]
        public void Detached_Observer_Should_Not_Receive_Message()
        {
            var subject = new ConcreteSubject();
            var observer = new ConcreteObserver();

            subject.Attach(observer);
            subject.Detach(observer);
            subject.Notify("Event B");

            Assert.Empty(observer.ReceivedMessages);
        }
    }
}
