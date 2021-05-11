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
                    indexNumber = int.Parse(parts[0]);
                    chanceCost = int.Parse(parts[2]);
                    chanceCardDictionary.Add(indexNumber, (parts[1], chanceCost));
                }
            }
        }
    }
}
