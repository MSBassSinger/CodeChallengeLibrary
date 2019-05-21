using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;


namespace CodingChallengeLibrary
{

    // http://csharphelper.com/blog/2017/03/make-basis-card-game-c/

    public class Card
    {

        private CardRankEnum m_Rank = CardRankEnum.Ace;
        private CardSuitEnum m_Suit = CardSuitEnum.Unknown;
        private Image m_SuitImage = null;

        public Card(CardRankEnum rank, CardSuitEnum suit)
        {

            m_Rank = rank;
            m_Suit = suit;
        }

        public CardRankEnum Rank
        {
            get
            {
                return m_Rank;
            }
            set
            {
                m_Rank = value;
            }
        }

        public CardSuitEnum Suit
        {
            get
            {
                return m_Suit;
            }
            set
            {
                m_Suit = value;
            }
        }

        public Image SuitImage
        {
            get
            {
                switch (m_Suit)
                {
                    case CardSuitEnum.Clubs:
                        m_SuitImage = Bitmap.FromFile("club.png");
                        break;
                    case CardSuitEnum.Diamonds:
                        m_SuitImage = Bitmap.FromFile("diamond.jpg");
                        break;
                    case CardSuitEnum.Hearts:
                        m_SuitImage = Bitmap.FromFile("heart.jpg");
                        break;
                    case CardSuitEnum.Spades:
                        m_SuitImage = Bitmap.FromFile("spade.jpg");
                        break;
                    default:
                        m_SuitImage = null;
                        break;
                }


                return m_SuitImage;
            }
        }



    }
}
