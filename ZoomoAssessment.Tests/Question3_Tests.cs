using System.Collections.Generic;
using static ZoomoAssessment.Question3;
using NUnit.Framework;

namespace ZoomoAssessment.Tests
{
    [TestFixture]
    public class Question3_Tests
    {
        private static object[] urlResponses = new object[]
        {
            new object[] { "https://about.google/?fg=1&amp;utm_source=google-AU&amp;utm_medium=referral&amp;utm_campaign=hp-header", true },
            new object[] { "https://store.google.com/AU?utm_source=hp_header&amp;utm_medium=google_ooo&amp;utm_campaign=GS100042&amp;hl=en-AU",  true },
            new object[] { "https://mail.google.com/mail/&amp;ogbl",  true },
            new object[] { "https://www.google.com.au/imghp?hl=en&amp;ogbl" , true },
            new object[] { "https://www.google.com.au/intl/en/about/products",  true },
            new object[] { "https://accounts.google.com/ServiceLogin?hl=en&amp;passive=true&amp;continue=https://www.google.com.au/&amp;ec=GAZAmgQ",  true },
            new object[] { "#",  true },
            new object[] { "https://www.google.com.au/intl/en_au/ads/?subid=ww-ww-et-g-awa-a-g_hpafoot1_1!o2&amp;utm_source=google.com&amp;utm_medium=referral&amp;utm_campaign=google_hpafooter&amp;fg=1" , true },
            new object[] { "https://www.google.com.au/services/?subid=ww-ww-et-g-awa-a-g_hpbfoot1_1!o2&amp;utm_source=google.com&amp;utm_medium=referral&amp;utm_campaign=google_hpbfooter&amp;fg=1" , true },
            new object[] { "https://google.com/search/howsearchworks/?fg=1", true },
            new object[] { "https://policies.google.com/privacy?hl=en-AU&amp;fg=1" , true}, 
            new object[] { "https://policies.google.com/terms?hl=en-AU&amp;fg=1", true },
            new object[] { "https://www.google.com.au/preferences?hl=en-AU&amp;fg=1", true },
            new object[] { "/advanced_search?hl=en-AU&amp;fg=1" , true},
            new object[] { "/history/privacyadvisor/search/unauth?utm_source=googlemenu&amp;fg=1", true },
            new object[] { "/history/optout?hl=en-AU&amp;fg=1", true },
            new object[] { "https://support.google.com/websearch/?p=ws_results_help&amp;hl=en-AU&amp;fg=1", true}
        };

        [Test]
        // note: using js document.getElementsByTagName("a").length to calculate correct number of links
        public void GetUrls_CorrectNumberOfUrls()
        {
            string htmlToTest = Properties.Resources.html;

            Assert.AreEqual(17, GetUrls(htmlToTest).Count);
        }

        [Test]
        public void ValidateUrls_CorrectResponses()
        {
            List<string> urlsToTest = GetUrls(Properties.Resources.html);
            var result = ValidateUrls(urlsToTest, @"http://www.google.com.au");

            Assert.AreEqual(urlResponses, result);
        }
    }
}
