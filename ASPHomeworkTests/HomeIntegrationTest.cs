using System.Net.Http;
using ASPHomework;
using ASPHomework.Persistence;
using ASPHomework.Views.Shared.Helpers;
using ASPHomeworkTests.WebApplicationFactory;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.VisualBasic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ASPHomeworkTests
{
    [TestClass]
    public class HomeIntegrationTest
    {
        private HttpClient _client;

        [TestInitialize]
        public void Init()
        {
            TestsWebApplicationFactory<Startup> factory = new TestsWebApplicationFactory<Startup>();
            _client = factory.CreateClient(new WebApplicationFactoryClientOptions
            {
                AllowAutoRedirect = false
            });
        }
        
        
        [TestMethod]
        public void TestIndex()
        {
            var response = _client.GetAsync("/").Result;
            response.EnsureSuccessStatusCode();

            var body = response.Content.ReadAsStringAsync().Result;

            foreach (var destination in TestDataGenerator.GetDestinations())
            {
                Assert.IsTrue(body.Contains(destination.Title));
                Assert.IsTrue(body.Contains(destination.Description.Truncate(200)));
            }
        }
    }
}