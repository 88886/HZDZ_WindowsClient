using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO.MemoryMappedFiles;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocalWinFormHZdz
{
    public partial class ProfileForm : Form
    {
        public ProfileForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void ProfileForm_Load(object sender, EventArgs e)
        {
            MainMethodInterface MMI = new MainMethodInterface();
            Task<string[]> Tasks = Task.Factory.StartNew<string[]>(() => MMI.GetUserDetailInfo());
            Task<string[]> Tasks0 = Task.Factory.StartNew<string[]>(() => MMI.GetTodayOrderInfo());
            Task<string[]> Tasks1 = Task.Factory.StartNew<string[]>(() => MMI.GetUserWalletInfo());
            Task<ArrayList> Tasks2 = Task.Factory.StartNew<ArrayList>(() => MMI.GetEachOrderDetailsWithId());
            string[] UserInfoList = Tasks.Result;
            string[] OrderCountInfo = Tasks0.Result;
            string[] UserWalletInfo = Tasks1.Result;
            ArrayList LendingOrderInfo = Tasks2.Result;
            if (LendingOrderInfo != null)
            {
                string ShownTime, FullText;
                int SubHours;
                foreach (var EachInfo in LendingOrderInfo)
                {
                    JObject GetDeailInfo = MMI.GetSerialJson(EachInfo.ToString());
                    JToken OrderNum = GetDeailInfo["orderNum"];
                    JToken LendingExpireTime = GetDeailInfo["leaseExpireTime"];
                    JToken Status = GetDeailInfo["status"];
                    JToken PayNum = GetDeailInfo["realPrice"];
                    JToken OrderClass = GetDeailInfo["specName"];
                    DateTime ExpirTime = MMI.GetTimeSampToDate(LendingExpireTime.ToString());
                    ShownTime = ExpirTime.ToString();
                    if (Status.ToString() == "2")
                    {
                        Status = "租用中";
                    }
                    PayNum = MMI.GetFormatDoubleString(PayNum.ToString());
                    FullText = $"订单编号:#{OrderNum.ToString()}\n\n状态:{Status}\n\n到期时间:{ExpirTime}\n\n规格:{OrderClass.ToString()}\n\n支付金额:{PayNum}元\n\n#######################################\n";
                    LendingTB.Text += FullText;
                    DateTime NowLocalTime = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                    TimeSpan TimeSub = ExpirTime - NowLocalTime;
                    SubHours = TimeSub.Hours;
                    if (SubHours <= 2)
                    {
                        MessageBox.Show("有一个或者多个订单距离到期时间只有两个小时,请注意", "注意", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                LendingTB.ForeColor = Color.Red;
                LendingTB.Text = "暂时没有租用中的订单\n\n\n软件5分钟刷新一次信息\n\n\n也可以退出重新登录获取最新订单信息";
                HZDZHOMEWEB.Text="点击这里查看登录官网查询";
                XUNLEILABEL.Text = "点击这里快速修改迅雷密码";
            }

            if (UserInfoList == null || OrderCountInfo == null)
            {
                MessageBox.Show("发生异常错误！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            if (UserInfoList != null)
            {
                UserNameLabel.Text += UserInfoList[6];//用户名
                UserEmail.Text += UserInfoList[1];//邮箱
                UserPhoneNum.Text += UserInfoList[4];//手机号码
                UserPayAccount.Text += UserInfoList[3];//收款账号
                UserShopLevel.Text += UserInfoList[5];//店铺等级
                UserRealName.Text += UserInfoList[2];
            }

            if (OrderCountInfo != null)
            {
                OrderLabel.Text += OrderCountInfo[1];
                PriceLabel.Text += OrderCountInfo[2] + "元";
            }
            if (OrderCountInfo != null)
            {
                TotalLeave.Text += UserWalletInfo[0] + "元";
                CanRecLabel.Text += UserWalletInfo[1] + "元";
                Lendinglabel.Text += UserWalletInfo[2] + "元";
            }

        }
        

    private void UserInfoGroup_Enter(object sender, EventArgs e)
    {
        //this.UserInfoGroup.Size = Size.Empty;
    }

    private void tabPage1_Click(object sender, EventArgs e)
    {

    }

    private void ProfileForm_KeyDown(object sender, KeyEventArgs e)
    {

    }

    private void ProfileForm_FormClosed(object sender, FormClosedEventArgs e)
    {
        Application.Exit();
    }

    private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
    {


    }

        private void HZDZHOMEWEB_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(HzWebApi.LoginUrlApiAddress.Substring(0,18));
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Application.Restart();
          

            //ProfileForm.ControlCollection m=new ProfileForm().Controls;
           //ProfileForm.
         
        }

        private void XUNLEILABEL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://i.xunlei.com/xluser/login.html");
        }
    }
}

