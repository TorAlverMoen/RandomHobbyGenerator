using System;

namespace RandomHobbyGenerator
{
    internal class Program
    {
        static string[] hobbies = { "frimerke samling", "fallskjerm hopping", "dypvannsfiske", "fotografering", "brodering av bunader" };

        static int generateRandomIndex()
        {
            Random rndNum = new Random();
            return rndNum.Next(0, 4);
        }

        static void Main()
        {
            Console.WriteLine("Hvem vil starte en ny hobby?");
            var name = Console.ReadLine();
            Console.WriteLine(name + " vil begynne med " + hobbies[generateRandomIndex()] + ".");
        }
    }
}