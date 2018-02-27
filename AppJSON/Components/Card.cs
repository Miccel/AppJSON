using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppJSON.Components
{
    class Card
    {
        public string name;
        public int value;
//0 Bastone 1 Denari 2 Coppe 3 Spade
        public int suit;

        public Card(string name, int value, int suit)
        {
            this.name = name;
            this.value = value;
            this.suit = suit;
        }
    }
}
