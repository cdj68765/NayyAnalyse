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

namespace NyaaAnalyse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var Web = new HtmlWeb();
            HtmlAgilityPack.HtmlDocument HtmlDoc = Web.Load("https://sukebei.nyaa.si/");
            HtmlNodeCollection nodes = HtmlDoc.DocumentNode.SelectNodes("//li/h3/a[@href]");
            foreach (var item in nodes)
            {
                Console.WriteLine(item);
            }
        }
    }
}
