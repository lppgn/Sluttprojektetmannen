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
            var aChanceSquare = new ChanceSquare();
            aChanceSquare.landedOnChanceSquare(walla, chance.chanceCardDictionary);
            walla.diceRoll();
            System.Console.WriteLine(walla.cash);
            Console.ReadLine();
        }
    }
}
