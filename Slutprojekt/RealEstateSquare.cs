using System;
using System.Collections.Generic;

namespace Slutprojekt
{
    public class RealEstateSquare : PropertySquare
    {
        public int houseAmount = 2;
        public static int houseVariable = 2;
        public int streetAmount = 0;
        public string streetType = "f";
        public RealEstateSquare()
        {
            cost = 12;
        }
        public void landedOnRealEstateSquare(Player aPlayer)
        {
            if(this.owned == true){
                if(aPlayer.name == this.ownedBy){

                }
                else{
                    isOwned(aPlayer);
                }
            }
            else{
                notOwned(aPlayer);
            }
        }
        private void resetCost()
        {
            if (ownedOfType == streetAmount)
            {
                cost /= 2;
            }
            for (int i = 0; i < houseAmount; i++)
            {
                cost /= houseVariable;
            }
        }
        private void calcCost(Player aPlayer)
        {
            ownedOfType = 0;
            foreach (KeyValuePair<int, PropertySquare> item in aPlayer.boardSquaresOwned)
            {
                if (item.Value is RealEstateSquare)
                {
                    if (((RealEstateSquare)item.Value).streetType == streetType)
                    {
                        ownedOfType++;
                    }
                }
            }
            if (ownedOfType == streetAmount)
            {
                cost *= 2;
            }
            for (int i = 0; i < houseAmount; i++)
            {
                cost *= houseVariable;
            }
        }
        private void isOwned(Player aPlayer)
        {
            calcCost(aPlayer);
            payMoney(aPlayer);
            resetCost();
        }
        private void notOwned(Player aPlayer)
        {
            System.Console.WriteLine("do you want to buy " + this);
        }
        private void payMoney(Player aPlayer){
            aPlayer.cash -= cost;
            foreach (Player item in Player.players.Values)
            {
                if(item.name == this.ownedBy){
                    item.cash += cost;
                }
            }
        }
    }
}
