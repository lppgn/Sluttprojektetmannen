using System;
using System.Collections.Generic;

namespace Slutprojekt
{
    public class StationSquare: PropertySquare
    {
        public void landedOnStationSquare(Player aPlayer){
            ownedOfType=0;
            foreach (KeyValuePair<int, PropertySquare> item in aPlayer.boardSquaresOwned)
            {
                if(item.Value == this){
                    ownedOfType++;
                    System.Console.WriteLine("funkar walla" + ownedOfType);
                }
            }
            aPlayer.cash -= cost*ownedOfType;
        }
    }
}
