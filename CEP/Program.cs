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
            string url = $"http://viacep.com.br/ws/{cep}/json/";

            var result = new HttpClient().GetStringAsync(url).Result;
            Endereco endereco = JsonConvert.DeserializeObject<Endereco>(result);

            Console.WriteLine(url);
            Console.WriteLine(result);
            Debug.WriteLine(result);


            Console.WriteLine(endereco);

            Console.ReadKey();
        }
    }
}
