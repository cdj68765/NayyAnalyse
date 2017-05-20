using CloudFlareUtilities;
using HtmlAgilityPack;
using System;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace NyaaAnalyse
{
    public partial class Form1 : DarkUI.Forms.DarkForm
    {
        private const string CreateTable = "CREATE TABLE  NyaaDB(Class char,Catagory char ,Address char,Name nvarchar(50),Torrent char,Magnet nvarchar(50),Size char,Time datetime,Up char,Leeches char,Complete char,OntherData BLOB)";//创建表
        private const string UNIQUETable = "CREATE UNIQUE INDEX NyaaDBIndex ON NyaaDB(Class ,Catagory  ,Address ,Name ,Torrent ,Magnet ,Size ,Time ,Up ,Leeches ,Complete,OntherData)";//建立数据唯一
        private const string VACUUMTable = "VACUUM";
        private const string DeleTable = "DROP  TABLE  NyaaDB";//删除表;
        private SQLiteConnection connection = null;
        private int HttpCount = 1;

        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            选择搜索类型.SelectedIndex = 0;

            #region 初始化数据库，建立表单

            SQLiteCommand command = null;
            if (!new FileInfo(@".\Nyaa").Exists)
            {
                SQLiteConnection.CreateFile("Nyaa");
                connection = new SQLiteConnection(@"data source=.\Nyaa");
                connection.Open();
                command = new SQLiteCommand(connection);
                command.CommandText = "CREATE TABLE  NyaaDB(Class char,Catagory char ,Address char,Name nvarchar(50),Torrent char,Magnet nvarchar(50),Size char,Time datetime,Up char,Leeches char,Complete char,OntherData BLOB)";
                command.ExecuteNonQuery();
                command.CommandText = "CREATE UNIQUE INDEX NyaaDBIndex ON NyaaDB(Class ,Catagory  ,Address ,Name ,Torrent ,Magnet ,Size ,Time ,Up ,Leeches ,Complete,OntherData)";
                command.ExecuteNonQuery();
                connection.Close();
            }

            #endregion 初始化数据库，建立表单
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
            if (搜索字符.Text == "Search...")
            {
                搜索字符.Text = "";
            }
        }

        private void SearchTextBox_Leave(object sender, EventArgs e)
        {
            if (搜索字符.Text == "")
            {
                搜索字符.Text = "Search...";
            }
        }

        private void 删除表_Click(object sender, EventArgs e)
        {
            if ((new DarkUI.Forms.DarkMessageBox("此操作将会清空数据库，请注意", "清空表", DarkUI.Forms.DarkMessageBoxIcon.Warning, DarkUI.Forms.DarkDialogButton.OkCancel)).ShowDialog() == DialogResult.OK)
            {
                if (connection != null)
                {
                    var command = new SQLiteCommand(connection);
                    command.CommandText = "select name from sqlite_master where name = 'NyaaDB'";
                    var Read = command.ExecuteReader();
                    if (Read.Read())
                    {
                        Read.Close();
                        command.CommandText = DeleTable;
                        command.ExecuteNonQuery();
                        command.CommandText = VACUUMTable;
                        command.ExecuteNonQuery();
                        command.CommandText = CreateTable;
                        command.ExecuteNonQuery();
                        command.CommandText = UNIQUETable;
                        command.ExecuteNonQuery();
                    }
                }
            }
        }

        private void 开始备份_Click(object sender, EventArgs e)
        {
            StartBackup();
        }

        private async void StartBackup()
        {
            try
            {
                var connection = new SQLiteConnection(@"data source=.\Nyaa");
                connection.Open();
                var command = new SQLiteCommand(connection);
                ClearanceHandler handler = new ClearanceHandler();
                var cookies = ReadCookiesFromDisk(@"Cookies");
                if (cookies != null)
                {
                    foreach (var item in cookies.GetCookies(new Uri(网站地址.Text)).Cast<Cookie>().ToList())
                    {
                        handler._cookies.Add(item);
                    }
                }
                HttpClient client = new HttpClient(handler);
                var CreateTransaction = connection.BeginTransaction();
                int TransactionCount = 0;
                while (true)
                {
                    var content = await client.GetStringAsync(网站地址.Text + @"?p=" + HttpCount);
                    if (content == "")
                    {
                        if (handler.HttpStatusCode == HttpStatusCode.NotFound || HttpCount > 9500)
                        {
                            HttpCount = 1;
                            break;
                        }
                        else if (handler.HttpStatusCode == HttpStatusCode.ServiceUnavailable)
                        {
                        }
                    }
                    var HtmlDoc = new HtmlAgilityPack.HtmlDocument();
                    HtmlDoc.LoadHtml(content);
                    foreach (var item in HtmlDoc.DocumentNode.SelectNodes(@" / html[1] / body[1] / div[1] / div[2] / table[1] / tbody[1] / tr"))
                    {
                        var temp = HtmlNode.CreateNode(item.OuterHtml);
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
                        var CreateDataBaseCommand = new StringBuilder();
                        CreateDataBaseCommand.Append(@"insert or ignore into NyaaDB(CLass,Catagory,Address,Name,Torrent,Magnet,Size,Time,Up,Leeches,Complete) values(");
                        CreateDataBaseCommand.Append("'");
                        CreateDataBaseCommand.Append(item.Attributes["class"].Value);
                        CreateDataBaseCommand.Append("',");

                        CreateDataBaseCommand.Append("'");
                        CreateDataBaseCommand.Append(temp.SelectSingleNode(@"//a[1]").Attributes["title"].Value);
                        CreateDataBaseCommand.Append("',");

                        CreateDataBaseCommand.Append("'");
                        CreateDataBaseCommand.Append(HtmlNode.CreateNode(temp.SelectSingleNode(@"//td[2]").InnerHtml).SelectSingleNode("//a[1]").Attributes["href"].Value);
                        CreateDataBaseCommand.Append("',");

                        CreateDataBaseCommand.Append("'");
                        CreateDataBaseCommand.Append(temp.SelectSingleNode(@"//td[2]").InnerText);
                        CreateDataBaseCommand.Append("',");

                        CreateDataBaseCommand.Append("'");
                        CreateDataBaseCommand.Append(Torrent);
                        CreateDataBaseCommand.Append("',");

                        CreateDataBaseCommand.Append("'");
                        CreateDataBaseCommand.Append(Magnet);
                        CreateDataBaseCommand.Append("',");

                        CreateDataBaseCommand.Append("'");
                        CreateDataBaseCommand.Append(temp.SelectSingleNode(@"//td[4]").InnerHtml);
                        CreateDataBaseCommand.Append("',");

                        CreateDataBaseCommand.Append("'");
                        CreateDataBaseCommand.Append(temp.SelectSingleNode(@"//td[5]").InnerHtml);
                        CreateDataBaseCommand.Append("',");

                        CreateDataBaseCommand.Append("'");
                        CreateDataBaseCommand.Append(temp.SelectSingleNode(@"//td[6]").InnerHtml);
                        CreateDataBaseCommand.Append("',");

                        CreateDataBaseCommand.Append("'");
                        CreateDataBaseCommand.Append(temp.SelectSingleNode(@"//td[7]").InnerHtml);
                        CreateDataBaseCommand.Append("',");

                        CreateDataBaseCommand.Append("'");
                        CreateDataBaseCommand.Append(temp.SelectSingleNode(@"//td[8]").InnerHtml);
                        CreateDataBaseCommand.Append("')");
                        command.CommandText = CreateDataBaseCommand.ToString();
                        command.ExecuteNonQuery();
                    }
                    if (TransactionCount == 5)
                    {
                        TransactionCount = 0;
                        CreateTransaction.Commit();
                        CreateTransaction = connection.BeginTransaction();
                        break;
                    }
                    Interlocked.Increment(ref TransactionCount);
                    Interlocked.Increment(ref HttpCount);
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                if (ex.InnerException.Message == "无法连接到远程服务器") ;
            }
        }

        private void 开始搜索_Click(object sender, EventArgs e)
        {
        }
    }
}