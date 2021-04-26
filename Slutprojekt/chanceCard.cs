using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace Slutprojekt
{
    public class chanceCard
    {
        public Dictionary<int, (string text, int value)> chanceCardDictionary = new Dictionary<int, (string text, int value)>();
        public chanceCard()
        {

            using (StreamReader reader = new StreamReader("Bok1.csv"))
            {
                string line;
                int indexNumber = 0;
                int chanceCost = 0;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(';');
                    bool try1 = int.TryParse(parts[0], out indexNumber);
                    try1 = int.TryParse(parts[2], out chanceCost);
                    chanceCardDictionary.Add(indexNumber, (parts[1], chanceCost));
                }
            }
        }
    }
}
