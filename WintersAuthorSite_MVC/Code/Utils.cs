using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.XPath;

namespace WintersAuthorSite_MVC
{
    public static class Utils
    {
        private static string PublicationsXML = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot//data//Publications.xml");
        private static string ImagesXML = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot//data//Images.xml");

        public static string GetImageBase64(string imageName)
        {
            XPathDocument xDoc = new XPathDocument(ImagesXML);
            XPathNavigator xNav = xDoc.CreateNavigator();
            return xNav.SelectSingleNode($"/Images/Image[@name='{imageName}']").Value;
        }

        public static List<Publication> GetPublications()
        {
            List<Publication> pubList = new List<Publication>();
            XPathDocument xDoc = new XPathDocument(PublicationsXML);
            XPathNavigator xNav = xDoc.CreateNavigator();
            XPathNodeIterator nodeIterator = xNav.Select($"/Publications/Publication");
            while (nodeIterator.MoveNext())
            {
                pubList.Add(new Publication
                {
                    Title = nodeIterator.Current.SelectSingleNode("title").Value,
                    Date = DateTime.Parse(nodeIterator.Current.SelectSingleNode("date").Value),
                    Publisher = nodeIterator.Current.SelectSingleNode("publisher").Value,
                    Snippet = nodeIterator.Current.SelectSingleNode("snippet").Value,
                    Link = nodeIterator.Current.SelectSingleNode("link").Value,
                    ImageName = nodeIterator.Current.SelectSingleNode("image").Value
                });
            }
            return pubList;
        }
    }
}
