using System;

namespace Slutprojekt
{
    public class mathSquare
    {
        private int valueVariable = 4;

        public void landedOnMathSquare(int diceValue, Player aPlayer){
            aPlayer.cash -= valueVariable*diceValue;
        }
    }
}
