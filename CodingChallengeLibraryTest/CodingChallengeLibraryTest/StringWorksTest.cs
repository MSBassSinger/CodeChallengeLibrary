using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CodingChallengeLibrary;
using System.Collections.Generic;


namespace CodingChallengeLibraryTest
{
    [TestClass]
    public class StringWorksTest
    {

        [TestMethod]
        public void ReverseWordTest()
        {
            try
            {
                StringWorks sw = new StringWorks();
                String retVal = sw.ReverseString("my dog has fleas");

                Assert.IsTrue(retVal.Equals("saelf sah god ym", StringComparison.CurrentCulture));
            }
            catch (Exception exUnhandled)
            {
                Assert.Fail(exUnhandled.Message);
            }
        }  // END public void ReverseWordltTest()


        [TestMethod]
        public void GetOnlyDigitsTest()
        {

            try
            {
                StringWorks sw = new StringWorks();
                String retVal = sw.GetOnlyDigits("ABC 123*D9");

                Assert.IsTrue(retVal.Equals("1239", StringComparison.CurrentCulture));
            }
            catch (Exception exUnhandled)
            {
                Assert.Fail(exUnhandled.Message);
            }
        }  // END public void IsOnlyDigitsTest()

        [TestMethod]
        public void GetOnlyLettersTest()
        {

            try
            {
                StringWorks sw = new StringWorks();
                String retVal = sw.GetOnlyLetters("ABC 123*D9");

                Assert.IsTrue(retVal.Equals("ABCD", StringComparison.CurrentCulture));
            }
            catch (Exception exUnhandled)
            {
                Assert.Fail(exUnhandled.Message);
            }
        }  // END public void GetOnlyLettersTest()

        [TestMethod]
        public void GetOnlyLettersAndDigitsTest()
        {

            try
            {
                StringWorks sw = new StringWorks();
                String retVal = sw.GetOnlyLettersAndDigits("ABC 123*D9");

                Assert.IsTrue(retVal.Equals("ABC123D9", StringComparison.CurrentCulture));
            }
            catch (Exception exUnhandled)
            {
                Assert.Fail(exUnhandled.Message);
            }
        }  // END public void GetOnlyLettersAndDigitsTest()

        [TestMethod]
        public void IsEmailFormatTest()
        {

            try
            {
                StringWorks sw = new StringWorks();
                Boolean retVal = sw.IsEmailFormat("JJones@mailbox.com");

                Assert.IsTrue(retVal);

                retVal = sw.IsEmailFormat("JJones.mailbox.com");

                Assert.IsFalse(retVal);

            }
            catch (Exception exUnhandled)
            {
                Assert.Fail(exUnhandled.Message);
            }
        }  // END public void IsEmailFormatTest()

        [TestMethod]
        public void IsOnlyDigitsTest()
        {

            try

            {
                StringWorks sw = new StringWorks();
                Boolean retVal = sw.IsOnlyDigits("1234567890");

                Assert.IsTrue(retVal);

                retVal = sw.IsOnlyDigits("ABC 123*D9");

                Assert.IsFalse(retVal);
            }
            catch (Exception exUnhandled)
            {
                Assert.Fail(exUnhandled.Message);
            }
        }  // END public void IsOnlyDigitsTest()

        [TestMethod]
        public void IsOnlyLettersTest()
        {

            try

            {
                StringWorks sw = new StringWorks();
                Boolean retVal = sw.IsOnlyLetters("aBcDeFgH");

                Assert.IsTrue(retVal);

                retVal = sw.IsOnlyLetters("ABC 123*D9");

                Assert.IsFalse(retVal);
            }
            catch (Exception exUnhandled)
            {
                Assert.Fail(exUnhandled.Message);
            }
        }  // END public void IsOnlyLettersTest()

        [TestMethod]
        public void IsOnlyLettersAndOrDigits()
        {

            try

            {
                StringWorks sw = new StringWorks();
                Boolean retVal = sw.IsOnlyLettersAndOrDigits("a0Bc9DeF7gH");

                Assert.IsTrue(retVal);

                retVal = sw.IsOnlyLettersAndOrDigits("ABC 123*D9");

                Assert.IsFalse(retVal);
            }
            catch (Exception exUnhandled)
            {
                Assert.Fail(exUnhandled.Message);
            }
        }  // END public void IsOnlyLettersTest()

    }  // END public class StringWorksTest
}
