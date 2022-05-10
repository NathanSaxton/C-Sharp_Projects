using System;
using System.Collections.Generic;
using System.Text;

namespace BlackJack
{
    public class Player
    {
        public Player (string name, int startingBalance)
        {
            Hand = new List<Card>();
            Wallet = startingBalance;
            Name = name;
        }
        private List<Card> _hand = new List<Card>();
        public List<Card> Hand { get { return _hand; } set { _hand = value;  } }
        public int Wallet { get; set; }
        public string Name { get; set; }
        public bool IsActivelyPlaying { get; set; }
        public bool Stay { get; set; }

        public bool Bet(int amount)
        {
            if (Wallet - amount < 0)
            {
                Console.WriteLine("You do not have enough for a bet that big...");
                return false;
            } else
            {
                Wallet -= amount;
                return true;
            }
        }
        public static Game operator + (Game game, Player player)
        {
            game.Players.Add(player);
            return game;
        }

        public static Game operator - (Game game, Player player)
        {
            game.Players.Remove(player);
            return game;
        }
    }
}
