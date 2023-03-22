// Aponta dll do windows uma classe em assembly do core do windows que contém classes, structs, enum e etc
using System;

namespace estruturasLinguagem
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ultilizando classe System do core do windows "dll"
            Console.WriteLine();

            //Ultizando uma struct System do core do windows "dll"
            int x = 10;

            // Ultilizando enum System do core do windows "dll"
            DayOfWeek dia = DateTime.Now.DayOfWeek;
        }
    }
}
