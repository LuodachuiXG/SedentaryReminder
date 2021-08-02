
namespace SedentaryReminder
{
    partial class FormSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage_generalSettings = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cBox_general_autoStarting = new System.Windows.Forms.CheckBox();
            this.cBox_general_selfStarting = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cBox_general_RememberMyChoice = new System.Windows.Forms.CheckBox();
            this.rBtn_general_finishProgram = new System.Windows.Forms.RadioButton();
            this.rBtn_general_minimize = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage_reminderSettings = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_finish = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cbBox_reminder_ignoreFuncKey = new System.Windows.Forms.ComboBox();
            this.cbBox_reminder_ignoreKey = new System.Windows.Forms.ComboBox();
            this.cbBox_reminder_activityKey = new System.Windows.Forms.ComboBox();
            this.cbBox_reminder_activityFuncKey = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_reminder_reminderText = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_reminder_selectMusic = new System.Windows.Forms.Button();
            this.btn_reminder_selectBackground = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.cbBox_reminder_textColor = new System.Windows.Forms.ComboBox();
            this.cb_reminder_displayTips = new System.Windows.Forms.CheckBox();
            this.cb_reminder_displayKeyAndTimeTips = new System.Windows.Forms.CheckBox();
            this.cb_reminder_windowsShadow = new System.Windows.Forms.CheckBox();
            this.tabControl1.SuspendLayout();
            this.tabPage_generalSettings.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage_reminderSettings.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage_generalSettings);
            this.tabControl1.Controls.Add(this.tabPage_reminderSettings);
            this.tabControl1.Location = new System.Drawing.Point(10, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(377, 446);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage_generalSettings
            // 
            this.tabPage_generalSettings.Controls.Add(this.groupBox2);
            this.tabPage_generalSettings.Controls.Add(this.groupBox1);
            this.tabPage_generalSettings.Location = new System.Drawing.Point(4, 22);
            this.tabPage_generalSettings.Name = "tabPage_generalSettings";
            this.tabPage_generalSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_generalSettings.Size = new System.Drawing.Size(369, 420);
            this.tabPage_generalSettings.TabIndex = 0;
            this.tabPage_generalSettings.Text = "常规设置";
            this.tabPage_generalSettings.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cBox_general_autoStarting);
            this.groupBox2.Controls.Add(this.cBox_general_selfStarting);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(6, 139);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(357, 127);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "功能设置";
            // 
            // cBox_general_autoStarting
            // 
            this.cBox_general_autoStarting.AutoSize = true;
            this.cBox_general_autoStarting.Location = new System.Drawing.Point(195, 78);
            this.cBox_general_autoStarting.Name = "cBox_general_autoStarting";
            this.cBox_general_autoStarting.Size = new System.Drawing.Size(120, 16);
            this.cBox_general_autoStarting.TabIndex = 4;
            this.cBox_general_autoStarting.Text = "自动运行久坐提醒";
            this.cBox_general_autoStarting.UseVisualStyleBackColor = true;
            // 
            // cBox_general_selfStarting
            // 
            this.cBox_general_selfStarting.AutoSize = true;
            this.cBox_general_selfStarting.Location = new System.Drawing.Point(195, 39);
            this.cBox_general_selfStarting.Name = "cBox_general_selfStarting";
            this.cBox_general_selfStarting.Size = new System.Drawing.Size(96, 16);
            this.cBox_general_selfStarting.TabIndex = 3;
            this.cBox_general_selfStarting.Text = "跟随系统启动";
            this.cBox_general_selfStarting.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 84);
            this.label2.TabIndex = 0;
            this.label2.Text = "程序在电脑启动时是否\r\n\r\n跟随启动（开机自启），\r\n\r\n以及启动软件后是否自动\r\n\r\n运行久坐提醒功能。";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cBox_general_RememberMyChoice);
            this.groupBox1.Controls.Add(this.rBtn_general_finishProgram);
            this.groupBox1.Controls.Add(this.rBtn_general_minimize);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(357, 127);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "关闭软件设置";
            // 
            // cBox_general_RememberMyChoice
            // 
            this.cBox_general_RememberMyChoice.AutoSize = true;
            this.cBox_general_RememberMyChoice.Location = new System.Drawing.Point(196, 86);
            this.cBox_general_RememberMyChoice.Name = "cBox_general_RememberMyChoice";
            this.cBox_general_RememberMyChoice.Size = new System.Drawing.Size(96, 16);
            this.cBox_general_RememberMyChoice.TabIndex = 3;
            this.cBox_general_RememberMyChoice.Text = "记住我的选择";
            this.cBox_general_RememberMyChoice.UseVisualStyleBackColor = true;
            // 
            // rBtn_general_finishProgram
            // 
            this.rBtn_general_finishProgram.AutoSize = true;
            this.rBtn_general_finishProgram.Location = new System.Drawing.Point(196, 58);
            this.rBtn_general_finishProgram.Name = "rBtn_general_finishProgram";
            this.rBtn_general_finishProgram.Size = new System.Drawing.Size(95, 16);
            this.rBtn_general_finishProgram.TabIndex = 2;
            this.rBtn_general_finishProgram.TabStop = true;
            this.rBtn_general_finishProgram.Text = "结束程序运行";
            this.rBtn_general_finishProgram.UseVisualStyleBackColor = true;
            // 
            // rBtn_general_minimize
            // 
            this.rBtn_general_minimize.AutoSize = true;
            this.rBtn_general_minimize.Checked = true;
            this.rBtn_general_minimize.Location = new System.Drawing.Point(196, 30);
            this.rBtn_general_minimize.Name = "rBtn_general_minimize";
            this.rBtn_general_minimize.Size = new System.Drawing.Size(143, 16);
            this.rBtn_general_minimize.TabIndex = 1;
            this.rBtn_general_minimize.TabStop = true;
            this.rBtn_general_minimize.Text = "最小化程序置系统托盘";
            this.rBtn_general_minimize.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "关闭软件时将程序最\r\n\r\n小化置系统托盘或直\r\n\r\n接结束程序运行。";
            // 
            // tabPage_reminderSettings
            // 
            this.tabPage_reminderSettings.Controls.Add(this.groupBox5);
            this.tabPage_reminderSettings.Controls.Add(this.groupBox4);
            this.tabPage_reminderSettings.Controls.Add(this.groupBox3);
            this.tabPage_reminderSettings.Location = new System.Drawing.Point(4, 22);
            this.tabPage_reminderSettings.Name = "tabPage_reminderSettings";
            this.tabPage_reminderSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_reminderSettings.Size = new System.Drawing.Size(369, 420);
            this.tabPage_reminderSettings.TabIndex = 1;
            this.tabPage_reminderSettings.Text = "提醒设置";
            this.tabPage_reminderSettings.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.cbBox_reminder_activityKey);
            this.groupBox3.Controls.Add(this.cbBox_reminder_activityFuncKey);
            this.groupBox3.Controls.Add(this.cbBox_reminder_ignoreKey);
            this.groupBox3.Controls.Add(this.cbBox_reminder_ignoreFuncKey);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(6, 7);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(357, 131);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "热键设置";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "忽略这次提醒：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "久坐提醒页面的一些快捷键。";
            // 
            // btn_finish
            // 
            this.btn_finish.Location = new System.Drawing.Point(294, 464);
            this.btn_finish.Name = "btn_finish";
            this.btn_finish.Size = new System.Drawing.Size(89, 30);
            this.btn_finish.TabIndex = 1;
            this.btn_finish.Text = "确定";
            this.btn_finish.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 12);
            this.label5.TabIndex = 3;
            this.label5.Text = "活动/结束活动：";
            // 
            // cbBox_reminder_ignoreFuncKey
            // 
            this.cbBox_reminder_ignoreFuncKey.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBox_reminder_ignoreFuncKey.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cbBox_reminder_ignoreFuncKey.FormattingEnabled = true;
            this.cbBox_reminder_ignoreFuncKey.Items.AddRange(new object[] {
            "无功能键",
            "Ctrl",
            "Shift",
            "Alt",
            "Ctrl+Shift",
            "Alt+Shift",
            "Ctrl+Alt",
            "Ctrl+Shift+Alt"});
            this.cbBox_reminder_ignoreFuncKey.Location = new System.Drawing.Point(116, 52);
            this.cbBox_reminder_ignoreFuncKey.Name = "cbBox_reminder_ignoreFuncKey";
            this.cbBox_reminder_ignoreFuncKey.Size = new System.Drawing.Size(120, 20);
            this.cbBox_reminder_ignoreFuncKey.TabIndex = 4;
            // 
            // cbBox_reminder_ignoreKey
            // 
            this.cbBox_reminder_ignoreKey.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBox_reminder_ignoreKey.FormattingEnabled = true;
            this.cbBox_reminder_ignoreKey.Items.AddRange(new object[] {
            "F1",
            "F2",
            "F3",
            "F4",
            "F5",
            "F6",
            "F7",
            "F8",
            "F9",
            "F10",
            "F11",
            "F12",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "0",
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z"});
            this.cbBox_reminder_ignoreKey.Location = new System.Drawing.Point(252, 52);
            this.cbBox_reminder_ignoreKey.Name = "cbBox_reminder_ignoreKey";
            this.cbBox_reminder_ignoreKey.Size = new System.Drawing.Size(79, 20);
            this.cbBox_reminder_ignoreKey.TabIndex = 5;
            // 
            // cbBox_reminder_activityKey
            // 
            this.cbBox_reminder_activityKey.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBox_reminder_activityKey.FormattingEnabled = true;
            this.cbBox_reminder_activityKey.Items.AddRange(new object[] {
            "F1",
            "F2",
            "F3",
            "F4",
            "F5",
            "F6",
            "F7",
            "F8",
            "F9",
            "F10",
            "F11",
            "F12",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "0",
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z"});
            this.cbBox_reminder_activityKey.Location = new System.Drawing.Point(252, 88);
            this.cbBox_reminder_activityKey.Name = "cbBox_reminder_activityKey";
            this.cbBox_reminder_activityKey.Size = new System.Drawing.Size(79, 20);
            this.cbBox_reminder_activityKey.TabIndex = 7;
            // 
            // cbBox_reminder_activityFuncKey
            // 
            this.cbBox_reminder_activityFuncKey.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBox_reminder_activityFuncKey.FormattingEnabled = true;
            this.cbBox_reminder_activityFuncKey.Items.AddRange(new object[] {
            "无功能键",
            "Ctrl",
            "Shift",
            "Alt",
            "Ctrl+Shift",
            "Alt+Shift",
            "Ctrl+Alt",
            "Ctrl+Shift+Alt"});
            this.cbBox_reminder_activityFuncKey.Location = new System.Drawing.Point(115, 88);
            this.cbBox_reminder_activityFuncKey.Name = "cbBox_reminder_activityFuncKey";
            this.cbBox_reminder_activityFuncKey.Size = new System.Drawing.Size(120, 20);
            this.cbBox_reminder_activityFuncKey.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(238, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(11, 48);
            this.label6.TabIndex = 8;
            this.label6.Text = "+\r\n\r\n\r\n+";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tb_reminder_reminderText);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Location = new System.Drawing.Point(6, 144);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(357, 100);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "提示文本";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(161, 12);
            this.label10.TabIndex = 0;
            this.label10.Text = "久坐提醒页面上的提示文本。";
            // 
            // tb_reminder_reminderText
            // 
            this.tb_reminder_reminderText.Location = new System.Drawing.Point(7, 47);
            this.tb_reminder_reminderText.Multiline = true;
            this.tb_reminder_reminderText.Name = "tb_reminder_reminderText";
            this.tb_reminder_reminderText.Size = new System.Drawing.Size(343, 42);
            this.tb_reminder_reminderText.TabIndex = 1;
            this.tb_reminder_reminderText.Text = "活动时间到了，起身活动一下并向远方眺望放松一下眼部压力。";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cb_reminder_windowsShadow);
            this.groupBox5.Controls.Add(this.cb_reminder_displayKeyAndTimeTips);
            this.groupBox5.Controls.Add(this.cb_reminder_displayTips);
            this.groupBox5.Controls.Add(this.cbBox_reminder_textColor);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.btn_reminder_selectBackground);
            this.groupBox5.Controls.Add(this.btn_reminder_selectMusic);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Location = new System.Drawing.Point(6, 251);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(357, 164);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "功能设置";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(173, 12);
            this.label7.TabIndex = 1;
            this.label7.Text = "久坐提醒页面上一些其他功能。";
            // 
            // btn_reminder_selectMusic
            // 
            this.btn_reminder_selectMusic.Location = new System.Drawing.Point(8, 52);
            this.btn_reminder_selectMusic.Name = "btn_reminder_selectMusic";
            this.btn_reminder_selectMusic.Size = new System.Drawing.Size(159, 24);
            this.btn_reminder_selectMusic.TabIndex = 2;
            this.btn_reminder_selectMusic.Text = "提醒音乐（未设置）";
            this.btn_reminder_selectMusic.UseVisualStyleBackColor = true;
            // 
            // btn_reminder_selectBackground
            // 
            this.btn_reminder_selectBackground.Location = new System.Drawing.Point(8, 88);
            this.btn_reminder_selectBackground.Name = "btn_reminder_selectBackground";
            this.btn_reminder_selectBackground.Size = new System.Drawing.Size(159, 24);
            this.btn_reminder_selectBackground.TabIndex = 3;
            this.btn_reminder_selectBackground.Text = "背景图 320*150（未设置）";
            this.btn_reminder_selectBackground.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 132);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 12);
            this.label8.TabIndex = 4;
            this.label8.Text = "提示窗口文字颜色：";
            // 
            // cbBox_reminder_textColor
            // 
            this.cbBox_reminder_textColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBox_reminder_textColor.FormattingEnabled = true;
            this.cbBox_reminder_textColor.Items.AddRange(new object[] {
            "深色",
            "浅色"});
            this.cbBox_reminder_textColor.Location = new System.Drawing.Point(116, 127);
            this.cbBox_reminder_textColor.Name = "cbBox_reminder_textColor";
            this.cbBox_reminder_textColor.Size = new System.Drawing.Size(51, 20);
            this.cbBox_reminder_textColor.TabIndex = 8;
            // 
            // cb_reminder_displayTips
            // 
            this.cb_reminder_displayTips.AutoSize = true;
            this.cb_reminder_displayTips.Location = new System.Drawing.Point(202, 52);
            this.cb_reminder_displayTips.Name = "cb_reminder_displayTips";
            this.cb_reminder_displayTips.Size = new System.Drawing.Size(72, 16);
            this.cb_reminder_displayTips.TabIndex = 9;
            this.cb_reminder_displayTips.Text = "提示文本";
            this.cb_reminder_displayTips.UseVisualStyleBackColor = true;
            // 
            // cb_reminder_displayKeyAndTimeTips
            // 
            this.cb_reminder_displayKeyAndTimeTips.AutoSize = true;
            this.cb_reminder_displayKeyAndTimeTips.Location = new System.Drawing.Point(202, 88);
            this.cb_reminder_displayKeyAndTimeTips.Name = "cb_reminder_displayKeyAndTimeTips";
            this.cb_reminder_displayKeyAndTimeTips.Size = new System.Drawing.Size(144, 16);
            this.cb_reminder_displayKeyAndTimeTips.TabIndex = 10;
            this.cb_reminder_displayKeyAndTimeTips.Text = "快捷键和活动计时提示";
            this.cb_reminder_displayKeyAndTimeTips.UseVisualStyleBackColor = true;
            // 
            // cb_reminder_windowsShadow
            // 
            this.cb_reminder_windowsShadow.AutoSize = true;
            this.cb_reminder_windowsShadow.Location = new System.Drawing.Point(202, 127);
            this.cb_reminder_windowsShadow.Name = "cb_reminder_windowsShadow";
            this.cb_reminder_windowsShadow.Size = new System.Drawing.Size(72, 16);
            this.cb_reminder_windowsShadow.TabIndex = 11;
            this.cb_reminder_windowsShadow.Text = "窗口阴影";
            this.cb_reminder_windowsShadow.UseVisualStyleBackColor = true;
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 506);
            this.Controls.Add(this.btn_finish);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSettings";
            this.Text = "设置";
            this.Load += new System.EventHandler(this.FormSettings_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage_generalSettings.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage_reminderSettings.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage_generalSettings;
        private System.Windows.Forms.TabPage tabPage_reminderSettings;
        private System.Windows.Forms.Button btn_finish;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rBtn_general_finishProgram;
        private System.Windows.Forms.RadioButton rBtn_general_minimize;
        private System.Windows.Forms.CheckBox cBox_general_RememberMyChoice;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cBox_general_selfStarting;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cBox_general_autoStarting;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbBox_reminder_ignoreKey;
        private System.Windows.Forms.ComboBox cbBox_reminder_ignoreFuncKey;
        private System.Windows.Forms.ComboBox cbBox_reminder_activityKey;
        private System.Windows.Forms.ComboBox cbBox_reminder_activityFuncKey;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb_reminder_reminderText;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_reminder_selectBackground;
        private System.Windows.Forms.Button btn_reminder_selectMusic;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbBox_reminder_textColor;
        private System.Windows.Forms.CheckBox cb_reminder_displayTips;
        private System.Windows.Forms.CheckBox cb_reminder_displayKeyAndTimeTips;
        private System.Windows.Forms.CheckBox cb_reminder_windowsShadow;
    }
}