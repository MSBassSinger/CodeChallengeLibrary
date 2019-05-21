using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CodingChallengeLibrary;
using System.Collections.Generic;


namespace CodingChallengeLibraryTest
{

    /// <summary>
    /// 
    /// </summary>
    [TestClass]
    public class CardWorksTest
    {

        /// <summary>
        /// 
        /// </summary>
        [TestMethod]
        public void BuildCardsTest()
        {

            Cards testDeck = new Cards(false);

            Assert.IsTrue(testDeck.Count == 52);

            Assert.IsFalse(testDeck.HasJokers);

            testDeck.Clear();

            testDeck = null;

            testDeck = new Cards(true);

            Assert.IsTrue(testDeck.Count == 54);

            Assert.IsTrue(testDeck.HasJokers);

            testDeck.Clear();

            testDeck = null;

        }

        /// <summary>
        /// 
        /// </summary>
        [TestMethod]
        public void ShuffleTest()
        {

            Cards newDeck = new Cards(false);

            newDeck.Shuffle();

            Assert.IsTrue(newDeck[0].Rank != CardRankEnum.Ace);
        }

        /// <summary>
        /// 
        /// </summary>
        [TestMethod]
        public void SortTest()
        {

            Cards newDeck = new Cards(false);

            newDeck.Shuffle();

            newDeck.SortBySuitAndRank();

            Assert.IsTrue(newDeck[0].Rank == CardRankEnum.Ace);
            Assert.IsTrue(newDeck[0].Suit == CardSuitEnum.Hearts);

        }

        /// <summary>
        /// 
        /// </summary>
        [TestMethod]
        public void GetBySuitAndRankTest()
        {

            Cards newDeck = new Cards(false);

            newDeck.Shuffle();

            Card retVal = newDeck.GetBySuitAndRank(CardSuitEnum.Hearts, CardRankEnum.Eight);

            Assert.IsTrue(retVal.Rank == CardRankEnum.Eight);
            Assert.IsTrue(retVal.Suit == CardSuitEnum.Hearts);

            retVal = newDeck.GetBySuitAndRank(CardSuitEnum.Hearts, CardRankEnum.Joker1);

            Assert.IsTrue(retVal == null);
        }

        /// <summary>
        /// 
        /// </summary>
        [TestMethod]
        public void GetBySuitTest()
        {

            Cards newDeck = new Cards(false);

            newDeck.Shuffle();

            List<Card> retVal = newDeck.GetAllBySuit(CardSuitEnum.Hearts);

            Assert.IsTrue(retVal.Count == 13);

            retVal = newDeck.GetAllBySuit(CardSuitEnum.Jokers);

            Assert.IsTrue(retVal.Count == 0);
        }

        /// <summary>
        /// 
        /// </summary>
        [TestMethod]
        public void GetByRankTest()
        {

            Cards newDeck = new Cards(false);

            newDeck.Shuffle();

            List<Card> retVal = newDeck.GetAllByRank(CardRankEnum.Four);

            Assert.IsTrue(retVal.Count == 4);

            retVal = newDeck.GetAllByRank(CardRankEnum.Joker2);

            Assert.IsTrue(retVal.Count == 0);
        }




    }
}
