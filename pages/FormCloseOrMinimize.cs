using SedentaryReminder.util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SedentaryReminder.pages
{
    public partial class FormCloseOrMinimize : Form
    {
        private Form form = null;
        private IniUtil ini = Common.iniSetting;
        public FormCloseOrMinimize(Form form)
        {
            this.form = form;
            InitializeComponent();
        }

        private void FormCloseOrMinimize_Load(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.ico;

            string minimize = ini.ReadString(Common.NODE_END, Common.END_MINIMIZE, "A");
            string finish = ini.ReadString(Common.NODE_END, Common.END_FINISH, "N");
            if (minimize.Equals("A"))
            {
                // 因为最小化按钮默认选择，如果用户没有点击RadioButton-
                // 而是直接点击记住选择的话，下次关闭软件就还会显示此窗口
                // 所以如果是第一次打开本窗口，就默认给最小化写入Y
                ini.WriteString(Common.NODE_END, Common.END_MINIMIZE, "Y");
            }

            // 如果结束运行等于Y，就将结束程序员运行RadioButton选中
            if (finish.Equals("Y"))
            {
                rb_minimize.Checked = false;
                rb_finishProgram.Checked = true;
            }
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            // 如果结束程序运行被选中，就直接结束本程序进程
            if (rb_finishProgram.Checked)
                System.Environment.Exit(0);
            else
            {
                // 最小化程序到系统托盘被选中，最小化启动窗并关闭本窗
                form.WindowState = FormWindowState.Minimized;
                this.Close();
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            // 取消按钮被单击就关闭本窗
            this.Close();
        }

        private void rb_minimize_CheckedChanged(object sender, EventArgs e)
        {
            // 最小化被选中，将最小化设置为Y，结束程序设置为N
            if (rb_minimize.Checked)
            {
                ini.WriteString(Common.NODE_END, Common.END_MINIMIZE, "Y");
                ini.WriteString(Common.NODE_END, Common.END_FINISH, "N");
            }

        }

        private void rb_finishProgram_CheckedChanged(object sender, EventArgs e)
        {
            // 结束程序被选中，将最小化设置为N，结束程序设置为Y
            if (rb_finishProgram.Checked)
            {
                ini.WriteString(Common.NODE_END, Common.END_MINIMIZE, "N");
                ini.WriteString(Common.NODE_END, Common.END_FINISH, "Y");
            }
        }

        private void cb_remeberMyChoice_CheckedChanged(object sender, EventArgs e)
        {
            // 记住选择被选中，将参数设置为Y，反之
            if (cb_remeberMyChoice.Checked)
                ini.WriteString(Common.NODE_END, Common.END_REMEMBER_CHOICE, "Y");
            else
                ini.WriteString(Common.NODE_END, Common.END_REMEMBER_CHOICE, "N");
        }
    }
}
