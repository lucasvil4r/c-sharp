using System.Reflection.Emit;

internal class Program
{
    private static void Main(string[] args)
    {
        //RepetitionFor();
        //RepetitionWhile();
        //RepetitionDoWhile();
        //Exercicios01();
        //Exercicios03();
        //Exercicios04();
        Exercicios05();
    }

    static void RepetitionFor()
    {
        for (int x = 1 ; x <= 10 ; x++ )
        {
            Console.WriteLine( x );
        }
    }
    static void RepetitionWhile()
    {
        int x = 1 ;
        while ( x <= 10 )
        {
            Console.WriteLine( x );
            x++;
        }
    }
    static void RepetitionDoWhile()
    {
        int x = 1;
        do
        {
            Console.WriteLine(x);
            x++;
        }
        while (x <= 10);
    }
    static void Exercicios01()
    {
        int n = 0;
        string label1 = "";

        while (n <= 10)
        {
            label1 += n.ToString("00");
            n += 2;
        }
        Console.WriteLine(label1);
    }

    static void Exercicios03()
    {
        int n = 12;
        string label1 = "";

        while (n <= 10)
        {
            n -= 2;
            label1 += n.ToString("00");
        }
        Console.WriteLine(label1);
    }

    static void Exercicios04()
    {
        int n = 12;
        string label1 = "";

        for (n = 0; n <= 10; n += 2)
        {
            label1 += n.ToString("00");

        }
        Console.WriteLine(label1);
    }

    static void Exercicios05()
    {
        int n = 0;
        string label1 = "";

        do
        {
            n += 2;
            label1 += n.ToString("00");
        } while (n >= 10);

        Console.WriteLine(label1);
    }
}
