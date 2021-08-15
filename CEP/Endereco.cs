using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEP
{
    class Endereco
    {
        public string CEP { get; set; }
        public string Logradouro { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Localidade { get; set; }
        public string UF { get; set; }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"CEP: {CEP}");
            sb.AppendLine($"Logradouro: {Logradouro}");
            sb.AppendLine($"Complemento: {Complemento}");
            sb.AppendLine($"Bairro: {Bairro}");
            sb.AppendLine($"Localidade: {Localidade}");
            sb.AppendLine($"UF: {UF}");


            return sb.ToString(); 
        }
    }
}
