using System;

namespace Slutprojekt
{
    public class PoliceSquare
    {
        
        public void landedOnPoliceSquare(Player aPlayer){
            aPlayer.inPrison = true;
            aPlayer.position = 10;
            System.Console.WriteLine("You will go straight to prison without passing start");
        }
    }
}
