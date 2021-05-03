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
            var walla1 = new Player("wolke", 2);
            var aChanceSquare = new ChanceSquare();
            var aBoardSquare = new StationSquare();
            var aRealEstateSquare = new RealEstateSquare();
            walla.boughtProperty(aRealEstateSquare);
            walla.boardSquaresOwned.Add(1, aRealEstateSquare);
            aRealEstateSquare.landedOnRealEstateSquare(walla);
            aRealEstateSquare.landedOnRealEstateSquare(walla);

            
            //walla.boardSquaresOwned.Add(1, aBoardSquare);
            //aBoardSquare.landedOnStationSquare(walla);
            
            //System.Console.WriteLine(walla.boardSquaresOwned[1].ToString());
            // System.Console.WriteLine(walla.boardSquaresOwned[1].GetType());
            Console.ReadLine();
            aChanceSquare.landedOnChanceSquare(walla, chance.chanceCardDictionary);
            walla.diceRoll();
            System.Console.WriteLine(walla.cash);
            Console.ReadLine();
        }
    }
}
