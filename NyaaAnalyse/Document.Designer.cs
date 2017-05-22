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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Document));
            BrightIdeasSoftware.HeaderStateStyle headerStateStyle25 = new BrightIdeasSoftware.HeaderStateStyle();
            BrightIdeasSoftware.HeaderStateStyle headerStateStyle26 = new BrightIdeasSoftware.HeaderStateStyle();
            BrightIdeasSoftware.HeaderStateStyle headerStateStyle27 = new BrightIdeasSoftware.HeaderStateStyle();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.olvTasks = new BrightIdeasSoftware.ObjectListView();
            this.olvName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvTorrent = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvMagnet = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn5 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn6 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn7 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn8 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn9 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.darkContextMenu1 = new DarkUI.Controls.DarkContextMenu();
            this.打开网页ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.下载种子ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.复制磁力ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.headerFormatStyle1 = new BrightIdeasSoftware.HeaderFormatStyle();
            this.复制种子名ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.olvTasks)).BeginInit();
            this.darkContextMenu1.SuspendLayout();
            this.SuspendLayout();
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
            // olvTasks
            // 
            this.olvTasks.AllColumns.Add(this.olvName);
            this.olvTasks.AllColumns.Add(this.olvTorrent);
            this.olvTasks.AllColumns.Add(this.olvMagnet);
            this.olvTasks.AllColumns.Add(this.olvColumn5);
            this.olvTasks.AllColumns.Add(this.olvColumn6);
            this.olvTasks.AllColumns.Add(this.olvColumn7);
            this.olvTasks.AllColumns.Add(this.olvColumn8);
            this.olvTasks.AllColumns.Add(this.olvColumn9);
            this.olvTasks.AllowColumnReorder = true;
            this.olvTasks.AllowDrop = true;
            this.olvTasks.CellEditUseWholeCell = false;
            this.olvTasks.CheckBoxes = true;
            this.olvTasks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvName,
            this.olvTorrent,
            this.olvMagnet,
            this.olvColumn5,
            this.olvColumn6,
            this.olvColumn7,
            this.olvColumn8,
            this.olvColumn9});
            this.olvTasks.ContextMenuStrip = this.darkContextMenu1;
            this.olvTasks.CopySelectionOnControlC = false;
            this.olvTasks.CopySelectionOnControlCUsesDragSource = false;
            this.olvTasks.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvTasks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.olvTasks.FullRowSelect = true;
            this.olvTasks.GridLines = true;
            this.olvTasks.HasCollapsibleGroups = false;
            this.olvTasks.HeaderFormatStyle = this.headerFormatStyle1;
            this.olvTasks.HideSelection = false;
            this.olvTasks.IsSearchOnSortColumn = false;
            this.olvTasks.Location = new System.Drawing.Point(0, 0);
            this.olvTasks.MenuLabelColumns = "列";
            this.olvTasks.MenuLabelGroupBy = "建成 \'{0}\'组";
            this.olvTasks.MenuLabelLockGroupingOn = "锁定 \'{0}\'组";
            this.olvTasks.MenuLabelSelectColumns = "选中列...";
            this.olvTasks.MenuLabelSortAscending = "按 \'{0}\'升序";
            this.olvTasks.MenuLabelSortDescending = "按 \'{0}\'降序";
            this.olvTasks.MenuLabelTurnOffGroups = "取消组";
            this.olvTasks.MenuLabelUnlockGroupingOn = "解锁\'{0}\'组";
            this.olvTasks.MenuLabelUnsort = "取消排序";
            this.olvTasks.Name = "olvTasks";
            this.olvTasks.OwnerDrawnHeader = true;
            this.olvTasks.PersistentCheckBoxes = false;
            this.olvTasks.RowHeight = 50;
            this.olvTasks.ShowCommandMenuOnRightClick = true;
            this.olvTasks.ShowGroups = false;
            this.olvTasks.ShowHeaderInAllViews = false;
            this.olvTasks.ShowImagesOnSubItems = true;
            this.olvTasks.ShowItemCountOnGroups = true;
            this.olvTasks.ShowItemToolTips = true;
            this.olvTasks.Size = new System.Drawing.Size(150, 150);
            this.olvTasks.TabIndex = 1;
            this.olvTasks.TriggerCellOverEventsWhenOverHeader = false;
            this.olvTasks.UpdateSpaceFillingColumnsWhenDraggingColumnDivider = false;
            this.olvTasks.UseCompatibleStateImageBehavior = false;
            this.olvTasks.View = System.Windows.Forms.View.Details;
            // 
            // olvName
            // 
            this.olvName.AspectName = "Name";
            this.olvName.Groupable = false;
            this.olvName.Hyperlink = true;
            this.olvName.Text = "Name";
            this.olvName.Width = 530;
            // 
            // olvTorrent
            // 
            this.olvTorrent.AspectName = "Torrent";
            this.olvTorrent.ButtonSizing = BrightIdeasSoftware.OLVColumn.ButtonSizingMode.CellBounds;
            this.olvTorrent.Groupable = false;
            this.olvTorrent.Sortable = false;
            this.olvTorrent.Text = "Torrent";
            // 
            // olvMagnet
            // 
            this.olvMagnet.AspectName = "Magnet";
            this.olvMagnet.Groupable = false;
            this.olvMagnet.Sortable = false;
            this.olvMagnet.Text = "Magnet";
            // 
            // olvColumn5
            // 
            this.olvColumn5.AspectName = "Size";
            this.olvColumn5.Text = "Size";
            // 
            // olvColumn6
            // 
            this.olvColumn6.AspectName = "Date";
            this.olvColumn6.Text = "Date";
            this.olvColumn6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.olvColumn6.Width = 120;
            // 
            // olvColumn7
            // 
            this.olvColumn7.AspectName = "Up";
            this.olvColumn7.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.olvColumn7.Text = "Up";
            this.olvColumn7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.olvColumn7.Width = 30;
            // 
            // olvColumn8
            // 
            this.olvColumn8.AspectName = "Leeches";
            this.olvColumn8.IsEditable = false;
            this.olvColumn8.Text = "Leeches";
            this.olvColumn8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // olvColumn9
            // 
            this.olvColumn9.AspectName = "Complete";
            this.olvColumn9.Text = "Complete";
            this.olvColumn9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // darkContextMenu1
            // 
            this.darkContextMenu1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.darkContextMenu1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkContextMenu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.打开网页ToolStripMenuItem,
            this.复制种子名ToolStripMenuItem,
            this.下载种子ToolStripMenuItem,
            this.复制磁力ToolStripMenuItem});
            this.darkContextMenu1.Name = "darkContextMenu1";
            this.darkContextMenu1.Size = new System.Drawing.Size(137, 92);
            // 
            // 打开网页ToolStripMenuItem
            // 
            this.打开网页ToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.打开网页ToolStripMenuItem.Name = "打开网页ToolStripMenuItem";
            this.打开网页ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.打开网页ToolStripMenuItem.Text = "打开网页";
            // 
            // 下载种子ToolStripMenuItem
            // 
            this.下载种子ToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.下载种子ToolStripMenuItem.Name = "下载种子ToolStripMenuItem";
            this.下载种子ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.下载种子ToolStripMenuItem.Text = "下载种子";
            // 
            // 复制磁力ToolStripMenuItem
            // 
            this.复制磁力ToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.复制磁力ToolStripMenuItem.Name = "复制磁力ToolStripMenuItem";
            this.复制磁力ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.复制磁力ToolStripMenuItem.Text = "复制磁力";
            // 
            // headerFormatStyle1
            // 
            headerStateStyle25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            headerStateStyle25.ForeColor = System.Drawing.Color.White;
            this.headerFormatStyle1.Hot = headerStateStyle25;
            headerStateStyle26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            headerStateStyle26.ForeColor = System.Drawing.Color.White;
            this.headerFormatStyle1.Normal = headerStateStyle26;
            headerStateStyle27.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            headerStateStyle27.ForeColor = System.Drawing.Color.White;
            headerStateStyle27.FrameColor = System.Drawing.Color.WhiteSmoke;
            headerStateStyle27.FrameWidth = 2F;
            this.headerFormatStyle1.Pressed = headerStateStyle27;
            // 
            // 复制种子名ToolStripMenuItem
            // 
            this.复制种子名ToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.复制种子名ToolStripMenuItem.Name = "复制种子名ToolStripMenuItem";
            this.复制种子名ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.复制种子名ToolStripMenuItem.Text = "复制种子名";
            // 
            // Document
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.olvTasks);
            this.Name = "Document";
            ((System.ComponentModel.ISupportInitialize)(this.olvTasks)).EndInit();
            this.darkContextMenu1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private BrightIdeasSoftware.ObjectListView olvTasks;
        private BrightIdeasSoftware.OLVColumn olvName;
        private BrightIdeasSoftware.OLVColumn olvTorrent;
        private BrightIdeasSoftware.OLVColumn olvMagnet;
        private BrightIdeasSoftware.OLVColumn olvColumn5;
        private BrightIdeasSoftware.OLVColumn olvColumn6;
        private BrightIdeasSoftware.OLVColumn olvColumn7;
        private BrightIdeasSoftware.OLVColumn olvColumn8;
        private BrightIdeasSoftware.OLVColumn olvColumn9;
        private DarkUI.Controls.DarkContextMenu darkContextMenu1;
        private System.Windows.Forms.ToolStripMenuItem 打开网页ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 下载种子ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 复制磁力ToolStripMenuItem;
        private BrightIdeasSoftware.HeaderFormatStyle headerFormatStyle1;
        private System.Windows.Forms.ToolStripMenuItem 复制种子名ToolStripMenuItem;
    }
}
