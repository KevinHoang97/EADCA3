using Bunit;
using CA3;
using CA3.Pages;
using CA3.Shared;
using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Xunit;

namespace CA3Tests
{
    public class UnitTest1
    {
        [Fact]
        public void TopAnimeComponentDoesntRenderCorrectly()
        {
            // Arrange
            using var ctx = new TestContext();

            // Act
            var cut = ctx.RenderComponent<CA3.Pages.TopAnime>();

            cut.MarkupMatches("<p>Calling the API has run into a problem.</p> ");
        }


        [Fact]
        public void SeasonComponentDoesntRenderCorrectly()
        {
            // Arrange
            using var ctx = new TestContext();

            // Act
            var cut = ctx.RenderComponent<Season>();

            cut.MarkupMatches("<p>Calling the API has run into a problem.");
        }

        [Fact]
        public async Task TestParse()
        {
            var Http = new HttpClient();

            string teststring = "{\"mal_id\":5114,\"rank\": 1,\"title\":\"Fullmetal Alchemist: Brotherhood\",\"url\":\"https://myanimelist.net/anime/5114/Fullmetal_Alchemist__Brotherhood\",\"image_url\":\"https://cdn.myanimelist.net/images/anime/1223/96541.jpg?s=faffcb677a5eacd17bf761edd78bfb3f\",\"type\":\"TV\",\"episodes\":64,\"start_date\":\"Apr 2009\",\"end_date\":\"Jul 2010\",\"members\":2067763,\"score\":9.21}";
            Root test = JsonSerializer.Deserialize<Root>(teststring);
            Root test2;

            string uri = "https://api.jikan.moe/v3/top/anime/1/tv";

            test2 = await Http.GetJsonAsync<Root>(uri);

            await Task.Delay(2000);


            Assert.Equal(test.top[0].title, test2.top[0].title);
           

        }

        [Fact]
        public async Task TestParseFail()
        {
            var Http = new HttpClient();

            string teststring = "{\"mal_id\":5114,\"rank\": 1,\"title\":\"Fullmetal Alchemist: Brotherhood\",\"url\":\"https://myanimelist.net/anime/5114/Fullmetal_Alchemist__Brotherhood\",\"image_url\":\"https://cdn.myanimelist.net/images/anime/1223/96541.jpg?s=faffcb677a5eacd17bf761edd78bfb3f\",\"type\":\"TV\",\"episodes\":64,\"start_date\":\"Apr 2009\",\"end_date\":\"Jul 2010\",\"members\":2067763,\"score\":9.21}";
            Root test = JsonSerializer.Deserialize<Root>(teststring);
            Root test2;


            string uri = "https://api.jikan.moe/v3/top/anime/1/tv";

            test2 = await Http.GetJsonAsync<Root>(uri);

            await Task.Delay(2000);


            Assert.NotEqual(test.top[0].title, test2.top[0].title);

           
        }



    }
}