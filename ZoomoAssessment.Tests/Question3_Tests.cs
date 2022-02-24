using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ZoomoAssessment.Question3;
using NUnit.Framework;
using System.IO;

namespace ZoomoAssessment.Tests
{
    [TestFixture]
    public class Question3_Tests
    {
        private static object[] urlResponses = new object[]
        {
            new object[] { "url", true },
        };

        [Test]
        // note: using js document.getElementsByTagName("a").length to calculate correct number of links
        public void GetUrls_CorrectNumberOfUrls()
        {
            string htmlToTest = Properties.Resources.html;

            Assert.AreEqual(438, GetUrls(htmlToTest).Length);
        }

        [Test]
        public void ValidateUrls_CorrectResponses()
        {
            string[] urlsToTest = GetUrls(Properties.Resources.html);

            Assert.AreEqual(urlResponses, ValidateUrls(urlsToTest));
        }
    }
}
