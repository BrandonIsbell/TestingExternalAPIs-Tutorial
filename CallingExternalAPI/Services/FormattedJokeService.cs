using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CallingExternalAPI.Services
{
    public class FormattedJokeService
    {
        private readonly IExternalAPIService _externalAPIService;

        public FormattedJokeService(IExternalAPIService externalAPIService)
        {
            _externalAPIService = externalAPIService;
        }
        public async Task<string> GetFormattedJokeAsync()
        {
            var joke = await _externalAPIService.GetJokeAsync();
            return joke.Value.Joke.Replace("&quot","\"");
        }
    }
}
