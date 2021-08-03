using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SedentaryReminder.pages;
using SedentaryReminder.util;

namespace SedentaryReminder
{
    public partial class FormStart : Form
    {
        private IniUtil ini = Common.iniSetting;

        // 久坐的时间记录
        public int sedentaryTimeRecord = 0;
        // 鼠标停止移动时间记录
        public int mouseNotMovingTimeRecord = 0;

        // 用户设置的久坐提醒时间（秒）
        private int sedentaryReminderTime = 0;

        // 用户设置的鼠标停止移动后停止计时的时间（秒）
        private int mouseNotMovingTime = 0;

        // 用户设置的提醒方式，这里保存ComboBox的选中索引
        private int reminderMode = 0;

        // 鼠标最后所处的XY位置，用于比对判断鼠标是否有操作
        private int mouseLastX = 0;
        private int mouseLastY = 0;

        // 用于告知Timer当前久坐计时已经停止
        private bool stopSedentaryTimeRecordFlag = false;

        public FormStart()
        {
            InitializeComponent();
        }

        private void FormStart_Load(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.ico;

            // 将TabControl的选择页设置为不可见
            this.tabControl1.Region = new Region(
                new RectangleF(this.tabPage_Main.Left, this.tabPage_Main.Top,
                this.tabPage_Main.Width, this.tabPage_Main.Height));

            // 设置notifyIcon图标
            notifyIcon.Icon = Properties.Resources.ico;

            // 初始化数据
            init();
        }

