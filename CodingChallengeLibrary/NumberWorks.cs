using System;
using System.Collections.Generic;

namespace CodingChallengeLibrary
{
    /// <summary>
    /// A Fibonacci sequence is an sequence of numbers, where 0 and 1 are the first
    /// two numbers (though others could be used), and the sequence thereafter where X is the ordinal position, 
    /// the next in the sequence is the sum of the (X-1) and (X-2) positions.
    /// 
    /// For example:
    /// Ordinal Position - 0  1  2  3  4  5  6  7  8  9
    /// X                - 0  1  2  3  4  5  6  7  8  9
    /// Fibonacci #      - 0  1  1  2  3  5  8  13 21 34
    /// 
    /// This can be calculated using recursion [O log(n)] or by looping [O(n)].  
    /// A looping example is shown here.
    /// </summary>
    public class NumberWorks
    {

        public NumberWorks()
        {

        }

         public List<Int32> GetFibonacciSequenceByLooping(Int32 maxSeed, Int32 seed0, Int32 seed1)
        {

            List<Int32> retVal = null;

            Int32 maxOrigSeed = 0;

            Int32 currentSeedValue = seed1;
            Int32 currentIndex = 1;


            try
            {
                maxOrigSeed = Math.Max(seed0, seed1);

                if (maxSeed < maxOrigSeed)
                {
                    throw new ArgumentException($"The maximum seed number, [{maxSeed.ToString()}] is less than the highest seed value [{maxOrigSeed.ToString()}].");
                }

                retVal = new List<Int32>
                {
                    seed0,
                    seed1
                };

                do
                {
                    currentSeedValue = retVal[currentIndex] + retVal[currentIndex - 1];

                    if (currentSeedValue > maxSeed)
                    {
                        break;
                    }

                    retVal.Add(currentSeedValue);
                    currentIndex += 1;
                }
                while (currentSeedValue <= maxSeed);

            }
            catch (Exception exUnhandled)
            {
                exUnhandled.Data.Add("Seed 0", seed0.ToString());
                exUnhandled.Data.Add("Seed 1", seed1.ToString());
                exUnhandled.Data.Add("maxSeed", maxSeed.ToString());

                throw;
            }

            return retVal;

        }  // END public List<Int32> GetFibonacciSequenceByLooping(Int32 maxSeed, Int32 seed0, Int32 seed1)


        public Int32 FibonacciSumOfSquares(Int32 maxSeed, Int32 seed0, Int32 seed1)
        {

            Int32 retVal = 0;
            List<Int32> sequence = null;

            try
            {

                sequence = GetFibonacciSequenceByLooping(maxSeed, seed0, seed1);

                retVal = (sequence[0] * sequence[0]) + (sequence[1] * sequence[1]);

                for (int i = 2; i < sequence.Count -1 ; i++)
                {
                    retVal += sequence[i] * sequence[i];
                }

            }
            catch (Exception exUnhandled)
            {
                exUnhandled.Data.Add("Seed 0", seed0.ToString());
                exUnhandled.Data.Add("Seed 1", seed1.ToString());
                exUnhandled.Data.Add("maxSeed", maxSeed.ToString());

                throw;
            }

            return retVal;

        }  // END public Int32 FibonacciSumOfSquares(Int32 maxSeed, Int32 seed0, Int32 seed1)

        public Int32 SumOfSquares(Int32 numSides)
        {

            Int32 retVal = 0;

            try
            {

                retVal = (numSides * (numSides + 1) * ((2 * numSides) + 1) / 6);

            }
            catch (Exception exUnhandled)
            {
                exUnhandled.Data.Add("numSides", numSides.ToString());

                throw;
            }

            return retVal;

        }  // END public Int32 SumOfSquares(Int32 numSides)


        public Int32 SumOfSquaresInRectangle(Int32 numVerticalSides, Int32 numHorizontalSides)
        {

            Int32 retVal = 0;

            Int32 leastSides = 0;

            Int32 mostSides = 0;

            try
            {
                if (numVerticalSides == numHorizontalSides)
                {
                    leastSides = numVerticalSides;
                    mostSides = numVerticalSides;
                }
                else
                {
                    leastSides = Math.Min(numVerticalSides, numHorizontalSides);

                    mostSides = Math.Max(numVerticalSides, numHorizontalSides);
                }

                retVal = (((leastSides * (leastSides + 1) * ((2 * leastSides) + 1))/ 6) + 
                         ((mostSides - leastSides) * leastSides * (leastSides + 1)) / 2);

            }
            catch (Exception exUnhandled)
            {
                exUnhandled.Data.Add("numVerticalSides", numVerticalSides.ToString());
                exUnhandled.Data.Add("numHorizontalSides", numHorizontalSides.ToString());

                throw;
            }

            return retVal;

        }  // END public Int32 SumOfSquares(Int32 numSides)


    }  // END public class NumberWorks

}  // END namespace CodingChallengeLibrary
