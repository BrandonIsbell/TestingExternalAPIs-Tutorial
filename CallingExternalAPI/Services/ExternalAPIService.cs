using CallingExternalAPI.Models;
using CallingExternalAPI.RefitApiInterfaces;
using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CallingExternalAPI.Services
{
    public class ExternalAPIService : IExternalAPIService
    {
        public async Task<Joke> GetJokeAsync()
        {
            try
            {
                var chuckNorrisApi = RestService.For<IChuckNorrisApi>("http://api.icndb.com");
                return await chuckNorrisApi.GetRandomJokeAsync();
            }
            catch
            {
                return new Joke { Type = "Failure", Value = new JokeContents { Id = -1, Joke = "Chuck Norris has counted to infinity. Twice." } };
            }
        }
    }
}
