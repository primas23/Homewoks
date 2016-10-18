// <copyright file="XmlHelpers.cs" company="Primas">
//     Company copyright tag.
// </copyright>
namespace HelperLibrary
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Xml;
    using System.Xml.Linq;

    /// <summary>
    /// Helper for xml creating. The default path is ../../../catalogue.xml
    /// </summary>
    public class XmlHelpers
    {
        /// <summary>
        /// The catalogue
        /// </summary>
        private const string Catalogue = "catalogue";

        /// <summary>
        /// The album
        /// </summary>
        private const string Album = "album";

        /// <summary>
        /// The name
        /// </summary>
        private const string Name = "name";

        /// <summary>
        /// The artist
        /// </summary>
        private const string Artist = "artist";

        /// <summary>
        /// The year
        /// </summary>
        private const string Year = "year";

        /// <summary>
        /// The producer
        /// </summary>
        private const string Producer = "producer";

        /// <summary>
        /// The price
        /// </summary>
        private const string Price = "price";

        /// <summary>
        /// The songs
        /// </summary>
        private const string Songs = "songs";

        /// <summary>
        /// The song
        /// </summary>
        private const string Song = "song";

        /// <summary>
        /// The title
        /// </summary>
        private const string Title = "title";

        /// <summary>
        /// The duration
        /// </summary>
        private const string Duration = "duration";

        /// <summary>
        /// The path.
        /// </summary>
        private string _path = "/";

        /// <summary>
        /// Initializes a new instance of the <see cref="XmlHelpers"/> class.
        /// </summary>
        /// <param name="path">The path.</param>
        public XmlHelpers(string path)
        {
            this._path = path;
        }

        /// <summary>
        /// Prints the numbers of albums for each artist.
        /// </summary>
        /// <param name="root">The root.</param>
        public static void PrintNumbersOfAlbumsForEachArtist(XmlElement root)
        {
            var artists = new Hashtable();

            foreach (XmlElement album in root.ChildNodes)
            {
                if (artists.ContainsKey(album[Artist].InnerText))
                {
                    (artists[album[Artist].InnerText] as List<string>).Add(album[Name].InnerText);
                }
                else
                {
                    artists.Add(album[Artist].InnerText, new List<string> { album[Name].InnerText });
                }
            }

            foreach (var key in artists.Keys)
            {
                Console.WriteLine(string.Format("Artist: {0} " + Environment.NewLine + "Number of albums: {1}", key, (artists[key] as List<string>).Count));
            }

            PrintSeparator();
        }

        /// <summary>
        /// Prints the artists number of albums using x path.
        /// </summary>
        /// <param name="root">The root.</param>
        public static void PrintArtistsNumberOfAlbumsUsingXPath(XmlNode root)
        {
            var artistsAndNumberOfAlbums = new Hashtable();
            var albums = root.SelectNodes(Album);

            foreach (XmlElement album in albums)
            {
                if (artistsAndNumberOfAlbums.ContainsKey(album[Artist].InnerText))
                {
                    (artistsAndNumberOfAlbums[album[Artist].InnerText] as List<string>).Add(album[Name].InnerText);
                }
                else
                {
                    artistsAndNumberOfAlbums.Add(album[Artist].InnerText, new List<string> { album[Name].InnerText });
                }
            }

            foreach (var key in artistsAndNumberOfAlbums.Keys)
            {
                Console.WriteLine(string.Format("Artist:{0} " + Environment.NewLine + "Number of albums: {1}", key, (artistsAndNumberOfAlbums[key] as List<string>).Count));
            }

            PrintSeparator();
        }

        /// <summary>
        /// Extracts the song titles from catalogue.
        /// </summary>
        /// <param name="pathToCatalogue">The path to catalogue.</param>
        /// <returns></returns>
        public static IList<string> ExtractSongTitlesFromCatalogue(string pathToCatalogue)
        {
            var songTitles = new List<string>();

            using (XmlReader reader = XmlReader.Create(pathToCatalogue))
            {
                while (reader.Read())
                {
                    if (reader.NodeType == XmlNodeType.Element && reader.Name == Title)
                    {
                        songTitles.Add(reader.ReadElementString().Trim());
                    }
                }
            }

            return songTitles;
        }

        /// <summary>
        /// Deletes the albums by price.
        /// </summary>
        /// <param name="root">The root.</param>
        /// <param name="minPrice">The minimum price.</param>
        public static void DeleteAlbumsByPrice(XmlNode root, double minPrice)
        {
            bool deletePrevious = false;

            foreach (XmlElement album in root.ChildNodes)
            {
                if (deletePrevious)
                {
                    root.RemoveChild(album.PreviousSibling);
                    deletePrevious = false;
                }

                if (double.Parse(album[Price].InnerText) > minPrice)
                {
                    Console.WriteLine(string.Format("{0} deleted!", album[Name].InnerText));
                    deletePrevious = true;
                }
            }

            if (deletePrevious)
            {
                root.RemoveChild(root.LastChild);
            }
        }

        /// <summary>
        /// Prints the separator.
        /// </summary>
        public static void PrintSeparator()
        {
            Console.WriteLine(new string('-', 100));
        }

        /// <summary>
        /// Creates the Catalog. This is the first task in the homework.
        /// </summary>
        public void CreateCatalogue()
        {
            XDocument doc = new XDocument(
                                        new XElement(Catalogue,
                                           new XElement(Album,
                                               new XElement(Name, "A Thousand Suns"),
                                               new XElement(Artist, "Linkin Park"),
                                               new XElement(Year, "2010"),
                                               new XElement(Producer, "Mike Shinoda"),
                                               new XElement(Price, "7"),
                                               new XElement(Songs,
                                                new XElement(Song,
                                                    new XElement(Title, "The Requiem"),
                                                    new XElement(Duration, "2:01")),
                                               new XElement(Song,
                                                    new XElement(Title, "Burning in the Skies"),
                                                    new XElement(Duration, "4:13")),
                                                new XElement(Song,
                                                    new XElement(Title, "When They Come for Me"),
                                                    new XElement(Duration, "4:55")),
                                                new XElement(Song,
                                                    new XElement(Title, "Robot Boy"),
                                                    new XElement(Duration, "4:28")),
                                                new XElement(Song,
                                                    new XElement(Title, "Waiting for the End"),
                                                    new XElement(Duration, "3:51")),
                                                new XElement(Song,
                                                    new XElement(Title, "Blackout"),
                                                    new XElement(Duration, "4:39")),
                                                new XElement(Song,
                                                    new XElement(Title, "Iridescent"),
                                                    new XElement(Duration, "4:56")),
                                                new XElement(Song,
                                                    new XElement(Title, "The Catalyst"),
                                                    new XElement(Duration, "5:39")),
                                                new XElement(Song,
                                                    new XElement(Title, "The Messenger"),
                                                    new XElement(Duration, "3:01")))),
                                            new XElement(Album,
                                                new XElement(Name, "Meteora"),
                                                new XElement(Artist, "Linkin Park"),
                                                new XElement(Year, "2010"),
                                                new XElement(Producer, "Don Gilmore"),
                                                new XElement(Price, "15"),
                                                new XElement(Songs,
                                                new XElement(Song,
                                                    new XElement(Title, "Don\'t Stay"),
                                                    new XElement(Duration, "3:07")),
                                                new XElement(Song,
                                                    new XElement(Title, "Somewhere I Belong"),
                                                    new XElement(Duration, "3:33")),
                                                new XElement(Song,
                                                    new XElement(Title, "Lying From You"),
                                                    new XElement(Duration, "2:55")),
                                                new XElement(Song,
                                                    new XElement(Title, "Hit the Floor"),
                                                    new XElement(Duration, "2:44")),
                                                new XElement(Song,
                                                    new XElement(Title, "Breaking the Habit"),
                                                    new XElement(Duration, "3:16")),
                                                new XElement(Song,
                                                    new XElement(Title, "From the Inside"),
                                                    new XElement(Duration, "2:55")),
                                                new XElement(Song,
                                                    new XElement(Title, "Numb"),
                                                    new XElement(Duration, "3:07")))),
                                            new XElement(Album,
                                                new XElement(Name, "Hybrid Theory"),
                                                new XElement(Artist, "Linkin Park"),
                                                new XElement(Year, "2010"),
                                                new XElement(Producer, "Don Gilmore"),
                                                new XElement(Price, "19"),
                                                new XElement(Songs,
                                                new XElement(Song,
                                                    new XElement(Title, "Papercut"),
                                                    new XElement(Duration, "3:04")),
                                                new XElement(Song,
                                                    new XElement(Title, "One Step Closer"),
                                                    new XElement(Duration, "2:35")),
                                                new XElement(Song,
                                                    new XElement(Title, "With You"),
                                                    new XElement(Duration, "3:23")),
                                                new XElement(Song,
                                                    new XElement(Title, "Crawling"),
                                                    new XElement(Duration, "3:29")),
                                                new XElement(Song,
                                                    new XElement(Title, "In the End"),
                                                    new XElement(Duration, "3:36")),
                                                new XElement(Song,
                                                    new XElement(Title, "A Place for My Head"),
                                                    new XElement(Duration, "3:04"))))));

            doc.Save(this._path);
        }
    }
}
