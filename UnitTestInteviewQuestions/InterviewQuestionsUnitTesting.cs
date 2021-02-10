using Microsoft.VisualStudio.TestTools.UnitTesting;
using InterviewQuestions;
using System;

namespace UnitTestInteviewQuestions
{
    [TestClass]
    public class InterviewQuestionsUnitTesting
    {
        [TestMethod]
        public void TestReverseString()
        {
            SolutionsCollection sol = new SolutionsCollection();
            string TestString = "Lorem";
            string ReversedStringValue = "meroL";

            Assert.AreEqual(sol.ReverseString(TestString), ReversedStringValue);
        }

        [TestMethod]
        public void TestFindMinPositive()
        {
            SolutionsCollection sol = new SolutionsCollection();
            int MinPositive = 2;

            int[] ValuesToTest = new int[] { -1, -99, -98, -92, -97, -95, 1 };

            Assert.AreEqual(MinPositive, sol.FindMinPositive(ValuesToTest));
        }

        [TestMethod]
        public void TestCountFlipsWithStartingCharacter()
        {
            PerfectBinaryStringWithMinimumBitFlips MinBitFlipsTest = new PerfectBinaryStringWithMinimumBitFlips();
            string MinimumFlipStringTest = "0001010111";
            int MinimumFlipsExpected = 2;

            Assert.AreEqual(MinimumFlipsExpected, Math.Min(MinBitFlipsTest.CountFlipsWithStartingCharacter(MinimumFlipStringTest, '0')
                                                            , MinBitFlipsTest.CountFlipsWithStartingCharacter(MinimumFlipStringTest, '1')));
        }
    }
}
