namespace NyaaAnalyse
{
    partial class Form1
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.类型图 = new System.Windows.Forms.ImageList(this.components);
            this.菜单栏 = new DarkUI.Controls.DarkMenuStrip();
            this.菜单 = new System.Windows.Forms.ToolStripMenuItem();
            this.开始同步ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.开始备份 = new System.Windows.Forms.ToolStripMenuItem();
            this.删除表 = new System.Windows.Forms.ToolStripMenuItem();
            this.退出 = new System.Windows.Forms.ToolStripMenuItem();
            this.网站地址 = new System.Windows.Forms.ToolStripTextBox();
            this.工具栏 = new DarkUI.Controls.DarkToolStrip();
            this.开始搜索 = new System.Windows.Forms.ToolStripButton();
            this.选择搜索类型 = new System.Windows.Forms.ToolStripComboBox();
            this.搜索字符 = new System.Windows.Forms.ToolStripTextBox();
            this.主窗口 = new DarkUI.Docking.DarkDockPanel();
            this.状态显示 = new DarkUI.Controls.DarkStatusStrip();
            this.InfoProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.Info1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.Info2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.Info3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.info4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.info5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.菜单栏.SuspendLayout();
            this.工具栏.SuspendLayout();
            this.状态显示.SuspendLayout();
            this.SuspendLayout();
            // 
            // 类型图
            // 
            this.类型图.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("类型图.ImageStream")));
            this.类型图.TransparentColor = System.Drawing.Color.Transparent;
            this.类型图.Images.SetKeyName(0, "Anime.png");
            this.类型图.Images.SetKeyName(1, "AV.png");
            this.类型图.Images.SetKeyName(2, "Doujinshi.png");
            this.类型图.Images.SetKeyName(3, "Game.png");
            this.类型图.Images.SetKeyName(4, "Manga.png");
            // 
            // 菜单栏
            // 
            this.菜单栏.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.菜单栏.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.菜单栏.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.菜单,
            this.网站地址});
            this.菜单栏.Location = new System.Drawing.Point(0, 0);
            this.菜单栏.Name = "菜单栏";
            this.菜单栏.Padding = new System.Windows.Forms.Padding(3, 2, 0, 2);
            this.菜单栏.Size = new System.Drawing.Size(698, 27);
            this.菜单栏.TabIndex = 0;
            this.菜单栏.Text = "darkMenuStrip1";
            // 
            // 菜单
            // 
            this.菜单.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.开始同步ToolStripMenuItem,
            this.开始备份,
            this.删除表,
            this.退出});
            this.菜单.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.菜单.Name = "菜单";
            this.菜单.Size = new System.Drawing.Size(44, 23);
            this.菜单.Text = "菜单";
            // 
            // 开始同步ToolStripMenuItem
            // 
            this.开始同步ToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.开始同步ToolStripMenuItem.Name = "开始同步ToolStripMenuItem";
            this.开始同步ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.开始同步ToolStripMenuItem.Text = "开始同步";
            this.开始同步ToolStripMenuItem.ToolTipText = "从第一页开始，到找到相同项结束";
            // 
            // 开始备份
            // 
            this.开始备份.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.开始备份.Name = "开始备份";
            this.开始备份.Size = new System.Drawing.Size(124, 22);
            this.开始备份.Text = "开始备份";
            this.开始备份.ToolTipText = "从第一页或者上次备份中断页开始，到最后一页为止";
            this.开始备份.Click += new System.EventHandler(this.开始备份_Click);
            // 
            // 删除表
            // 
            this.删除表.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.删除表.Name = "删除表";
            this.删除表.Size = new System.Drawing.Size(124, 22);
            this.删除表.Text = "删除表";
            this.删除表.Click += new System.EventHandler(this.删除表_Click);
            // 
            // 退出
            // 
            this.退出.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.退出.Name = "退出";
            this.退出.Size = new System.Drawing.Size(124, 22);
            this.退出.Text = "退出";
            this.退出.Click += new System.EventHandler(this.退出_Click);
            // 
            // 网站地址
            // 
            this.网站地址.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.网站地址.Name = "网站地址";
            this.网站地址.Size = new System.Drawing.Size(140, 23);
            this.网站地址.Text = "https://sukebei.nyaa.si/";
            // 
            // 工具栏
            // 
            this.工具栏.AutoSize = false;
            this.工具栏.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.工具栏.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.工具栏.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.开始搜索,
            this.选择搜索类型,
            this.搜索字符});
            this.工具栏.Location = new System.Drawing.Point(0, 27);
            this.工具栏.Name = "工具栏";
            this.工具栏.Padding = new System.Windows.Forms.Padding(5, 0, 1, 0);
            this.工具栏.Size = new System.Drawing.Size(698, 47);
            this.工具栏.TabIndex = 8;
            this.工具栏.Text = "darkToolStrip1";
            // 
            // 开始搜索
            // 
            this.开始搜索.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.开始搜索.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.开始搜索.Font = new System.Drawing.Font("Microsoft YaHei UI", 40F);
            this.开始搜索.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.开始搜索.Image = ((System.Drawing.Image)(resources.GetObject("开始搜索.Image")));
            this.开始搜索.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.开始搜索.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.开始搜索.Name = "开始搜索";
            this.开始搜索.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.开始搜索.Size = new System.Drawing.Size(35, 44);
            this.开始搜索.Text = "Search";
            this.开始搜索.Click += new System.EventHandler(this.开始搜索_Click);
            // 
            // 选择搜索类型
            // 
            this.选择搜索类型.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.选择搜索类型.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.选择搜索类型.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.选择搜索类型.Items.AddRange(new object[] {
            "All categories",
            "Art",
            "Art - Anime",
            "Art - Doujinshi",
            "Art - Games",
            "Art - Manga",
            "Art - Pictures",
            "Real Life",
            "Real Life - Pictures",
            "Real Life - Videos"});
            this.选择搜索类型.Name = "选择搜索类型";
            this.选择搜索类型.Size = new System.Drawing.Size(125, 47);
            this.选择搜索类型.ToolTipText = "Search";
            // 
            // 搜索字符
            // 
            this.搜索字符.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.搜索字符.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.搜索字符.Name = "搜索字符";
            this.搜索字符.Size = new System.Drawing.Size(130, 47);
            this.搜索字符.Text = "Search...";
            this.搜索字符.Leave += new System.EventHandler(this.SearchTextBox_Leave);
            this.搜索字符.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SearchTextBox_MouseDown);
            // 
            // 主窗口
            // 
            this.主窗口.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.主窗口.Dock = System.Windows.Forms.DockStyle.Fill;
            this.主窗口.Location = new System.Drawing.Point(0, 74);
            this.主窗口.Name = "主窗口";
            this.主窗口.Size = new System.Drawing.Size(698, 292);
            this.主窗口.TabIndex = 9;
            // 
            // 状态显示
            // 
            this.状态显示.AutoSize = false;
            this.状态显示.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.状态显示.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.状态显示.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.InfoProgressBar,
            this.Info1,
            this.Info2,
            this.Info3,
            this.info4,
            this.info5});
            this.状态显示.Location = new System.Drawing.Point(0, 332);
            this.状态显示.Name = "状态显示";
            this.状态显示.Padding = new System.Windows.Forms.Padding(0, 5, 0, 3);
            this.状态显示.Size = new System.Drawing.Size(698, 34);
            this.状态显示.SizingGrip = false;
            this.状态显示.TabIndex = 10;
            this.状态显示.Text = "darkStatusStrip1";
            // 
            // InfoProgressBar
            // 
            this.InfoProgressBar.Name = "InfoProgressBar";
            this.InfoProgressBar.Size = new System.Drawing.Size(150, 20);
            this.InfoProgressBar.Step = 1;
            // 
            // Info1
            // 
            this.Info1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold);
            this.Info1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Info1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Info1.Name = "Info1";
            this.Info1.Size = new System.Drawing.Size(45, 21);
            this.Info1.Text = "Ready";
            // 
            // Info2
            // 
            this.Info2.Name = "Info2";
            this.Info2.Size = new System.Drawing.Size(0, 21);
            // 
            // Info3
            // 
            this.Info3.Name = "Info3";
            this.Info3.Size = new System.Drawing.Size(0, 21);
            // 
            // info4
            // 
            this.info4.Name = "info4";
            this.info4.Size = new System.Drawing.Size(0, 21);
            // 
            // info5
            // 
            this.info5.Name = "info5";
            this.info5.Size = new System.Drawing.Size(0, 21);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 366);
            this.Controls.Add(this.状态显示);
            this.Controls.Add(this.主窗口);
            this.Controls.Add(this.工具栏);
            this.Controls.Add(this.菜单栏);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.菜单栏;
            this.Name = "Form1";
            this.Text = "Browse :: Sukebei";
            this.菜单栏.ResumeLayout(false);
            this.菜单栏.PerformLayout();
            this.工具栏.ResumeLayout(false);
            this.工具栏.PerformLayout();
            this.状态显示.ResumeLayout(false);
            this.状态显示.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ImageList 类型图;
        private DarkUI.Controls.DarkMenuStrip 菜单栏;
        private System.Windows.Forms.ToolStripMenuItem 菜单;
        private System.Windows.Forms.ToolStripMenuItem 退出;
        private DarkUI.Controls.DarkToolStrip 工具栏;
        private System.Windows.Forms.ToolStripButton 开始搜索;
        private System.Windows.Forms.ToolStripComboBox 选择搜索类型;
        private System.Windows.Forms.ToolStripTextBox 搜索字符;
        private DarkUI.Docking.DarkDockPanel 主窗口;
        private DarkUI.Controls.DarkStatusStrip 状态显示;
        private System.Windows.Forms.ToolStripMenuItem 删除表;
        private System.Windows.Forms.ToolStripStatusLabel Info1;
        private System.Windows.Forms.ToolStripTextBox 网站地址;
        private System.Windows.Forms.ToolStripMenuItem 开始备份;
        private System.Windows.Forms.ToolStripMenuItem 开始同步ToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel Info2;
        private System.Windows.Forms.ToolStripStatusLabel Info3;
        private System.Windows.Forms.ToolStripStatusLabel info4;
        private System.Windows.Forms.ToolStripProgressBar InfoProgressBar;
        private System.Windows.Forms.ToolStripStatusLabel info5;
    }
}

