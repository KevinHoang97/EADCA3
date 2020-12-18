using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CA3.Shared;
using Microsoft.AspNetCore.Components;
namespace CA3.Pages
{
    public partial class Season : ComponentBase
    {
        private Root Mains;
        private string ErrorMessage;
        private string type = "anime";
        private int genreId = 1;
        private int page = 1;
        private async Task GetDataAsync()
        {
            try
            {

                {

                    string uri = "https://api.jikan.moe/v3/genre/" + type + "/" + genreId + "/" + page; //anime/1/1
                    // string uri = "https://api.jikan.moe/v3/genre/anime/1/1";


                    // string uri = "https://api.jikan.moe/v3/schedule/" + day;
                    //  string uri = "https://api.jikan.moe/v3/schedule/monday";
                    // string uri = "https://api.jikan.moe/v3/season/" + year + "/" + season; 
                    Mains = await Http.GetJsonAsync<Root>(uri);
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
