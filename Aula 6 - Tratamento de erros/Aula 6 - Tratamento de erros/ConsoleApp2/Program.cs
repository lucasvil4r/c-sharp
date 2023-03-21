
using System.Reflection.Emit;
using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Debug();
    }

    static void Debug()
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
        // Finally é executado sempre com erros ou sem erros 
        finally { Console.WriteLine("Fim do programa"); }
    }
}
