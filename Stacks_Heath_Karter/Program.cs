using System;
using System.Collections.Generic;

namespace Stacks_Heath_Karter
{
    // Card class to represent a playing card
    public class Card
    {
        // Properties with automatic getters
        public string Number { get; }
        public string Suit { get; }

        // Constructor with parameters number and suit
        public Card(string number, string suit)
        {
            Number = number;
            Suit = suit;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an array of Card objects (our starting cards)
            Card[] cards =
            {
                new Card("A", "Hearts"),
                new Card("2", "Clubs"),
                new Card("3", "Diamonds"),
                new Card("4", "Spades"),
                new Card("5", "Hearts"),
                new Card("6", "Clubs"),
                new Card("7", "Diamonds")
            };

            // Create a stack of Cards and add the array of cards to it
            Stack<Card> startingDeck = new Stack<Card>(cards);

            // Print the cards currently in the deck
            Console.WriteLine("Cards in the deck:");
            foreach (Card card in startingDeck)
            {
                Console.WriteLine($"The {card.Number} of {card.Suit}!");
            }

            // Print the number of cards in the deck
            Console.WriteLine($"Number of cards in the stack: {startingDeck.Count}");

            // Create a new list called myHand to hold cards
            List<Card> myHand = new List<Card>
            {
                new Card("8", "Spades"),
                new Card("9", "Hearts"),
                new Card("10", "Clubs")
            };

            // Print a message
            Console.WriteLine("Got any 8's?");

            // Pop a card from the deck and add it to myHand (if there are cards to pop)
            if (startingDeck.Count > 0)
            {
                Card poppedCard = startingDeck.Pop();
                myHand.Add(poppedCard);
            }

            // Print the number of cards after popping
            Console.WriteLine($"Number of cards in the stack after popping: {startingDeck.Count}");

            // Place one card from myHand back onto the stack
            if (myHand.Count > 0)
            {
                Card cardToReturn = myHand[0]; // choose the first card in myHand
                startingDeck.Push(cardToReturn); // push it onto the stack
                myHand.Remove(cardToReturn); // remove it from myHand
            }

            // Print the updated deck
            Console.WriteLine("Cards in the deck:");
            foreach (Card card in startingDeck)
            {
                Console.WriteLine($"The {card.Number} of {card.Suit}!");
            }
        }
    }
}
