using System;

namespace Uppgift_4._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Välj ett alternativ");
            Console.WriteLine("1. Subtrahera ett tal");
            Console.WriteLine("2. Dividera ett tal");
            Console.WriteLine("3. Avsluta programmet");
            string svar = Console.ReadLine();

            switch (svar)
            {
                case "1":
                    Console.WriteLine("Skriv in första talet");
                    double tal1Minus = double.Parse(Console.ReadLine());
                    Console.WriteLine("Skriv in andra talet");
                    double tal2Minus = double.Parse(Console.ReadLine());
                    Console.WriteLine($"{tal1Minus}-{tal2Minus}={tal1Minus - tal2Minus}");
                    break;
                case "2":
                    Console.WriteLine("Skriv in första talet");
                    double tal1Division = double.Parse(Console.ReadLine());
                    Console.WriteLine("Skriv in andra talet");
                    double tal2Division = double.Parse(Console.ReadLine());
                    Console.WriteLine($"{tal1Division}/{tal2Division}={tal1Division / tal2Division}");
                    break;
                case "3":
                    break;
            }
            Console.ReadKey();
        }
    }
}