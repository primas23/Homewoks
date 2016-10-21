// <copyright file="Startup.cs" company="Primas Entertainment">
//     Company copyright tag.
// </copyright>
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

            // Task 07
            // In a text file we are given the name, address and phone number of given person (each at a single line).
            // Write a program, which creates new XML document, which contains these data in structured XML format.
            XmlHelpers.CreateXmlPhonebook();

            // Task 08
            // Write a program, which (using XmlReader and XmlWriter) reads the file catalog.xml and creates the file album.xml, in 
            // which stores in appropriate way the names of all albums and their authors.
            XmlHelpers.CreateAlbumsXml();

            // Task 09
            // Write a program to traverse given directory and write to a XML file its contents together with all subdirectories and files.
            // Use tags <file> and <dir> with appropriate attributes.
            // For the generation of the XML document use the class XmlWriter.
            XmlHelpers.CreateFileXml();

            // Task 10
            // Rewrite the last exercises using XDocument, XElement and XAttribute.
            XDocument documentA = new XDocument();
            documentA.Add(XmlHelpers.CreateFileSystemXmlTree("../../../ "));
            documentA.Save("../../../traverseWithXElement.xml");

            // Task 11
            // Write a program, which extract from the file catalog.xml the prices for all albums, published 5 years ago or earlier.
            XmlDocument documentEleven = new XmlDocument();
            documentEleven.Load("../../../catalogue.xml");
            var docRoot = documentEleven.DocumentElement;
            var oldAlbumsPrices = docRoot.SelectNodes("album/price[../year/text() < 2011]");

            for (int i = 0; i < oldAlbumsPrices.Count; i++)
            {
                var element = oldAlbumsPrices[i];
                Console.WriteLine(element.InnerText);
            }

            // Task 12
            // Rewrite the previous using LINQ query.
            XDocument documentXX = XDocument.Load("../../../catalogue.xml");

            var oldAlbumsPricesUsingLinq = from album in documentXX.Descendants("album")
                                           where int.Parse(album.Element("year").Value) < 2011
                                           select album.Descendants("price").FirstOrDefault();
            foreach (var price in oldAlbumsPricesUsingLinq)
            {
                Console.WriteLine(price.Value.Trim());
            }

        }
    }
}
