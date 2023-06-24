using Microsoft.AspNetCore.Mvc.Testing;  // from: https://www.nuget.org/packages/Microsoft.AspNetCore.Mvc.Testing

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        private readonly WebApplicationFactory<WebApplication1.Pages.IndexModel> _factory;

        public UnitTest1()
        {
            _factory = new WebApplicationFactory<WebApplication1.Pages.IndexModel>();
        }

        [TestMethod]
        public async Task IndexPageReturnSuccessAndCorrectContentType()
        {
            // Arrange
            var client = _factory.CreateClient();

            // Act
            var response = await client.GetAsync("/");

            // Assert
            response.EnsureSuccessStatusCode(); // Status Code 200-299
            Assert.AreEqual("text/html; charset=utf-8", response.Content.Headers.ContentType?.ToString());
        }
    }
}