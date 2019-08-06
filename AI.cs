using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissorsLizardSpock
{
    class AI : Player
    {
        public AI(string n) : base(n)
        {
            this.name = n;
            this.wins = 0;

            
        }
        int increaseWins()
        {
            this.wins++;
            return this.wins;
        }
    }
}
