internal class Program
{
    private static void Main(string[] args)
    {
        RepetitionFor();
        RepetitionWhile();
        RepetitionDoWhile();
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
}
