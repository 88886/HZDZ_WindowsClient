using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Net;
using System.IO;
using System.Web;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.Collections;
using System.Configuration;
using System.Diagnostics;
/*2020年6月2日，0:53休息，下一步开发获取用户资料信息等功能，目前登录功能已开发完毕，晚安啊！*/
/*2020年6月3日,2:34开发完毕,下一步进行本文件优化，进行异常处理捕获，晚安。*/
/*2020年6月10日，16：36新增功能货架管理，至此最新版本为1.1.5,本人停止继续开发,项目结束.*/
namespace LocalWinFormHZdz
{
    struct HzWebApi
    {
        public const string LoginUrlApiAddress = "http://m.idsdz.com/api/user/login";//登录接口
        public const string AllOrderApiAddress = "http://m.idsdz.com/api/applet-order/workOrder/list";
        public const string WalletApiAddress = "http://m.idsdz.com/api/applet-user/income/info";//获取余额接口
        public const string UserDetailInfoApiAddress = "http://m.idsdz.com/api/applet-user/user/info";//用户详细信息
        public const string UserShopProductApiAddress = "http://m.idsdz.com/api/applet-shop/workbench/shelflist";//货架管理
        public const string UpdateProductApiAddress = "http://m.idsdz.com/api/applet-shop/workbench/updategoods";
        public static string Orderstatus;//订单状态
        public static string OrderApiAddress;
        public static string SuccessCookie;
        public static string TodayDetailApiAddress;
        public static string OrderDetailsApiAddress;
        public static string ProductDetailsApiAddress;
    }
    public class MainMethodInterface
    {
        public MainMethodInterface()
        {
          //
        }
        public void GetProductDetailsOutMethod(out JToken PostList, out string[] DetailInfoList,string ApiUrl)
        {//获取一个商品的详细资料
            JObject JBJ = GetHttpResponJson(ApiUrl);
            JToken RSPCODE = JBJ["code"];
            JToken RSData = JBJ["data"];
            PostList = RSData;
            string[] TestArray=new string[4];
            if (RSPCODE.ToString() == "200")
            {
                PostList = RSData;
                string Product_desc, Product_UserName, Product_UserPassword, Product_ExpireTime;
                Product_desc = RSData["goodsName"].ToString();
                Product_UserName = RSData["goodsUsername"].ToString();
                Product_UserPassword = RSData["goodsPassword"].ToString();
                Product_ExpireTime = RSData["expireTime"].ToString();
                TestArray[0]= Product_desc;//商品名称
                TestArray[1] = Product_UserName;//用户名
                TestArray[2] = Product_UserPassword;//密码
                TestArray[3] = Product_ExpireTime;//到期时间
                DetailInfoList = TestArray;
            }
            else
            {
                PostList = null;
                DetailInfoList = null;
            }

        }//获取货架商品详细信息
        public string[] GetUserProductList()
        {
            Dictionary<string,string> ProductInfoDetails = new Dictionary<string,string>();
            JObject JBJ = GetHttpResponJson(HzWebApi.UserShopProductApiAddress);
            JToken RespCode = JBJ["code"];
            if (RespCode.ToString() == "200")
            {
                string ProductStatus, ProductName, ProductClass, GoodId;
                JToken RespData = JBJ["data"];
                ProductStatus = RespData[0]["shelfStatus"].ToString();
                ProductName = RespData[0]["shelfName"].ToString();
                ProductClass = RespData[0]["specNames"].ToString();
                GoodId = RespData[0]["goodsId"].ToString();
                string[] ProductList = { ProductStatus, ProductName, ProductClass, GoodId };
                return ProductList;
            }
            else
            {
                return null;
            }
            //JToken ts = JBJ["data"];
            //MessageBox.Show(ts.ToString());
           // return new string[3];
        }//获取产品列表，但是我就只想获取一个。
        public ArrayList GetEachOrderDetailsWithId()//通过ID获取订单详情 返回一个字符串数组，可转换为Jobject格式
        {
            try
            {
                ArrayList IdList = GetLendingOrderDetail();
                if (IdList == null)
                {
                    return null;
                }
                else
                {
                    ArrayList DataArray = new ArrayList();
                    HzWebApi.OrderApiAddress = "http://m.idsdz.com/api/applet-order/order/detail?orderId=";
                    foreach (var DataList in IdList)
                    {
                        JObject JOBJ = GetHttpResponJson(HzWebApi.OrderApiAddress + DataList.ToString());
                        JToken JCode = JOBJ["code"];
                        if (JCode.ToString() != "200")
                        {
                            return null;
                        }
                        JToken JData = JOBJ["data"];
                        DataArray.Add(JData.ToString());
                    }
                    return DataArray;
                }
            }
            catch (NullReferenceException)
            {
                return null;
            }
            
            
        }
        private ArrayList GetLendingOrderDetail()//获取租用订单详情
        {
            ArrayList AllDetailIdList = GetUserOrderIdList();
            ArrayList ReturnIds=new ArrayList();
            foreach (var EachId in AllDetailIdList)
            {
                ReturnIds.Add(EachId.ToString());
            }
            if (AllDetailIdList == null)
            {
                return null;
            }
            else
            {
                return ReturnIds;
            }
            
        }
        public DateTime GetTimeSampToDate(string Timesamp)//时间戳转日期时间
        {
            DateTime UnixDate = TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(1970, 1, 1));
            TimeSpan AddTimeSpan = new TimeSpan(long.Parse(Timesamp.ToString()) * 10000L);
            DateTime ReturnDatetime = UnixDate.Add(AddTimeSpan);
            return ReturnDatetime;
        }
        public JObject GetSerialJson(string InputString)//获取字符串的Json表示
        {
            JObject ReturnJobj = JObject.Parse(InputString);
            return ReturnJobj;
        }
        private ArrayList GetUserOrderIdList()//获取租用中的Id列表
        {
            HzWebApi.Orderstatus = "2" ;//租用中
            string OrStaus = HzWebApi.Orderstatus;
            HzWebApi.OrderApiAddress = "http://m.idsdz.com/api/applet-order/workOrder/list?status="+OrStaus;
            JObject JOBJ = GetHttpResponJson(HzWebApi.OrderApiAddress);
            JToken JtokenCode = JOBJ["code"];
            JArray JtokenList = JArray.Parse(JOBJ["data"]["list"].ToString());
            int JtokenListLength;
            JtokenListLength = JtokenList.Count;
            if (JtokenListLength < 1)
            {
                return null;
            }
            else
            {
                ArrayList FullInfoList = new ArrayList();
                for (int i = 0; i < JtokenListLength; i++)
                {
                    JObject JbJ = GetSerialJson(JtokenList[i].ToString());
                    FullInfoList.Add(JbJ["id"]);//获取Id
                }
                return FullInfoList;
            }
            //2020年6月2日 17:53 开发到了获取订单的操作，下班了，我要回家了，告辞。
        }
        public string[] GetUserWalletInfo()//获取用户余额等信息
        {
            JObject OBJ_Json = GetHttpResponJson(HzWebApi.WalletApiAddress);
            JToken JtokenCode = OBJ_Json["code"];
            JToken JtokenTotalNum = OBJ_Json["data"]["totalPrice"];//总余额
            JToken JtokenCanRecNum = OBJ_Json["data"]["settlement"];//可提现
            JToken JtokenLendingNum = OBJ_Json["data"]["unSettlement"];//未结算
            string StrTotalNum, StrCanRecNum, StrLendingNum;
            StrTotalNum = GetFormatDoubleString(JtokenTotalNum.ToString());
            StrCanRecNum = GetFormatDoubleString(JtokenCanRecNum.ToString());
            StrLendingNum = GetFormatDoubleString(JtokenLendingNum.ToString());
            if (JtokenCode.ToString() != "200")
            {
                return null;
            }
            else
            {
                string[] UserWalletInfo = { StrTotalNum, StrCanRecNum, StrLendingNum };
                return UserWalletInfo;
                //0-总余额，1-可提现余额，2-未结算金额
            }
            


        }
        public string GetFormatDoubleString(string InputDoubleString)//转换号子短租的金额格式
        {
            string DoubleFormatString;
            double TempDoubleNum;
            TempDoubleNum = double.Parse(InputDoubleString)/100;
            DoubleFormatString = TempDoubleNum.ToString("F");
            return DoubleFormatString;
        }
        public string[] GetTodayOrderInfo()//获取当日订单
        {
            string TodayDateTimeStr = DateTime.Now.ToString("yyyy-MM-dd");
            HzWebApi.TodayDetailApiAddress = $@"http://m.idsdz.com/api/applet-order/workOrder/income?toDay={TodayDateTimeStr}";
            string TodayApiInfoAddr = HzWebApi.TodayDetailApiAddress;
            JObject ResponseObj = GetHttpResponJson(TodayApiInfoAddr);
            JToken JtokenCode = ResponseObj["code"];
            JToken JtokenOderCount = ResponseObj["data"]["orderCount"];
            JToken JtokenNumCount = ResponseObj["data"]["totalPrice"];
            string Code, OrdercountNum,StringPrice;
            //double PriceNum;
            Code = JtokenCode.ToString();
            OrdercountNum = JtokenOderCount.ToString();
            StringPrice = GetFormatDoubleString(JtokenNumCount.ToString());
            if (Code != "200")
            {
                return null;
            }
            else
            {
                string[] TodayOderInfoArray = { Code, OrdercountNum , StringPrice};
                return TodayOderInfoArray;

            }
            

        }
        public bool GetNetWorkStatus()//获取网络状态
        {
            const string BaiduUrl = "m.idsdz.com";
            bool Netstatus;
            Ping NetPing = new Ping();
            try
            {
                PingReply NetReply = NetPing.Send(BaiduUrl);
                if (NetReply.Status != IPStatus.Success)
                {
                    Netstatus = false;
                }
                else
                {
                    Netstatus = true;
                }
            }
            catch (System.Net.NetworkInformation.PingException)
            {
                Netstatus = false;
            }
            return Netstatus;
        }
        public string[] GetUserDetailInfo()//获取用户信息
        {
            JObject RawResponseJson=GetHttpResponJson(HzWebApi.UserDetailInfoApiAddress);
            JToken CodeJson = RawResponseJson["code"].ToString();
            JToken HookEmaliJson = RawResponseJson["data"]["email"].ToString();
            JToken RealName = RawResponseJson["data"]["name"].ToString();
            JToken AliPayAccount = RawResponseJson["data"]["payUsername"].ToString();
            JToken UserPhoneNum = RawResponseJson["data"]["phone"].ToString();
            JToken UserShopLevel = RawResponseJson["data"]["shopLevel"].ToString();
            JToken UserShowName = RawResponseJson["data"]["username"].ToString();
            string Code, Email, Rname, ApAccount, UPhoneNum, UShopLevel, UShowName;
            Code = CodeJson.ToString();
            Email = HookEmaliJson.ToString();
            Rname = RealName.ToString();
            ApAccount = AliPayAccount.ToString();
            UPhoneNum = UserPhoneNum.ToString();
            UShopLevel = UserShopLevel.ToString();
            UShowName = UserShowName.ToString();
            if (Code != "200" || Rname == "")
            {
                return null;
            }
            else
            {
                string[] UserInfoArray = { Code, Email, Rname, ApAccount, UPhoneNum, UShopLevel, UShowName };
                //0-状态码，1-用户邮箱，2-用户认证真实姓名，3-收款账号，4-用户绑定手机号码，5-用户店铺等级，6-用户名
                return UserInfoArray;
            }
           
        }
        //GET方法获取
        private JObject GetHttpResponJson(string InputUrl,string DefaultMethod = "GET")
        {
            string ResponeResult,GetCookie;
            HttpWebRequest MainRequest = (HttpWebRequest)WebRequest.Create(InputUrl);
            MainRequest.Method = DefaultMethod;
            GetCookie = HzWebApi.SuccessCookie;
            MainRequest.KeepAlive = true;
            if (GetCookie != null)
            {
                MainRequest.Headers.Add("Cookie", $"token={GetCookie}");
                MainRequest.Headers.Add("Authorization", $"Bearer {GetCookie}");
                HttpWebResponse MainResponse = (HttpWebResponse)MainRequest.GetResponse();
                //MainResponse.Headers.Add("Cookie", "token=123");
                Stream ResponeObject = MainResponse.GetResponseStream();
                StreamReader MainReturnText = new StreamReader(ResponeObject, Encoding.UTF8);
                ResponeResult = MainReturnText.ReadToEnd();
                JObject JOBJ = JObject.Parse(ResponeResult);
                return JOBJ;
            }
            else
            {
                return null;
            }
            
        }
        //POST方法获取
        public string[] PostHttpResponJson(string InputUrl, string UserName, string Password, string DefaultMethod = "POST")
        {
            string ResponeResult;
            HttpWebRequest MainRequest = (HttpWebRequest)WebRequest.Create(InputUrl);
            MainRequest.Method = DefaultMethod;
            MainRequest.ContentType = "application/json;charset=UTF-8";
            JObject PostParJson = new JObject();
            PostParJson.Add("password",Password);
            PostParJson.Add("username", UserName);
            string PostJsonStr = PostParJson.ToString();
            byte[] PostInfo = Encoding.ASCII.GetBytes(PostJsonStr);
            Stream PostStream = MainRequest.GetRequestStream();
            PostStream.Write(PostInfo,0,PostInfo.Length);
            PostStream.Close();
            HttpWebResponse MainResponse = (HttpWebResponse)MainRequest.GetResponse();
            Stream ResponeObject = MainResponse.GetResponseStream();
            StreamReader MainReturnText = new StreamReader(ResponeObject, Encoding.UTF8);
            ResponeResult = MainReturnText.ReadToEnd();
            string Code, AccessToken, RefreshToken, Msg;
            JObject JOBJ = JObject.Parse(ResponeResult);
            JToken ReturnCode=JOBJ["code"];
            Code = ReturnCode.ToString();
            if (Code=="200")
            {
                JToken ReturnAccessToken = JOBJ["data"]["access_token"];
                JToken ReturnRefreshToken = JOBJ["data"]["refresh_token"];
                JToken ReturnMsg = JOBJ["msg"];
                AccessToken = ReturnAccessToken.ToString();
                RefreshToken = ReturnRefreshToken.ToString();
                Msg = ReturnMsg.ToString();
                //0-状态码，1-accesstoken值，2-refreshtoken值，3-msg的值
                HzWebApi.SuccessCookie = AccessToken;
                string[] ReturnArray = { Code, AccessToken, RefreshToken, Msg };
                return ReturnArray;
            }
            else
            {
                string[] Tester = { };
                return Tester;
            }
            
        }
        public string PostHttp(JObject para,string InputUrl)
        {
            string ResponeResult, GetCookie;
            GetCookie = HzWebApi.SuccessCookie;
            HttpWebRequest MainRequest = (HttpWebRequest)WebRequest.Create(InputUrl);
            MainRequest.Method = "POST";
            MainRequest.ContentType = "application/json;charset=UTF-8";
            MainRequest.Headers.Add("Cookie", $"token={GetCookie}");
            MainRequest.Headers.Add("Authorization", $"Bearer {GetCookie}");
            JObject PostParJson = new JObject();
            //PostParJson.Add("nmsl","");
            //JObject JsonStr = JObject.Parse(para);
            //string jtest;
            //jtest = JsonStr.ToString();
            Debug.WriteLine(para);
            byte[] JsonStrByte = Encoding.UTF8.GetBytes(para.ToString());
            Stream STm = MainRequest.GetRequestStream();
            STm.Write(JsonStrByte,0, JsonStrByte.Length);
            STm.Close();
            HttpWebResponse MainResponse = (HttpWebResponse)MainRequest.GetResponse();
            Stream ResponeObject = MainResponse.GetResponseStream();
            StreamReader MainReturnText = new StreamReader(ResponeObject, Encoding.UTF8);
            ResponeResult = MainReturnText.ReadToEnd();
            string Code, AccessToken, RefreshToken, Msg;
            JObject JOBJ = JObject.Parse(ResponeResult);
            JToken ReturnCode = JOBJ["code"];
            Code = ReturnCode.ToString();
            if (Code == "200")
            {
                string Result = JOBJ["msg"].ToString();
                return Result;

            }
            else
            {
                return null;
            }
        }
    }
}
