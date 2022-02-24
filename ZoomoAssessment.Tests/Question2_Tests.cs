using NUnit.Framework;
using System;
using static ZoomoAssessment.Question2;

namespace ZoomoAssessment.Tests
{
    [TestFixture]
    public class Question2_Tests
    {
        [TestCaseSource(nameof(Question2Cases)]
        public void calculateTriangleArea_RandomSideLengths(int[] testCase)
        {
            int a, b, c;
            a = testCase[0];
            b = testCase[1];
            c = testCase[2];
            var expectedOutcome = 0.25 * Math.Sqrt( (a + b + c) * (-a + b + c) * (a - b + c) * (a + b - c) );

            Assert.AreEqual(expectedOutcome, calculateTriangleArea(testCase));
        }

        [Test]
        public void calculateTriangleArea_InvalidInput_ThrowsException()
        {

        }


        static int[][] Question2Cases =
        {
        };

        // set up the question 2 test cases using random numbers
        static Question2_Tests()
        {
            Random rnd = new Random();
            for (int i = 0; i < 5; i++)
            {
                int[] tmpArray = new int[3];
                for (int j = 0; j < 3; j++)
                {
                    tmpArray[i] = rnd.Next();
                }
            }
        }
        
    }
}
