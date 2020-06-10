using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
namespace LocalWinFormHZdz
{
    public partial class MainFormLogin : Form
    {
        public MainFormLogin()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MainMethodInterface MMF = new MainMethodInterface();
            if (MMF.GetNetWorkStatus() == true)
            {
                StatusLabel.ForeColor = Color.Green;
                StatusLabel.Text = "网络连接正常，请登录";
            }
            else
            {
                StatusLabel.Text = string.Format("网络连接异常，3秒后将会退出...");
                this.Enabled = false;
                Task.Run(
                    async delegate
                    {
                        await Task.Delay(3000);
                        Application.Exit();
                    }
                    );

            }
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            MainMethodInterface MainMethod = new MainMethodInterface();
            string Uname, Upassword;
            Uname = UserNameBox.Text.Trim();
            Upassword = PasswordBox.Text.Trim();
            if (Uname == "" || Upassword == "")
            {
                StatusLabel.ForeColor = Color.Red;
                StatusLabel.Text = "请输入账号或者密码";
            }
            else
            {
                StatusLabel.Text = "正在登录中...";
                //使用task进行多线程操作获取带有返回值的函数，lamba表达式
                Task<string[]> Tasks = Task.Factory.StartNew<string[]>(() => MainMethod.PostHttpResponJson(HzWebApi.LoginUrlApiAddress, Uname, Upassword));
                string[] LoginInfoArray = Tasks.Result;
                if (LoginInfoArray.Length != 0)
                {
                    //StatusLabel.Text = "登录成功";
                    //Task.Delay(1000);
                    this.Hide();
                    ProfileForm PFM = new ProfileForm();
                    PFM.Show();
                        
                       
                    
                }
                else
                {
                    StatusLabel.ForeColor = Color.Red;
                    StatusLabel.Text = "登录失败,可能是密码或者账号错误";
                }
            }
            

            

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string regstring = @"[\u4e00-\u9fff]";
            Regex r = new Regex(regstring);
            Match m = r.Match(UserNameBox.Text);
            Match m1 = r.Match(PasswordBox.Text);
            if (m.Success || m1.Success)
            {
                UserNameBox.Text = "";
                PasswordBox.Text = "";
            }

        }

        private void MainFormLogin_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void PasswordBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PasswordBox_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                LoginButton_Click(sender, e);
            }
        }

        private void MainFormLogin_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void LoginButton_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Application.Exit();
            }
        }

        public void MainFormLogin_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                IconMin.Visible = true;
                this.Hide();
            }
        }

        public void IconMin_DoubleClick(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            IconMin.Visible = false;
            //IconMin.Dispose();
        }

        public void nmslToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            IconMin.Visible = false;
            //IconMin.Dispose();
        }

        public void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
