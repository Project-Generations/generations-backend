using Microsoft.AspNetCore.Mvc.Testing;

namespace Generations.IntegrationTests
{
    public class TeamControllerTests : IClassFixture<WebApplicationFactory<Program>>
    {
        private readonly HttpClient _httpClient;

        public TeamControllerTests(WebApplicationFactory<Program> factory)
        {
            _httpClient = factory.CreateClient();
        }

        [Theory]
        [InlineData("/api/team")]
        [InlineData("/api/team/1")]
        public async Task GetAllTeamsTest(string url)
        {
            var response = await _httpClient.GetAsync(url);

            response.EnsureSuccessStatusCode();

            Assert.StartsWith("application/json",
                response?.Content?.Headers?.ContentType?.ToString());
        }

        /*[Theory]
        [InlineData("/api/team/delete/1")]
        public async Task DeleteTeam(string url)
        {
            var response = await _httpClient.GetAsync(url);

            response.EnsureSuccessStatusCode();

            Assert.True(response.IsSuccessStatusCode);
        }*/
    }
}