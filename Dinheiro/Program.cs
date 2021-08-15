using Caelum.Stella.CSharp.Vault;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dinheiro
{
    class Program
    {
        static void Main(string[] args)
        {

            Money money1 = 10.00;

            Console.WriteLine(money1.ToString("C", new CultureInfo("pt-BR")));

            Debug.WriteLine(money1.ToString("C", new CultureInfo("pt-BR")));

            Debug.WriteLine(money1);

            float valor1 = 10.00F;
            float valor2 = 20.00F;

            float total = valor1 + valor2;

            Money money2 = total;

            Console.WriteLine(money2);
            Debug.WriteLine(money2);

            decimal valor3 = 25.00M;
            decimal valor4 = 55.00M;
            decimal total2 = valor3 * valor4;
            Money money3 = total2;

            Console.WriteLine(money3);
            Debug.WriteLine(money3);

            Money euro = new Money(Currency.EUR, 1000);

            Console.WriteLine(euro);
            Debug.WriteLine(euro);

            Money dolar = new Money(Currency.USD, 1500);

            Console.WriteLine(dolar);
            Debug.WriteLine(dolar);

            Money real = new Money(Currency.BRL, 1500);

            Console.WriteLine(real);
            Debug.WriteLine(real);

            //var somaMoedasDiferentes = euro + dolar;
            //Console.WriteLine(somaMoedasDiferentes);
            //Debug.WriteLine(somaMoedasDiferentes);


            Money dolar2 = new Money(Currency.USD, 1000);
            CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");
            Debug.WriteLine(dolar2);

            Console.ReadKey();


        }
    }
}