        /// <summary>
        /// 初始化页面数据
        /// </summary>
        private void init()
        {
            // 判断是否是第一次运行软件
            if (ini.ReadString(Common.NODE_MAIN, Common.MAIN_FIRST_RUN, "N").Equals("N"))
            {
                // 第一次运行
                ini.WriteString(Common.NODE_MAIN, Common.MAIN_FIRST_RUN, "Y");
                string str = "欢迎使用久坐护眼提醒！\n久坐危害多多，建议启动软件开机自启和启动后自动运行久坐提醒功能，" +
                    "时刻提醒久坐。\n点击确定立即进行设置，或者进入软件后点击功能->设置进行设置。";
                if (MessageBox.Show(str, "温馨提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    new FormSettings().ShowDialog();
            }

            // 读取FormStart上显示数据
            string sedentartReminderTime = ini.ReadString(Common.NODE_MAIN, Common.MAIN_REMINDER_TIME, "60");
            string stopReminderTime = ini.ReadString(Common.NODE_MAIN, Common.MAIN_STOP_REMINDER_TIME, "5");
            int reminderMode = ini.ReadInt(Common.NODE_MAIN, Common.MAIN_REMINDER_MODE, 0);

            tb_reminderTime.Text = sedentartReminderTime;
            tb_stopReminderTime.Text = stopReminderTime;
            cbBox_reminderMode.SelectedIndex = reminderMode;



            // 判断是否启用了自动运行久坐提醒
            if (ini.ReadString(Common.NODE_MAIN, Common.MAIN_AUTO_START, "N").Equals("Y"))
            {
                // 已经启动了自动运行久坐提醒，但是要先判断读入的提醒时间数据是否正确
                if (tb_reminderTime.Text.Length <= 0 || tb_stopReminderTime.Text.Length <= 0 ||
                    float.Parse(tb_reminderTime.Text) == 0 || float.Parse(tb_stopReminderTime.Text) == 0)
                {
                    MessageBox.Show("久坐提醒时间或鼠标无操作时间为空，自动运行久坐提醒失败！请检查！", "温馨提示");
                    return;
                }

                // 久坐提醒时间不能短于停止提醒时间
                if (float.Parse(tb_reminderTime.Text) < float.Parse(tb_stopReminderTime.Text))
                {
                    MessageBox.Show("鼠标不动后停止久坐记录时间不能大于久坐的提醒时间！\n" +
                        "推荐久坐提醒60分钟，鼠标不动5分钟后停止计时。自动运行久坐提醒失败！请检查！", "温馨提示");
                    return;
                }

                // 启动久坐提醒计时
                // 将久坐和鼠标无操作时间记录变量初始化
                sedentaryTimeRecord = 0;
                mouseNotMovingTimeRecord = 0;

                // 将用户设置的久坐和鼠标无操作停止计时时间转换为秒，存在变量中
                sedentaryReminderTime = (int)(float.Parse(tb_reminderTime.Text) * 60);
                mouseNotMovingTime = (int)(float.Parse(tb_stopReminderTime.Text) * 60);
                reminderMode = cbBox_reminderMode.SelectedIndex;

                timer_sedentaryReminder.Enabled = true;
                label_reminderTime.Text = $"久坐提醒时间：{tb_reminderTime.Text}分钟" +
                    $" | 鼠标无操作停止久坐记录：{tb_stopReminderTime.Text}分钟";
                tabControl1.SelectedIndex = 1;
                this.ShowInTaskbar = false;
                this.Hide();
            }
        }

        private void FormStart_FormClosing(object sender, FormClosingEventArgs e)
        {
            string rememberChoice = ini.ReadString(Common.NODE_END, Common.END_REMEMBER_CHOICE, "N");
            string minimize = ini.ReadString(Common.NODE_END, Common.END_MINIMIZE, "N");
            string finish = ini.ReadString(Common.NODE_END, Common.END_FINISH, "N");

            // 记住选择和结束程序为Y，如果计时正在进行就询问，否则直接结束本程序进程
            if (rememberChoice.Equals("Y") && finish.Equals("Y"))
            {
                if (timer_sedentaryReminder.Enabled)
                {
                    string str = "久坐提醒正在运行中，现在退出会直接停止久坐提醒，确定吗？";
                    if (MessageBox.Show(str, "温馨提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
                        System.Environment.Exit(0);
                    else
                    {
                        e.Cancel = true;
                        return;
                    }
                        
                }
                else
                    System.Environment.Exit(0);
            }
                
            //记住选择和最小化为Y，最小化本窗置系统托盘
            if (rememberChoice.Equals("Y") && minimize.Equals("Y"))
            {
                this.ShowInTaskbar = false;
                this.Hide();
                e.Cancel = true;
                return;
            }

            // 如果上面两个条件都不满足，就打开FormCloseOrMinimize窗-
            // 让用户选择关闭还是最小化
            FormCloseOrMinimize form = new FormCloseOrMinimize(this);
            form.ShowDialog();
            e.Cancel = true;
        }

        private void SettingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormSettings().ShowDialog();
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormAbout().ShowDialog();
        }

        /// <summary>
        /// 屏蔽Tab和Ctrl键导致tabControl切换页面
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="keyData"></param>
        /// <returns></returns>
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case (Keys.Tab | Keys.Control):
                    return true;
                case (Keys.Left):
                    return true;
                case (Keys.Right):
                    return true;
                default:
                    break;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void tb_textBox_reminderTime_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBoxFloatCheck(tb_reminderTime, sender, e);
        }

        private void tb_stopReminderTime_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBoxFloatCheck(tb_stopReminderTime, sender, e);
        }

        /// <summary>
        /// 控制TextBox只能输入小数
        /// </summary>
        /// <param name="textBox"></param>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBoxFloatCheck(TextBox textBox, object sender, KeyPressEventArgs e)
        {
            // 只能输入数字和退格
            if (((int)e.KeyChar < 48 || (int)e.KeyChar > 57) && (int)e.KeyChar != 8)
                e.Handled = true;

            // 判断可输入小数点，但小数点不能放在数字的前面，且要保证只能输入一个小数点在正确的位置
            if ((int)e.KeyChar == 46)
            {
                if (textBox.Text.Length <= 0)
                    // 小数点不能在第一位   
                    e.Handled = true;
                else
                {
                    float f;
                    float oldf;
                    bool b1 = false, b2 = false;
                    b1 = float.TryParse(textBox.Text, out oldf);
                    b2 = float.TryParse(textBox.Text + e.KeyChar.ToString(), out f);
                    if (b2 == false)
                    {
                        if (b1 == true)
                            e.Handled = true;
                        else
                            e.Handled = false;
                    }
                    else
                        e.Handled = false;
                }
            }
        }

        private void label_stopReminderTips_Click(object sender, EventArgs e)
        {
            MessageBox.Show("在鼠标停止移动指定时间后，即判断当前未在使用电脑，停止久坐提醒的计时。" +
                "\n直到再次移动鼠标时重新开始计时。", "温馨提示");
        }

        private void notifyIconMenu_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Visible = true;
                this.WindowState = FormWindowState.Normal;
                this.ShowInTaskbar = true;
            }
        }

