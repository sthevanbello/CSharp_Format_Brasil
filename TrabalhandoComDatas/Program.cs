using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Threading.Tasks;

namespace TrabalhandoComDatas
{
    class Program
    {
        static void Main(string[] args)
        {

            DateTime data = new DateTime(2020, 8, 14);


            Debug.WriteLine(data.ToString("d", new CultureInfo("pt-BR")));
            Debug.WriteLine(data.ToString("d"));

            Console.WriteLine(data.ToString("d", new CultureInfo("pt-BR")));
            Console.WriteLine(data.ToString("d"));
            Console.WriteLine(data.ToString("dd/MM/yyyy"));
            Console.WriteLine(data.ToString("MM/dd/yyyy"));

            Debug.WriteLine(data.ToString("dd/MM/yyyy"));
            Debug.WriteLine(data.ToString("MM/dd/yyyy"));

            data = new DateTime(2020, 8, 14, 20, 29, 30, 987);
            DateTime dataNow = DateTime.Now;
            Console.WriteLine(data);
            Console.WriteLine(data.ToString("HH:mm"));
            Console.WriteLine(data.ToString("HH:mm:ss.fff"));
            Console.WriteLine(data.ToString("D"));
            Console.WriteLine(data.ToString("m"));
            Console.WriteLine(data.ToString("M"));
            Console.WriteLine("==============================================");
            Console.WriteLine(dataNow.ToString("D"));
            Console.WriteLine(dataNow.ToString("m"));
            Console.WriteLine(dataNow.ToString("M"));
            Console.WriteLine(dataNow.ToString("Y"));
            Console.WriteLine(dataNow.ToString("HH:mm:ss.fff"));
            Console.WriteLine(dataNow.ToString("G"));
            Console.WriteLine(dataNow.ToString("g"));

            Console.WriteLine(dataNow.ToString("O"));
            Console.WriteLine(DateTime.Parse(dataNow.ToString("O")).ToString("D"));

            Console.WriteLine(dataNow.ToString("t"));
            Console.WriteLine(dataNow.ToString("T"));



            Console.ReadKey();
        }
    }
}
