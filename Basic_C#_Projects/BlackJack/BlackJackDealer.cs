using System;
using System.Collections.Generic;
using System.Text;

namespace BlackJack
{
    public class BlackJackDealer: Dealer
    {
        private List<Card> _hand = new List<Card>();
        public bool Stay { get; set; }
        public bool IsBusted { get; set; }
        public List<Card> Hand { get { return _hand; } set { _hand = value; } }
    }
}
