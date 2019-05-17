using System;
using System.Collections.Generic;
using System.Text;

namespace CodingChallengeLibrary
{
    public class StringWorks
    {


        public String ReverseString(String word2Reverse)
        {

            String retVal = "";

            try
            {

                if (word2Reverse.Length > 0)
                {
                    if (word2Reverse.Length == 1)
                    {
                        retVal = word2Reverse;
                    }
                    else
                    {
                        for (int i = word2Reverse.Length; i --> 0; )
                        {
                            retVal += word2Reverse[i];
                        }

                    }
                }
                
            }
            catch (Exception exUnhandled)
            {
                exUnhandled.Data.Add("word2Reverse", (word2Reverse ?? "NULL"));

                throw;
            }

            return retVal;

        }  // END public String ReverseString(String word2Reverse)

        /// <summary>
        /// This process checks for all characters being digits.  Conversion
        /// functions to test numbers may translate letters as Hex values.
        /// </summary>
        /// <param name="testString"></param>
        /// <returns>True if the string is only digits, False if not.</returns>
        public Boolean IsOnlyDigits(String testString)
        {


            Boolean retValue = true;

            try
            {
                // remove white spaces 
                testString = testString.Trim();

                if ((testString.Length == 0))
                {
                    retValue = false;
                }

                // We have a string with no spaces.

                if ((retValue))
                {
                    // Loop through the string, checking each character.
                    for (Int32 index = 0; index <= testString.Length - 1; index++)
                    {
                        if ((char.IsDigit(testString[index]) == false))
                        {
                            retValue = false;
                            break;
                        }

                    }

                }

            }
            catch (Exception exUnhandled)
            {
                exUnhandled.Data.Add("testString", testString ?? "NULL");

                throw;

            }

            return retValue;
        }  // END public Boolean IsOnlyDigits(String testString)

        /// <summary>
        /// This process gets all digits in a string
        /// </summary>
        /// <param name="testString"></param>
        /// <returns>String of digits.</returns>
        public String GetOnlyDigits(String testString)
        {


            String retValue = "";


            try
            {
                // remove white spaces 
                testString = testString ?? "";

                testString = testString.Trim();


                if ((testString.Length == 0))
                {
                    retValue = "";
                }
                else
                {
                    // Loop through the string, checking each character.
                    for (Int32 index = 0; index <= testString.Length - 1; index++)
                    {
                        if ((char.IsDigit(testString[index]) == true))
                        {
                            retValue += testString[index];
                        }

                    }

                }

            }
            catch (Exception exUnhandled)
            {
                exUnhandled.Data.Add("testString", testString ?? "NULL");

                throw;

            }

            return retValue;
        }  // END public String GetOnlyDigits(String testString)

        /// <summary>
        /// This process gets all letters in a string
        /// </summary>
        /// <param name="testString"></param>
        /// <returns>String of digits.</returns>
        public String GetOnlyLetters(String testString)
        {

            String retValue = "";

            try
            {
                // remove white spaces 
                testString = testString ?? "";

                testString = testString.Trim();


                if ((testString.Length == 0))
                {
                    retValue = "";
                }
                else
                {
                    // Loop through the string, checking each character.
                    for (Int32 index = 0; index <= testString.Length - 1; index++)
                    {
                        if ((char.IsLetter(testString[index]) == true))
                        {
                            retValue += testString[index];
                        }

                    }

                }

            }
            catch (Exception exUnhandled)
            {
                exUnhandled.Data.Add("testString", testString ?? "NULL");

                throw;

            }

            return retValue;
        }  // END public String GetOnlyLetters(String testString)


