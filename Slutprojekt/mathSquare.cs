using System;

namespace Slutprojekt
{
    public class MathSquare: BoardSquare
    {
        public void landedOnMathSquare(int diceValue, Player aPlayer){
            aPlayer.cash -= cost*diceValue;
        }
    }
}