        private void notifyIconMenu_displayWindow_Click(object sender, EventArgs e)
        {
            this.Visible = true;
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
        }

        private void notifyIconMenu_setting_Click(object sender, EventArgs e)
        {
            new FormSettings().Show();
        }

        private void notifyIconMenu_about_Click(object sender, EventArgs e)
        {
            new FormAbout().Show();
        }

        private void notifyIconMenu_finish_Click(object sender, EventArgs e)
        {
            if (timer_sedentaryReminder.Enabled)
            {
                string str = "久坐提醒正在运行中，现在退出会直接停止久坐提醒，确定吗？";
                if (MessageBox.Show(str, "温馨提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    System.Environment.Exit(0);   
            }
            else
                System.Environment.Exit(0);
        }

        private void notifyIcon_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Visible = true;
                this.WindowState = FormWindowState.Normal;
                this.ShowInTaskbar = true;
            }
        }


        /// 提醒时间文本更改事件
        private void tb_reminderTime_TextChanged(object sender, EventArgs e)
        {
            ini.WriteString(Common.NODE_MAIN, Common.MAIN_REMINDER_TIME, tb_reminderTime.Text);
        }

        // 停止提醒时间文本更改事件
        private void tb_stopReminderTime_TextChanged(object sender, EventArgs e)
        {
            ini.WriteString(Common.NODE_MAIN, Common.MAIN_STOP_REMINDER_TIME, tb_stopReminderTime.Text);
        }

