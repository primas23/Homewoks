using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace Console
{
    public class Program
    {
        public static void Main(string[] args)
        {
            XDocument doc = new XDocument(
                                        new XElement("catalogue",
                                           new XElement("album",
                                               new XElement("name", "A Thousand Suns"),
                                               new XElement("artist", "Linkin Park"),
                                               new XElement("year", "2010"),
                                               new XElement("producer", "Mike Shinoda"),
                                               new XElement("price", "priceless"),
                                               new XElement("songs",
                                                new XElement("song",
                                                    new XElement("title", "The Requiem"),
                                                    new XElement("duration", "2:01")),
                                               new XElement("song",
                                                    new XElement("title", "Burning in the Skies"),
                                                    new XElement("duration", "4:13")),
                                                new XElement("song",
                                                    new XElement("title", "When They Come for Me"),
                                                    new XElement("duration", "4:55")),
                                                new XElement("song",
                                                    new XElement("title", "Robot Boy"),
                                                    new XElement("duration", "4:28")),
                                                new XElement("song",
                                                    new XElement("title", "Waiting for the End"),
                                                    new XElement("duration", "3:51")),
                                                new XElement("song",
                                                    new XElement("title", "Blackout"),
                                                    new XElement("duration", "4:39")),
                                                new XElement("song",
                                                    new XElement("title", "Iridescent"),
                                                    new XElement("duration", "4:56")),
                                                new XElement("song",
                                                    new XElement("title", "The Catalyst"),
                                                    new XElement("duration", "5:39")),
                                                new XElement("song",
                                                    new XElement("title", "The Messenger"),
                                                    new XElement("duration", "3:01")))),

                                            new XElement("album",
                                                new XElement("name", "Meteora"),
                                                new XElement("artist", "Linkin Park"),
                                                new XElement("year", "2010"),
                                                new XElement("producer", "Don Gilmore"),
                                                new XElement("price", "priceless"),
                                                new XElement("songs",
                                                new XElement("song",
                                                    new XElement("title", "Don\'t Stay"),
                                                    new XElement("duration", "3:07")),
                                                new XElement("song",
                                                    new XElement("title", "Somewhere I Belong"),
                                                    new XElement("duration", "3:33")),
                                                new XElement("song",
                                                    new XElement("title", "Lying From You"),
                                                    new XElement("duration", "2:55")),
                                                new XElement("song",
                                                    new XElement("title", "Hit the Floor"),
                                                    new XElement("duration", "2:44")),
                                                new XElement("song",
                                                    new XElement("title", "Breaking the Habit"),
                                                    new XElement("duration", "3:16")),
                                                new XElement("song",
                                                    new XElement("title", "From the Inside"),
                                                    new XElement("duration", "2:55")),
                                                new XElement("song",
                                                    new XElement("title", "Numb"),
                                                    new XElement("duration", "3:07")))),

                                            new XElement("album",
                                                new XElement("name", "Hybrid Theory"),
                                                new XElement("artist", "Linkin Park"),
                                                new XElement("year", "2010"),
                                                new XElement("producer", "Don Gilmore"),
                                                new XElement("price", "priceless"),
                                                new XElement("songs",
                                                new XElement("song",
                                                    new XElement("title", "Papercut"),
                                                    new XElement("duration", "3:04")),
                                                new XElement("song",
                                                    new XElement("title", "One Step Closer"),
                                                    new XElement("duration", "2:35")),
                                                new XElement("song",
                                                    new XElement("title", "With You"),
                                                    new XElement("duration", "3:23")),
                                                new XElement("song",
                                                    new XElement("title", "Crawling"),
                                                    new XElement("duration", "3:29")),
                                                new XElement("song",
                                                    new XElement("title", "In the End"),
                                                    new XElement("duration", "3:36")),
                                                new XElement("song",
                                                    new XElement("title", "A Place for My Head"),
                                                    new XElement("duration", "3:04"))))));

            doc.Save("../../../catalogue.xml");
        }
    }
}
