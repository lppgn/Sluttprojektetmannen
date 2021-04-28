using System;

namespace Slutprojekt
{
    public class StationSquare: PropertySquare
    {
        public int i = 0;
        public int cost = 50;
        public void landedOnStationSquare(Player aPlayer){
            i=0;
            foreach (var item in aPlayer.boardSquaresOwned)
            {
                if(item.Value.ToString() == "Slutprojekt.StationSquare"){
                    i++;
                    System.Console.WriteLine("funkar walla" + i);
                }
            }
            aPlayer.cash -= cost*i;
        }
    }
}
