namespace pkNX.WinForms
{
    partial class SimpleFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
base.Dispose(disposing);
        }


#region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cleanAllRewardBtn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.normalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.生成目录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.TB_Path = new System.Windows.Forms.TextBox();
            this.Dencb = new System.Windows.Forms.ComboBox();
            this.isRarecb = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GameVercb = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Reward999Btn = new System.Windows.Forms.Button();
            this.LastSpeciesBtn = new System.Windows.Forms.Button();
            this.RewardsBtn = new System.Windows.Forms.Button();
            this.RBuRewardsBtn = new System.Windows.Forms.Button();
            this.RaidsBtn = new System.Windows.Forms.Button();
            this.DenMap = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DenMap)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cleanAllRewardBtn
            // 
            this.cleanAllRewardBtn.Location = new System.Drawing.Point(24, 17);
            this.cleanAllRewardBtn.Name = "cleanAllRewardBtn";
            this.cleanAllRewardBtn.Size = new System.Drawing.Size(120, 30);
            this.cleanAllRewardBtn.TabIndex = 1;
            this.cleanAllRewardBtn.Text = "清除所有普通奖励";
            this.cleanAllRewardBtn.UseVisualStyleBackColor = true;
            this.cleanAllRewardBtn.Click += new System.EventHandler(this.cleanAllRewardBtn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.关于ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(369, 25);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.normalToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.openToolStripMenuItem.Text = "打开";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // normalToolStripMenuItem
            // 
            this.normalToolStripMenuItem.Name = "normalToolStripMenuItem";
            this.normalToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.normalToolStripMenuItem.Text = "正常模式";
            this.normalToolStripMenuItem.Click += new System.EventHandler(this.normalToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.exitToolStripMenuItem.Text = "退出";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.生成目录ToolStripMenuItem,
            this.关于ToolStripMenuItem1});
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.关于ToolStripMenuItem.Text = "帮助";
            // 
            // 生成目录ToolStripMenuItem
            // 
            this.生成目录ToolStripMenuItem.Name = "生成目录ToolStripMenuItem";
            this.生成目录ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.生成目录ToolStripMenuItem.Text = "生成目录";
            this.生成目录ToolStripMenuItem.Click += new System.EventHandler(this.生成目录ToolStripMenuItem_Click);
            // 
            // 关于ToolStripMenuItem1
            // 
            this.关于ToolStripMenuItem1.Name = "关于ToolStripMenuItem1";
            this.关于ToolStripMenuItem1.Size = new System.Drawing.Size(124, 22);
            this.关于ToolStripMenuItem1.Text = "关于";
            this.关于ToolStripMenuItem1.Click += new System.EventHandler(this.关于ToolStripMenuItem1_Click);
            // 
            // TB_Path
            // 
            this.TB_Path.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_Path.Location = new System.Drawing.Point(95, 2);
            this.TB_Path.Name = "TB_Path";
            this.TB_Path.ReadOnly = true;
            this.TB_Path.Size = new System.Drawing.Size(274, 21);
            this.TB_Path.TabIndex = 11;
            this.TB_Path.Text = "No Game Loaded";
            // 
            // Dencb
            // 
            this.Dencb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Dencb.FormattingEnabled = true;
            this.Dencb.Location = new System.Drawing.Point(220, 42);
            this.Dencb.Name = "Dencb";
            this.Dencb.Size = new System.Drawing.Size(137, 20);
            this.Dencb.TabIndex = 13;
            this.Dencb.SelectedIndexChanged += new System.EventHandler(this.DenChanged);
            // 
            // isRarecb
            // 
            this.isRarecb.AutoSize = true;
            this.isRarecb.Location = new System.Drawing.Point(206, 78);
            this.isRarecb.Name = "isRarecb";
            this.isRarecb.Size = new System.Drawing.Size(72, 16);
            this.isRarecb.TabIndex = 14;
            this.isRarecb.Text = "是否紫柱";
            this.isRarecb.UseVisualStyleBackColor = true;
            this.isRarecb.CheckedChanged += new System.EventHandler(this.DenChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(193, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 12);
            this.label1.TabIndex = 24;
            this.label1.Text = "坑:";
            // 
            // GameVercb
            // 
            this.GameVercb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GameVercb.FormattingEnabled = true;
            this.GameVercb.Items.AddRange(new object[] {
            "剑",
            "盾"});
            this.GameVercb.Location = new System.Drawing.Point(300, 76);
            this.GameVercb.Name = "GameVercb";
            this.GameVercb.Size = new System.Drawing.Size(57, 20);
            this.GameVercb.TabIndex = 26;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Reward999Btn);
            this.groupBox2.Controls.Add(this.LastSpeciesBtn);
            this.groupBox2.Controls.Add(this.cleanAllRewardBtn);
            this.groupBox2.Location = new System.Drawing.Point(196, 111);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(161, 142);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "常用功能";
            // 
            // Reward999Btn
            // 
            this.Reward999Btn.Location = new System.Drawing.Point(24, 98);
            this.Reward999Btn.Name = "Reward999Btn";
            this.Reward999Btn.Size = new System.Drawing.Size(120, 30);
            this.Reward999Btn.TabIndex = 3;
            this.Reward999Btn.Text = "改团战特殊奖励999";
            this.Reward999Btn.UseVisualStyleBackColor = true;
            this.Reward999Btn.Click += new System.EventHandler(this.Reward999Btn_Click);
            // 
            // LastSpeciesBtn
            // 
            this.LastSpeciesBtn.Location = new System.Drawing.Point(24, 58);
            this.LastSpeciesBtn.Name = "LastSpeciesBtn";
            this.LastSpeciesBtn.Size = new System.Drawing.Size(120, 30);
            this.LastSpeciesBtn.TabIndex = 2;
            this.LastSpeciesBtn.Text = "此巢穴最后一只pm";
            this.LastSpeciesBtn.UseVisualStyleBackColor = true;
            this.LastSpeciesBtn.Click += new System.EventHandler(this.LastSpeciesBtn_Click);
            // 
            // RewardsBtn
            // 
            this.RewardsBtn.Location = new System.Drawing.Point(24, 59);
            this.RewardsBtn.Name = "RewardsBtn";
            this.RewardsBtn.Size = new System.Drawing.Size(120, 30);
            this.RewardsBtn.TabIndex = 4;
            this.RewardsBtn.Text = "修改普通奖励";
            this.RewardsBtn.UseVisualStyleBackColor = true;
            this.RewardsBtn.Click += new System.EventHandler(this.RewardsBtn_Click);
            // 
            // RBuRewardsBtn
            // 
            this.RBuRewardsBtn.Location = new System.Drawing.Point(24, 96);
            this.RBuRewardsBtn.Name = "RBuRewardsBtn";
            this.RBuRewardsBtn.Size = new System.Drawing.Size(120, 30);
            this.RBuRewardsBtn.TabIndex = 3;
            this.RBuRewardsBtn.Text = "修改特殊奖励";
            this.RBuRewardsBtn.UseVisualStyleBackColor = true;
            this.RBuRewardsBtn.Click += new System.EventHandler(this.RBuRewardsBtn_Click);
            // 
            // RaidsBtn
            // 
            this.RaidsBtn.Location = new System.Drawing.Point(24, 22);
            this.RaidsBtn.Name = "RaidsBtn";
            this.RaidsBtn.Size = new System.Drawing.Size(120, 30);
            this.RaidsBtn.TabIndex = 2;
            this.RaidsBtn.Text = "修改巢穴精灵";
            this.RaidsBtn.UseVisualStyleBackColor = true;
            this.RaidsBtn.Click += new System.EventHandler(this.RaidsBtn_Click);
            // 
            // DenMap
            // 
            this.DenMap.BackgroundImage = global::pkNX.WinForms.Properties.Resources.map;
            this.DenMap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.DenMap.Location = new System.Drawing.Point(12, 29);
            this.DenMap.Name = "DenMap";
            this.DenMap.Size = new System.Drawing.Size(167, 369);
            this.DenMap.TabIndex = 12;
            this.DenMap.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RewardsBtn);
            this.groupBox1.Controls.Add(this.RaidsBtn);
            this.groupBox1.Controls.Add(this.RBuRewardsBtn);
            this.groupBox1.Location = new System.Drawing.Point(196, 259);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(161, 139);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "原始功能";
            // 
            // SimpleFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 401);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.GameVercb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.isRarecb);
            this.Controls.Add(this.Dencb);
            this.Controls.Add(this.DenMap);
            this.Controls.Add(this.TB_Path);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(385, 440);
            this.MinimumSize = new System.Drawing.Size(385, 440);
            this.Name = "SimpleFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "pkNX - Simple1.6 - BY cale";
            this.Load += new System.EventHandler(this.SimpleFrm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DenMap)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

            }


#endregion
        private System.Windows.Forms.Button cleanAllRewardBtn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem normalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TextBox TB_Path;
        private System.Windows.Forms.PictureBox DenMap;
        private System.Windows.Forms.ComboBox Dencb;
        private System.Windows.Forms.CheckBox isRarecb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox GameVercb;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.Button RaidsBtn;
        private System.Windows.Forms.Button RBuRewardsBtn;
        private System.Windows.Forms.Button RewardsBtn;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Reward999Btn;
        private System.Windows.Forms.Button LastSpeciesBtn;
        private System.Windows.Forms.ToolStripMenuItem 生成目录ToolStripMenuItem;
    }
}