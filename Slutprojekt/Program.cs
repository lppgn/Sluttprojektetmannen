using System;

namespace Slutprojekt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var chance = new chanceCard();


            Random generator = new Random();
            int bruh = generator.Next(1,10);


            System.Console.WriteLine(chance.chanceCardDictionary[bruh].text + "__" + chance.chanceCardDictionary[bruh].value);
            Console.ReadLine();
        }
    }
}
