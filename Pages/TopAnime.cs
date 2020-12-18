using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CA3.Shared;
using Microsoft.AspNetCore.Components;
namespace CA3.Pages
{
   
        public partial class TopAnime : ComponentBase
        {
            private Root Main;
            private string ErrorMessage;

            private async Task GetDataAsync()
            {
                try
                {

                    // var baseAddress = new Uri("https://api.jikan.moe/v3/");

                    //  using (var httpClient = new HttpClient { BaseAddress = baseAddress })
                    {

                        //    using (var response = await httpClient.GetAsync("top/anime/1/tv"))
                        //  {

                        //    string responseData = await response.Content.ReadAsStringAsync();
                        //  }

                        string uri = "https://api.jikan.moe/v3/top/anime/1/tv";
                        Main = await Http.GetJsonAsync<Root>(uri);
                        ErrorMessage = String.Empty;
                     
                    }
                }
                catch (Exception e)
                {
                    ErrorMessage = e.Message;
                }
            }

            protected override async Task OnInitializedAsync()
            {
                await GetDataAsync();
            }



        }
    }
    //var baseAddress = new Uri("https://api.jikan.moe/v3/");

    //using (var httpClient = new HttpClient { BaseAddress = baseAddress })
    //{

    //  using (var response = await httpClient.GetAsync("top/{type}/{page}/{subtype}"))
    //{

    //  string responseData = await response.Content.ReadAsStringAsync();
    //}
    //}

