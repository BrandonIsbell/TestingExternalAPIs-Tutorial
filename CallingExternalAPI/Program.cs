using CallingExternalAPI.Services;
using System;
using System.Threading.Tasks;

namespace CallingExternalAPI
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var apiService = new ExternalAPIService();
            var formattedJokeService = new FormattedJokeService(apiService);
            Console.WriteLine(await formattedJokeService.GetFormattedJokeAsync());
        }
    }
}
