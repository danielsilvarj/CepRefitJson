using Refit;
using System;
using System.Threading.Tasks;

namespace CepRefitJson
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var cepClient = RestService.For<ICepApiService>("https://viacep.com.br");

            Console.WriteLine("Digite o Cep para Buscar");
            string meuCep = Console.ReadLine();

            Console.WriteLine("Consultando dados do Cep:" + meuCep);

            var address = await cepClient.GetAddressAsync(meuCep);

            Console.Write($"\nLogradouro:{address.Logradouro}\nBairro:{address.Bairro}" +
                $"\nEstado:{address.Uf}\nCódigo Ibge:{address.Ibge}");
            Console.ReadKey();
        }
    }
}
