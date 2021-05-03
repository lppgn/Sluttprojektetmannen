using System;

namespace Slutprojekt
{
    public class TaxSquare: BoardSquare
    {
        public void landedOnTaxSquare(Player aPlayer){
            aPlayer.cash -= cost;
        }
    }
}
