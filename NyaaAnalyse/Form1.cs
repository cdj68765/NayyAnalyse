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
//using System.Data.SqlClient;
using System.Data.SQLite;
using System.Diagnostics;

namespace NyaaAnalyse
{
    public partial class Form1 : DarkUI.Forms.DarkForm
    {
        private HtmlAgilityPack.HtmlDocument HtmlDoc = new HtmlAgilityPack.HtmlDocument();
        const string DeleTable = "DROP  TABLE  NyaaDB";//删除表;
        public Form1()
        {
            InitializeComponent();
            SearchcomboBox.SelectedIndex=0;
            #region 初始化数据库，建立表单
            SQLiteConnection connection = null;
            SQLiteCommand command = null;
            if (!new FileInfo(@".\Nyaa").Exists)
            {
                SQLiteConnection.CreateFile("Nyaa");
                connection = new SQLiteConnection(@"data source=.\Nyaa");
                connection.Open();
                command = new SQLiteCommand(connection);
                command.CommandText = "CREATE TABLE  NyaaDB(Class char,Catagory char ,Address char,Name nvarchar(50),Torrent char,Magnet nvarchar(50),Size char,Time char,Up char,Leeches char,Complete char,OntherData BLOB)";
                command.ExecuteNonQuery();
                command.CommandText = "CREATE UNIQUE INDEX NyaaDBIndex ON NyaaDB(Class ,Catagory  ,Address ,Name ,Torrent ,Magnet ,Size ,Time ,Up ,Leeches ,Complete,OntherData)";
                command.ExecuteNonQuery();

            }
            else
            {
                connection = new SQLiteConnection(@"data source=.\Nyaa");
                connection.Open();
                command = new SQLiteCommand(connection);
            }
            #endregion
            HtmlDoc.LoadHtml(Resource1.Html);
            HtmlNodeCollection hrefs2 = HtmlDoc.DocumentNode.SelectNodes(@" / html[1] / body[1] / div[1] / div[2] / table[1] / tbody[1] / tr");
            CheckForIllegalCrossThreadCalls = false;
            new Task(() =>
            {
                Stopwatch stopWatch = new Stopwatch();
                var trans = connection.BeginTransaction();
                stopWatch.Start();
                var Count = 0;
                for (int i = 0; i < 100; i++)
                {
                   
                    darkLabel1.Text = i.ToString() ;
                    darkLabel2.Text = stopWatch.Elapsed.Minutes.ToString();
                    darkLabel3.Text =(stopWatch.Elapsed.Milliseconds - Count).ToString();
                     Count = stopWatch.Elapsed.Milliseconds; 
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
                        TB.Append(@"insert or ignore into NyaaDB(CLass,title,Address,Name,Torrent,Magnet,Size,Time,Up,Leeches,Complete) values(");
                        TB.Append("'");
                        TB.Append(Class);
                        TB.Append("',");

                        TB.Append("'");
                        TB.Append(title);
                        TB.Append("',");

                        /* TB.Append("'");
                         TB.Append(Imgsrc);
                         TB.Append("',");*/

                        TB.Append("'");
                        TB.Append(Address);
                        TB.Append("',");

                        TB.Append("\'" + name + "\',");

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
                        /*  Cmd.CommandText = TB.ToString();
                          Cmd.ExecuteNonQuery();*/
                        command.CommandText = TB.ToString();
                        command.ExecuteNonQuery();
                    }
                    
                }
                trans.Commit();
                connection.Close();
                stopWatch.Stop();
            });
            //url = "https://sukebei.nyaa.si/?p=9000";
            // url = "https://sukebei.nyaa.si/";
            url = "https://www.google.co.jp/";
            go(connection);
        }

        private string url;

        private async void go(SQLiteConnection connection)
        {
            try
            {
              var  command = new SQLiteCommand(connection);
                /*  SqlConnection c = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\cdj68\Desktop\PEPlugin-Git\bin\Debug\Nyaa.mdf;Integrated Security=True;Connect Timeout=30");
                  c.Open();
                  SqlCommand Cmd = new SqlCommand();
                  Cmd.Connection = c;
                  Cmd.CommandType = CommandType.Text;*/
                /*   Cmd.CommandText = "delete from torrent";
                   Cmd.ExecuteScalar();*/
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
                //var TorrentM = await client.GetStringAsync(@"https://sukebei.nyaa.si/view/2305136/torrent");
                var content = await client.GetStringAsync(url);
                if (content == "")
                {
                    if (handler.HttpStatusCode == HttpStatusCode.NotFound)
                    {

                    }
                }
                HtmlDoc.LoadHtml(content);
                WriteCookiesToDisk("Cookies", handler._cookies);
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
                    TB.Append(@"insert or ignore into NyaaDB(CLass,title,Address,Name,Torrent,Magnet,Size,Time,Up,Leeches,Complete) values(");
                    TB.Append("'");
                    TB.Append(Class);
                    TB.Append("',");

                    TB.Append("'");
                    TB.Append(title);
                    TB.Append("',");

                    /* TB.Append("'");
                     TB.Append(Imgsrc);
                     TB.Append("',");*/

                    TB.Append("'");
                    TB.Append(Address);
                    TB.Append("',");

                    TB.Append("\'" + name + "\',");

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
                    /*  Cmd.CommandText = TB.ToString();
                      Cmd.ExecuteNonQuery();*/
                    command.CommandText = TB.ToString();
                    command.ExecuteNonQuery();
                }
                // c.Close();

            }
            catch (Exception ex) 
            {
                if (ex.InnerException.Message == "无法连接到远程服务器") ;
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

        private void 退出_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SearchTextBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (SearchTextBox.Text == "Search...")
            {
                SearchTextBox.Text="";
            }
        }

        private void SearchTextBox_Leave(object sender, EventArgs e)
        {
            if (SearchTextBox.Text == "")
            {
                SearchTextBox.Text = "Search...";
            }
        }
    }
}