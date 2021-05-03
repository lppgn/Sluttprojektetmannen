using System;

namespace Slutprojekt
{
    public class PropertySquare: BoardSquare
    {
        public bool owned = false;
        public string ownedBy = "";
        public static int ownedOfType = 0;
        public int price { get; set; }
    }
}
