using NUnit.Framework;
using static ZoomoAssessment.Question2;

namespace ZoomoAssessment.Tests
{
    [TestFixture]
    public class Question2_Tests
    {
        [Test]
        public void calculateTriangleArea_ValidCase()
        { 
            Assert.AreEqual(6, calculateTriangleArea(new int[] { 3, 4, 5 }));
        }

        [Test]
        public void calculateTriangleArea_InvalidInput_ThrowsException()
        {
            Assert.Throws<InvalidTriangleException>(() => calculateTriangleArea(new int[] { 1, 2, -3 }));
        }
        
        [Test]
        public void calculateTriangleArea_InvalidSideLengths_ThrowsException()
        {
            Assert.Throws<InvalidTriangleException>(() => calculateTriangleArea(new int[] { 1, 2, 6 }));
        }
        
    }
}
