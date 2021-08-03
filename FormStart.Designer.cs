
using System;

namespace SedentaryReminder
{
    partial class FormStart
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage_Main = new System.Windows.Forms.TabPage();
            this.btn_startReminder = new System.Windows.Forms.Button();
            this.cbBox_reminderMode = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label_stopReminderTips = new System.Windows.Forms.Label();
            this.tb_stopReminderTime = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_reminderTime = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage_Running = new System.Windows.Forms.TabPage();
            this.btn_stopReminder = new System.Windows.Forms.Button();
            this.label_reminderTime = new System.Windows.Forms.Label();
            this.tb_reminderTimeInfo = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FuncToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SettingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.notifyIconMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.notifyIconMenu_displayWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIconMenu_setting = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIconMenu_about = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.notifyIconMenu_finish = new System.Windows.Forms.ToolStripMenuItem();
            this.timer_sedentaryReminder = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage_Main.SuspendLayout();
            this.tabPage_Running.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.notifyIconMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage_Main);
            this.tabControl1.Controls.Add(this.tabPage_Running);
            this.tabControl1.Location = new System.Drawing.Point(0, 3);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(385, 175);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage_Main
            // 
            this.tabPage_Main.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage_Main.Controls.Add(this.btn_startReminder);
            this.tabPage_Main.Controls.Add(this.cbBox_reminderMode);
            this.tabPage_Main.Controls.Add(this.label3);
            this.tabPage_Main.Controls.Add(this.label_stopReminderTips);
            this.tabPage_Main.Controls.Add(this.tb_stopReminderTime);
            this.tabPage_Main.Controls.Add(this.label4);
            this.tabPage_Main.Controls.Add(this.label2);
            this.tabPage_Main.Controls.Add(this.tb_reminderTime);
            this.tabPage_Main.Controls.Add(this.label1);
            this.tabPage_Main.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Main.Name = "tabPage_Main";
            this.tabPage_Main.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Main.Size = new System.Drawing.Size(377, 149);
            this.tabPage_Main.TabIndex = 0;
            this.tabPage_Main.Text = "Main";
            // 
            // btn_startReminder
            // 
            this.btn_startReminder.Location = new System.Drawing.Point(133, 108);
            this.btn_startReminder.Name = "btn_startReminder";
            this.btn_startReminder.Size = new System.Drawing.Size(122, 24);
            this.btn_startReminder.TabIndex = 8;
            this.btn_startReminder.Text = "运行久坐提醒";
            this.btn_startReminder.UseVisualStyleBackColor = true;
            this.btn_startReminder.Click += new System.EventHandler(this.btn_startReminder_Click);
            // 
            // cbBox_reminderMode
            // 
            this.cbBox_reminderMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBox_reminderMode.FormattingEnabled = true;
            this.cbBox_reminderMode.Items.AddRange(new object[] {
            "右下角弹窗",
            "左下角弹窗",
            "右上角弹窗",
            "左上角弹窗",
            "居中弹窗"});
            this.cbBox_reminderMode.Location = new System.Drawing.Point(133, 70);
            this.cbBox_reminderMode.Name = "cbBox_reminderMode";
            this.cbBox_reminderMode.Size = new System.Drawing.Size(122, 20);
            this.cbBox_reminderMode.TabIndex = 7;
            this.cbBox_reminderMode.SelectedIndexChanged += new System.EventHandler(this.cbBox_reminderMode_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "提醒方式：";
            // 
            // label_stopReminderTips
            // 
            this.label_stopReminderTips.AutoSize = true;
            this.label_stopReminderTips.Cursor = System.Windows.Forms.Cursors.Help;
            this.label_stopReminderTips.Location = new System.Drawing.Point(261, 46);
            this.label_stopReminderTips.Name = "label_stopReminderTips";
            this.label_stopReminderTips.Size = new System.Drawing.Size(113, 12);
            this.label_stopReminderTips.TabIndex = 5;
            this.label_stopReminderTips.Text = "分钟后停止久坐记录";
            this.label_stopReminderTips.Click += new System.EventHandler(this.label_stopReminderTips_Click);
            // 
            // tb_stopReminderTime
            // 
            this.tb_stopReminderTime.Location = new System.Drawing.Point(133, 40);
            this.tb_stopReminderTime.Name = "tb_stopReminderTime";
            this.tb_stopReminderTime.Size = new System.Drawing.Size(122, 21);
            this.tb_stopReminderTime.TabIndex = 4;
            this.tb_stopReminderTime.Text = "5";
            this.tb_stopReminderTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_stopReminderTime.TextChanged += new System.EventHandler(this.tb_stopReminderTime_TextChanged);
            this.tb_stopReminderTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_stopReminderTime_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "鼠标无操作：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(261, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "分钟";
            // 
            // tb_reminderTime
            // 
            this.tb_reminderTime.Location = new System.Drawing.Point(133, 10);
            this.tb_reminderTime.Name = "tb_reminderTime";
            this.tb_reminderTime.Size = new System.Drawing.Size(122, 21);
            this.tb_reminderTime.TabIndex = 1;
            this.tb_reminderTime.Text = "60";
            this.tb_reminderTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_reminderTime.TextChanged += new System.EventHandler(this.tb_reminderTime_TextChanged);
            this.tb_reminderTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_textBox_reminderTime_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "久坐提醒时间：";
            // 
            // tabPage_Running
            // 
            this.tabPage_Running.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage_Running.Controls.Add(this.btn_stopReminder);
            this.tabPage_Running.Controls.Add(this.label_reminderTime);
            this.tabPage_Running.Controls.Add(this.tb_reminderTimeInfo);
            this.tabPage_Running.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Running.Name = "tabPage_Running";
            this.tabPage_Running.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Running.Size = new System.Drawing.Size(377, 149);
            this.tabPage_Running.TabIndex = 1;
            this.tabPage_Running.Text = "Running";
            // 
            // btn_stopReminder
            // 
            this.btn_stopReminder.Location = new System.Drawing.Point(133, 108);
            this.btn_stopReminder.Name = "btn_stopReminder";
            this.btn_stopReminder.Size = new System.Drawing.Size(122, 24);
            this.btn_stopReminder.TabIndex = 9;
            this.btn_stopReminder.Text = "停止久坐提醒";
            this.btn_stopReminder.UseVisualStyleBackColor = true;
            this.btn_stopReminder.Click += new System.EventHandler(this.btn_stopReminder_Click);
            // 
            // label_reminderTime
            // 
            this.label_reminderTime.Location = new System.Drawing.Point(8, 10);
            this.label_reminderTime.Name = "label_reminderTime";
            this.label_reminderTime.Size = new System.Drawing.Size(357, 16);
            this.label_reminderTime.TabIndex = 1;
            this.label_reminderTime.Text = "久坐提醒时间：0分钟 | 鼠标无操作停止久坐记录：0分钟";
            this.label_reminderTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_reminderTimeInfo
            // 
            this.tb_reminderTimeInfo.Font = new System.Drawing.Font("新宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_reminderTimeInfo.Location = new System.Drawing.Point(8, 33);
            this.tb_reminderTimeInfo.Multiline = true;
            this.tb_reminderTimeInfo.Name = "tb_reminderTimeInfo";
            this.tb_reminderTimeInfo.ReadOnly = true;
            this.tb_reminderTimeInfo.Size = new System.Drawing.Size(357, 69);
            this.tb_reminderTimeInfo.TabIndex = 0;
            this.tb_reminderTimeInfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Window;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(0);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FuncToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.menuStrip1.Size = new System.Drawing.Size(381, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FuncToolStripMenuItem
            // 
            this.FuncToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SettingToolStripMenuItem,
            this.toolStripSeparator1,
            this.AboutToolStripMenuItem});
            this.FuncToolStripMenuItem.Name = "FuncToolStripMenuItem";
            this.FuncToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.FuncToolStripMenuItem.Text = "功能";
            // 
            // SettingToolStripMenuItem
            // 
            this.SettingToolStripMenuItem.Image = global::SedentaryReminder.Properties.Resources.setting;
            this.SettingToolStripMenuItem.Name = "SettingToolStripMenuItem";
            this.SettingToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.SettingToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.SettingToolStripMenuItem.Text = "设置(&S)";
            this.SettingToolStripMenuItem.Click += new System.EventHandler(this.SettingToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(156, 6);
            // 
            // AboutToolStripMenuItem
            // 
            this.AboutToolStripMenuItem.Image = global::SedentaryReminder.Properties.Resources.about;
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            this.AboutToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.AboutToolStripMenuItem.Text = "关于(&A)";
            this.AboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.notifyIconMenu;
            this.notifyIcon.Text = "久坐提醒";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseClick);
            // 
            // notifyIconMenu
            // 
            this.notifyIconMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.notifyIconMenu_displayWindow,
            this.notifyIconMenu_setting,
            this.notifyIconMenu_about,
            this.toolStripSeparator2,
            this.notifyIconMenu_finish});
            this.notifyIconMenu.Name = "notifyIconMenu";
            this.notifyIconMenu.Size = new System.Drawing.Size(141, 98);
            // 
            // notifyIconMenu_displayWindow
            // 
            this.notifyIconMenu_displayWindow.Name = "notifyIconMenu_displayWindow";
            this.notifyIconMenu_displayWindow.Size = new System.Drawing.Size(140, 22);
            this.notifyIconMenu_displayWindow.Text = "显示程序(&V)";
            this.notifyIconMenu_displayWindow.Click += new System.EventHandler(this.notifyIconMenu_displayWindow_Click);
            // 
            // notifyIconMenu_setting
            // 
            this.notifyIconMenu_setting.Name = "notifyIconMenu_setting";
            this.notifyIconMenu_setting.Size = new System.Drawing.Size(140, 22);
            this.notifyIconMenu_setting.Text = "设置(&S)";
            this.notifyIconMenu_setting.Click += new System.EventHandler(this.notifyIconMenu_setting_Click);
            // 
            // notifyIconMenu_about
            // 
            this.notifyIconMenu_about.Name = "notifyIconMenu_about";
            this.notifyIconMenu_about.Size = new System.Drawing.Size(140, 22);
            this.notifyIconMenu_about.Text = "关于(&I)";
            this.notifyIconMenu_about.Click += new System.EventHandler(this.notifyIconMenu_about_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(137, 6);
            // 
            // notifyIconMenu_finish
            // 
            this.notifyIconMenu_finish.Name = "notifyIconMenu_finish";
            this.notifyIconMenu_finish.Size = new System.Drawing.Size(140, 22);
            this.notifyIconMenu_finish.Text = "关闭软件(&E)";
            this.notifyIconMenu_finish.Click += new System.EventHandler(this.notifyIconMenu_finish_Click);
            // 
            // timer_sedentaryReminder
            // 
            this.timer_sedentaryReminder.Interval = 1000;
            this.timer_sedentaryReminder.Tick += new System.EventHandler(this.timer_sedentaryReminder_Tick);
            // 
            // FormStart
            // 
            this.AcceptButton = this.btn_startReminder;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 174);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FormStart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "久坐提醒";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormStart_FormClosing);
            this.Load += new System.EventHandler(this.FormStart_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage_Main.ResumeLayout(false);
            this.tabPage_Main.PerformLayout();
            this.tabPage_Running.ResumeLayout(false);
            this.tabPage_Running.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.notifyIconMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion
        private System.Windows.Forms.TabPage tabPage_Main;
        private System.Windows.Forms.TabPage tabPage_Running;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_reminderTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_stopReminderTips;
        private System.Windows.Forms.TextBox tb_stopReminderTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbBox_reminderMode;
        private System.Windows.Forms.Button btn_startReminder;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FuncToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SettingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip notifyIconMenu;
        private System.Windows.Forms.ToolStripMenuItem notifyIconMenu_displayWindow;
        private System.Windows.Forms.ToolStripMenuItem notifyIconMenu_setting;
        private System.Windows.Forms.ToolStripMenuItem notifyIconMenu_about;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem notifyIconMenu_finish;
        private System.Windows.Forms.TextBox tb_reminderTimeInfo;
        private System.Windows.Forms.Label label_reminderTime;
        private System.Windows.Forms.Button btn_stopReminder;
        public System.Windows.Forms.Timer timer_sedentaryReminder;
    }
}

