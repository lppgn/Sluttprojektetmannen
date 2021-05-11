using System;
using System.Collections.Generic;
namespace Slutprojekt
{
    public class GameBoard
    {
        public int Size {get; set; } = 40;
        public List<BoardSquare> boardSquares = new List<BoardSquare>();
        //static Dictionary<int, (string name, BoardSquare type)> stuffs = new Dictionary<int, (string name, string type)>();

        public GameBoard(){
           // stuffs[1].type
        }
    }
}
