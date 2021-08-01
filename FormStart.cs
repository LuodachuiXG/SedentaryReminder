using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SedentaryReminder.util;

namespace SedentaryReminder
{
    public partial class FormStart : Form
    {
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

            // 将ComboBox_ReminderMode默认选择项设置为0
            cb_reminderMode.SelectedIndex = 0;
        }

        private void SettingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormSetting().ShowDialog();
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormAbout().ShowDialog();
        }

        /*
         * 屏蔽Tab和Ctrl键导致tabControl切换页面（Tab给tabControl焦点后按左右键依旧会切换）
         */
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case (Keys.Tab | Keys.Control):
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

        /*
         * 控制TextBox只能输入小数
         */
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

        private void cb_reminderMode_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }
    }
}
