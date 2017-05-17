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
using System.Data.SqlClient;

namespace NyaaAnalyse
{
    public partial class Form1 : Form
    {
        private HtmlAgilityPack.HtmlDocument HtmlDoc = new HtmlAgilityPack.HtmlDocument();

        public Form1()
        {
            InitializeComponent();
            // SqlConnection c = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\m10\Documents\Nyaa.mdf;Integrated Security=True;Connect Timeout=30");
            SqlConnection c = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\cdj68\Desktop\PEPlugin-Git\bin\Debug\Nyaa.mdf;Integrated Security=True;Connect Timeout=30");
            HtmlDoc.LoadHtml(Resource1.Html);
            c.Open();
            SqlCommand Cmd = new SqlCommand();
            Cmd.Connection = c;
            Cmd.CommandType = CommandType.Text;
            Cmd.CommandText = "delete from torrent";
            Cmd.ExecuteScalar();
            /* Cmd.CommandText = "create table torrent(CLass varchar(100),title varchar(100),ImageSrc char(100),Address varchar(100),Name varchar(100),Torrent char(100),Magnet varchar(1024),Size varchar(100),Time char(100),Up varchar(100),Leeches varchar(100),Complete char(100))";
             Cmd.ExecuteScalar();*/
            HtmlNodeCollection hrefs2 = HtmlDoc.DocumentNode.SelectNodes(@" / html[1] / body[1] / div[1] / div[2] / table[1] / tbody[1] / tr");
            foreach (var item in hrefs2)
            {
                var temp = HtmlNode.CreateNode(item.OuterHtml);
                var Class = item.Attributes["class"].Value;
                var title = temp.SelectSingleNode(@"//a[1]").Attributes["title"].Value;
                var Imgsrc = temp.SelectSingleNode("//img").Attributes["src"].Value;
                var Address = HtmlNode.CreateNode(temp.SelectSingleNode(@"//td[2]").InnerHtml).SelectSingleNode("//a[1]").Attributes["href"].Value;
                var name = temp.SelectSingleNode(@"//td[2]").InnerText;
                var Torrent = HtmlNode.CreateNode(temp.SelectSingleNode(@"//td[3]").InnerHtml).SelectSingleNode("//a[1]").Attributes["href"].Value;
                var Magnet = "";
                if (Torrent.StartsWith("magnet"))
                {
                    Magnet = Torrent;
                    Torrent = "";
                }
                else
                {
                    Magnet = HtmlNode.CreateNode(temp.SelectSingleNode(@"//td[3]").InnerHtml).SelectSingleNode("//a[2]").Attributes["href"].Value;
                }
                var Size = temp.SelectSingleNode(@"//td[4]").InnerHtml;
                var Time = temp.SelectSingleNode(@"//td[5]").InnerHtml;
                var Up = temp.SelectSingleNode(@"//td[6]").InnerHtml;
                var Leeches = temp.SelectSingleNode(@"//td[7]").InnerHtml;
                var Complete = temp.SelectSingleNode(@"//td[8]").InnerHtml;
                var TB = new StringBuilder();
                TB.Append(@"insert into torrent(CLass,title,ImageSrc,Address,Name,Torrent,Magnet,Size,Time,Up,Leeches,Complete) values(");
                /*  TB.Append("'");
                  TB.Append(Class);
                  TB.Append("',");

                  TB.Append("'");
                  TB.Append(title);
                  TB.Append("',");

                  TB.Append("'");
                  TB.Append(Imgsrc);
                  TB.Append("',");

                  TB.Append("'");
                  TB.Append(Address);
                  TB.Append("',");

                  TB.Append("'");
                  TB.Append(name);
                  TB.Append("',");

                  TB.Append("'");
                  TB.Append(Torrent);
                  TB.Append("',");

                  TB.Append("'");
                  TB.Append(Magnet);
                  TB.Append("',");

                  TB.Append("'");
                  TB.Append(Size);
                  TB.Append("',");

                  TB.Append("'");
                  TB.Append(Time);
                  TB.Append("',");

                  TB.Append("'");
                  TB.Append(Up);
                  TB.Append("',");

                  TB.Append("'");
                  TB.Append(Leeches);
                  TB.Append("',");

                  TB.Append("'");
                  TB.Append(Complete);
                  TB.Append("')");*/

                TB.Append("'");
                TB.Append(Class);
                TB.Append("',");

                TB.Append("'");
                TB.Append(title);
                TB.Append("',");

                TB.Append("'");
                TB.Append(Imgsrc);
                TB.Append("',");

                TB.Append("'");
                TB.Append(Address);
                TB.Append("',");

                TB.Append("N\'"+name+"\',");

                TB.Append("'");
                TB.Append(Torrent);
                TB.Append("',");

                TB.Append("'");
                TB.Append(Magnet);
                TB.Append("',");



                TB.Append("'");
                TB.Append(Size);
                TB.Append("',");

                TB.Append("'");
                TB.Append(Time);
                TB.Append("',");


                TB.Append("'");
                TB.Append(Up);
                TB.Append("',");

                TB.Append("'");
                TB.Append(Leeches);
                TB.Append("',");

                TB.Append("'");
                TB.Append(Complete);
                TB.Append("')");
                Cmd.CommandText = TB.ToString();
                Cmd.ExecuteNonQuery();

            }
            c.Close();
            url = "https://sukebei.nyaa.si/";
            // go();
        }

        private string url;

        private async void go()
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