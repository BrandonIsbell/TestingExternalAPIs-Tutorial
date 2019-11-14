using Refit;
using CallingExternalAPI.Models;
using System.Threading.Tasks;

namespace CallingExternalAPI.RefitApiInterfaces
{
    public interface IChuckNorrisApi
    {
        [Get("/jokes/random/")]
        Task<Joke> GetRandomJokeAsync();
    }
}
