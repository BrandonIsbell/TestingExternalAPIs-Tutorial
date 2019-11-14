using CallingExternalAPI.Models;
using CallingExternalAPI.Services;
using Moq;
using NUnit.Framework;
using System.Threading.Tasks;

namespace CallingExternalAPI.Test
{
    public class FormattedJokeServiceTest
    {
        private Mock<IExternalAPIService> mockExternalApiService;
        private Joke jokeWithQuotes;

        [SetUp]
        public void Setup()
        {
            mockExternalApiService = new Mock<IExternalAPIService>();
            jokeWithQuotes = new Joke { Value = new JokeContents { Joke = "&quotThis is a test&quot" } };
        }

        [Test]
        public async Task GetFormattedJokeFixesQuotes()
        {
            mockExternalApiService.Setup(eas => eas.GetJokeAsync()).ReturnsAsync(jokeWithQuotes);
            var formattedJokeService = new FormattedJokeService(mockExternalApiService.Object);

            var expected = "\"This is a test\"";
            var actual = await formattedJokeService.GetFormattedJokeAsync();

            Assert.AreEqual(expected, actual);
        }
    }
}