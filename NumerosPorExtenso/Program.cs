using Caelum.Stella.CSharp.Inwords;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumerosPorExtenso
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor = 75;
            double valor2 = 25789654123;
            double valor3 = 2885789654123;
            double valor4 = 1;
            double valor5 = 25.65;

            string extenso = new Numero(valor).Extenso();
            Console.WriteLine(extenso);


            NumeroExtenso(valor2);
            NumeroExtenso(valor3);
            NumeroExtensoMoeda(valor4);
            NumeroExtensoMoeda(valor5);

            Console.ReadKey();
        }

        private static void NumeroExtenso(double valor)
        {
            string extenso = new Numero(valor).Extenso();

            Console.WriteLine("\n===================\n");
            Console.WriteLine(extenso);
        }

        private static void NumeroExtensoMoeda(double valor)
        {
            string extenso = new MoedaBRL(valor).Extenso();
            Console.WriteLine("\n===================\n");
            Console.WriteLine(extenso);
        }
    }
}
