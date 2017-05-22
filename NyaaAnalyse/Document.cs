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
            DockText = v;
            DoubleBuffered = true;
            olvName.Renderer = CreateDescribedTaskRenderer();
            this.olvName.AspectName = "Catagory";
            this.olvName.ImageAspectName = "Catagory";
            this.olvName.CellPadding = new Rectangle(4, 2, 4, 2);
            olvTorrent.IsButton = true;
            olvTorrent.AspectName = "Download";
            this.olvTorrent.ButtonSizing = OLVColumn.ButtonSizingMode.FixedBounds;
            this.olvTorrent.ButtonSize = new Size(60, 26);
            this.olvTorrent.TextAlign = HorizontalAlignment.Center;
            this.olvTorrent.EnableButtonWhenItemIsDisabled = true;
            olvMagnet.IsButton = true;
            olvMagnet.AspectName = "Copy";
            this.olvMagnet.ButtonSizing = OLVColumn.ButtonSizingMode.FixedBounds;
            this.olvMagnet.ButtonSize = new Size(60, 26);
            this.olvMagnet.TextAlign = HorizontalAlignment.Center;
            this.olvMagnet.EnableButtonWhenItemIsDisabled = true;
            olvTasks.ButtonClick += (s, e) =>
            {
                var SelectButton = olvTasks.SelectedColumn;
                var Select = e.Model as TorrentInfo;
            };
            olvTasks.UseAlternatingBackColors = true;
            olvTasks.AlternateRowBackColor = Color.WhiteSmoke;
            olvTasks.SetObjects(sa);
        }

        private IRenderer CreateDescribedTaskRenderer()
        {
            DescribedTaskRenderer renderer = new DescribedTaskRenderer();
            renderer.ImageList = this.imageList1;
            renderer.DescriptionAspectName = "Name";
            renderer.TitleFont = new Font("Tahoma", 11, FontStyle.Bold);
            renderer.DescriptionFont = new Font("Tahoma", 9);
            renderer.ImageTextSpace = 8;
            renderer.TitleDescriptionSpace = 1;
            renderer.UseGdiTextRendering = true;
            return renderer;
        }
    }
}