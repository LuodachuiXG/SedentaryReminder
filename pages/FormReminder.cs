using SedentaryReminder.util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SedentaryReminder.pages
{
    public partial class FormReminder : Form
    {

        private FormStart parentForm = null;
        private int reminderMode = -1;

        private IniUtil ini = Common.iniSetting;

        private const int WM_HOTKEY = 0x312; //窗口消息：热键
        private const int WM_CREATE = 0x1; //窗口消息：创建
        private const int WM_DESTROY = 0x2; //窗口消息：销毁

        private int hotKey_ignore = 0;
        private int hotKey_activity = 1;

        // 音乐控制
        private Music music = new Music();

        // 记录起身活动时间（秒）
        private int activityTimeRecord = 0;

        // 标记快捷键和起身活动计时标签是否显示
        private string displayKeyAndTime = "Y";

        public FormReminder(FormStart parentForm, int reminderMode)
        {
            this.parentForm = parentForm;
            this.reminderMode = reminderMode;
            InitializeComponent();
        }

        private void FormReminder_Load(object sender, EventArgs e)
        {
            init();
        }

        private void init()
        {
            // 判断提示文本是否设置，否则使用默认文本
            label_reminderText.Text = ini.ReadString(Common.NODE_REMINDER, 
                Common.REMINDER_REMINDER_TEXT, Common.DEFAULT_SEDENTARY_REMINDER_TEXT);

            int reminderMode = ini.ReadInt(Common.NODE_MAIN, Common.MAIN_REMINDER_MODE, 0);
            // 根据提示类型设置本窗所在屏幕位置（不包括任务栏宽高）
            int screenWidth = Screen.PrimaryScreen.WorkingArea.Width;
            int screenHeight = Screen.PrimaryScreen.WorkingArea.Height;
            if (reminderMode == 0)
                // 右下
                this.Location = new Point(screenWidth - this.Size.Width, screenHeight - this.Size.Height);
            else if (reminderMode == 1)
                // 左下
                this.Location = new Point(0, screenHeight - this.Size.Height);
            else if (reminderMode == 2)
                // 右上
                this.Location = new Point(screenWidth - this.Size.Width, 0);
            else if (reminderMode == 3)
                // 左上
                this.Location = new Point(0, 0);
            else if (reminderMode == 4)
                // 居中
                this.Location = new Point(screenWidth / 2 - this.Size.Width / 2, screenHeight / 2 - this.Size.Height / 2);


            // 判断是否设置了音乐并播放
            string musicAddress = ini.ReadString(Common.NODE_REMINDER, Common.REMINDER_MUSIC_ADDRESS, "");
            if (musicAddress.Length > 0 && File.Exists(musicAddress)){
                // 播放音乐
                music.FileName = musicAddress;
                music.play();
            }

            // 判断是否设置了背景图
            string backgroundAddress = ini.ReadString(Common.NODE_REMINDER, Common.REMINDER_BACKGROUND_ADDRESS, "");
            if (backgroundAddress.Length > 0 && File.Exists(backgroundAddress)){
                // 设置背景图
                Image image = Image.FromFile(backgroundAddress);
                this.BackgroundImage = image;
            }

            // 判断提示文本和快捷键和计时提示是否显示
            if (ini.ReadString(Common.NODE_REMINDER, Common.REMINDER_DISPLAY_REMINDER_TEXT, "Y").Equals("N"))
                label_reminderText.Visible = false;
            displayKeyAndTime = ini.ReadString(Common.NODE_REMINDER, Common.REMINDER_DISPLAY_KEY_AND_TIPS, "Y");
            if (displayKeyAndTime.Equals("N"))
            {
                label_key.Visible = false;
                label_activityTime.Visible = false;
            }

            // 判断文字颜色是深色还是浅色
            if (!ini.ReadString(Common.NODE_REMINDER, Common.REMINDER_TEXT_COLOR, "0").Equals("0"))
            {
                label_reminderText.ForeColor = Color.White;
            }


            // #####判断热键是否已经设置，否则使用默认热键#####
            string keyText = "";
            int ignoreFuncKey = ini.ReadInt(Common.NODE_REMINDER, Common.REMINDER_IGNORE_FUNC_KEY, -1);
            int ignoreKey = ini.ReadInt(Common.NODE_REMINDER, Common.REMINDER_IGNORE_KEY, -1);
            int activityFuncKey = ini.ReadInt(Common.NODE_REMINDER, Common.REMINDER_ACTIVITY_FUNC_KEY, -1);
            int activityKey = ini.ReadInt(Common.NODE_REMINDER, Common.REMINDER_ACTIVITY_KEY, -1);

            // #####忽视键#####
            if (ignoreFuncKey == -1 && ignoreKey == -1)
            {
                // 忽视功能键和键均未设置，使用默认
                keyText += "Alt+Shift+I";
                HotKey.RegisterHotKey(this.Handle, hotKey_ignore,
                    HotKey.KeyModifiers.Alt | HotKey.KeyModifiers.Shift, Keys.I);
            }
            else if (ignoreFuncKey == -1 || ignoreKey == 0)
            {
                // 未设置功能键
                keyText += Tool.GetKeyString(ignoreKey);
                HotKey.RegisterHotKey(this.Handle, hotKey_ignore,
                    HotKey.KeyModifiers.None, Tool.GetKey(ignoreKey));
            }
            else
            {
                // 功能键和键均设置
                keyText += Tool.GetFuncKeyString(ignoreFuncKey) + Tool.GetKeyString(ignoreKey);
                HotKey.RegisterHotKey(this.Handle, hotKey_ignore,
                    Tool.GetFuncKey(ignoreFuncKey), Tool.GetKey(ignoreKey));
            }
            keyText += "：忽视本次活动提醒\r\n\r\n";

            // #####活动键#####
            if (activityFuncKey == -1 && activityKey == -1)
            {
                // 活动功能键和键均未设置，使用默认
                keyText += "Alt+Shift+G";
                HotKey.RegisterHotKey(this.Handle, hotKey_activity,
                    HotKey.KeyModifiers.Alt | HotKey.KeyModifiers.Shift, Keys.G);
            }
            else if (activityFuncKey == -1 || activityKey == 0)
            {
                // 未设置功能键
                keyText += Tool.GetKeyString(activityKey);
                HotKey.RegisterHotKey(this.Handle, hotKey_activity,
                    HotKey.KeyModifiers.None, Tool.GetKey(activityKey));
            }
            else
            {
                // 功能键和键均设置
                keyText += Tool.GetFuncKeyString(activityFuncKey) + Tool.GetKeyString(activityKey);
                HotKey.RegisterHotKey(this.Handle, hotKey_activity,
                    Tool.GetFuncKey(activityFuncKey), Tool.GetKey(activityKey));
            }
            keyText += "：起身活动/活动结束";
            label_key.Text = keyText;

        }

        private void FormReminder_FormClosing(object sender, FormClosingEventArgs e)
        {
            parentForm.sedentaryTimeRecord = 0;
            parentForm.mouseNotMovingTimeRecord = 0;
            parentForm.timer_sedentaryReminder.Enabled = true;
            music.StopT();
        }

        /// <summary>
        /// 热键回馈
        /// </summary>
        /// <param name="msg"></param>
        protected override void WndProc(ref Message msg)
        {
            base.WndProc(ref msg);
            switch (msg.Msg)
            {
                case WM_HOTKEY: //窗口消息：热键
                    int tmpWParam = msg.WParam.ToInt32();
                    if (tmpWParam == hotKey_ignore)
                    {
                        // 忽视本次提醒
                        parentForm.sedentaryTimeRecord = 0;
                        parentForm.mouseNotMovingTimeRecord = 0;
                        parentForm.timer_sedentaryReminder.Enabled = true;
                        this.Close();
                    }
                    else if (tmpWParam == hotKey_activity)
                    {
                        // 开始活动
                        if (timer_activity.Enabled == false)
                        {
                            activityTimeRecord = 0;
                            timer_activity.Enabled = true;
                            label_key.Visible = false;
                            // 根据用户设置判断活动时间标是否显示
                            if (displayKeyAndTime.Equals("Y"))
                                label_activityTime.Visible = true;
                        }
                        else
                        {
                            timer_activity.Enabled = false;
                            parentForm.sedentaryTimeRecord = 0;
                            parentForm.mouseNotMovingTimeRecord = 0;
                            parentForm.timer_sedentaryReminder.Enabled = true;
                            this.Close();
                        }
                    }
                    break;
                //case WM_CREATE: //窗口消息：创建
                    //HotKey.RegHotKey(this.Handle, hotKey_ignore, SystemHotKey.KeyModifiers.None, Keys.F1);
                    //break;
                case WM_DESTROY: //窗口消息：销毁
                    //销毁热键
                    HotKey.UnRegHotKey(this.Handle, hotKey_ignore);
                    HotKey.UnRegHotKey(this.Handle, hotKey_activity);
                    break;
                default:
                    break;
            }
        }

        private void timer_activity_Tick(object sender, EventArgs e)
        {
            activityTimeRecord++;
            // 用户设置活动时间标可见的情况下再更新Text
            if (displayKeyAndTime.Equals("Y"))
                label_activityTime.Text = "已经活动：" + Tool.SecondToTime(activityTimeRecord);
        }
    }
}
