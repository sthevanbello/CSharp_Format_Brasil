using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CEP
{
    class Program
    {
        static void Main(string[] args)
        {
            string cep = "07084182";

            //var endereco = GetEndereco(cep);
            Endereco endereco = GetEndereco(cep).Result;
            var endereco2 = GetEndereco("01001000").Result;

            Debug.WriteLine(endereco);

            Console.WriteLine(endereco);

            Console.WriteLine(endereco2);

            Console.ReadKey();
        }

        private static async Task<Endereco> GetEndereco(string cep)
        {
            string url = $"http://viacep.com.br/ws/{cep}/json/";
            var result = await new HttpClient().GetStringAsync(url);
            return JsonConvert.DeserializeObject<Endereco>(result);

        }
    }
}
