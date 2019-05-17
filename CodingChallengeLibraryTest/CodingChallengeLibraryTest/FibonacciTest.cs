using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CodingChallengeLibrary;
using System.Collections.Generic;

namespace CodingChallengeLibraryTest
{
    [TestClass]
    public class FibonacciTest
    {
        [TestMethod]
        public void LoopingDefaultTest()
        {
            try
            {
                Fibonacci fib = new Fibonacci();
                List<Int32> retVal = fib.GetSequenceByLooping(10);

                Assert.IsTrue(retVal[retVal.Count - 1] <= 10);
            }
            catch (Exception exUnhandled)
            {
                Assert.Fail(exUnhandled.Message);
            }
        }  // END public void LoopingDefaultTest()

        [TestMethod]
        public void LoopingSeededTest()
        {
            try
            {
                Fibonacci fib = new Fibonacci(192, 16);
                List<Int32> retVal = fib.GetSequenceByLooping(1000);

                Assert.IsTrue(retVal[retVal.Count - 1] <= 1000);
            }
            catch (Exception exUnhandled)
            {
                Assert.Fail(exUnhandled.Message);
            }
        }  // END public void LoopingDefaultTest()

        [TestMethod]
        public void SumOfSquaresDefaultTest()
        {
            try
            {
                Fibonacci fib = new Fibonacci();
                Int32 retVal = fib.SumOfSquares(64);

                Assert.IsTrue(retVal == 1870);
            }
            catch (Exception exUnhandled)
            {
                Assert.Fail(exUnhandled.Message);
            }
        }  // END public void LoopingDefaultTest()



    }
}
