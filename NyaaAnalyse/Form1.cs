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
using System.Net;
using Cloudflare_Evader;
using NitinJS;

namespace NyaaAnalyse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            /*WebClient client = CloudflareEvader.CreateBypassedWebClient("https://sukebei.nyaa.si");
            var c= client.DownloadData("https://sukebei.nyaa.si/");*/
            /*CookieContainer cookies = new CookieContainer();
            SmsWebClient client = new SmsWebClient(cookies);
            string html = client.DownloadString("https://sukebei.nyaa.si/");*/
            /* var Web = new HtmlWeb();
             var HtmlDoc = new HtmlAgilityPack.HtmlDocument();
             HtmlDoc.LoadHtml(Resource1.String2);

              HtmlNodeCollection nodes = HtmlDoc.DocumentNode.SelectNodes("//p");
              foreach (var item in nodes)
              {
                  Console.WriteLine(item);
              }*/
            var target = new Uri("https://sukebei.nyaa.si/");

            var handler = new ClearanceHandler();

            var client = new HttpClient(handler);

            try
            {
                var content = await client.GetStringAsync(new Uri("https://sukebei.nyaa.si/"));
                txtUserAgent.Text = "Client/1.0";
                txtCfduid.Text = handler.IDCookieValue;
                txtCfClearance.Text = handler.ClearanceCookieValue;
            }
            catch (AggregateException ex) when (ex.InnerException is CloudFlareClearanceException)
            {
                MessageBox.Show(ex.InnerException.Message);
            }
        }
    }
}
