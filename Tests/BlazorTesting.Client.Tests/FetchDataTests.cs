using System;
using System.Linq;
using Blazorme;
using BlazorTesting.Client.Pages;
using BlazorTesting.Shared;
using NUnit.Framework;

namespace BlazorTesting.Client.Tests
{
    public class FetchDataTests
    {
        private readonly TestHost _host = new TestHost();

        [Test]
        public void FetchData_OnDataRetrieval_RendersCorrectValues()
        {
            var req = _host.AddMockHttp().Capture("");

            var component = _host.AddComponent<FetchData>();

            _host.WaitForNextRender(() => req.SetResult(new[]
            {
                new WeatherForecast {Summary = "First", TemperatureC = 30, Date = DateTime.Now.AddDays(1)},
                new WeatherForecast {Summary = "Second", TemperatureC = 28, Date = DateTime.Now.AddDays(2)},
            }));

            var forecasts = component.FindAll("tbody tr");
            
            Assert.That(forecasts.ElementAt(0).InnerText.Contains("First"));
            Assert.That(forecasts.ElementAt(1).InnerText.Contains("Second"));

        }
    }
}
