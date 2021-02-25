using System.Threading.Tasks;
using Blazorme;
using BlazorTesting.Client.Pages;
using NUnit.Framework;

namespace BlazorTesting.Client.Tests
{
    public class CounterTests
    {
        private readonly TestHost _host = new TestHost();

        [Test]
        public void CounterValue_OnInitialRender_IsZero()
        {
            var component = _host.AddComponent<Counter>();
            
            Assert.AreEqual("Current count: 0", component.Find("p").InnerText);
        }

        [TestCase(0)]
        [TestCase(2)]
        [TestCase(10)]
        public async Task CounterValue_OnButtonPress_IncrementsValueCorrectly(int timesClicked)
        {
            var component = _host.AddComponent<Counter>();
            
            for(var x = 0; x < timesClicked; x++)
                await component.Find("button").ClickAsync();
            
            Assert.AreEqual($"Current count: {timesClicked}", component.Find("p").InnerText);
        }
    }
}
