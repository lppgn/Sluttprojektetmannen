using System;

namespace Slutprojekt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            Console.ReadLine();


            var chance = new chanceCard();
            var walla = new Player("ider", 1);
            var walla1 = new Player("wolke", 2);
            var aChanceSquare = new ChanceSquare();
            var aBoardSquare = new StationSquare();
            var aRealEstateSquare = new RealEstateSquare();
            var aMathSquare = new MathSquare();
            var aPoliceSquare = new PoliceSquare();
            walla.BoughtProperty(aRealEstateSquare);
            aRealEstateSquare.landedOnRealEstateSquare(walla);
            aRealEstateSquare.landedOnRealEstateSquare(walla);
            aBoardSquare.landedOnStationSquare(walla);
            aChanceSquare.landedOnChanceSquare(walla, chance.chanceCardDictionary);
            walla.DiceRoll();
            aMathSquare.landedOnMathSquare(walla.dice.diceValue1+walla.dice.diceValue2, walla);
            aPoliceSquare.landedOnPoliceSquare(walla);
            walla.DiceRoll();
            walla.DiceRoll();
            walla.DiceRoll();


            

            
            //walla.boardSquaresOwned.Add(1, aBoardSquare);
            //aBoardSquare.landedOnStationSquare(walla);
            
            //System.Console.WriteLine(walla.boardSquaresOwned[1].ToString());
            // System.Console.WriteLine(walla.boardSquaresOwned[1].GetType());
            Console.ReadLine();
            aChanceSquare.landedOnChanceSquare(walla, chance.chanceCardDictionary);
            walla.DiceRoll();
            System.Console.WriteLine(walla.cash);
            Console.ReadLine();
        }
    }
}
