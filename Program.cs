using System;

namespace Uppgift_Oscar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Oscar Rösbäck");
            Console.WriteLine("2020-04-26");
            bool x = true;
            Random ny = new Random();
            do
            {
                Console.WriteLine("Hur många tärningar vill du rulla? Välj mellan 1 och 4:  ");
                string inmatning = Console.ReadLine();
                int utmatning;
                try
                {
                    utmatning = Int32.Parse(inmatning);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Du måste välja en siffra, välj mellan 1 och 4");
                    continue;
                }
                if (utmatning < 1 || utmatning > 4)
                {
                    Console.WriteLine("Du valde för högt, välj mellan 1 och 4");
                    continue;
                }
                int i = 0;
                int raknare = 0;
                int tarning = 1;
                while (i < utmatning)
                {
                    int tarningSvar = RandomDice(ny);
                    if (tarningSvar == 1)
                    {
                        Console.WriteLine("Du rullade 1. Du får 2 nya försökt!");
                        utmatning++;
                        tarning++;
                    }
                    else
                    {
                        raknare += tarningSvar;
                        Console.WriteLine($"Du har rullat {tarningSvar} och du har {raknare} poäng");
                        i++;
                    }

                }
                Console.WriteLine($"Du har rullat {utmatning} tärning/tärningar och dina totala poäng är {raknare} ");
                Console.WriteLine("Vill du börja om? Skriv \"j\" om du vill börja om eller \"n\" om du vill avsluta");
                string fortsatt = Console.ReadLine();
                x = fortsatt == "j";
            } while (x);
        }
        static public int RandomDice(Random start)
        {
            return start.Next(1, 6);
        }
    }
}
