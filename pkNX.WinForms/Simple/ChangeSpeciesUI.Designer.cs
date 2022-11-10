namespace pkNX.WinForms.Simple
{
    partial class ChangeSpeciesUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeSpeciesUI));
            this.splabel = new System.Windows.Forms.Label();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.IsGmaxcb = new System.Windows.Forms.CheckBox();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.speciesCb = new System.Windows.Forms.ComboBox();
            this.spnlabel = new System.Windows.Forms.Label();
            this.halabel = new System.Windows.Forms.Label();
            this.Abilitycb = new System.Windows.Forms.ComboBox();
            this.IVslabel = new System.Windows.Forms.Label();
            this.FlawlessIVscb = new System.Windows.Forms.ComboBox();
            this.IwannaAllcb = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // splabel
            // 
            this.splabel.AutoSize = true;
            this.splabel.Location = new System.Drawing.Point(42, 92);
            this.splabel.Name = "splabel";
            this.splabel.Size = new System.Drawing.Size(65, 12);
            this.splabel.TabIndex = 0;
            this.splabel.Text = "精灵种族：";
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(125, 181);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(105, 35);
            this.SaveBtn.TabIndex = 0;
            this.SaveBtn.Text = "保存";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // IsGmaxcb
            // 
            this.IsGmaxcb.AutoSize = true;
            this.IsGmaxcb.Location = new System.Drawing.Point(123, 129);
            this.IsGmaxcb.Name = "IsGmaxcb";
            this.IsGmaxcb.Size = new System.Drawing.Size(84, 16);
            this.IsGmaxcb.TabIndex = 3;
            this.IsGmaxcb.Text = "是否超级巨";
            this.IsGmaxcb.UseVisualStyleBackColor = true;
            this.IsGmaxcb.CheckedChanged += new System.EventHandler(this.IsGmaxcb_CheckedChanged);
            // 
            // CancelBtn
            // 
            this.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBtn.Location = new System.Drawing.Point(22, 181);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(65, 35);
            this.CancelBtn.TabIndex = 4;
            this.CancelBtn.Text = "取消";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // speciesCb
            // 
            this.speciesCb.FormattingEnabled = true;
            this.speciesCb.Location = new System.Drawing.Point(123, 89);
            this.speciesCb.Name = "speciesCb";
            this.speciesCb.Size = new System.Drawing.Size(107, 20);
            this.speciesCb.TabIndex = 5;
            // 
            // spnlabel
            // 
            this.spnlabel.AutoSize = true;
            this.spnlabel.Location = new System.Drawing.Point(121, 112);
            this.spnlabel.Name = "spnlabel";
            this.spnlabel.Size = new System.Drawing.Size(59, 12);
            this.spnlabel.TabIndex = 6;
            this.spnlabel.Text = "种族值：1";
            // 
            // halabel
            // 
            this.halabel.AutoSize = true;
            this.halabel.Location = new System.Drawing.Point(66, 20);
            this.halabel.Name = "halabel";
            this.halabel.Size = new System.Drawing.Size(41, 12);
            this.halabel.TabIndex = 7;
            this.halabel.Text = "特性：";
            // 
            // Abilitycb
            // 
            this.Abilitycb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Abilitycb.FormattingEnabled = true;
            this.Abilitycb.Items.AddRange(new object[] {
            "特性1",
            "特性2",
            "梦特",
            "普特",
            "任意"});
            this.Abilitycb.Location = new System.Drawing.Point(123, 17);
            this.Abilitycb.Name = "Abilitycb";
            this.Abilitycb.Size = new System.Drawing.Size(107, 20);
            this.Abilitycb.TabIndex = 9;
            this.Abilitycb.SelectedIndexChanged += new System.EventHandler(this.Abilitycb_SelectedIndexChanged);
            // 
            // IVslabel
            // 
            this.IVslabel.AutoSize = true;
            this.IVslabel.Location = new System.Drawing.Point(20, 56);
            this.IVslabel.Name = "IVslabel";
            this.IVslabel.Size = new System.Drawing.Size(89, 12);
            this.IVslabel.TabIndex = 10;
            this.IVslabel.Text = "至少完美IV数：";
            // 
            // FlawlessIVscb
            // 
            this.FlawlessIVscb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FlawlessIVscb.FormattingEnabled = true;
            this.FlawlessIVscb.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.FlawlessIVscb.Location = new System.Drawing.Point(123, 53);
            this.FlawlessIVscb.Name = "FlawlessIVscb";
            this.FlawlessIVscb.Size = new System.Drawing.Size(107, 20);
            this.FlawlessIVscb.TabIndex = 11;
            this.FlawlessIVscb.SelectedIndexChanged += new System.EventHandler(this.FlawlessIVscb_SelectedIndexChanged);
            // 
            // IwannaAllcb
            // 
            this.IwannaAllcb.AutoSize = true;
            this.IwannaAllcb.Location = new System.Drawing.Point(22, 151);
            this.IwannaAllcb.Name = "IwannaAllcb";
            this.IwannaAllcb.Size = new System.Drawing.Size(216, 16);
            this.IwannaAllcb.TabIndex = 12;
            this.IwannaAllcb.Text = "我全都要(将坑内所有精灵改为这个)";
            this.IwannaAllcb.UseVisualStyleBackColor = true;
            // 
            // ChangeSpeciesUI
            // 
            this.AcceptButton = this.SaveBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelBtn;
            this.ClientSize = new System.Drawing.Size(261, 228);
            this.Controls.Add(this.IwannaAllcb);
            this.Controls.Add(this.FlawlessIVscb);
            this.Controls.Add(this.IVslabel);
            this.Controls.Add(this.Abilitycb);
            this.Controls.Add(this.halabel);
            this.Controls.Add(this.spnlabel);
            this.Controls.Add(this.speciesCb);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.IsGmaxcb);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.splabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChangeSpeciesUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "修改巢穴精灵";
            this.Load += new System.EventHandler(this.ChangeSpeciesUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label splabel;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.CheckBox IsGmaxcb;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.ComboBox speciesCb;
        private System.Windows.Forms.Label spnlabel;
        private System.Windows.Forms.Label halabel;
        private System.Windows.Forms.ComboBox Abilitycb;
        private System.Windows.Forms.Label IVslabel;
        private System.Windows.Forms.ComboBox FlawlessIVscb;
        private System.Windows.Forms.CheckBox IwannaAllcb;
    }
}