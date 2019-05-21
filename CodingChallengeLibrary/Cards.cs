using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingChallengeLibrary
{
    /// <summary>
    /// 
    /// </summary>
    public class Cards : List<Card>
    {

        /// <summary>
        /// 
        /// </summary>
        private Boolean m_IncludeJokers = false;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="includeJokers"></param>
        public Cards(Boolean includeJokers) : base()
        {
            m_IncludeJokers = includeJokers;

            if (includeJokers)
            {
                this.Add(new Card(CardRankEnum.Joker1, CardSuitEnum.Jokers));
                this.Add(new Card(CardRankEnum.Joker2, CardSuitEnum.Jokers));
            }

            for (CardSuitEnum suit = CardSuitEnum.Hearts; suit < CardSuitEnum.Jokers; suit++)
            {

                for (CardRankEnum rank = CardRankEnum.Ace; rank < CardRankEnum.Joker1; rank++)
                {

                    Card newCard = new Card(rank, suit);
                    this.Add(newCard);

                }
            }

        }

        /// <summary>
        /// 
        /// </summary>
        public Boolean HasJokers
        {
            get
            {
                return m_IncludeJokers;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Shuffle()
        {

            if (this.Count > 1)
            {
                Random rndm = new Random(Environment.TickCount);

                for (Int32 ordinal = this.Count - 1; ordinal > 0; --ordinal)
                {

                    Int32 randomOne = rndm.Next(ordinal + 1);
                    Card tempCard = this[ordinal];
                    this[ordinal] = this[randomOne];
                    this[randomOne] = tempCard;
                }
            }

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="directionAscending"></param>
        public void SortBySuitAndRank(Boolean directionAscending = true)
        {
            Int32 result = 0;

            if (directionAscending)
            {
                this.Sort((x, y) =>
                {
                    result = x.Suit.CompareTo(y.Suit);

                    if (result == 0)
                    {
                        result = x.Rank.CompareTo(y.Rank);
                    }
                    return result;
                });
            }
            else
            {
                this.Sort((x, y) =>
                {
                    result = y.Suit.CompareTo(x.Suit);

                    if (result == 0)
                    {
                        result = y.Rank.CompareTo(x.Rank);
                    }
                    return result;
                });
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="suit"></param>
        /// <param name="rank"></param>
        /// <returns></returns>
        public Card GetBySuitAndRank(CardSuitEnum suit, CardRankEnum rank)
        {

            Card retVal = this.Find(x => x.Rank == rank && x.Suit == suit);

            return retVal;

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="rank"></param>
        /// <returns></returns>
        public List<Card> GetAllByRank(CardRankEnum rank)
        {

            List<Card> retVal = this.FindAll(x => x.Rank == rank);

            if (retVal != null)
            {
                retVal.Sort((x, y) =>
                {
                    return x.Suit.CompareTo(y.Suit);
                });
            }


            if (retVal == null)
            {
                retVal = new List<Card>();
            }

            return retVal;

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="suit"></param>
        /// <returns></returns>
        public List<Card> GetAllBySuit(CardSuitEnum suit)
        {

            List<Card> retVal = this.FindAll(x => x.Suit == suit);

            if (retVal != null)
            {
                retVal.Sort((x, y) =>
                {
                    return x.Rank.CompareTo(y.Rank);

                });
            }

            if (retVal == null)
            {
                retVal = new List<Card>();
            }

            return retVal;

        }


    }
}
