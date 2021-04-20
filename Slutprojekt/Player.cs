using System;
using System.Collections.Generic;
namespace Slutprojekt
{
    public class Player
    {
        static Random dice = new Random();
        public int position = 0;
        public int cash = 1000;
        public int prisonCard = 0;
        public Dictionary<int, boardSquare> boardSquaresOwned = new Dictionary<int, boardSquare>();
    }
}
