// See https://aka.ms/new-console-template for more information

using System.Globalization;

namespace Aula03
{
    class Program
    {
        static void Main(string[] args)
        {
            // Texto
            String nome = "Teste";

            //Numero Inteiro
            short idade = 10;
            int id = 10;
            long numeroLong = 10000;

            //Numero com fração
            double porcentagem = 4.58889189489;
            decimal salario = Convert.ToDecimal(5645.50);
            float comissao = Convert.ToSingle(3.5);

            //Data
            DateTime data = new DateTime();
            DateTime agora = DateTime.Now;

            //Boolean
            bool pessoaFisica = true;

            //Array
            int[] numeros = new int[3];
        }

        public String nome = "Teste";
        String ExibirDados() => nome;

        String CalcularPreco()
        {
        }
    }
}
