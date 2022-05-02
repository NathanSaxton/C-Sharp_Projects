﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TwentyOne
{
    public class Deck
    {
        public Deck()
        {
            Cards = new List<Card>();
            List<string> Suits = new List<string>() { "Spades", "Clubs", "Hearts", "Diamonds" };
            List<string> Faces = new List<string>()
            {
                "Ace", "Two", "Three", "Four", "Five", "Six", "Seven",
                "Eight", "Nine", "Ten", "Jack", "Queen", "King"
            };
                        
            foreach(string suit in Suits)
            {
                foreach (string face in Faces)
                {
                    Card card = new Card();
                    card.Face = face;
                    card.Suit = suit;
                    Cards.Add(card);
                }
            }

        }
        public List<Card> Cards = new List<Card>();
    }
}
