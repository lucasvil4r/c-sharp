using System;
namespace Aula01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Olá");
            //int x = 10;
            //Console.WriteLine(x);

            DayOfWeek dia = DateTime.Now.DayOfWeek;
            Console.WriteLine(dia);
            Console.WriteLine((int)dia);


        }
    }
}
