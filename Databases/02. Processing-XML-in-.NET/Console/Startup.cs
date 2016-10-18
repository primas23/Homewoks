// <copyright file="Startup.cs" company="Primas Entertainment">
//     Company copyright tag.
// </copyright>

using System.Collections;

namespace Console
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Xml;
    using System.Xml.Linq;

    using HelperLibrary;

    /// <summary>
    /// The XML Processing in .NET homework
    /// </summary>
    public class Startup
    {
        /// <summary>
        /// The path. When the code is executed from Visual Studio it will map the solution directory.
        /// </summary>
        private static string _path = "../../../catalogue.xml";

        /// <summary>
        /// The entry point of the programm.
        /// </summary>
        /// <param name="args">The arguments.</param>
        public static void Main(string[] args)
        {
            // Task 01
            XmlHelpers xml = new XmlHelpers(_path);
            xml.CreateCatalogue();

            // Task 02
            // Write program that extracts all different artists which are found in the catalog.xml.
            // For each author you should print the number of albums in the catalogue.
            // Use the DOM parser and a hash - table.
            XmlDocument document = new XmlDocument();
            document.Load(_path);
            XmlHelpers.PrintNumbersOfAlbumsForEachArtist(document.DocumentElement);

            // Task 03
            // Implement the previous using XPath.
            XmlHelpers.PrintArtistsNumberOfAlbumsUsingXPath(document.DocumentElement);

            // Task 04
            // Using the DOM parser write a program to delete from catalog.xml all albums having price > 20.
            XmlHelpers.DeleteAlbumsByPrice(document.DocumentElement, 20.0);

            // Task 05
            // Write a program, which using XmlReader extracts all song titles from catalog.xml.
            IList<string> songTitles = XmlHelpers.ExtractSongTitlesFromCatalogue(_path);
            Console.WriteLine("Titles: " + string.Join(", ", songTitles));
            XmlHelpers.PrintSeparator();

            // Task 06
            // Rewrite the same using XDocument and LINQ query.
            XDocument doc = XDocument.Load(_path);
            IEnumerable<string> songTitlesUsingLinq = from songs 
                                                      in doc.Descendants("title")
                                                      select songs.Value.Trim();

            Console.WriteLine("Titles: " + string.Join(", ", songTitlesUsingLinq));
            XmlHelpers.PrintSeparator();
        }
    }
}
