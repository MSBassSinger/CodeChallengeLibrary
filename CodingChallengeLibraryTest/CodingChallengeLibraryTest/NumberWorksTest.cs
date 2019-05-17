using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CodingChallengeLibrary;
using System.Collections.Generic;

namespace CodingChallengeLibraryTest
{
    [TestClass]
    public class NumberWorksTest
    {
        [TestMethod]
        public void FibonacciLoopingDefaultTest()
        {
            try
            {
                NumberWorks fib = new NumberWorks();
                List<Int32> retVal = fib.GetFibonacciSequenceByLooping(10, 0, 1);

                Assert.IsTrue(retVal[retVal.Count - 1] <= 10);
            }
            catch (Exception exUnhandled)
            {
                Assert.Fail(exUnhandled.Message);
            }
        }  // END public void FibonacciLoopingDefaultTest()

        [TestMethod]
        public void FibonacciLoopingSeededTest()
        {
            try
            {
                NumberWorks fib = new NumberWorks();
                List<Int32> retVal = fib.GetFibonacciSequenceByLooping(1000, 192, 16);

                Assert.IsTrue(retVal[retVal.Count - 1] <= 1000);
            }
            catch (Exception exUnhandled)
            {
                Assert.Fail(exUnhandled.Message);
            }
        }  // END public void FibonacciLoopingDefaultTest()

        [TestMethod]
        public void FibonacciSumOfSquaresDefaultTest()
        {
            try
            {
                NumberWorks fib = new NumberWorks();
                Int32 retVal = fib.FibonacciSumOfSquares(64, 0, 1);

                Assert.IsTrue(retVal == 1870);
            }
            catch (Exception exUnhandled)
            {
                Assert.Fail(exUnhandled.Message);
            }
        }  // END public void FibonacciSumOfSquaresDefaultTest()

        [TestMethod]
        public void SumOfSquaresTest()
        {
            try
            {
                NumberWorks nw = new NumberWorks();
                Int32 retVal = nw.SumOfSquares(3);

                Assert.IsTrue(retVal == 14);
            }
            catch (Exception exUnhandled)
            {
                Assert.Fail(exUnhandled.Message);
            }
        }  // END public void SumOfSquaresTest()

        [TestMethod]
        public void SumOfSquaresInRectangleTest()
        {
            try
            {
                NumberWorks nw = new NumberWorks();
                Int32 retVal = nw.SumOfSquaresInRectangle(4, 3);

                Assert.IsTrue(retVal == 20);
            }
            catch (Exception exUnhandled)
            {
                Assert.Fail(exUnhandled.Message);
            }
        }  // END public void SumOfSquaresInRectangleTest()

    }
}
