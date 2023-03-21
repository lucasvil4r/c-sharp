// See https://aka.ms/new-console-template for more information

using System.Globalization;

namespace Aula03
{
    class Program
    {
        static void Main(string[] args)
        {
            // Atribuição

            int x = 10;
            int z = 20;

            // Aritmeticos
            int t = x + z;
            t = 10 * 5;

            // Incremento
            t = t + 1;
            t += 1;
            t += 6;

            // Incrementa e retorna 
            t++;
            // Retorna e Incrementa
            ++t;

            bool testeOperacao = 10 > 5;
            Console.WriteLine(testeOperacao);
        }
    }
}