        /// <summary>
        /// This process gets all letters and digits in a string
        /// </summary>
        /// <param name="testString"></param>
        /// <returns>String of digits.</returns>
        public String GetOnlyLettersAndDigits(String testString)
        {

            String retValue = "";

            try
            {
                // remove white spaces 
                testString = testString ?? "";

                testString = testString.Trim();

                if ((testString.Length == 0))
                {
                    retValue = "";
                }
                else
                {
                    // Loop through the string, checking each character.
                    for (Int32 index = 0; index <= testString.Length - 1; index++)
                    {
                        if ((char.IsLetterOrDigit(testString[index]) == true))
                        {
                            retValue += testString[index];
                        }

                    }

                }

            }
            catch (Exception exUnhandled)
            {
                exUnhandled.Data.Add("testString", testString ?? "NULL");

                throw;

            }

            return retValue;
        }  // END public String GetOnlyLettersAndDigits(String testString)


        /// <summary>
        /// This process checks for all characters being letters.
        /// </summary>
        /// <param name="testString"></param>
        /// <returns>True if the string is only letters, False if not.</returns>
        public Boolean IsOnlyLetters(String testString)
        {

            Boolean retValue = true;

            try
            {
                //'remove white spaces 
                testString = testString.Trim();


                if ((testString.Length == 0))
                {
                    retValue = false;
                }

                // We have a string with no spaces.

                if ((retValue))
                {
                    //' Loop through the string, checking each character.
                    for (Int32 index = 0; index <= testString.Length - 1; index++)
                    {
                        if ((char.IsLetter(testString[index]) == false))
                        {
                            retValue = false;
                            break;
                        }

                    }

                }

            }
            catch (Exception exUnhandled)
            {
                exUnhandled.Data.Add("testString", testString ?? "NULL");

                throw;

            }

            return retValue;
        }  // END public Boolean IsOnlyLetters(String testString)

        /// <summary>
        /// This process checks for all characters being only letters and numbers.
        /// </summary>
        /// <param name="testString"></param>
        /// <returns>True if the string is only letters, False if not.</returns>
        public Boolean IsOnlyLettersAndOrDigits(String testString)
        {

            Boolean retValue = true;

            try
            {
                // remove white spaces 
                testString = testString.Trim();


                if ((testString.Length == 0))
                {
                    retValue = false;
                }

                // We have a string with no spaces.

                if ((retValue))
                {
                    // Loop through the string, checking each character.
                    for (Int32 index = 0; index <= testString.Length - 1; index++)
                    {
                        if ((char.IsLetterOrDigit(testString[index]) == false))
                        {
                            retValue = false;
                            break;
                        }

                    }

                }

            }
            catch (Exception exUnhandled)
            {
                exUnhandled.Data.Add("testString", testString ?? "NULL");

                throw;

            }

            return retValue;
        }  // END public Boolean IsOnlyLettersAndOrDigits(String testString)

        /// <summary>
        /// This extension for the String object checks the string to see if it is a valid email format.
        /// it does not check whether it is a valid, working email.
        /// </summary>
        /// <param name="email">The email address to test</param>
        /// <returns>True if formatted correctly, False if not.</returns>
        public Boolean IsEmailFormat(String email)
        {

            Boolean retValue = false;

            System.Net.Mail.MailAddress mailAddress = null;


            try
            {
                if (((email != null)))
                {
                    if ((email.Contains("@")))
                    {
                        if ((!email.Contains(" ")))
                        {
                            mailAddress = new System.Net.Mail.MailAddress(email);
                            retValue = true;
                        }
                        else
                        {
                            retValue = false;
                        }
                    }
                    else
                    {
                        retValue = false;
                    }
                }
                else
                {
                    email = "";
                    retValue = true;
                }

            }
            catch (FormatException exFormat)
            {
                // I hate using exceptions as a part of normal flow, but this object
                // does not have a TryParse() option
                retValue = false;

            }
            catch (Exception exUnhandled)
            {
                exUnhandled.Data.Add("email", email ?? "NULL");

                throw;

            }
            finally
            {
                mailAddress = null;
            }

            return retValue;

        }  // END public Boolean IsEmailFormat(String email)

    }  // END public class StringWorks

}  // END namespace CodingChallengeLibrary
