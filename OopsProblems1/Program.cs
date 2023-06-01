using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsProblems1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] suits = { "Clubs", "Diamonds", "Hearts", "Spades" };
            string[] ranks = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace" };

            // Create a deck of cards
            List<string> deck = new List<string>();
            foreach (string suit in suits)
            {
                foreach (string rank in ranks)
                {
                    deck.Add(rank + " of " + suit);
                }
            }

            // Shuffle the cards using Random method
            Random random = new Random();
            for (int i = deck.Count - 1; i > 0; i--)
            {
                int j = random.Next(i + 1);
                string temp = deck[i];
                deck[i] = deck[j];
                deck[j] = temp;
            }

            // Distribute 9 cards to 4 players
            string[,] players = new string[4, 9];
            int currentPlayer = 0;
            int currentCard = 0;

            foreach (string card in deck)
            {
                players[currentPlayer, currentCard] = card;
                currentCard++;

                if (currentCard == 9)
                {
                    currentPlayer++;
                    currentCard = 0;
                }

                if (currentPlayer == 4)
                {
                    break;
                }
            }

            // Print the cards received by each player
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Player " + (i + 1) + " cards:");
                for (int j = 0; j < 9; j++)
                {
                    Console.WriteLine(players[i, j]);
                }
                Console.WriteLine();

            }
            
        }
    }
}
