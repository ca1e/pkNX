namespace pkNX.WinForms.Simple
{
    partial class DropItemUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DropItemUI));
            this.mainpanel = new System.Windows.Forms.Panel();
            this.FLP_ctrls = new System.Windows.Forms.FlowLayoutPanel();
            this.DenTypecb = new System.Windows.Forms.ComboBox();
            this.tablehash = new System.Windows.Forms.Label();
            this.mainpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainpanel
            // 
            this.mainpanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.mainpanel.Controls.Add(this.FLP_ctrls);
            this.mainpanel.Location = new System.Drawing.Point(2, 28);
            this.mainpanel.Name = "mainpanel";
            this.mainpanel.Size = new System.Drawing.Size(382, 233);
            this.mainpanel.TabIndex = 1;
            // 
            // FLP_ctrls
            // 
            this.FLP_ctrls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FLP_ctrls.Location = new System.Drawing.Point(0, 0);
            this.FLP_ctrls.Name = "FLP_ctrls";
            this.FLP_ctrls.Size = new System.Drawing.Size(382, 233);
            this.FLP_ctrls.TabIndex = 1;
            // 
            // DenTypecb
            // 
            this.DenTypecb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DenTypecb.FormattingEnabled = true;
            this.DenTypecb.Items.AddRange(new object[] {
            "普通光柱",
            "特殊光柱",
            "未知1",
            "未知2",
            "铠岛红柱1",
            "铠岛紫柱1",
            "铠岛红柱蛋",
            "铠岛紫柱蛋",
            "铠岛红柱2",
            "铠岛紫柱2"});
            this.DenTypecb.Location = new System.Drawing.Point(116, 3);
            this.DenTypecb.Name = "DenTypecb";
            this.DenTypecb.Size = new System.Drawing.Size(121, 20);
            this.DenTypecb.TabIndex = 2;
            this.DenTypecb.SelectedIndexChanged += new System.EventHandler(this.DenTypecb_SelectedIndexChanged);
            // 
            // tablehash
            // 
            this.tablehash.AutoSize = true;
            this.tablehash.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tablehash.Location = new System.Drawing.Point(243, 7);
            this.tablehash.Name = "tablehash";
            this.tablehash.Size = new System.Drawing.Size(31, 14);
            this.tablehash.TabIndex = 3;
            this.tablehash.Text = "hash";
            // 
            // DropItemUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.tablehash);
            this.Controls.Add(this.DenTypecb);
            this.Controls.Add(this.mainpanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(400, 300);
            this.Name = "DropItemUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "特殊掉落奖励(红/紫坑)";
            this.Load += new System.EventHandler(this.DropItemUI_Load);
            this.mainpanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion
        private System.Windows.Forms.Panel mainpanel;
        private System.Windows.Forms.FlowLayoutPanel FLP_ctrls;
        private System.Windows.Forms.ComboBox DenTypecb;
        private System.Windows.Forms.Label tablehash;
    }
}