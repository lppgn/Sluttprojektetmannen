using System;

namespace Slutprojekt
{
    public class MathSquare
    {
        private int valueVariable = 4;

        public void landedOnMathSquare(int diceValue, Player aPlayer){
            aPlayer.cash -= valueVariable*diceValue;
        }
    }
}
