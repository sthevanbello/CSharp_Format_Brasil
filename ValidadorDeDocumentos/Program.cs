using Caelum.Stella.CSharp.Format;
using Caelum.Stella.CSharp.Validation;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidadorDeDocumentos
{
    class Program
    {
        static void Main(string[] args)
        {
            string cpf1 = "86288366757";
            string cpf2 = "98745366797";
            string cpf3 = "22222222222";
            string cpfAlura = "86288366757";

            ValidarCPF(cpf1);
            ValidarCPF(cpf2);
            ValidarCPF(cpf3);
            

            string cnpj1 = "33001209000120";
            string cnpj2 = "60478340000154";
            string cnpj3 = "52247366000160";
            string cnpjAlura = "51241758000152";

            ValidarCNPJ(cnpj1);
            ValidarCNPJ(cnpj2);
            ValidarCNPJ(cnpj3);


            string titulo1 = "440527680167";
            string titulo2 = "215048380158";
            string titulo3 = "852110620167";
            string tituloAlura = "041372570132";

            ValidarTitulo(titulo1);
            ValidarTitulo(titulo2);
            ValidarTitulo(titulo3);


            Debug.WriteLine(cpf1);

            string cpfFormatado = new CPFFormatter().Format(cpf1);
            Debug.WriteLine(cpfFormatado);

            Debug.WriteLine(new CPFFormatter().Format(cpfFormatado));
            Debug.WriteLine(new CPFFormatter().Unformat(cpfFormatado));

            FormataCNPJ(cnpj1);
            FormataCNPJ(cnpj2);
            FormataCNPJ(cnpj3);

            string tituloFormatado = new TituloEleitoralFormatter().Format(titulo1);
            Debug.WriteLine(tituloFormatado);


            ValidarCPF(cpfAlura);
            ValidarCNPJ(cnpjAlura);
            ValidarTitulo(tituloAlura);

            Console.ReadKey();

        }

        private static void FormataCNPJ(string cnpj)
        {
            string cnpjFormatado = new CNPJFormatter().Format(cnpj);

            Debug.WriteLine(cnpjFormatado);
        }

        private static void ValidarTitulo(string titulo)
        {
            if (new TituloEleitoralValidator().IsValid(titulo))
            {
                Debug.WriteLine($"Ttítulo de eleitor {titulo} é válido");
            }
            else
            {
                Debug.WriteLine($"Título de eleitor {titulo} é inválido");
            }
        }

        private static void ValidarCPF(string cpf)
        {
            if (new CPFValidator().IsValid(cpf))
            {
                Debug.WriteLine($"CPF válido: {cpf}");
            }
            else
            {
                Debug.WriteLine($"CPF inválido: {cpf}");
            }
        }

        private static void ValidarCNPJ(string cnpj)
        {
            if (new CNPJValidator().IsValid(cnpj))
            {
                Debug.WriteLine($"CNPJ válido: {cnpj}");
            }
            else
            {
                Debug.WriteLine($"CNPJ inválido: {cnpj}");
            }
        }
    }
}
