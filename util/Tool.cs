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

        /// <summary>
        /// 把秒转为类似于10天23小时59分钟59秒的文本
        /// </summary>
        /// <param name="second">秒</param>
        /// <param name="supplementZero">是否在时间上增补0</param>
        /// <returns></returns>
        public static string SecondToTime(int second, bool supplementZero = true)
        {
            int day = second / 86400;
            int hour = second / 3600 - day * 24;
            int minute = second / 60 - hour * 60 - day * 1440;
            int mSecond = second - minute * 60 - hour * 3600 - day * 86400;

            string str = "";
            if (supplementZero)
                str = (day.ToString().Length < 2 ? "0" + day : day.ToString()) + "天" +
                    (hour.ToString().Length < 2 ? "0" + hour : hour.ToString()) + "时" +
                    (minute.ToString().Length < 2 ? "0" + minute : minute.ToString()) + "分" +
                    (mSecond.ToString().Length < 2 ? "0" + mSecond : mSecond.ToString()) + "秒";
            else
                str = day + "天" + hour + "时" + minute + "分" + mSecond + "秒";
            return str;
        }

        /// <summary>
        /// 通过索引返回功能鍵文字，例如Ctrl+Shift等文本
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public static string GetFuncKeyString(int index)
        {
            switch (index)
            {
                case 1:
                    return "Ctrl+";
                case 2:
                    return "Shift+";
                case 3:
                    return "Alt+";
                case 4:
                    return "Ctrl+Shift+";
                case 5:
                    return "Alt+Shift+";
                case 6:
                    return "Ctrl+Alt+";
                case 7:
                    return "Ctrl+Shift+Alt+";
                default:
                    return "";
            }
        }

        /// <summary>
        /// 通过索引返回功能鍵
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public static HotKey.KeyModifiers GetFuncKey(int index)
        {
            switch (index)
            {
                case 0:
                    return HotKey.KeyModifiers.None;
                case 1:
                    return HotKey.KeyModifiers.Ctrl;
                case 2:
                    return HotKey.KeyModifiers.Shift;
                case 3:
                    return HotKey.KeyModifiers.Alt;
                case 4:
                    return HotKey.KeyModifiers.Ctrl | HotKey.KeyModifiers.Shift;
                case 5:
                    return HotKey.KeyModifiers.Alt | HotKey.KeyModifiers.Shift;
                case 6:
                    return HotKey.KeyModifiers.Ctrl | HotKey.KeyModifiers.Alt;
                case 7:
                    return HotKey.KeyModifiers.Ctrl | HotKey.KeyModifiers.Shift | HotKey.KeyModifiers.Alt;
                default:
                    return HotKey.KeyModifiers.None;
            }
        }

        /// <summary>
        /// 通过索引返回鍵文字，例如F1、F2等文本
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public static string GetKeyString(int index)
        {
            switch (index)
            {
                case 0:
                    return "F1";
                case 1:
                    return "F2";
                case 2:
                    return "F3";
                case 3:
                    return "F4";
                case 4:
                    return "F5";
                case 5:
                    return "F6";
                case 6:
                    return "F7";
                case 7:
                    return "F8";
                case 8:
                    return "F9";
                case 9:
                    return "F10";
                case 10:
                    return "F11";
                case 11:
                    return "F12";
                case 12:
                    return "1";
                case 13:
                    return "2";
                case 14:
                    return "3";
                case 15:
                    return "4";
                case 16:
                    return "5";
                case 17:
                    return "6";
                case 18:
                    return "7";
                case 19:
                    return "8";
                case 20:
                    return "9";
                case 21:
                    return "0";
                case 22:
                    return "A";
                case 23:
                    return "B";
                case 24:
                    return "C";
                case 25:
                    return "D";
                case 26:
                    return "E";
                case 27:
                    return "F";
                case 28:
                    return "G";
                case 29:
                    return "H";
                case 30:
                    return "I";
                case 31:
                    return "J";
                case 32:
                    return "K";
                case 33:
                    return "L";
                case 34:
                    return "M";
                case 35:
                    return "N";
                case 36:
                    return "O";
                case 37:
                    return "P";
                case 38:
                    return "Q";
                case 39:
                    return "R";
                case 40:
                    return "S";
                case 41:
                    return "T";
                case 42:
                    return "U";
                case 43:
                    return "V";
                case 44:
                    return "W";
                case 45:
                    return "X";
                case 46:
                    return "Y";
                case 47:
                    return "Z";
                default:
                    return "";
            }


        }

        /// <summary>
        /// 通过索引返回鍵
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public static Keys GetKey(int index)
        {
            switch (index)
            {
                case 0:
                    return Keys.F1;
                case 1:
                    return Keys.F2;
                case 2:
                    return Keys.F3;
                case 3:
                    return Keys.F4;
                case 4:
                    return Keys.F5;
                case 5:
                    return Keys.F6;
                case 6:
                    return Keys.F7;
                case 7:
                    return Keys.F8;
                case 8:
                    return Keys.F9;
                case 9:
                    return Keys.F10;
                case 10:
                    return Keys.F11;
                case 11:
                    return Keys.F12;
                case 12:
                    return Keys.NumPad1;
                case 13:
                    return Keys.NumPad2;
                case 14:
                    return Keys.NumPad3;
                case 15:
                    return Keys.NumPad4;
                case 16:
                    return Keys.NumPad5;
                case 17:
                    return Keys.NumPad6;
                case 18:
                    return Keys.NumPad7;
                case 19:
                    return Keys.NumPad8;
                case 20:
                    return Keys.NumPad9;
                case 21:
                    return Keys.NumPad0;
                case 22:
                    return Keys.A;
                case 23:
                    return Keys.B;
                case 24:
                    return Keys.C;
                case 25:
                    return Keys.D;
                case 26:
                    return Keys.E;
                case 27:
                    return Keys.F;
                case 28:
                    return Keys.G;
                case 29:
                    return Keys.H;
                case 30:
                    return Keys.I;
                case 31:
                    return Keys.J;
                case 32:
                    return Keys.K;
                case 33:
                    return Keys.L;
                case 34:
                    return Keys.M;
                case 35:
                    return Keys.N;
                case 36:
                    return Keys.O;
                case 37:
                    return Keys.P;
                case 38:
                    return Keys.Q;
                case 39:
                    return Keys.R;
                case 40:
                    return Keys.S;
                case 41:
                    return Keys.T;
                case 42:
                    return Keys.U;
                case 43:
                    return Keys.V;
                case 44:
                    return Keys.W;
                case 45:
                    return Keys.X;
                case 46:
                    return Keys.Y;
                case 47:
                    return Keys.Z;
                default:
                    return Keys.None;
            }


        }


    }
}
