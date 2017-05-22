using System.Collections.Generic;

namespace NyaaAnalyse
{
    partial class dataListView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dataListView));
            BrightIdeasSoftware.HeaderStateStyle headerStateStyle52 = new BrightIdeasSoftware.HeaderStateStyle();
            BrightIdeasSoftware.HeaderStateStyle headerStateStyle53 = new BrightIdeasSoftware.HeaderStateStyle();
            BrightIdeasSoftware.HeaderStateStyle headerStateStyle54 = new BrightIdeasSoftware.HeaderStateStyle();
            this.dataListView1 = new BrightIdeasSoftware.DataListView();
            this.Category = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.name = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.Torrent = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.magnet = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.Size = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.Date = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.Up = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.Leeches = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.Complete = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.headerFormatStyle1 = new BrightIdeasSoftware.HeaderFormatStyle();
            ((System.ComponentModel.ISupportInitialize)(this.dataListView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataListView1
            // 
            this.dataListView1.AllColumns.Add(this.Category);
            this.dataListView1.AllColumns.Add(this.name);
            this.dataListView1.AllColumns.Add(this.Torrent);
            this.dataListView1.AllColumns.Add(this.magnet);
            this.dataListView1.AllColumns.Add(this.Size);
            this.dataListView1.AllColumns.Add(this.Date);
            this.dataListView1.AllowColumnReorder = true;
            this.dataListView1.AllowDrop = true;
            this.dataListView1.CellEditUseWholeCell = false;
            this.dataListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Category,
            this.name,
            this.Torrent,
            this.magnet,
            this.Size,
            this.Date});
            this.dataListView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataListView1.DataSource = null;
            this.dataListView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataListView1.GridLines = true;
            this.dataListView1.HasCollapsibleGroups = false;
            this.dataListView1.HeaderFormatStyle = this.headerFormatStyle1;
            this.dataListView1.HideSelection = false;
            this.dataListView1.IsSearchOnSortColumn = false;
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
            this.dataListView1.PersistentCheckBoxes = false;
            this.dataListView1.RowHeight = 35;
            this.dataListView1.SelectAllOnControlA = false;
            this.dataListView1.SelectColumnsMenuStaysOpen = false;
            this.dataListView1.SelectColumnsOnRightClick = false;
            this.dataListView1.SelectColumnsOnRightClickBehaviour = BrightIdeasSoftware.ObjectListView.ColumnSelectBehaviour.None;
            this.dataListView1.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataListView1.SelectedForeColor = System.Drawing.Color.White;
            this.dataListView1.ShowCommandMenuOnRightClick = true;
            this.dataListView1.ShowGroups = false;
            this.dataListView1.ShowHeaderInAllViews = false;
            this.dataListView1.ShowImagesOnSubItems = true;
            this.dataListView1.ShowItemCountOnGroups = true;
            this.dataListView1.ShowItemToolTips = true;
            this.dataListView1.Size = new System.Drawing.Size(150, 150);
            this.dataListView1.SmallImageList = this.imageList1;
            this.dataListView1.TabIndex = 1;
            this.dataListView1.TriggerCellOverEventsWhenOverHeader = false;
            this.dataListView1.UpdateSpaceFillingColumnsWhenDraggingColumnDivider = false;
            this.dataListView1.UseCompatibleStateImageBehavior = false;
            this.dataListView1.UseHotControls = false;
            this.dataListView1.UseOverlays = false;
            this.dataListView1.View = System.Windows.Forms.View.Details;
            // 
            // Category
            // 
            this.Category.AspectName = "Category";
            this.Category.Groupable = false;
            this.Category.Sortable = false;
            this.Category.Text = "Category";
            this.Category.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Category.Width = 90;
            // 
            // name
            // 
            this.name.AspectName = "Name";
            this.name.Text = "Name";
            this.name.Width = 550;
            // 
            // Torrent
            // 
            this.Torrent.AspectName = "Torrent";
            this.Torrent.Groupable = false;
            this.Torrent.IsButton = true;
            this.Torrent.Sortable = false;
            this.Torrent.Text = "Torrent";
            this.Torrent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Torrent.Width = 70;
            // 
            // magnet
            // 
            this.magnet.AspectName = "Magnet";
            this.magnet.Groupable = false;
            this.magnet.IsButton = true;
            this.magnet.Sortable = false;
            this.magnet.Text = "Magnet";
            this.magnet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.magnet.Width = 70;
            // 
            // Size
            // 
            this.Size.AspectName = "Size";
            this.Size.Text = "Size";
            // 
            // Date
            // 
            this.Date.AspectName = "Date";
            this.Date.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Date.Text = "Date";
            this.Date.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Date.Width = 140;
            // 
            // Up
            // 
            this.Up.AspectName = "Up";
            this.Up.DisplayIndex = 6;
            this.Up.Text = "Up";
            this.Up.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Leeches
            // 
            this.Leeches.AspectName = "Leeches";
            this.Leeches.DisplayIndex = 7;
            this.Leeches.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Leeches.Text = "Leeches";
            this.Leeches.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Leeches.Width = 55;
            // 
            // Complete
            // 
            this.Complete.AspectName = "Complete";
            this.Complete.DisplayIndex = 8;
            this.Complete.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Complete.Text = "Complete";
            this.Complete.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Complete.Width = 65;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Art - Anime");
            this.imageList1.Images.SetKeyName(1, "Real Life - Videos");
            this.imageList1.Images.SetKeyName(2, "Art - Doujinshi");
            this.imageList1.Images.SetKeyName(3, "Art - Games");
            this.imageList1.Images.SetKeyName(4, "Art - Manga");
            this.imageList1.Images.SetKeyName(5, "Art - Pictures");
            this.imageList1.Images.SetKeyName(6, "Real Life - Photobooks / Pictures");
            // 
            // headerFormatStyle1
            // 
            headerStateStyle52.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            headerStateStyle52.ForeColor = System.Drawing.Color.White;
            this.headerFormatStyle1.Hot = headerStateStyle52;
            headerStateStyle53.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            headerStateStyle53.ForeColor = System.Drawing.Color.White;
            this.headerFormatStyle1.Normal = headerStateStyle53;
            headerStateStyle54.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            headerStateStyle54.ForeColor = System.Drawing.Color.White;
            headerStateStyle54.FrameColor = System.Drawing.Color.WhiteSmoke;
            headerStateStyle54.FrameWidth = 2F;
            this.headerFormatStyle1.Pressed = headerStateStyle54;
            // 
            // dataListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataListView1);
            this.Name = "dataListView";
            ((System.ComponentModel.ISupportInitialize)(this.dataListView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BrightIdeasSoftware.DataListView dataListView1;
        private BrightIdeasSoftware.OLVColumn Category;
        private BrightIdeasSoftware.OLVColumn name;
        private BrightIdeasSoftware.OLVColumn Torrent;
        private BrightIdeasSoftware.OLVColumn magnet;
        private BrightIdeasSoftware.OLVColumn Size;
        private BrightIdeasSoftware.OLVColumn Date;
        private BrightIdeasSoftware.OLVColumn Up;
        private BrightIdeasSoftware.OLVColumn Leeches;
        private BrightIdeasSoftware.OLVColumn Complete;
        private System.Windows.Forms.ImageList imageList1;
        private BrightIdeasSoftware.HeaderFormatStyle headerFormatStyle1;
    }
}
