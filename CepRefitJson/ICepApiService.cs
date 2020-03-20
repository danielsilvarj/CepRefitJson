using Refit;
using System.Threading.Tasks;

namespace CepRefitJson
{
    public interface ICepApiService
    {
        [Get("/ws/{cep}/json")]
        Task<CepResponse> GetAddressAsync(string cep);
    }
}
