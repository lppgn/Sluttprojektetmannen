using System;

namespace Slutprojekt
{
    public class Dice
    {
        public Random randomDice = new Random();
        public int diceValue1 = 0;
        public int diceValue2 = 0;
        public void RollDice(){
            diceValue1 = randomDice.Next(1,7);
            diceValue2 = randomDice.Next(1,7);
        }
    }
}
