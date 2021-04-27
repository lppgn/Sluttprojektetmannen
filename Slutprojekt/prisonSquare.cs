using System;

namespace Slutprojekt
{
    public class PrisonSquare
    {
        
        public void landedOnPrisonSquare(Player aPlayer){
            if(aPlayer.inPrison == true){
                if(aPlayer.prisonCard>0){
                    aPlayer.prisonCard--;
                    aPlayer.inPrison = false;
                }
            }
        }
    }
}
