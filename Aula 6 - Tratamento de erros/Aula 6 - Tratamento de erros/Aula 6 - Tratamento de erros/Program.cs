
using System.Reflection.Emit;
using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Exception01();
        Exception02();
    }

    static void Exception01()
    {
        try 
        {
            decimal valorProduto = Convert.ToDecimal(Console.ReadLine());
            decimal quantidade = Convert.ToInt32 (Console.ReadLine());
            decimal total = valorProduto + quantidade;

            if (valorProduto < 0 || quantidade < 0)
            { 
                //Lança uma exception manualmente
                throw new ApplicationException("Número inserido menor que zero"); 
            }

            Console.WriteLine(total);
        }
        //Variavel que é instanciada pelo SO automaticamente e retorna erro
        // catch generico
        catch
        {
            Console.WriteLine("Erro na entrada de dados, favor verificar");
        }
    }
    static void Exception02()
    {
        try
        {
            decimal valorProduto = Convert.ToDecimal(Console.ReadLine());
            decimal quantidade = Convert.ToInt32(Console.ReadLine());
            decimal total = valorProduto + quantidade;

            Console.WriteLine(total);
        }
        //Somente erros de formatos ele entrará nesse catch
        catch (FormatException)
        {
            Console.WriteLine("Formato de dados de entrada invalido, favor verificar!");
        }
        //Somente erros de formatos ele entrará nesse catch
        catch (OverflowException)
        {
            Console.WriteLine("Numero muito grande, favor verificar!");
        }
        //Variavel que é instanciada pelo SO automaticamente e retorna erro
        catch (Exception ex)
        {
            Console.WriteLine("Erro generico");
        }
    }
}