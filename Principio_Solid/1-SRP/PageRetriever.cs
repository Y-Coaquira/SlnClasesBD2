using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;
using System.IO;
using System.Net;

namespace Principio_Solid._1_SRP
{
    class PageRetriever
    {
        internal HtmlDocument GetPage()
        {
            var req = (HttpWebRequest)WebRequest.Create("http://www.kinetica-solutions.com/");

            HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
            HtmlDocument doc = new HtmlDocument();

            var resultStream = resp.GetResponseStream();
            doc.Load(resultStream);

            return doc;
        }

        public byte[] GetImage(string url)
        {
            byte[] imageBytes;
            HttpWebRequest imageRequest = (HttpWebRequest)WebRequest.Create(url);
            WebResponse imageResponse = imageRequest.GetResponse();

            Console.WriteLine("downloading image");

            Stream responseStream = imageResponse.GetResponseStream();

            using (BinaryReader br = new BinaryReader(responseStream))
            {
                imageBytes = br.ReadBytes((int)imageResponse.ContentLength);
                br.Close();
            }
            responseStream.Close();
            imageResponse.Close();

            return imageBytes;
        }
    }
}
