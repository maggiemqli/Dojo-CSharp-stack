using System;
using System.Collections.Generic;

namespace DeckOfCards
{
    public class Card {
        public string stringVal; // stores (Ace, 2, 3, 4, 5, 6, 7, 8, 9, 10, Jack, Queen, King)
        public string suit; // stores (Clubs, Spades, Hearts, Diamonds)
        public int val; // stores (numerical value of the card 1-13 )

        public Card(string strval, string suitval, int numval){
            stringVal = strval;
            suit = suitval;
            val = numval;
        }

        public override string ToString(){
            return stringVal + "of" + suit;
        }
    } // end of class Card.

    public class Deck {
        private List<Card> cards;

        public Deck CreateDeck(){
            cards = new List<Card>();
            string[] stringvals = {"Ace", "1", "2", "3", "4", "5", "6", "7", "8", "9", "Jack", "Queen", "King"};
            string[] suits = {"Clubs", "Spades", "Hearts", "Diamonds"};
            Dictionary<string, string> newDeck = new Dictionary<string,string>();
            for(int i = 0 ; i < suits.Length; i++){
                for(int j = 0 ; i < stringvals.Length; j++){
                    newDeck.Add(suits[i], stringvals[j]);
                }
            }
            return newDeck; 
            // string stv_temp = "";
            // string suit_temp = "";
            // int val_temp = 0;

            // for (int i = 0 ; i < 4; i++){
            //     suit_temp = suits[i];
            //         stv_temp = stringvals[j];
            //         val_temp = j;
            //         Card new_card = new Card(stv_temp, suit_temp, val_temp);
            //         cards.Add(new_card);
            //     }
            // }
        }

        public Card Deal(){
            if(cards.Count > 0){
                Card deal = cards[0]; 
                cards.RemovrAt(0);
                return deal;
            }
            return null;
        }

        public Deck Reset(){
            // cards = new List<Card>();
            CreateDeck();
            return this;
        }

        public Deck Shuffle(){
            Random rand = new Random();
            // 1. choose a "random number" in the range of "cards.Count" as "randIdx". 
            // 2. swap the card in the "cards" list on the index of "randIdx" with the card on the index of "random number".
            for (int idx = cards.Count - 1; idx > 0; idx--){
                int randIdx = rand.Next(idx);
                Card temp = cards[randIdx];
                cards[randIdx] = cards[idx];
                cards[idx] = temp; 
            }
            return this;
        }

        public override string ToString(){
            string info = "";
            foreach(Card card in cards){
                info += card + "\n";
            }
            return info;
        }
    } // end of class Deck. 

    public class Player {
        public string name;
        private List<Card> hand;

        public Player(string n){
            hand = new List<Card>();
            name = n;
        }

        public void Draw(Deck currentDeck){
            // var drawCard = currentDeck.cards[0];
            // hand.Add(drawCard);
            // currentDeck.cards.Remove(drawCard);
            // return drawCard;
            hand.Add(currentDeck.Deal()); // because Deal() returns the cards[0]. No need to duplicate the function. 
        }

        public Card Discard(int idx){
            Card temp = hand[idx];
            hand.RemoveAt(idx);
            return temp;
        }

        public void SeeHand(){
            foreach (var card in hand){
                Console.WriteLine(card);
            }
        }
    } // end of class Player.
    

    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Deck myDeck = new Deck();
            Player player1 = new Player("M");
            Console.WriteLine(myDeck);
        }
    }


}
