using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DarkUI.Docking;
using DarkUI.Controls;
using static NyaaAnalyse.Form1;
using BrightIdeasSoftware;

namespace NyaaAnalyse
{
    public partial class Document : DarkDocument
    {

        public Document()
        {
            InitializeComponent();
        }


        public Document(string v, List<TorrentInfo> sa)
        {
            InitializeComponent();
            var s = new List<DarkListItem>();
            DockText = v;
            foreach (var item in sa)
            {

            }
            dataListView1.SetObjects(s);
        }

        public Document(string v, DataSet ds)
        {
            InitializeComponent();
            this.DockText = v;
            dataListView1.DataSource = new BindingSource(ds, "NyaaDB");
        }

        private void dataListView1_HotItemChanged(object sender, HotItemChangedEventArgs e)
        {
            if (sender == null)
            {
                return;
            }

            switch (e.HotCellHitLocation)
            {
                case HitTestLocation.Nothing:
                    break;
                case HitTestLocation.Header:
                case HitTestLocation.HeaderCheckBox:
                case HitTestLocation.HeaderDivider:
                 
                    break;
                case HitTestLocation.Group:
                 
                    break;
                case HitTestLocation.GroupExpander:
                   
                    break;
                default:
                
                    break;
            }
        }
    }
}
