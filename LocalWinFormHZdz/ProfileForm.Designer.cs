namespace LocalWinFormHZdz
{
    partial class ProfileForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfileForm));
            this.UserInfoGroup = new System.Windows.Forms.GroupBox();
            this.UserRealName = new System.Windows.Forms.Label();
            this.UserShopLevel = new System.Windows.Forms.Label();
            this.UserPayAccount = new System.Windows.Forms.Label();
            this.UserPhoneNum = new System.Windows.Forms.Label();
            this.UserEmail = new System.Windows.Forms.Label();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.UserWalletGp = new System.Windows.Forms.GroupBox();
            this.Lendinglabel = new System.Windows.Forms.Label();
            this.CanRecLabel = new System.Windows.Forms.Label();
            this.TotalLeave = new System.Windows.Forms.Label();
            this.TodayGroupInfo = new System.Windows.Forms.GroupBox();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.OrderLabel = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.XUNLEILABEL = new System.Windows.Forms.LinkLabel();
            this.HZDZHOMEWEB = new System.Windows.Forms.LinkLabel();
            this.LendingTB = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.Category1 = new System.Windows.Forms.GroupBox();
            this.CategoryInfo1 = new System.Windows.Forms.Label();
            this.EditButton1 = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.IconMin = new System.Windows.Forms.NotifyIcon(this.components);
            this.RightMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.nmslToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.UserInfoGroup.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.UserWalletGp.SuspendLayout();
            this.TodayGroupInfo.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.Category1.SuspendLayout();
            this.RightMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserInfoGroup
            // 
            this.UserInfoGroup.AutoSize = true;
            this.UserInfoGroup.Controls.Add(this.UserRealName);
            this.UserInfoGroup.Controls.Add(this.UserShopLevel);
            this.UserInfoGroup.Controls.Add(this.UserPayAccount);
            this.UserInfoGroup.Controls.Add(this.UserPhoneNum);
            this.UserInfoGroup.Controls.Add(this.UserEmail);
            this.UserInfoGroup.Controls.Add(this.UserNameLabel);
            this.UserInfoGroup.Location = new System.Drawing.Point(8, 6);
            this.UserInfoGroup.Name = "UserInfoGroup";
            this.UserInfoGroup.Size = new System.Drawing.Size(245, 178);
            this.UserInfoGroup.TabIndex = 1;
            this.UserInfoGroup.TabStop = false;
            this.UserInfoGroup.Text = "用户信息";
            this.UserInfoGroup.MouseHover += new System.EventHandler(this.UserInfoGroup_Enter);
            // 
            // UserRealName
            // 
            this.UserRealName.AutoSize = true;
            this.UserRealName.Location = new System.Drawing.Point(15, 149);
            this.UserRealName.Name = "UserRealName";
            this.UserRealName.Size = new System.Drawing.Size(65, 12);
            this.UserRealName.TabIndex = 6;
            this.UserRealName.Text = "真实姓名：";
            // 
            // UserShopLevel
            // 
            this.UserShopLevel.AutoSize = true;
            this.UserShopLevel.Location = new System.Drawing.Point(15, 126);
            this.UserShopLevel.Name = "UserShopLevel";
            this.UserShopLevel.Size = new System.Drawing.Size(65, 12);
            this.UserShopLevel.TabIndex = 5;
            this.UserShopLevel.Text = "店铺等级：";
            // 
            // UserPayAccount
            // 
            this.UserPayAccount.AutoSize = true;
            this.UserPayAccount.Location = new System.Drawing.Point(15, 101);
            this.UserPayAccount.Name = "UserPayAccount";
            this.UserPayAccount.Size = new System.Drawing.Size(65, 12);
            this.UserPayAccount.TabIndex = 4;
            this.UserPayAccount.Text = "收款账号：";
            // 
            // UserPhoneNum
            // 
            this.UserPhoneNum.AutoSize = true;
            this.UserPhoneNum.Location = new System.Drawing.Point(15, 80);
            this.UserPhoneNum.Name = "UserPhoneNum";
            this.UserPhoneNum.Size = new System.Drawing.Size(41, 12);
            this.UserPhoneNum.TabIndex = 3;
            this.UserPhoneNum.Text = "手机：";
            // 
            // UserEmail
            // 
            this.UserEmail.AutoSize = true;
            this.UserEmail.Location = new System.Drawing.Point(15, 55);
            this.UserEmail.Name = "UserEmail";
            this.UserEmail.Size = new System.Drawing.Size(41, 12);
            this.UserEmail.TabIndex = 2;
            this.UserEmail.Text = "邮箱：";
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Location = new System.Drawing.Point(15, 26);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(41, 12);
            this.UserNameLabel.TabIndex = 1;
            this.UserNameLabel.Text = "昵称：";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(296, 401);
            this.tabControl1.TabIndex = 2;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.UserWalletGp);
            this.tabPage1.Controls.Add(this.TodayGroupInfo);
            this.tabPage1.Controls.Add(this.UserInfoGroup);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(288, 375);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "用户资料";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // UserWalletGp
            // 
            this.UserWalletGp.AutoSize = true;
            this.UserWalletGp.Controls.Add(this.Lendinglabel);
            this.UserWalletGp.Controls.Add(this.CanRecLabel);
            this.UserWalletGp.Controls.Add(this.TotalLeave);
            this.UserWalletGp.Location = new System.Drawing.Point(8, 257);
            this.UserWalletGp.Name = "UserWalletGp";
            this.UserWalletGp.Size = new System.Drawing.Size(245, 92);
            this.UserWalletGp.TabIndex = 3;
            this.UserWalletGp.TabStop = false;
            this.UserWalletGp.Text = "收益详情";
            // 
            // Lendinglabel
            // 
            this.Lendinglabel.AutoSize = true;
            this.Lendinglabel.Location = new System.Drawing.Point(125, 29);
            this.Lendinglabel.Name = "Lendinglabel";
            this.Lendinglabel.Size = new System.Drawing.Size(77, 12);
            this.Lendinglabel.TabIndex = 2;
            this.Lendinglabel.Text = "未结算金额：";
            // 
            // CanRecLabel
            // 
            this.CanRecLabel.AutoSize = true;
            this.CanRecLabel.Location = new System.Drawing.Point(6, 62);
            this.CanRecLabel.Name = "CanRecLabel";
            this.CanRecLabel.Size = new System.Drawing.Size(77, 12);
            this.CanRecLabel.TabIndex = 1;
            this.CanRecLabel.Text = "可提现金额：";
            // 
            // TotalLeave
            // 
            this.TotalLeave.AutoSize = true;
            this.TotalLeave.Location = new System.Drawing.Point(6, 29);
            this.TotalLeave.Name = "TotalLeave";
            this.TotalLeave.Size = new System.Drawing.Size(53, 12);
            this.TotalLeave.TabIndex = 0;
            this.TotalLeave.Text = "总余额：";
            // 
            // TodayGroupInfo
            // 
            this.TodayGroupInfo.AutoSize = true;
            this.TodayGroupInfo.Controls.Add(this.PriceLabel);
            this.TodayGroupInfo.Controls.Add(this.OrderLabel);
            this.TodayGroupInfo.Location = new System.Drawing.Point(8, 190);
            this.TodayGroupInfo.Name = "TodayGroupInfo";
            this.TodayGroupInfo.Size = new System.Drawing.Size(245, 61);
            this.TodayGroupInfo.TabIndex = 2;
            this.TodayGroupInfo.TabStop = false;
            this.TodayGroupInfo.Text = "今日订单";
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Location = new System.Drawing.Point(125, 29);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(53, 12);
            this.PriceLabel.TabIndex = 1;
            this.PriceLabel.Text = "总金额：";
            // 
            // OrderLabel
            // 
            this.OrderLabel.AutoSize = true;
            this.OrderLabel.Location = new System.Drawing.Point(6, 29);
            this.OrderLabel.Name = "OrderLabel";
            this.OrderLabel.Size = new System.Drawing.Size(53, 12);
            this.OrderLabel.TabIndex = 0;
            this.OrderLabel.Text = "订单数：";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(288, 375);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "租用订单查询";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.XUNLEILABEL);
            this.groupBox1.Controls.Add(this.HZDZHOMEWEB);
            this.groupBox1.Controls.Add(this.LendingTB);
            this.groupBox1.Location = new System.Drawing.Point(8, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(277, 335);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "租用中订单";
            // 
            // XUNLEILABEL
            // 
            this.XUNLEILABEL.AutoSize = true;
            this.XUNLEILABEL.Location = new System.Drawing.Point(16, 186);
            this.XUNLEILABEL.Name = "XUNLEILABEL";
            this.XUNLEILABEL.Size = new System.Drawing.Size(0, 12);
            this.XUNLEILABEL.TabIndex = 2;
            this.XUNLEILABEL.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.XUNLEILABEL_LinkClicked);
            // 
            // HZDZHOMEWEB
            // 
            this.HZDZHOMEWEB.AutoSize = true;
            this.HZDZHOMEWEB.Location = new System.Drawing.Point(16, 141);
            this.HZDZHOMEWEB.Name = "HZDZHOMEWEB";
            this.HZDZHOMEWEB.Size = new System.Drawing.Size(0, 12);
            this.HZDZHOMEWEB.TabIndex = 1;
            this.HZDZHOMEWEB.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.HZDZHOMEWEB_LinkClicked);
            // 
            // LendingTB
            // 
            this.LendingTB.AutoSize = true;
            this.LendingTB.Location = new System.Drawing.Point(16, 27);
            this.LendingTB.Name = "LendingTB";
            this.LendingTB.Size = new System.Drawing.Size(0, 12);
            this.LendingTB.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.Category1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(288, 375);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "货架管理";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // Category1
            // 
            this.Category1.AutoSize = true;
            this.Category1.Controls.Add(this.CategoryInfo1);
            this.Category1.Controls.Add(this.EditButton1);
            this.Category1.Location = new System.Drawing.Point(8, 3);
            this.Category1.Name = "Category1";
            this.Category1.Size = new System.Drawing.Size(277, 83);
            this.Category1.TabIndex = 0;
            this.Category1.TabStop = false;
            this.Category1.Text = "货架1";
            // 
            // CategoryInfo1
            // 
            this.CategoryInfo1.AutoSize = true;
            this.CategoryInfo1.Location = new System.Drawing.Point(7, 21);
            this.CategoryInfo1.Name = "CategoryInfo1";
            this.CategoryInfo1.Size = new System.Drawing.Size(0, 12);
            this.CategoryInfo1.TabIndex = 1;
            // 
            // EditButton1
            // 
            this.EditButton1.Location = new System.Drawing.Point(196, 40);
            this.EditButton1.Name = "EditButton1";
            this.EditButton1.Size = new System.Drawing.Size(75, 23);
            this.EditButton1.TabIndex = 0;
            this.EditButton1.Text = "编辑";
            this.EditButton1.UseVisualStyleBackColor = true;
            this.EditButton1.Visible = false;
            this.EditButton1.Click += new System.EventHandler(this.EditButton1_Click);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 300000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // IconMin
            // 
            this.IconMin.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Warning;
            this.IconMin.BalloonTipText = "nmsl";
            this.IconMin.BalloonTipTitle = "nmsl";
            this.IconMin.ContextMenuStrip = this.RightMenu;
            this.IconMin.Icon = ((System.Drawing.Icon)(resources.GetObject("IconMin.Icon")));
            this.IconMin.Text = "号子短租";
            this.IconMin.DoubleClick += new System.EventHandler(this.IconMin_DoubleClick);
            // 
            // RightMenu
            // 
            this.RightMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nmslToolStripMenuItem,
            this.toolStripMenuItem1});
            this.RightMenu.Name = "RightMenu";
            this.RightMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.RightMenu.Size = new System.Drawing.Size(95, 48);
            this.RightMenu.Text = "test";
            // 
            // nmslToolStripMenuItem
            // 
            this.nmslToolStripMenuItem.Name = "nmslToolStripMenuItem";
            this.nmslToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.nmslToolStripMenuItem.Text = "显示";
            this.nmslToolStripMenuItem.Click += new System.EventHandler(this.nmslToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(94, 22);
            this.toolStripMenuItem1.Text = "退出";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // ProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 399);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ProfileForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "号子短租-控制台";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ProfileForm_FormClosed);
            this.Load += new System.EventHandler(this.ProfileForm_Load);
            this.SizeChanged += new System.EventHandler(this.ProfileForm_SizeChanged);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ProfileForm_KeyDown);
            this.UserInfoGroup.ResumeLayout(false);
            this.UserInfoGroup.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.UserWalletGp.ResumeLayout(false);
            this.UserWalletGp.PerformLayout();
            this.TodayGroupInfo.ResumeLayout(false);
            this.TodayGroupInfo.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.Category1.ResumeLayout(false);
            this.Category1.PerformLayout();
            this.RightMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox UserInfoGroup;
        private System.Windows.Forms.Label UserShopLevel;
        private System.Windows.Forms.Label UserPayAccount;
        private System.Windows.Forms.Label UserPhoneNum;
        private System.Windows.Forms.Label UserEmail;
        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.Label UserRealName;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox TodayGroupInfo;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Label OrderLabel;
        private System.Windows.Forms.GroupBox UserWalletGp;
        private System.Windows.Forms.Label CanRecLabel;
        private System.Windows.Forms.Label TotalLeave;
        private System.Windows.Forms.Label Lendinglabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LendingTB;
        private System.Windows.Forms.LinkLabel HZDZHOMEWEB;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.LinkLabel XUNLEILABEL;
        private System.Windows.Forms.NotifyIcon IconMin;
        private System.Windows.Forms.ContextMenuStrip RightMenu;
        private System.Windows.Forms.ToolStripMenuItem nmslToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox Category1;
        private System.Windows.Forms.Button EditButton1;
        private System.Windows.Forms.Label CategoryInfo1;
    }
}