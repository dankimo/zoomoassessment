using NUnit.Framework;
using static ZoomoAssessment.Question1;

namespace ZoomoAssessment.Tests
{
    [TestFixture]
    public class Question1_Tests
    {
        [Test]
        public void isNullorEmpty_Null_ReturnsTrue()
        {
            Assert.AreEqual(true, isNullorEmpty(null));
        }

        [Test]
        public void isNullorEmpty_ContainsCharacter_ReturnsFalse()
        {
            Assert.AreEqual(false, isNullorEmpty("a"));
        }

        [Test]
        public void isNullorEmpty_Empty_ReturnsTrue()
        {
            Assert.AreEqual(true, isNullorEmpty(""), );
        }

        [Test]
        public void isNullorEmpty_NullLiteral_ReturnsFalse()
        {
            Assert.AreEqual(false, isNullorEmpty("null"), );
        }
    }
}
