using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NyaaAnalyse
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {

           /* var Web = new HtmlWeb();
            var tx = new System.Net.WebClient();
            WebProxy proxy = new WebProxy();*/
            /*proxy.Address = new Uri("http://127.0.0.1:7070");
            tx.Proxy = proxy;
            tx.DownloadData("http://sukebei.nyaa.si/");*/
            //HtmlAgilityPack.HtmlDocument HtmlDoc = Web.Load("http://sukebei.nyaa.si/");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
