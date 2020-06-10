using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.Configuration;
using Microsoft.Win32;

namespace LocalWinFormHZdz
{
     class MainFile
    {
        public static void SetRegeditData(String HKLM_SOFT_Dir_Name, String Sub_Dir_Name, String Key_Name, String Key_Value)
        {
            RegistryKey hklm = Registry.LocalMachine.OpenSubKey("SOFTWARE", true);
            RegistryKey software;
            if (IsRegeditDirExist(HKLM_SOFT_Dir_Name))
            {
                software = hklm.OpenSubKey(HKLM_SOFT_Dir_Name, true);
            }
            else
            {
                software = hklm.CreateSubKey(HKLM_SOFT_Dir_Name);
            }
            RegistryKey aimdir = software.CreateSubKey(Sub_Dir_Name);
            aimdir.SetValue(Key_Name, Key_Value);
        }
        public static bool IsRegeditDirExist(String HKLM_SOFT_Dir_Name)
        {
            bool _exit = false;
            string[] subkeyNames;
            RegistryKey hklm = Registry.LocalMachine.OpenSubKey("SOFTWARE", true);
            subkeyNames = hklm.GetSubKeyNames();
            foreach (string DirName in subkeyNames)
            {
                if (DirName == HKLM_SOFT_Dir_Name)
                {
                    _exit = true;
                    return _exit;
                }
            }
            return _exit;
        }
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            bool test=MainFile.IsRegeditDirExist("LocHzdz");
            //string FlagStr; 
            if (test == false)
            {
                string TempStringVersion = @"当前版本：Version1.1.5
#########
版本更新记录:
v1.1.5
增加了编辑个人商品货架的功能
#########
v1.1.4
增加了托盘图标
修复了双击托盘显示窗口
不正常的bug
#########
v1.1.3
取消自动刷新功能，更改为自动注销重启登录
增加了迅雷快捷密码快捷修改网址
增加号子短租快捷登录网址
优化软件性能，提示用户体验
#########
v1.1.2
修复了等待刷新会导致数据重叠的情况
#########
v1.1.0
修复了没有租用订单会导致程序出现异常的bug
#########
v1.0.0
添加网络状态检测和输入内容优化";
                MessageBox.Show(TempStringVersion, "更新日志");
                MainFile.SetRegeditData("LocHzdz", "LocHzdz", "LocHzdz", "LocHzdz");
            }
            AppDomain.CurrentDomain.AssemblyResolve += CurrentDomain_AssemblyResolve;//调用
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainFormLogin());


        }
        private static Assembly CurrentDomain_AssemblyResolve(object sender, ResolveEventArgs args)
        {
            //调用DLL函数，对应改成路径名称
            string resourceName = "LocalWinFormHZdz." + new AssemblyName(args.Name).Name + ".dll";
            using (var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(resourceName))
            {
                byte[] assemblyData = new byte[stream.Length];
                stream.Read(assemblyData, 0, assemblyData.Length);
                return Assembly.Load(assemblyData);
            }
        }
    }
}
