using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SedentaryReminder.util
{
    class Tool
    {
        /// <summary>
        /// 设置程序是否开机自启，通过修改注册表键值实现
        /// </summary>
        /// <param name="isAuto"></param>
        /// <returns></returns>
        public static bool AutoStart(bool isAuto = true)
        {
            try
            {
                RegistryKey R_local = Registry.CurrentUser;
                RegistryKey R_run = R_local.CreateSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run");
                if (isAuto)
                {
                    R_run.SetValue("久坐提醒", Application.ExecutablePath);
                    R_run.Close();
                    R_local.Close();
                }
                else
                {
                    R_run.DeleteValue("久坐提醒", false);
                    R_run.Close();
                    R_local.Close();
                }
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
    }
}
