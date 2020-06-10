namespace LocalWinFormHZdz
{
    partial class EditProductForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditProductForm));
            this.ProductNameLabel = new System.Windows.Forms.Label();
            this.ProductAccount = new System.Windows.Forms.Label();
            this.ProductPassword = new System.Windows.Forms.Label();
            this.ProductExpireTime = new System.Windows.Forms.Label();
            this.ProductnameBox = new System.Windows.Forms.TextBox();
            this.ProductUname = new System.Windows.Forms.TextBox();
            this.ProductUpassword = new System.Windows.Forms.TextBox();
            this.ProductExpirtime = new System.Windows.Forms.TextBox();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Editstatus = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // ProductNameLabel
            // 
            this.ProductNameLabel.AutoSize = true;
            this.ProductNameLabel.Location = new System.Drawing.Point(12, 23);
            this.ProductNameLabel.Name = "ProductNameLabel";
            this.ProductNameLabel.Size = new System.Drawing.Size(65, 12);
            this.ProductNameLabel.TabIndex = 0;
            this.ProductNameLabel.Text = "商品名称：";
            // 
            // ProductAccount
            // 
            this.ProductAccount.AutoSize = true;
            this.ProductAccount.Location = new System.Drawing.Point(12, 57);
            this.ProductAccount.Name = "ProductAccount";
            this.ProductAccount.Size = new System.Drawing.Size(65, 12);
            this.ProductAccount.TabIndex = 1;
            this.ProductAccount.Text = "商品账号：";
            // 
            // ProductPassword
            // 
            this.ProductPassword.AutoSize = true;
            this.ProductPassword.Location = new System.Drawing.Point(12, 88);
            this.ProductPassword.Name = "ProductPassword";
            this.ProductPassword.Size = new System.Drawing.Size(65, 12);
            this.ProductPassword.TabIndex = 2;
            this.ProductPassword.Text = "商品密码：";
            // 
            // ProductExpireTime
            // 
            this.ProductExpireTime.AutoSize = true;
            this.ProductExpireTime.Location = new System.Drawing.Point(12, 118);
            this.ProductExpireTime.Name = "ProductExpireTime";
            this.ProductExpireTime.Size = new System.Drawing.Size(65, 12);
            this.ProductExpireTime.TabIndex = 3;
            this.ProductExpireTime.Text = "到期时间：";
            // 
            // ProductnameBox
            // 
            this.ProductnameBox.Location = new System.Drawing.Point(72, 23);
            this.ProductnameBox.Name = "ProductnameBox";
            this.ProductnameBox.Size = new System.Drawing.Size(100, 21);
            this.ProductnameBox.TabIndex = 4;
            // 
            // ProductUname
            // 
            this.ProductUname.Location = new System.Drawing.Point(72, 50);
            this.ProductUname.Name = "ProductUname";
            this.ProductUname.Size = new System.Drawing.Size(100, 21);
            this.ProductUname.TabIndex = 5;
            // 
            // ProductUpassword
            // 
            this.ProductUpassword.Location = new System.Drawing.Point(71, 85);
            this.ProductUpassword.Name = "ProductUpassword";
            this.ProductUpassword.Size = new System.Drawing.Size(100, 21);
            this.ProductUpassword.TabIndex = 6;
            // 
            // ProductExpirtime
            // 
            this.ProductExpirtime.Location = new System.Drawing.Point(72, 112);
            this.ProductExpirtime.Name = "ProductExpirtime";
            this.ProductExpirtime.ReadOnly = true;
            this.ProductExpirtime.Size = new System.Drawing.Size(100, 21);
            this.ProductExpirtime.TabIndex = 7;
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(12, 139);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(75, 23);
            this.SubmitButton.TabIndex = 8;
            this.SubmitButton.Text = "确认修改";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(97, 139);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 9;
            this.closeButton.Text = "关闭窗口";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Editstatus
            // 
            this.Editstatus.AutoSize = true;
            this.Editstatus.Location = new System.Drawing.Point(69, 8);
            this.Editstatus.Name = "Editstatus";
            this.Editstatus.Size = new System.Drawing.Size(0, 12);
            this.Editstatus.TabIndex = 10;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(12, 165);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(161, 12);
            this.linkLabel1.TabIndex = 11;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "请点击这里打开迅雷安全中心";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // EditProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(183, 181);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.Editstatus);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.ProductExpirtime);
            this.Controls.Add(this.ProductUpassword);
            this.Controls.Add(this.ProductUname);
            this.Controls.Add(this.ProductnameBox);
            this.Controls.Add(this.ProductExpireTime);
            this.Controls.Add(this.ProductPassword);
            this.Controls.Add(this.ProductAccount);
            this.Controls.Add(this.ProductNameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "EditProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "修改商品";
            this.Load += new System.EventHandler(this.EditProductForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ProductNameLabel;
        private System.Windows.Forms.Label ProductAccount;
        private System.Windows.Forms.Label ProductPassword;
        private System.Windows.Forms.Label ProductExpireTime;
        private System.Windows.Forms.TextBox ProductnameBox;
        private System.Windows.Forms.TextBox ProductUname;
        private System.Windows.Forms.TextBox ProductUpassword;
        private System.Windows.Forms.TextBox ProductExpirtime;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label Editstatus;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}