using SedentaryReminder.util;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SedentaryReminder
{
    public partial class FormSettings : Form
    {
        private readonly IniUtil ini = Common.iniSetting;

        public FormSettings()
        {
            InitializeComponent();
        }

        private void FormSettings_Load(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.ico;
            init();
        }

        /// <summary>
        /// 初始化设置数据
        /// </summary>
        private void init()
        {
            // 读取数据
            string generalMinimize = ini.ReadString(Common.NODE_END, Common.END_MINIMIZE, "Y");
            string generalFinishProgram = ini.ReadString(Common.NODE_END, Common.END_FINISH, "N");
            string generalRememberChoice = ini.ReadString(Common.NODE_END, Common.END_REMEMBER_CHOICE, "N");
            string generalSelfStarting = ini.ReadString(Common.NODE_MAIN, Common.MAIN_SELF_START, "N");
            string generalAutoStarting = ini.ReadString(Common.NODE_MAIN, Common.MAIN_AUTO_START, "N");
            int reminderIgnoreFuncKey = ini.ReadInt(Common.NODE_REMINDER, Common.REMINDER_IGNORE_FUNC_KEY, 5);
            int reminderIgnoreKey = ini.ReadInt(Common.NODE_REMINDER, Common.REMINDER_IGNORE_KEY, 30);
            int reminderActivityFuncKey = ini.ReadInt(Common.NODE_REMINDER, Common.REMINDER_ACTIVITY_FUNC_KEY, 5);
            int reminderActivityKey = ini.ReadInt(Common.NODE_REMINDER, Common.REMINDER_ACTIVITY_KEY, 28);
            string reminderReminderText = ini.ReadString(Common.NODE_REMINDER, Common.REMINDER_REMINDER_TEXT, Common.DEFAULT_SEDENTARY_REMINDER_TEXT);
            string reminderMusicAddress = ini.ReadString(Common.NODE_REMINDER, Common.REMINDER_MUSIC_ADDRESS, "");
            bool reminderMusicIsExist = reminderMusicAddress.Length <= 0 ? false : File.Exists(reminderMusicAddress);
            string reminderBackgroundAddress = ini.ReadString(Common.NODE_REMINDER, Common.REMINDER_BACKGROUND_ADDRESS, "");
            bool reminderBackgroundIsExist = reminderBackgroundAddress.Length <= 0 ? false : File.Exists(reminderBackgroundAddress);
            string reminderDisplayReminderText = ini.ReadString(Common.NODE_REMINDER, Common.REMINDER_DISPLAY_REMINDER_TEXT, "Y");
            string reminderDisplayKeyAndTips = ini.ReadString(Common.NODE_REMINDER, Common.REMINDER_DISPLAY_KEY_AND_TIPS, "Y");
            int reminderTextColor = ini.ReadInt(Common.NODE_REMINDER, Common.REMINDER_TEXT_COLOR, 0);
            string reminderWindowShadow = ini.ReadString(Common.NODE_REMINDER, Common.REMINDER_WINDOW_SHADOW, "Y");
        
            // 根据数据设置组件状态
            // 常规设置-结束程序运行选中
            if (generalFinishProgram.Equals("Y"))
            {
                rBtn_general_minimize.Checked = false;
                rBtn_general_finishProgram.Checked = true;
            }

             // 常规设置-记住我的选择选中
            if (generalRememberChoice.Equals("Y"))
                cBox_general_RememberMyChoice.Checked = true;

            // 常规设置-跟随系统启动选中
            if (generalSelfStarting.Equals("Y"))
                cBox_general_selfStarting.Checked = true;

            // 常规设置-自动运行久坐提醒选中
            if (generalAutoStarting.Equals("Y"))
                cBox_general_autoStarting.Checked = true;

            // 提醒设置-忽略这次提醒/活动/结束活动快捷键
            cbBox_reminder_ignoreFuncKey.SelectedIndex = reminderIgnoreFuncKey;
            cbBox_reminder_ignoreKey.SelectedIndex = reminderIgnoreKey;
            cbBox_reminder_activityFuncKey.SelectedIndex = reminderActivityFuncKey;
            cbBox_reminder_activityKey.SelectedIndex = reminderActivityKey;
            tb_reminder_reminderText.Text = reminderReminderText;

            // 提醒设置-提醒音乐是否设置，以及音乐文件是否存在
            if (reminderMusicAddress.Length > 0 && reminderMusicIsExist)
                btn_reminder_selectMusic.Text = "提醒音乐（已设置）";

            // 提醒设置-背景图是否设置，以及背景图是否存在
            if (reminderBackgroundAddress.Length > 0 && reminderBackgroundIsExist)
                btn_reminder_selectBackground.Text = "背景图 320*150（已设置）";

            // 提醒设置-提示文本未选中
            if (reminderDisplayReminderText.Equals("N"))
                cBox_reminder_displayTips.Checked = false;

            // 提醒设置-快捷键和活动计时提示未选中
            if (reminderDisplayKeyAndTips.Equals("N"))
                cBox_reminder_displayKeyAndTimeTips.Checked = false;

            // 提醒设置-设置提示窗口文本颜色
            cbBox_reminder_textColor.SelectedIndex = reminderTextColor;

            // 提醒设置-窗口阴影未选中
            if (reminderWindowShadow.Equals("N"))
                cBox_reminder_windowsShadow.Checked = false;

        }

        /// <summary>
        /// 确定按钮被单击
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_finish_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 最小化程序置系统托盘选择状态改变
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rBtn_general_minimize_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtn_general_minimize.Checked)
            {
                ini.WriteString(Common.NODE_END, Common.END_MINIMIZE, "Y");
                ini.WriteString(Common.NODE_END, Common.END_FINISH, "N");
            }
        }

        /// <summary>
        /// 结束程序运行选择状态改变
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rBtn_general_finishProgram_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtn_general_finishProgram.Checked)
            {
                ini.WriteString(Common.NODE_END, Common.END_MINIMIZE, "N");
                ini.WriteString(Common.NODE_END, Common.END_FINISH, "Y");
            }
        }

        /// <summary>
        /// 记住我的选择选择状态被改变
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cBox_general_RememberMyChoice_CheckedChanged(object sender, EventArgs e)
        {
            if (cBox_general_RememberMyChoice.Checked)
                ini.WriteString(Common.NODE_END, Common.END_REMEMBER_CHOICE, "Y");
            else
                ini.WriteString(Common.NODE_END, Common.END_REMEMBER_CHOICE, "N");
        }

        /// <summary>
        /// 跟随系统启动选择状态被改变
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cBox_general_selfStarting_CheckedChanged(object sender, EventArgs e)
        {
            if (cBox_general_selfStarting.Checked)
            {
                // 设置软件为开机自启
                if (!Tool.AutoStart())
                {
                    // 开机启动设置失败
                    cBox_general_selfStarting.Checked = false;
                    MessageBox.Show("设置开机启动失败，请检查是否被安全软件拦截！\n" +
                        "或尝试用管理员身份运行软件", "温馨提示");
                    return;
                }
                ini.WriteString(Common.NODE_MAIN, Common.MAIN_SELF_START, "Y");
            }
            else
            {
                // 取消软件开机自启
                if (!Tool.AutoStart(false))
                {
                    // 取消开机启动设置失败
                    cBox_general_selfStarting.Checked = true;
                    MessageBox.Show("取消开机启动失败，请检查是否被安全软件拦截！\n" +
                        "或尝试用管理员身份运行软件", "温馨提示");
                    return;
                }
                ini.WriteString(Common.NODE_MAIN, Common.MAIN_SELF_START, "N");
            }
        }

        /// <summary>
        /// 自动运行久坐提醒选择状态被改变
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cBox_general_autoStarting_CheckedChanged(object sender, EventArgs e)
        {
            if (cBox_general_autoStarting.Checked)
                ini.WriteString(Common.NODE_MAIN, Common.MAIN_AUTO_START, "Y");
            else
                ini.WriteString(Common.NODE_MAIN, Common.MAIN_AUTO_START, "N");
        }

        /// <summary>
        /// 用于判断忽略本次提醒和活动的快捷键是否相同
        /// </summary>
        /// <returns>相同返回true，反之</returns>
        private bool IgnoreAndActivityKeyIsSame()
        {
            if (cbBox_reminder_ignoreFuncKey.SelectedIndex == cbBox_reminder_activityFuncKey.SelectedIndex &&
                cbBox_reminder_ignoreKey.SelectedIndex == cbBox_reminder_activityKey.SelectedIndex)
            {
                MessageBox.Show("不能将热键设置为相同选项", "温馨提示");
                return true;
            }
            return false;
        }

        /// <summary>
        /// 将热键数据写入配置项
        /// </summary>
        private void SetHotKey()
        {
            ini.WriteInt(Common.NODE_REMINDER, Common.REMINDER_IGNORE_FUNC_KEY,
                cbBox_reminder_ignoreFuncKey.SelectedIndex);
            ini.WriteInt(Common.NODE_REMINDER, Common.REMINDER_IGNORE_KEY,
                cbBox_reminder_ignoreKey.SelectedIndex);
            ini.WriteInt(Common.NODE_REMINDER, Common.REMINDER_ACTIVITY_FUNC_KEY,
                cbBox_reminder_activityFuncKey.SelectedIndex);
            ini.WriteInt(Common.NODE_REMINDER, Common.REMINDER_ACTIVITY_KEY,
                cbBox_reminder_activityKey.SelectedIndex);
        }

        /// <summary>
        /// 忽略这次提醒功能键选择项改变
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbBox_reminder_ignoreFuncKey_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (IgnoreAndActivityKeyIsSame())
            {
                // 热键设置相同，不设置热键，直接返回方法
                return;
            }
            SetHotKey();
        }

        /// <summary>
        /// 忽略这次提醒键选择项改变
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbBox_reminder_ignoreKey_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (IgnoreAndActivityKeyIsSame())
            {
                // 热键设置相同，不设置热键，直接返回方法
                return;
            }
            SetHotKey();
        }

        /// <summary>
        /// 活动功能键选择项改变
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbBox_reminder_activityFuncKey_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (IgnoreAndActivityKeyIsSame())
            {
                // 热键设置相同，不设置热键，直接返回方法
                return;
            }
            SetHotKey();
        }

        /// <summary>
        /// 活动键选择项改变
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbBox_reminder_activityKey_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (IgnoreAndActivityKeyIsSame())
            {
                // 热键设置相同，不设置热键，直接返回方法
                return;
            }
            SetHotKey();
        }

        /// <summary>
        /// 提示文本被改变
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tb_reminder_reminderText_TextChanged(object sender, EventArgs e)
        {
            ini.WriteString(Common.NODE_REMINDER, Common.REMINDER_REMINDER_TEXT, tb_reminder_reminderText.Text);
        }


        /// <summary>
        /// 提示文本选择状态被改变
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cBox_reminder_displayTips_CheckedChanged(object sender, EventArgs e)
        {
            if (cBox_reminder_displayTips.Checked)
                ini.WriteString(Common.NODE_REMINDER, Common.REMINDER_DISPLAY_REMINDER_TEXT, "Y");
            else
                ini.WriteString(Common.NODE_REMINDER, Common.REMINDER_DISPLAY_REMINDER_TEXT, "N");
        }

        /// <summary>
        /// 快捷键和活动计时提示选择状态被改变
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cBox_reminder_displayKeyAndTimeTips_CheckedChanged(object sender, EventArgs e)
        {
            if (cBox_reminder_displayKeyAndTimeTips.Checked)
                ini.WriteString(Common.NODE_REMINDER, Common.REMINDER_DISPLAY_KEY_AND_TIPS, "Y");
            else
                ini.WriteString(Common.NODE_REMINDER, Common.REMINDER_DISPLAY_KEY_AND_TIPS, "N");
        }

        /// <summary>
        /// 窗口阴影选择状态被改变
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cBox_reminder_windowsShadow_CheckedChanged(object sender, EventArgs e)
        {
            if (cBox_reminder_windowsShadow.Checked)
                ini.WriteString(Common.NODE_REMINDER, Common.REMINDER_WINDOW_SHADOW, "Y");
            else
                ini.WriteString(Common.NODE_REMINDER, Common.REMINDER_WINDOW_SHADOW, "N");
        }


        /// <summary>
        /// 提示窗口文本颜色选择项改变
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbBox_reminder_textColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            ini.WriteInt(Common.NODE_REMINDER, Common.REMINDER_TEXT_COLOR, cbBox_reminder_textColor.SelectedIndex);
        }


        /// <summary>
        /// 提醒音乐按钮被单击
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_reminder_selectMusic_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Multiselect = false;
            fileDialog.Title = "选择Mp3格式音乐";
            fileDialog.Filter = "MP3音乐(*.mp3)|*.mp3";

            // 判断用户是否正确的选择了文件
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                // 获取用户选择文件的后缀名
                string filePath = fileDialog.FileName;
                string extension = Path.GetExtension(filePath);

                // 声明允许的后缀名
                string[] str = new string[] { ".mp3" };
                if (!((IList)str).Contains(extension))
                    // 用户选择了非mp3文件
                    MessageBox.Show("仅支持Mp3音乐格式！", "温馨提示");
                else
                {
                    // 用户选择了正确的Mp3文件，将Mp3文件复制到程序文件夹下
                    try
                    {
                        File.Copy(filePath, Common.PATH + "music.mp3", true);
                        btn_reminder_selectMusic.Text = "提醒音乐（已设置）";
                        ini.WriteString(Common.NODE_REMINDER, Common.REMINDER_MUSIC_ADDRESS, Common.PATH + "music.mp3");
                        MessageBox.Show("音乐设置成功", "温馨提示");
                    }
                    catch (Exception es)
                    {
                        Console.WriteLine(es.Message);
                        MessageBox.Show("设置音乐失败！请查看是否被安全软件拦截。\n或尝试使用管理员身份运行本软件。",
                            "温馨提示");
                    }
                }
            }
            else
            {
                // 用户取消了音乐选择，删除音乐地址配置文件
                ini.WriteString(Common.NODE_REMINDER, Common.REMINDER_MUSIC_ADDRESS, "");
                btn_reminder_selectMusic.Text = "提醒音乐（未设置）";
            }
        }

        /// <summary>
        /// 背景图按钮被单击
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_reminder_selectBackground_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Multiselect = false;
            fileDialog.Title = "选择背景图片";
            fileDialog.Filter = "JPG图片(*.jpg)|*.jpg|PNG图片(*.png)|*.png";

            // 判断用户是否正确的选择了文件
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                // 获取用户选择文件的后缀名
                string filePath = fileDialog.FileName;
                string extension = Path.GetExtension(filePath);

                // 声明允许的后缀名
                string[] str = new string[] { ".png" , ".jpg"};
                if (!((IList)str).Contains(extension))
                    // 用户选择了非jpg/png文件
                    MessageBox.Show("仅支持JPG和PNG图片格式！", "温馨提示");
                else
                {
                    // 用户选择了正确的图片文件，将图片文件复制到程序文件夹下
                    try
                    {
                        File.Copy(filePath, Common.PATH + "background" + extension, true);
                        btn_reminder_selectBackground.Text = "背景图 320*150（已设置）";
                        ini.WriteString(Common.NODE_REMINDER, Common.REMINDER_BACKGROUND_ADDRESS, 
                            Common.PATH + "background" + extension);
                        MessageBox.Show("背景图设置成功", "温馨提示");
                    }
                    catch (Exception es)
                    {
                        Console.WriteLine(es.Message);
                        MessageBox.Show("设置背景图失败！请查看是否被安全软件拦截。\n或尝试使用管理员身份运行本软件。",
                            "温馨提示");
                    }
                }
            }
            else
            {
                // 用户取消了图片选择，删除图片地址配置文件
                ini.WriteString(Common.NODE_REMINDER, Common.REMINDER_BACKGROUND_ADDRESS, "");
                btn_reminder_selectBackground.Text = "背景图 320*150（未设置）";
            }
        }
    }
}
