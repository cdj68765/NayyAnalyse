using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;
using CloudFlareUtilities;
using System.Net.Http;
using System.IO;
using System.Net;
using System.Runtime.Serialization.Formatters.Binary;

namespace NyaaAnalyse
{
    public partial class Form1 : Form
    {


        HtmlAgilityPack.HtmlDocument HtmlDoc = new HtmlAgilityPack.HtmlDocument();
        public Form1()
        {
            InitializeComponent();
            HtmlDoc.LoadHtml(Resource1.Html);
            HtmlNodeCollection hrefs2 = HtmlDoc.DocumentNode.SelectNodes(@" / html[1] / body[1] / div[1] / div[2] / table[1] / tbody[1] / tr");
            foreach (var item in hrefs2)
            {
                var temp = HtmlNode.CreateNode(item.OuterHtml);
                var td = temp.SelectNodes(@"//td");
                var title = temp.SelectSingleNode(@"//a[1]").Attributes["title"].Value;
                var Imgsrc = temp.SelectSingleNode("//img").Attributes["src"].Value;
                var Adress = HtmlNode.CreateNode(temp.SelectSingleNode(@"//td[2]").InnerHtml).SelectSingleNode("//a[1]").Attributes["href"].Value;
                var name = temp.SelectSingleNode(@"//td[2]").InnerText;
                var Torrent = HtmlNode.CreateNode(temp.SelectSingleNode(@"//td[3]").InnerHtml).SelectSingleNode("//a[1]").Attributes["href"].Value;
                if (Torrent.StartsWith("magnet"))
                {
                    var Magnet = Torrent;
                    Torrent = "";
                }
                else
                {
                    var Magnet = HtmlNode.CreateNode(temp.SelectSingleNode(@"//td[3]").InnerHtml).SelectSingleNode("//a[2]").Attributes["href"].Value;
                }
                var Size = temp.SelectSingleNode(@"//td[4]").InnerHtml;
                var Time = temp.SelectSingleNode(@"//td[5]").InnerHtml;
                var Up = temp.SelectSingleNode(@"//td[6]").InnerHtml;
                var Leeches = temp.SelectSingleNode(@"//td[7]").InnerHtml;
                var Complete = temp.SelectSingleNode(@"//td[8]").InnerHtml;
            }
            url = "https://sukebei.nyaa.si/";
            // go();

        }
        string url;
        async void go()
        {
            try
            {
                ClearanceHandler handler = new ClearanceHandler();
                var cookies = ReadCookiesFromDisk(@"Cookies");
                if (cookies != null)
                {
                    foreach (var item in cookies.GetCookies(new Uri("https://sukebei.nyaa.si/")).Cast<Cookie>().ToList())
                    {
                        handler._cookies.Add(item);
                    } 
                }
                HttpClient client = new HttpClient(handler);
                var content = await client.GetStringAsync(url);
                HtmlDoc.LoadHtml(content);
                WriteCookiesToDisk("Cookies", handler._cookies);
                HtmlNodeCollection hrefs2 = HtmlDoc.DocumentNode.SelectNodes(@" / html[1] / body[1] / div[1] / div[2] / table[1] / tbody[1] / tr");
                foreach (var item in hrefs2)
                {
                    var temp = HtmlNode.CreateNode(item.OuterHtml);
                    var td = temp.SelectNodes(@"//td");
                    var title = temp.SelectSingleNode(@"//a[1]").Attributes["title"].Value;
                    var Imgsrc = temp.SelectSingleNode("//img").Attributes["src"].Value;
                    var Adress = HtmlNode.CreateNode(temp.SelectSingleNode(@"//td[2]").InnerHtml).SelectSingleNode("//a[1]").Attributes["href"].Value;
                    var name = temp.SelectSingleNode(@"//td[2]").InnerText;
                    var Torrent = HtmlNode.CreateNode(temp.SelectSingleNode(@"//td[3]").InnerHtml).SelectSingleNode("//a[1]").Attributes["href"].Value;
                    var Magnet = HtmlNode.CreateNode(temp.SelectSingleNode(@"//td[3]").InnerHtml).SelectSingleNode("//a[2]").Attributes["href"].Value;
                    var Size = temp.SelectSingleNode(@"//td[4]").InnerHtml;
                    var Time = temp.SelectSingleNode(@"//td[5]").InnerHtml;
                    var Up = temp.SelectSingleNode(@"//td[6]").InnerHtml;
                    var Leeches = temp.SelectSingleNode(@"//td[7]").InnerHtml;
                    var Complete = temp.SelectSingleNode(@"//td[8]").InnerHtml;
                }
                url = "https://sukebei.nyaa.si/?p=2";
                go();
            }
            catch (Exception)
            {
            }
        }
        public static void WriteCookiesToDisk(string file, CookieContainer cookieJar)
        {
            using (Stream stream = File.Create(file))
            {
                try
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(stream, cookieJar);

                }
                catch (Exception)
                {
                }
            }
        }

        public static CookieContainer ReadCookiesFromDisk(string file)
        {
            try
            {
                using (Stream stream = File.Open(file, FileMode.Open))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    return (CookieContainer)formatter.Deserialize(stream);
                }
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
