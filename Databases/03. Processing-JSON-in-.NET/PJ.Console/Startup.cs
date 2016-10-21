namespace PJ.Console
{
    using System;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Xml.Linq;

    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Startup
    {
        private const string TelrikRssUrl = "https://www.youtube.com/feeds/videos.xml?channel_id=UCLC-vbm7OWvpbqzXaoAMGGw";
        private const string RssFile = "../../../rss.xml";

        public static void Main()
        {
            WebClient webclient = new WebClient();
            webclient.DownloadFile(TelrikRssUrl, RssFile);

            XDocument rss = XDocument.Load(RssFile);
            string jsonFromXml = JsonConvert.SerializeXNode(rss, Formatting.Indented);

            var jsonObj = JObject.Parse(jsonFromXml);
            var titles = jsonObj["feed"]["entry"].Select(entry => entry["title"]);

            System.Console.WriteLine(string.Join(Environment.NewLine, titles));

            var template = new { id = string.Empty, title = string.Empty, published = string.Empty };
            var videos = jsonObj["feed"]["entry"].Select(video => JsonConvert.DeserializeAnonymousType(video.ToString(), template));
            using (var htmlCreator = new StreamWriter("../../../videos.html"))
            {
                htmlCreator.Write("<html><head><title>Videos from Telerik RSS</title><meta charset=\"UTF-8\"></head><body>");

                foreach (var video in videos)
                {
                    htmlCreator.WriteLine(
                        "<div style=\"display: inline-block;\"><iframe width=600 height=500 src=\"https://www.youtube.com/embed/"
                        + video.id.Substring(video.id.LastIndexOf(":") + 1) + "\"></iframe><br />"
                        + "<a href=\"https://youtube/"+ video.id.Substring(video.id.LastIndexOf(":") + 1) + "\" target=\"_blank\">" + video.title + "</a></div>");
                }

                htmlCreator.Write("</body></html>");
            }
        }
    }
}
