using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using ZoomoAssessment;

namespace ZoomoAssessment.Tests
{
    [TestFixture]
    public class Question1
    {
        [Test]
        public void isNullorEmpty_Null_ReturnsTrue()
        {
            Assert.AreEqual(isNullorEmpty(null), true);
        }

        [Test]
        public void isNullorEmpty_ContainsCharacter_ReturnsFalse()
        {
            Assert.AreEqual(isNullorEmpty("a"), false);
        }

        [Test]
        public void isNullorEmpty_Empty_ReturnsTrue()
        {
            Assert.AreEqual(isNullorEmpty(""), true);
        }

        [Test]
        public void isNullorEmpty_NullLiteral_ReturnsFalse()
        {
            Assert.AreEqual(isNullorEmpty("null"), false);
        }
    }
}
