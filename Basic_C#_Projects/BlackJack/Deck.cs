using System;
using System.Collections.Generic;
using System.Text;

namespace BlackJack
{
    public class Deck
    {
        public Deck()
        {
            Cards = new List<Card>();

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 13; j++)
                {
                    Card card = new Card();
                    card.Face = (Face)j;
                    card.Suit = (Suit)i;
                    Cards.Add(card);
                }
            }
        }
        public List<Card> Cards { get; set; }   

        public void Shuffle()
        {
            List<Card> TempList = new List<Card>();
            Random random = new Random();

            while (Cards.Count > 0)
            {
                int randomIndex = random.Next(0, Cards.Count);
                TempList.Add(Cards[randomIndex]);
                Cards.RemoveAt(randomIndex);
            }
            Cards = TempList;
        }
    }
}
