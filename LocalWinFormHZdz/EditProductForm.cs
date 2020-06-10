using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Newtonsoft.Json;

namespace LocalWinFormHZdz
{
    public partial class EditProductForm : Form
    {
        public EditProductForm()
        {
            InitializeComponent();
        }

        private void EditProductForm_Load(object sender, EventArgs e)
        {
            string goodid;
            //ProfileForm PF = new ProfileForm();
            MainMethodInterface MMI = new MainMethodInterface();
            goodid = ProfileForm.goodid;
            HzWebApi.ProductDetailsApiAddress = "http://m.idsdz.com/api/applet-shop/workbench/goodsdetail?goodsId=" + goodid;
            MMI.GetProductDetailsOutMethod(out JToken JpostToken, out string[] FullInfoList, HzWebApi.ProductDetailsApiAddress);
            ProductnameBox.Text = FullInfoList[0].Trim();
            ProductUname.Text = FullInfoList[1].Trim();
            ProductUpassword.Text = FullInfoList[2].Trim();
            ProductExpirtime.Text =MMI.GetTimeSampToDate( FullInfoList[3].Trim()).ToString("yyyy-MM-dd");
            

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            string goodid;
            MainMethodInterface MMI = new MainMethodInterface();
            goodid = ProfileForm.goodid;
            HzWebApi.ProductDetailsApiAddress = "http://m.idsdz.com/api/applet-shop/workbench/goodsdetail?goodsId=" + goodid;
            MMI.GetProductDetailsOutMethod(out JToken JpostToken, out string[] FullInfoList, HzWebApi.ProductDetailsApiAddress);
            string UpdateProductName, UpdateUserName, UPdatePassword;
            UpdateProductName = ProductnameBox.Text.Trim();
            UpdateUserName = ProductUname.Text.Trim();
            UPdatePassword = ProductUpassword.Text.Trim();
            JArray JsonArrayText = JArray.Parse(JpostToken["skuJson"].ToString());
            JArray JsonDescPic = JArray.Parse(JpostToken["descriptionImages"].ToString());
            JObject NewParaOBJ = new JObject();
            NewParaOBJ.Add("id",goodid);
            NewParaOBJ.Add("shelfId",JpostToken["shelfId"]);
            NewParaOBJ.Add("categoryId",JpostToken["categoryId"]);
            NewParaOBJ.Add("goodsName",UpdateProductName);
            NewParaOBJ.Add("username", UpdateUserName);
            NewParaOBJ.Add("password",UPdatePassword);
            NewParaOBJ.Add("usernameExpire",ProductExpirtime.Text);
            NewParaOBJ.Add("stockTotal",JpostToken["stockTotal"]);
            NewParaOBJ.Add("description",JpostToken["description"]);
            NewParaOBJ.Add("sku", JsonArrayText);
            NewParaOBJ.Add("descriptionImages",JsonDescPic);
            Task<string> TS = Task.Factory.StartNew<string>(() =>MMI.PostHttp(NewParaOBJ,HzWebApi.UpdateProductApiAddress));
            Editstatus.Text = "正在提交修改...";
            Editstatus.ForeColor = Color.Green;
            string Message = TS.Result;
            if (Message != null)
            {
                MessageBox.Show(Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Editstatus.Text = "";
                this.Close();
                Application.Restart();
            }
            else
            {
                MessageBox.Show("修改失败","提示",MessageBoxButtons.OK,MessageBoxIcon.Error);
                Editstatus.Text = "";
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string regstring = @"[\u4e00-\u9fff]";
            Regex r = new Regex(regstring);
            Match m = r.Match(ProductUname.Text);
            Match m1 = r.Match(ProductUpassword.Text);
            if (m.Success || m1.Success)
            {
                ProductUname.Text = "";
                ProductUpassword.Text = "";
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://i.xunlei.com/xluser/login.html");
        }
    }
}
