using System;

namespace BlackJack
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Casino Royale. Tell us who you are.");
            string playerName = Console.ReadLine();
            Console.WriteLine("How much cash you planning on dropping today?");
            int wallet = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hey, {0}, wanna take a seat at a blackjack table?", playerName);
            string answer = Console.ReadLine().ToLower();
            if (answer == "yes" || answer == "ya" || answer == "y" || answer == "yeah")
            {
                Player player = new Player(playerName, wallet);
                Game game = new BlackJackGame();
                game += player;
                player.IsActivelyPlaying = true;
                while (player.IsActivelyPlaying == true && player.Wallet > 0)
                {
                    game.Play();
                }
                game -= player;
                Console.WriteLine("Thank you, come again.");
            }
            Console.WriteLine("... Now get out of my casino!");
            Console.ReadKey();
        }
    }
}
