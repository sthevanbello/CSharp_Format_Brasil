using Caelum.Stella.CSharp.Http;
using Newtonsoft.Json;
using System;
using System.Diagnostics;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace CEP
{
    class Program
    {
        static void Main(string[] args)
        {
            string cep = "07084182";
            string cep2 = "01001000";

            //var endereco = GetEndereco(cep);

            Endereco endereco = GetEndereco(cep).Result;
            var endereco2 = GetEndereco(cep2).Result;

            Debug.WriteLine(endereco);
            Console.WriteLine(endereco);
            Console.WriteLine(endereco2);


            #region Com Biblioteca Caelum

            // Usando o ViaCEP com o pacote Caelum.Stella.CSharp
            ServicePointManager.Expect100Continue = true; 
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            ViaCEP viaCEP = new ViaCEP();

            string enderecoJson = viaCEP.GetEnderecoJson(cep);
            Debug.WriteLine(enderecoJson);
            Console.WriteLine(enderecoJson);

            // Com método Async
            string enderecoJson2 = viaCEP.GetEnderecoJsonAsync(cep2).Result;
            Debug.WriteLine(enderecoJson2);
            Console.WriteLine(enderecoJson2);
            #endregion

            #region Com biblioteca Caelum dentro de um método

            // Utilizando o ViaCEP Caelum em um método
            Endereco enderecoCaelum = GetEnderecoCaelumAsync(cep).Result;
            Console.WriteLine(enderecoCaelum);
            Debug.WriteLine(enderecoCaelum);

            #endregion



            Console.ReadKey();
        }

        private static async Task<Endereco> GetEndereco(string cep)
        {
            string url = $"http://viacep.com.br/ws/{cep}/json/";

            var result = await new HttpClient().GetStringAsync(url);

            return JsonConvert.DeserializeObject<Endereco>(result);

        }

        private static async Task<Endereco> GetEnderecoCaelumAsync(string cep)
        {
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            ViaCEP viaCEP = new ViaCEP();

            string enderecoJson = await viaCEP.GetEnderecoJsonAsync(cep);

            return JsonConvert.DeserializeObject<Endereco>(enderecoJson);

        }
    }
}
