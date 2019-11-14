using System.Threading.Tasks;
using CallingExternalAPI.Models;

namespace CallingExternalAPI.Services
{
    public interface IExternalAPIService
    {
        Task<Joke> GetJokeAsync();
    }
}