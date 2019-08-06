using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissorsLizardSpock
{
    class Player
    {
        public int wins;
        public string name;

        public int Win
        {
            get
            {
                return wins;
            }
            set
            {
                wins = value;
            }
        }

        public Player(string n)
        {
            this.name = n;
            this.wins = 0;
        }

        public string SetName(string n)
        {
            this.name = n;
            return this.name;
        }
        public string GetName()
        {
            return this.name;
        }
        public int GetWins()
        {
            return this.wins;
        }
        public int SetWins(int wins)
        {
            this.wins = wins;
            return this.wins;
        }
        public void addWin()
        {
            this.wins++;
            Console.WriteLine(this.GetName() + " wins the round!");
            Console.WriteLine(this.GetName() + "'s score is: " + this.GetWins());
        }

    }
}
