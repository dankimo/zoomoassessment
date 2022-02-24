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
        [Test]
        getUrls_CorrectNumberOfUrls()
        {
            string htmlToTest = Properties.Resources.html;

            Assert.AreEqual(123, getUrls(htmlToTest).Length);
        }

        [Test]
        validateUrls_CorrectResponses()
        {
            string[] urlsToTest = getUrls(Properties.Resources.html);

            Assert.AreEqual(urlResponses, )
        }
    }
}
