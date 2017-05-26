using CloudFlareUtilities;
using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NyaaAnalyse
{
    public partial class Form1 : DarkUI.Forms.DarkForm
    {
        private const string CreateTable = "CREATE TABLE  NyaaDB(Class char,Catagory char ,Address char,Name nvarchar(50),Torrent char,Magnet nvarchar(50),Size char,Time datetime,Up char,Leeches char,Complete char,OntherData BLOB)";//创建表
        private const string UNIQUETable = "CREATE UNIQUE INDEX NyaaDBIndex ON NyaaDB(Class ,Catagory  ,Address ,Name ,Torrent ,Magnet ,Size ,Time ,Up ,Leeches ,Complete,OntherData)";//建立数据唯一
        private const string VACUUMTable = "VACUUM";
        private const string DeleTable = "DROP  TABLE  NyaaDB";//删除表;
        private int HttpCount = 1;

        public class TorrentInfo
        {
            public string Download => "下载";
            public string Copy => "复制";
            public string Class { get; set; }
            public string Catagory { get; set; }
            public string Address { get; set; }
            public string Name { get; set; }
            public string Torrent { get; set; }
            public string Magnet { get; set; }
            public string Size { get; set; }
            public DateTime Date { get; set; }
            public string Up { get; set; }
            public string Leeches { get; set; }
            public string Complete { get; set; }
        }

        public Form1()
        {
            InitializeComponent();
            网站地址.ForeColor = System.Drawing.Color.Black;
            搜索字符.ForeColor = System.Drawing.Color.Black;
            选择搜索类型.ForeColor = System.Drawing.Color.Black;
            CheckForIllegalCrossThreadCalls = false;
            选择搜索类型.SelectedIndex = 0;
            new TaskFactory().StartNew(async () =>
            {
                var conn = new SQLiteConnection(@"data source=.\Nyaa");
                conn.Open();
                var cmd = new SQLiteCommand(conn);
                cmd.CommandText = "select * from NyaaDB order by Time desc limit 1000000 offset 0";
                var read = await cmd.ExecuteReaderAsync();
            });
            
          
            // var dataAdapter= new SQLiteDataAdapter("select Catagory,Address,Name,Torrent,Magnet,Size,Time,Up,Leeches,Complete from NyaaDB order by Time desc limit 20", conn);
            // var dataAdapter = new SQLiteDataAdapter("select * from NyaaDB order by Time desc limit 20", conn);
            /* DataSet ds = new DataSet();
             ds.EnforceConstraints = false;
             dataAdapter.FillSchema(ds, SchemaType.Source, "NyaaDB");
             dataAdapter.Fill(ds, "NyaaDB");
             主窗口.AddContent(new Document("主页", ds));*/
            /*   if (read.HasRows)
               {
                   List<TorrentInfo> sa = new List<TorrentInfo>();
                   while (read.Read())
                   {
                       TorrentInfo Temp = new TorrentInfo();
                       Temp.Class = read.GetString(0);
                       Temp.Catagory = read.GetString(1);
                       Temp.Address = read.GetString(2);
                       Temp.Name = read.GetString(3);
                       Temp.Torrent = read.GetString(4);
                       Temp.Magnet = read.GetString(5);
                       Temp.Size = read.GetString(6);
                       Temp.Date = read.GetDateTime(7);
                       Temp.Up = read.GetString(8);
                       Temp.Leeches = read.GetString(9);
                       Temp.Complete = read.GetString(10);
                       sa.Add(Temp);
                   }
                   主窗口.AddContent(new Document("主页", sa));
                   主窗口.AddContent(new dataListView("主页", sa));
               }*/

            #region 初始化数据库，建立表单

            SQLiteCommand command = null;
            if (!new FileInfo(@".\Nyaa").Exists)
            {
                SQLiteConnection connection = null;
                SQLiteConnection.CreateFile("Nyaa");
                connection = new SQLiteConnection(@"data source=.\Nyaa");
                connection.Open();
                command = new SQLiteCommand(connection);
                command.CommandText = CreateTable; ;
                command.ExecuteNonQuery();
                command.CommandText = UNIQUETable;
                command.ExecuteNonQuery();
                connection.Close();
            }

            #endregion 初始化数据库，建立表单
        }

        private async Task goreadAsync()
        {
            var conn = new SQLiteConnection(@"data source=.\Nyaa");
            conn.Open();
            var cmd = new SQLiteCommand(conn);
            cmd.CommandText = "select * from NyaaDB order by Time desc limit 1000000 offset 0";
            var read = await cmd.ExecuteReaderAsync();
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
                SQLiteConnection connection = null;
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

        private Task StopTask = null;
        private Stopwatch stop = new Stopwatch();
        private int Seconds = 0;

        private void 开始备份_Click(object sender, EventArgs e)
        {
            StopTask = new Task(() =>
             {
                 stop = new Stopwatch();
                 stop.Start();
                 var StartCount = HttpCount - 1;
                 while (stop.IsRunning)
                 {
                     Info2.Text = "总耗时:" + (int)stop.Elapsed.TotalHours + "小时" + stop.Elapsed.Minutes + "分钟" + stop.Elapsed.Seconds + "秒";
                     Info3.Text = "单例耗时:" + (stop.Elapsed.Seconds - Seconds) + "秒";
                     TimeSpan ts = new TimeSpan(0, 0, ((int)stop.Elapsed.TotalSeconds / (HttpCount - StartCount)) * (9970 - HttpCount));
                     info4.Text = "预计剩余" + (int)ts.TotalHours + "小时" + ts.Minutes + "分钟" + ts.Seconds + "秒";
                     info5.Text = "当前页面:" + HttpCount;
                     Thread.Sleep(1000);
                 }
                 Info2.Text = "";
                 Info3.Text = "";
                 info4.Text = "";
                 info5.Text = "";
             }, TaskCreationOptions.LongRunning);

            if (开始备份.Text == "开始备份")
            {
                if ((new DarkUI.Forms.DarkMessageBox("是否开始备份", "", DarkUI.Forms.DarkMessageBoxIcon.Warning, DarkUI.Forms.DarkDialogButton.YesNoCancel)).ShowDialog() == DialogResult.Yes)
                {
                    开始备份.Text = "取消备份";
                    Start = true;
                    StartBackup();
                }
            }
            else
            {
                if ((new DarkUI.Forms.DarkMessageBox("是否取消备份", "", DarkUI.Forms.DarkMessageBoxIcon.Warning, DarkUI.Forms.DarkDialogButton.YesNo)).ShowDialog() == DialogResult.Yes)
                {
                    Info1.Text = "等待本次实例完成";
                    Start = false;
                    开始备份.Text = "开始备份";
                }
            }
        }

        private int ErrorCount = 0;
        private bool Start = true;

        private void StartBackup()
        {
            if (new FileInfo("Config").Exists)
            {
                using (Stream Filestream = new FileStream("Config", FileMode.Open))
                {
                    IFormatter formatter = new BinaryFormatter();
                    HttpCount = (int)formatter.Deserialize(Filestream);
                }
            }
            var connection = new SQLiteConnection(@"data source=.\Nyaa");
            connection.Open();
            var command = new SQLiteCommand(connection);

            new Task(async () =>
            {
                Restart:
                var CreateTransaction = connection.BeginTransaction();
                try
                {
                    int TransactionCount = 0; ClearanceHandler handler = new ClearanceHandler();
                    var cookies = ReadCookiesFromDisk(@"Cookies");
                    if (cookies != null)
                    {
                        foreach (var item in cookies.GetCookies(new Uri(网站地址.Text)).Cast<Cookie>().ToList())
                        {
                            handler._cookies.Add(item);
                        }
                    }
                    while (Start)
                    {
                        Seconds = stop.Elapsed.Seconds;
                        if (ErrorCount == 0)
                            Info1.Text = "获得HTML";
                        else Info1.Text = "获得HTML第" + ErrorCount + "次";
                        var content = "";
                        var c = new WebClient();
                        if (ErrorCount % 2 == 0)
                        {
                            content = Encoding.UTF8.GetString(c.DownloadData(网站地址.Text + @"?p=" + (HttpCount - 1)));
                        }
                        else
                        {
                            HttpClient client = new HttpClient(handler);
                            content = await client.GetStringAsync(网站地址.Text + @"?p=" + HttpCount);
                        }

                        Info1.Text = "分析HTML";
                        if (content == "")
                        {
                            if (handler.HttpStatusCode == HttpStatusCode.NotFound || HttpCount > 9960)
                            {
                                CreateTransaction.Commit();
                                Info1.Text = "备份完成";
                                using (Stream Filestream = new FileStream("Config", FileMode.OpenOrCreate))
                                {
                                    IFormatter formatter2 = new BinaryFormatter();
                                    formatter2.Serialize(Filestream, HttpCount);
                                    Filestream.Close();
                                }
                                stop.Stop();
                                connection.Close();
                                return;
                            }
                            else if (handler.HttpStatusCode == HttpStatusCode.ServiceUnavailable)
                            {
                                Info1.Text = "出现503错误,推测IP被Ban";
                            }
                            else
                            {
                                Info1.Text = "出现" + handler.HttpStatusCode.ToString();
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
                            using (Stream Filestream = new FileStream("Config", FileMode.OpenOrCreate))
                            {
                                IFormatter formatter2 = new BinaryFormatter();
                                formatter2.Serialize(Filestream, HttpCount);
                                Filestream.Close();
                            }
                        }
                        ErrorCount = 0;
                        Interlocked.Increment(ref TransactionCount);
                        Interlocked.Increment(ref HttpCount);
                    }

                    Info1.Text = "备份取消";
                    CreateTransaction.Commit();
                    connection.Close();
                    using (Stream Filestream = new FileStream("Config", FileMode.OpenOrCreate))
                    {
                        IFormatter formatter2 = new BinaryFormatter();
                        formatter2.Serialize(Filestream, HttpCount);
                    }
                    stop.Stop();
                }
                catch (Exception ex)
                {
                    CreateTransaction.Commit();

                    using (Stream Filestream = new FileStream("Config", FileMode.OpenOrCreate))
                    {
                        IFormatter formatter2 = new BinaryFormatter();
                        formatter2.Serialize(Filestream, HttpCount);
                        Filestream.Close();
                    }
                    if (ex.Message.Contains("404"))
                    {
                        Info1.Text = "出现404错误";
                    }
                    Interlocked.Increment(ref ErrorCount);
                    if (ErrorCount < 5)
                    {
                        Thread.Sleep(10000);
                    }
                    else if (ErrorCount < 10)
                    {
                        Thread.Sleep(20000);
                    }
                    else if (ErrorCount > 15)
                    {
                        Info1.Text = "备份失败";
                        connection.Close();
                        return;
                    }
                    Info1.Text = "错误第" + ErrorCount + "次,错误类型" + ex.Message;
                    goto Restart;
                }
            }).Start();
            StopTask.Start();
        }

        private void 开始搜索_Click(object sender, EventArgs e)
        {
            SQLiteConnection connection = null;

        }
    }
}