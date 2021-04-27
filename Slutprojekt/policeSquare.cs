using System;

namespace Slutprojekt
{
    public class policeSquare
    {
        
        public void landedOnPoliceSquare(Player aPlayer){
            aPlayer.inPrison = true;
            aPlayer.position = 10;
        }
    }
}
