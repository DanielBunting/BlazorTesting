using Blazorme;
using NUnit.Framework;

namespace BlazorTesting.Client.Tests
{
    public class Tests
    {
        private readonly TestHost _host = new TestHost();

        [Test]
        public void WhenLoaded_HeaderOneElement_ShouldShowHelloWorld()
        {
            var component = _host.AddComponent<Pages.Index>();

            Assert.AreEqual("Hello, world!", component.Find("h1").InnerText);
        }
    }
}