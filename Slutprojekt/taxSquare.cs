using System;

namespace Slutprojekt
{
    public class TaxSquare
    {
        public int taxAmount = 200;
        public void landedOnTaxSquare(Player aPlayer){
            aPlayer.cash -= taxAmount;
        }
    }
}
