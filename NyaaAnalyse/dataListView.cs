using BrightIdeasSoftware;
using DarkUI.Docking;
using System.Collections.Generic;
using static NyaaAnalyse.Form1;

namespace NyaaAnalyse
{
    public partial class dataListView : DarkDocument
    {
        private string v;
        private List<TorrentInfo> sa;

        public dataListView()
        {
            InitializeComponent();
        }

        public dataListView(string v, List<Form1.TorrentInfo> sa)
        {
            InitializeComponent();
            DockText = v;
            DoubleBuffered = true;
            Category.ImageGetter = new ImageGetterDelegate((obj) =>
            {
                return (obj as TorrentInfo).Catagory;
            });
            Torrent.AspectName = "Download";
            magnet.AspectName = "Copy";
            dataListView1.SetObjects(sa);
        }
    }
}