        // 提醒方式选项更改事件
        private void cbBox_reminderMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            ini.WriteInt(Common.NODE_MAIN, Common.MAIN_REMINDER_MODE, cbBox_reminderMode.SelectedIndex);
        }

        // 运行久坐提醒按钮被单击
        private void btn_startReminder_Click(object sender, EventArgs e)
        {
            // 久坐提醒时间或停止提醒时间TextBox内容长度为0，或内容等于0
            if (tb_reminderTime.Text.Length <= 0 || tb_stopReminderTime.Text.Length <= 0 || 
                float.Parse(tb_reminderTime.Text) == 0 || float.Parse(tb_stopReminderTime.Text) == 0)
            {
                MessageBox.Show("请将信息填写完整！", "温馨提示");
                return;
            }

            // 久坐提醒时间不能短于停止提醒时间
            if (float.Parse(tb_reminderTime.Text) < float.Parse(tb_stopReminderTime.Text))
            {
                MessageBox.Show("鼠标不动后停止久坐记录时间不能大于久坐的提醒时间！\n" +
                    "推荐久坐提醒60分钟，鼠标不动5分钟后停止计时。", "温馨提示");
                return;
            }

            // 如果停止提醒时间小于5分钟的话提醒一下
            if (float.Parse(tb_stopReminderTime.Text) < 5)
            {
                string text = "鼠标不动后停止久坐记录时间不建议设置过短。\n" +
                    "以防止例如打字等无需经常移动鼠标导致坐姿时间记录不准确，建议设置5分钟以上。\n" +
                    "如你坚持使用" + tb_stopReminderTime.Text + "分钟，请点击'确定'按钮。";
                if (MessageBox.Show(text, "温馨提示", MessageBoxButtons.OKCancel) != DialogResult.OK)
                {
                    return;
                }
            }

            // 将久坐和鼠标无操作时间记录变量初始化
            sedentaryTimeRecord = 0;
            mouseNotMovingTimeRecord = 0;

            // 将用户设置的久坐和鼠标无操作停止计时时间转换为秒，存在变量中
            sedentaryReminderTime = (int)(float.Parse(tb_reminderTime.Text) * 60);
            mouseNotMovingTime = (int)(float.Parse(tb_stopReminderTime.Text) * 60);
            reminderMode = cbBox_reminderMode.SelectedIndex;

            timer_sedentaryReminder.Enabled = true;
            label_reminderTime.Text = $"久坐提醒时间：{tb_reminderTime.Text}分钟" +
                $" | 鼠标无操作停止久坐记录：{tb_stopReminderTime.Text}分钟";
            tabControl1.SelectedIndex = 1;
        }

        // Timer事件
        private void timer_sedentaryReminder_Tick(object sender, EventArgs e)
        {
            // 用于显示久坐时间和鼠标无操作时间给用户
            string sedentaryTimeInfo = "";
            string mouseNotMovingTimeInfo = "";
            
            // #####检测鼠标是否无操作并记录鼠标无操作时间#####
            // 记录鼠标当前xy坐标，用于判断鼠标是否操作
            int x = Control.MousePosition.X;
            int y = Control.MousePosition.Y;
            if (x == mouseLastX && y == mouseLastY)
            {
                // 现在鼠标位置相比上一秒没有移动，鼠标无操作时间+1
                mouseNotMovingTimeRecord++;
                Console.WriteLine(mouseNotMovingTimeRecord);
                
                //判断鼠标无操作时间是否达到了停止计时的时间
                if (mouseNotMovingTimeRecord >= mouseNotMovingTime)
                {
                    // 达到停止计时时间
                    sedentaryTimeRecord = 0;
                    // 设置Flag，告知下面统计久坐时间停止
                    stopSedentaryTimeRecordFlag = true;
                    sedentaryTimeInfo = "坐姿时间：已停止计时";
                }

            }
            else
            {
                // 现在鼠标位置相比上一秒已经移动了，鼠标无操作时间归零
                mouseNotMovingTimeRecord = 0;
                stopSedentaryTimeRecordFlag = false;
            }
            mouseNotMovingTimeInfo = "鼠标无操作：" + Tool.SecondToTime(mouseNotMovingTimeRecord);

            // 将当前鼠标位置记录给全局变量
            mouseLastX = x;
            mouseLastY = y;

            // #####记录久坐时间#####
            // 通过上面代码的Flag判断当前是否需要进行久坐记录
            if (!stopSedentaryTimeRecordFlag)
            {
                sedentaryTimeRecord++;
                sedentaryTimeInfo = "坐姿时间：" + Tool.SecondToTime(sedentaryTimeRecord);
            }

            // #####托盘图标提示文字和页面久坐和鼠标无操作时间展示设置#####
            notifyIcon.Text = $"久坐提醒\n坐姿时间：{Tool.SecondToTime(sedentaryTimeRecord)}";

            // #####判断久坐时间是否已经达到提醒时间#####
            if (sedentaryTimeRecord >= sedentaryReminderTime)
            {
                timer_sedentaryReminder.Enabled = false;
                new FormReminder(this, reminderMode).Show();
            }

            tb_reminderTimeInfo.Text = sedentaryTimeInfo + "\r\n\r\n" + mouseNotMovingTimeInfo;
        }

        // 停止久坐提醒按钮被单击
        private void btn_stopReminder_Click(object sender, EventArgs e)
        {
            // 在用户点击停止按钮的时候先吊起Timer
            timer_sedentaryReminder.Enabled = false;
            string str = "确定要取消久坐提醒吗，取消后可以重新设置时间。";
            if (MessageBox.Show(str, "温馨提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                tb_reminderTimeInfo.Text = "";
                tabControl1.SelectedIndex = 0;
                notifyIcon.Text = "久坐提醒";
                return;
            }
            // 用户没有停止久坐提醒，恢复Timer
            timer_sedentaryReminder.Enabled = true;
        }
    }
}
