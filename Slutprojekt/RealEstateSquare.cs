using System;
using System.Collections.Generic;

namespace Slutprojekt
{
    public class RealEstateSquare: PropertySquare
    {
        public int initialCost = 0;
        public int houseAmount = 0;
        public int houseVariable = 2;
        public int streetAmount = 0;
        public string streetType = "f";
        public void landedOnRealEstateSquare(Player aPlayer){
            int ownedOfStreet = 0;
            foreach (KeyValuePair<int, PropertySquare> item in aPlayer.boardSquaresOwned)
            {

                if (item.Value is RealEstateSquare)
                {
                    if (((RealEstateSquare) item.Value).streetType == streetType)
                    {
                        System.Console.WriteLine("funkar");
                    }
                }
            }
        }
    }
}
