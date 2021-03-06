using System;
using System.Collections.Generic;
namespace Slutprojekt
{
    public class Player
    {
        public Dice dice = new Dice();
        public static Dictionary<int, Player> players = new Dictionary<int, Player>();
        public string name = "";
        public int position = 0;
        public int cash = 1000;
        public string readAnswer = "";
        public int prisonCard = 0;
        public bool inPrison = false;
        public Dictionary<int, PropertySquare> boardSquaresOwned = new Dictionary<int, PropertySquare>();

        public Player(string name, int i)
        {
            this.name = name;
            players.Add(i, this);
        }
        public void BoughtProperty(PropertySquare aProperty)
        {
            aProperty.ownedBy = this.name;
            this.boardSquaresOwned.Add(1, aProperty);
        }
        public void DiceRoll()
        {
            if (inPrison == true)
            {
                System.Console.WriteLine("You are in prison, pay 50$ to get out or roll the same number on both dice. On your 3rd try you will be forced to pay 50$.");
                System.Console.WriteLine("Do you want to pay 50$. y/n");
                while (true)
                {
                    readAnswer = Console.ReadLine();
                    if (readAnswer == "y" || readAnswer == "Y")
                    {
                        cash -= 50;
                        inPrison = false;
                        this.dice.RollDice();
                        position += dice.diceValue1 + dice.diceValue2;
                        if (position > 40)
                        {
                            System.Console.WriteLine("You passed start and recieved 200$");
                            position -= 40;
                            cash += 200;
                        }
                        System.Console.WriteLine("you rolled a " + dice.diceValue1 + " and a " + dice.diceValue2 + " so you are now on square " + position);
                        break;
                    }
                    else if (readAnswer == "n" || readAnswer == "N")
                    {
                        System.Console.WriteLine("You chose not to pay");
                        this.dice.RollDice();
                        if (dice.diceValue1 == dice.diceValue2)
                        {
                            inPrison = false;
                            position += dice.diceValue2 + dice.diceValue1;
                            if (position > 40)
                            {
                                position -= 40;
                                System.Console.WriteLine("You passed start and recieved 200$");
                                cash += 200;
                            }
                        }
                        System.Console.WriteLine("you rolled a " + dice.diceValue1 + " and a " + dice.diceValue2 + "  yosou are now on square " + position);
                        break;
                    }
                    else
                    {
                        System.Console.WriteLine("You did not answer with y or n");
                    }
                }

            }
            else
            {
                this.dice.RollDice();
                position += dice.diceValue2 + dice.diceValue1;
                if (position > 40)
                {
                    position -= 40;
                    System.Console.WriteLine("You passed start and recieved 200$");
                    cash += 200;
                }
                System.Console.WriteLine("you rolled a " + dice.diceValue1 + " and a " + dice.diceValue2 + " so you are now on square " + position);
            }
        }
    }
}
