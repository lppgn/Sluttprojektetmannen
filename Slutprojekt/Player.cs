using System;
using System.Collections.Generic;
namespace Slutprojekt
{
    public class Player
    {
        static Random dice = new Random();
        static Dictionary<int, Player> players = new Dictionary<int, Player>();
        public string Name = "";
        public int position = 0;
        public int cash = 1000;
        public int prisonCard = 0;
        public Dictionary<int, boardSquare> boardSquaresOwned = new Dictionary<int, boardSquare>();

        public Player(string name, int i)
        {
            this.Name = name;
            players.Add(i, this);
        }
    }
}
