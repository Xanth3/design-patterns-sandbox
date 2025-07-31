using Design.Patterns.Sandbox.Structural.Proxy;
using Xunit;

namespace Design.Patterns.Sandbox.Tests
{
    public class ProxyTests
    {
        [Fact]
        public void Proxy_Grants_Access_When_Allowed()
        {
            var realSubject = new RealSubject();
            var proxy = new Proxy(realSubject) { AccessGranted = true };
            Assert.Equal("RealSubject: Handling request.", proxy.Request());
        }

        [Fact]
        public void Proxy_Denies_Access_When_Not_Allowed()
        {
            var realSubject = new RealSubject();
            var proxy = new Proxy(realSubject) { AccessGranted = false };
            Assert.Equal("Proxy: Access denied.", proxy.Request());
        }
    }
}
