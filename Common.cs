using SedentaryReminder.util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SedentaryReminder
{
    class Common
    {
        // 程序数据存放地址
        public static readonly string PATH = $"C:\\Users\\{Environment.UserName}\\AppData\\Local\\SedentaryReminder\\";
        
        public static readonly string DEFAULT_KEY_REMINDER_TEXT = "Alt+Shift+I：忽视本次活动提醒，重新进行计时\r\n\r\nAlt+SHift+G：起身活动/活动结束";
        public static readonly string DEFAULT_SEDENTARY_REMINDER_TEXT = "活动时间到了，起身活动一下并向远方眺望放松一下眼部压力。";

        // 配置文件节点
        public static readonly string NODE_MAIN = "main";
        public static readonly string NODE_END = "endsetting";
        public static readonly string NODE_REMINDER = "reminderSetting";

        // 主设置项
        public static readonly string MAIN_FIRST_RUN = "first";
        public static readonly string MAIN_REMINDER_TIME = "reminderTime";
        public static readonly string MAIN_STOP_REMINDER_TIME = "stopReminderTime";
        public static readonly string MAIN_REMINDER_MODE = "reminderType";
        public static readonly string MAIN_SELF_START = "selfStarting";
        public static readonly string MAIN_AUTO_START = "autoStarting";

        // 关闭设置项
        public static readonly string END_REMEMBER_CHOICE = "rememberChoice";
        public static readonly string END_MINIMIZE = "minimize";
        public static readonly string END_FINISH = "finish";

        // 久坐提醒设置项
        public static readonly string REMINDER_REMINDER_TEXT = "prompt";
        public static readonly string REMINDER_IGNORE_FUNC_KEY = "ignoreFunctionKey";
        public static readonly string REMINDER_IGNORE_KEY = "ignoreKey";
        public static readonly string REMINDER_ACTIVITY_FUNC_KEY = "getFunctionKey";
        public static readonly string REMINDER_ACTIVITY_KEY = "getKey";
        public static readonly string REMINDER_MUSIC_ADDRESS = "musicAddress";
        public static readonly string REMINDER_BACKGROUND_ADDRESS = "backgroundAddress";
        public static readonly string REMINDER_DISPLAY_REMINDER_TEXT = "displayPrompt";
        public static readonly string REMINDER_DISPLAY_KEY_AND_TIPS = "displayKeyAndTime";
        public static readonly string REMINDER_TEXT_COLOR = "textColor";
        public static readonly string REMINDER_WINDOW_SHADOW = "windowsShadow";

        // 全局设置配置文件IniUtil类
        public static readonly IniUtil iniSetting = new IniUtil(PATH, "setting.ini");

    }
}
