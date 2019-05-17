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
    /// This can be calculated using recursion or by looping.  A looping
    /// example is shown here.
    /// </summary>
    public class Fibonacci
    {
        private Int32 m_Seed0 = 0;
        private Int32 m_Seed1 = 1;

        public Fibonacci()
        {

        }

        public Fibonacci(Int32 seed0, Int32 seed1)
        {
            m_Seed0 = seed0;
            m_Seed1 = seed1;
        }

        public List<Int32> GetSequenceByLooping(Int32 maxSeed)
        {

            List<Int32> retVal = null;

            Int32 maxOrigSeed = 0;

            Int32 currentSeedValue = m_Seed1;
            Int32 currentIndex = 1;


            try
            {
                maxOrigSeed = Math.Max(m_Seed0, m_Seed1);

                if (maxSeed < maxOrigSeed)
                {
                    throw new ArgumentException($"The maximum seed number, [{maxSeed.ToString()}] is less than the highest seed value [{maxOrigSeed.ToString()}].");
                }

                retVal = new List<Int32>
                {
                    m_Seed0,
                    m_Seed1
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
                exUnhandled.Data.Add("Seed 0", m_Seed0.ToString());
                exUnhandled.Data.Add("Seed 1", m_Seed0.ToString());
                exUnhandled.Data.Add("maxSeed", maxSeed.ToString());

                throw;
            }

            return retVal;

        }  // END public List<Int32> GetSequenceByLooping(Int32 maxSeed)

 
        public Int32 SumOfSquares(Int32 maxSeed)
        {

            Int32 retVal = 0;
            List<Int32> sequence = null;

            try
            {

                sequence = GetSequenceByLooping(maxSeed);

                retVal = (sequence[0] * sequence[0]) + (sequence[1] * sequence[1]);

                for (int i = 2; i < sequence.Count -1 ; i++)
                {
                    retVal += sequence[i] * sequence[i];
                }

            }
            catch (Exception exUnhandled)
            {
                exUnhandled.Data.Add("Seed 0", m_Seed0.ToString());
                exUnhandled.Data.Add("Seed 1", m_Seed0.ToString());
                exUnhandled.Data.Add("maxSeed", maxSeed.ToString());

                throw;
            }

            return retVal;

        }  // END public Int32 SumOfSquares(Int32 maxSeed)




    }  // END public class Fibonacci

}  // END namespace CodingChallengeLibrary
