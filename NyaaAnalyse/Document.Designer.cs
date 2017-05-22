namespace NyaaAnalyse
{
    partial class Document
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            BrightIdeasSoftware.HeaderStateStyle headerStateStyle7 = new BrightIdeasSoftware.HeaderStateStyle();
            BrightIdeasSoftware.HeaderStateStyle headerStateStyle8 = new BrightIdeasSoftware.HeaderStateStyle();
            BrightIdeasSoftware.HeaderStateStyle headerStateStyle9 = new BrightIdeasSoftware.HeaderStateStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Document));
            this.dataListView1 = new BrightIdeasSoftware.DataListView();
            this.catagory = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.headerFormatStyle1 = new BrightIdeasSoftware.HeaderFormatStyle();
            this.address = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.name = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn1 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.Torrent = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.Magnet = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.Size = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.Time = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.Up = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.Leeches = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.Complete = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageRenderer1 = new BrightIdeasSoftware.ImageRenderer();
            ((System.ComponentModel.ISupportInitialize)(this.dataListView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataListView1
            // 
            this.dataListView1.AllColumns.Add(this.catagory);
            this.dataListView1.AllColumns.Add(this.address);
            this.dataListView1.AllColumns.Add(this.name);
            this.dataListView1.AllColumns.Add(this.olvColumn1);
            this.dataListView1.AllColumns.Add(this.Torrent);
            this.dataListView1.AllColumns.Add(this.Magnet);
            this.dataListView1.AllColumns.Add(this.Size);
            this.dataListView1.AllColumns.Add(this.Time);
            this.dataListView1.AllColumns.Add(this.Up);
            this.dataListView1.AllColumns.Add(this.Leeches);
            this.dataListView1.AllColumns.Add(this.Complete);
            this.dataListView1.AllowColumnReorder = true;
            this.dataListView1.AllowDrop = true;
            this.dataListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.catagory,
            this.address,
            this.name,
            this.olvColumn1,
            this.Torrent,
            this.Magnet,
            this.Size,
            this.Time,
            this.Up,
            this.Leeches,
            this.Complete});
            this.dataListView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataListView1.DataSource = null;
            this.dataListView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataListView1.FullRowSelect = true;
            this.dataListView1.GridLines = true;
            this.dataListView1.HeaderFormatStyle = this.headerFormatStyle1;
            this.dataListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.dataListView1.HideSelection = false;
            this.dataListView1.HighlightBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataListView1.HighlightForegroundColor = System.Drawing.Color.White;
            this.dataListView1.IncludeColumnHeadersInCopy = true;
            this.dataListView1.LargeImageList = this.imageList1;
            this.dataListView1.Location = new System.Drawing.Point(0, 0);
            this.dataListView1.MenuLabelColumns = "列";
            this.dataListView1.MenuLabelGroupBy = "建立组 \'{0}\'";
            this.dataListView1.MenuLabelLockGroupingOn = "锁定组 \'{0}\'";
            this.dataListView1.MenuLabelSelectColumns = "选中列...";
            this.dataListView1.MenuLabelSortAscending = "升序\'{0}\'";
            this.dataListView1.MenuLabelSortDescending = "降序 \'{0}\'";
            this.dataListView1.MenuLabelTurnOffGroups = "取消组";
            this.dataListView1.MenuLabelUnlockGroupingOn = "解除 \'{0}\'组";
            this.dataListView1.MenuLabelUnsort = "不排序";
            this.dataListView1.Name = "dataListView1";
            this.dataListView1.OwnerDraw = true;
            this.dataListView1.SelectColumnsOnRightClickBehaviour = BrightIdeasSoftware.ObjectListView.ColumnSelectBehaviour.Submenu;
            this.dataListView1.ShowCommandMenuOnRightClick = true;
            this.dataListView1.ShowGroups = false;
            this.dataListView1.ShowImagesOnSubItems = true;
            this.dataListView1.ShowItemToolTips = true;
            this.dataListView1.Size = new System.Drawing.Size(150, 150);
            this.dataListView1.SmallImageList = this.imageList1;
            this.dataListView1.TabIndex = 0;
            this.dataListView1.UseCellFormatEvents = true;
            this.dataListView1.UseCompatibleStateImageBehavior = false;
            this.dataListView1.UseHotItem = true;
            this.dataListView1.UseTranslucentHotItem = true;
            this.dataListView1.View = System.Windows.Forms.View.Details;
            this.dataListView1.HotItemChanged += new System.EventHandler<BrightIdeasSoftware.HotItemChangedEventArgs>(this.dataListView1_HotItemChanged);
            // 
            // catagory
            // 
            this.catagory.Renderer = this.imageRenderer1;
            this.catagory.Text = "Catagory";
            // 
            // headerFormatStyle1
            // 
            headerStateStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            headerStateStyle7.ForeColor = System.Drawing.Color.White;
            this.headerFormatStyle1.Hot = headerStateStyle7;
            headerStateStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            headerStateStyle8.ForeColor = System.Drawing.Color.Gainsboro;
            this.headerFormatStyle1.Normal = headerStateStyle8;
            headerStateStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            headerStateStyle9.ForeColor = System.Drawing.Color.White;
            headerStateStyle9.FrameColor = System.Drawing.Color.WhiteSmoke;
            headerStateStyle9.FrameWidth = 2F;
            this.headerFormatStyle1.Pressed = headerStateStyle9;
            // 
            // address
            // 
            this.address.Text = "Address";
            // 
            // name
            // 
            this.name.Text = "Name";
            // 
            // Torrent
            // 
            this.Torrent.Text = "Torrent";
            // 
            // Magnet
            // 
            this.Magnet.Text = "Magnet";
            // 
            // Size
            // 
            this.Size.Text = "Size";
            // 
            // Time
            // 
            this.Time.Text = "Time";
            // 
            // Up
            // 
            this.Up.Text = "Up";
            // 
            // Leeches
            // 
            this.Leeches.Text = "Leeches";
            // 
            // Complete
            // 
            this.Complete.Text = "Complete";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Anime.png");
            this.imageList1.Images.SetKeyName(1, "AV.png");
            this.imageList1.Images.SetKeyName(2, "Doujinshi.png");
            this.imageList1.Images.SetKeyName(3, "Game.png");
            this.imageList1.Images.SetKeyName(4, "Manga.png");
            // 
            // Document
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataListView1);
            this.Name = "Document";
            ((System.ComponentModel.ISupportInitialize)(this.dataListView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BrightIdeasSoftware.DataListView dataListView1;
        private BrightIdeasSoftware.HeaderFormatStyle headerFormatStyle1;
        private BrightIdeasSoftware.OLVColumn catagory;
        private BrightIdeasSoftware.OLVColumn address;
        private BrightIdeasSoftware.OLVColumn name;
        private BrightIdeasSoftware.OLVColumn olvColumn1;
        private BrightIdeasSoftware.OLVColumn Torrent;
        private BrightIdeasSoftware.OLVColumn Magnet;
        private BrightIdeasSoftware.OLVColumn Size;
        private BrightIdeasSoftware.OLVColumn Time;
        private BrightIdeasSoftware.OLVColumn Up;
        private BrightIdeasSoftware.OLVColumn Leeches;
        private BrightIdeasSoftware.OLVColumn Complete;
        private System.Windows.Forms.ImageList imageList1;
        private BrightIdeasSoftware.ImageRenderer imageRenderer1;
    }
}
