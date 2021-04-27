using System;
using System.Collections.Generic;
namespace Slutprojekt
{
    public class chanceSquare
    {
        static Random cardRandomizer = new Random();
        static int randomInt = 0;
        public void landedOnChanceSquare(Player aPlayer,Dictionary<int, (string text, int value)> dict){
            randomInt = cardRandomizer.Next(1,11);
            System.Console.WriteLine(dict[randomInt].text);
            if(dict[randomInt].value == 0){
                aPlayer.inPrison = true;
                aPlayer.position = 10;
            }
            else if(dict[randomInt].value == 100){
                aPlayer.prisonCard++;
            }
            else{
                aPlayer.cash += dict[randomInt].value;
            }
        }
    }
}
