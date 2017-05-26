using System;
using System.Text;
using System.Linq;

public class Deck
{
    //Basic playing card Deck, has 52 Cards
	public Deck()
	{
        //Deck Contains 52 Cards
        var Card = new Card();
	}

    public enum Suit
    {
        Spades,
        Hearts,
        Clubs,
        Diamonds,
    }

    public enum Number: int
    {
        Ace = 1,
        Two = 2,
        Three = 3,
        Four = 4,
        Five = 5,
        Six = 6,
        Seven = 7,
        Eight = 8,
        Nine = 9,
        Ten = 10,
        Jack = 11;
        Queen = 12;
        King = 13;
    }

    public 
}
