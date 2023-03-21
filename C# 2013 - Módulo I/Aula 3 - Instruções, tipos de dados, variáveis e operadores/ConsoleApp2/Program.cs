// See https://aka.ms/new-console-template for more information

using System.Drawing;
using System.Reflection.Emit;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Aula_03_Parte_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Question03();
        }

        static double Example01()
        {
            // Formata valor
            double valor = 1021.45;
            Console.WriteLine("O valor é {0:n2}", valor);
            return valor;
        }

        static DateTime Example02()
        {
            // Formata data 
            DateTime data = DateTime.Now;
            Console.WriteLine("{0}", data);
            Console.WriteLine("{0:D}", data);
            Console.WriteLine("{0:d}", data);
            Console.WriteLine("{0:m}", data);
            Console.WriteLine("{0:MM}", data);
            Console.WriteLine("{0:MMM}", data);
            return data;
        }

        static void Example03()
        {
            double valor = Example01();
            DateTime data = Example02();

            // Formata string
            string numero = string.Format("{0:c}", valor);
            Console.WriteLine(numero);
            string frase = string.Format("Hoje é {0:d} e o valor é {1:c}", data, valor);
            Console.WriteLine(frase);
        }

        static void Example04()
        {
            double valor = Example01();
            DateTime data = Example02();

            // Altera formato conforme linguagem
            var ci = new System.Globalization.CultureInfo("en-US");
            string padraoFormatUS = string.Format(ci, "Hoje é {0:d} e o valor é {1:c}", data, valor);
            Console.WriteLine(padraoFormatUS);
        }

        static void Example05()
        {
            double valor = Example01();
            DateTime data = Example02();

            // Altera formato conforme linguagem
            var ci = new System.Globalization.CultureInfo("en-US");
            string padraoFormatUS = string.Format(ci, "Hoje é {0:d} e o valor é {1:c}", data, valor);
            Console.WriteLine(padraoFormatUS);
        }

        static bool Question02()
        {
            int a = 10, b = 15, c = 10;
            bool d = a == c || b != a && a == b;
            Console.WriteLine(d); //True
            return d;
        }

        static string Question03()
        {
            int a = 4, b = 5, c = 6;
            int d = (a++ / 2) * (++c % 2) * ++b;
            string resultado = d + (d % 3 == 0 ? " é " : " não é ") + "múltiplo de 3";
            string resultadoLabel = string.Format("a = {0}, b = {1}, c = {2}, d = {3}\nresultado: {4}", a, b, c, d, resultado);
            Console.WriteLine(resultadoLabel);

            return resultadoLabel;
        }

    }
}
