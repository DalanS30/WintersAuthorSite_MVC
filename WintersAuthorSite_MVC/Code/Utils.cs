using System;
using System.Collections.Generic;
using System.Xml.XPath;

namespace WintersAuthorSite_MVC
{
    public static class Utils
    {
        private const string PublicationsXML = @"https://raw.githubusercontent.com/DalanS30/WintersAuthorSite_MVC/master/XML-Data/Publications.xml";
        private const string ImagesXML = @"https://raw.githubusercontent.com/DalanS30/WintersAuthorSite_MVC/master/XML-Data/Images.xml";

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
