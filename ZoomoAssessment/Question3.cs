using System.Collections.Generic;
using System.Net;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ZoomoAssessment
{
    public static class Question3
    {
        /// <summary>
        /// Get all of the link tags from a specified html document.
        /// </summary>
        /// <param name="html">The html document</param>
        /// <returns></returns>
        /// <remarks>Assuming "link tags" means a/anchor tags.
        /// <para/>Using html from <a href="google.com.au"></a> to test</remarks>
        public static List<string> GetUrls(string html)
        {
            List<string> urls = new List<string>();

            var anchorRegex = new Regex(@"<a[^>]+href=\""(.*?)\""[^>]*>");
            var urlsFound = anchorRegex.Matches(html);

            foreach (Match match in urlsFound)
            {
                urls.Add(match.Groups[1].Value);
            }

            return urls;
        }

        public static object[] ValidateUrls(List<string> urlsToTest, string domain)
        {
            object[] results = new object[urlsToTest.Count];
            Parallel.For(0, urlsToTest.Count, index =>
            {
                object[] tmp = new object[2];

                tmp[0] = urlsToTest[index];
                tmp[1] = GetOkay(urlsToTest[index], domain);

                results[index] = tmp;
            });

            return results;
        }

        private static bool GetOkay(string uri, string domain)
        { 
            bool checkUrl(string url)
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                    return response.StatusCode == HttpStatusCode.OK;
            }

            try
            {
                var okay = checkUrl(uri);
                return okay;
            }
            catch (System.UriFormatException)
            {
                // in case the link is relative
                try
                {
                    var okay = checkUrl(domain + uri);
                    return okay;
                }
                // in case the link is a # navigational link
                catch (System.UriFormatException)
                {
                    if (uri.StartsWith("#"))
                    {
                        var okay = checkUrl(domain);
                        return okay;
                    }
                }
            }
            return false;
        }
    }
}
