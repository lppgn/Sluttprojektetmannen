using System;

namespace Slutprojekt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var chance = new chanceCard();
            var walla = new Player("ider", 1);
            walla.inPrison = true;
            walla.diceRoll();
            System.Console.WriteLine(walla.inPrison + "--" + walla.cash);
            Random generator = new Random();
            int bruh = generator.Next(1,10);


            System.Console.WriteLine(chance.chanceCardDictionary[bruh].text + "__" + chance.chanceCardDictionary[bruh].value);
            Console.ReadLine();
        }
    }
}
