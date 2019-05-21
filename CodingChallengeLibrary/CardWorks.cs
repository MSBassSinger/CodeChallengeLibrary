using System;
using System.Collections.Generic;
using System.Text;

namespace CodingChallengeLibrary
{

    public enum CardSuitEnum
    {
        Unknown = 0,
        Hearts = 1,
        Diamonds = 2, 
        Spades = 3,
        Clubs = 4,
        Jokers = 5
    }

    public enum CardRankEnum
    {
        Unknown = 0,
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
        Jack = 11, 
        Queen = 12, 
        King = 13,
        Joker1 = 14,
        Joker2 = 15
    }


    public class CardWorks
    {


        Boolean m_IncludeJokers = false;


        public CardWorks()
        {

        }

        public CardWorks(Boolean includeJokers)
        {
            m_IncludeJokers = includeJokers;
        }

        public Cards GetADeckOfCards()
        {
            Cards retVal = new Cards(m_IncludeJokers);

            return retVal;
        }

 
    }
}
