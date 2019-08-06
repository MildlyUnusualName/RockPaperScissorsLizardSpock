using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissorsLizardSpock
{
    class Human : Player
    {
        public Human(string n) : base(n)
        {
            this.name = n;
            this.Win = 0;

        }
        int increaseWins()
            {
                this.Win++;
                return this.Win;
            }
        
    }
}
