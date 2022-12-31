﻿namespace Durak.Game.Domain
{
    public static class Constants
    {
        public const int FullHandCount = 7;

        public static readonly IEnumerable<Card> Deck = new List<Card>
        {
            new(2, Suit.Club),
            new(3, Suit.Club),
            new(4, Suit.Club),
            new(5, Suit.Club),
            new(6, Suit.Club),
            new(7, Suit.Club),  
            new(8, Suit.Club),
            new(9, Suit.Club),  
            new(10, Suit.Club),
            new(11, Suit.Club),
            new(12, Suit.Club),
            new(13, Suit.Club),
            new(14, Suit.Club),
            new(2, Suit.Diamond),   
            new(3, Suit.Diamond),
            new(4, Suit.Diamond),
            new(5, Suit.Diamond),
            new(6, Suit.Diamond),   
            new(7, Suit.Diamond),
            new(8, Suit.Diamond),
            new(9, Suit.Diamond),
            new(10, Suit.Diamond),
            new(11, Suit.Diamond),
            new(12, Suit.Diamond),
            new(13, Suit.Diamond),
            new(14, Suit.Diamond),
            new(2, Suit.Heart),
            new(3, Suit.Heart),
            new(4, Suit.Heart),
            new(5, Suit.Heart),
            new(6, Suit.Heart),
            new(7, Suit.Heart),
            new(8, Suit.Heart),
            new(9, Suit.Heart),
            new(10, Suit.Heart),
            new(11, Suit.Heart),
            new(12, Suit.Heart),
            new(13, Suit.Heart),
            new(14, Suit.Heart),
            new(2, Suit.Spade),
            new(3, Suit.Spade),
            new(4, Suit.Spade),
            new(5, Suit.Spade),
            new(6, Suit.Spade),
            new(7, Suit.Spade),
            new(8, Suit.Spade),
            new(9, Suit.Spade),
            new(10, Suit.Spade),
            new(11, Suit.Spade),
            new(12, Suit.Spade),
            new(13, Suit.Spade),
            new(14, Suit.Spade),
        };
    }
}
