// See https://aka.ms/new-console-template for more information

namespace Aula_03_Parte_04
{
    class Program
    {
        static void Main(string[] args)
        {
            // Formata valor
            double valor = 1021.45;
            Console.WriteLine("O valor é {0:n2}", valor);

            Console.WriteLine("--------------------------------");

            // Formata data 
            DateTime data = DateTime.Now;
            Console.WriteLine("{0}", data);
            Console.WriteLine("{0:D}", data);
            Console.WriteLine("{0:d}", data);
            Console.WriteLine("{0:m}", data);
            Console.WriteLine("{0:MM}", data);
            Console.WriteLine("{0:MMM}", data);

            Console.WriteLine("--------------------------------");

            // Formata string
            string numero = string.Format("{0:c}", valor);
            Console.WriteLine(numero);
            string frase = string.Format("Hoje é {0:d} e o valor é {1:c}", data, valor);
            Console.WriteLine(frase);

            Console.WriteLine("--------------------------------");

            // Altera formato conforme linguagem
            var ci=new System.Globalization.CultureInfo("en-US");
            string padraoFormatUS = string.Format(ci, "Hoje é {0:d} e o valor é {1:c}", data, valor);
            Console.WriteLine(padraoFormatUS);
        }
    }
}
