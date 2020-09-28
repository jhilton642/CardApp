using System;
using System.Collections.Generic;
using System.Text;

namespace CardApp
{
    class Card
    {
        string rank;
        string suit;
        int val;
        public string Rank { get => rank; set => rank = value; }
        public string Suit { get => suit; set => suit = value; }
        public int Val { get => val; set => val = value; }

        public Card(string rank, string suit, int value)
        {
            this.rank = rank;
            this.suit = suit;
            this.val = value;
        }
        public override string ToString()
        {
            return rank + " " + suit;
        }
        public int Value
        {
            get
            {
                return val;
            }
            set
            {
                val = value;
            }
        }
    }
}
