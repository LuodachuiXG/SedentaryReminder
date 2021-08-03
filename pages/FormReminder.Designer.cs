
namespace SedentaryReminder.pages
{
    partial class FormReminder
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
            this.components = new System.ComponentModel.Container();
            this.label_reminderText = new System.Windows.Forms.Label();
            this.label_key = new System.Windows.Forms.Label();
            this.label_activityTime = new System.Windows.Forms.Label();
            this.timer_activity = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label_reminderText
            // 
            this.label_reminderText.BackColor = System.Drawing.Color.Transparent;
            this.label_reminderText.Font = new System.Drawing.Font("宋体", 11F);
            this.label_reminderText.Location = new System.Drawing.Point(0, 9);
            this.label_reminderText.Name = "label_reminderText";
            this.label_reminderText.Size = new System.Drawing.Size(320, 80);
            this.label_reminderText.TabIndex = 0;
            this.label_reminderText.Text = "活动时间到了，起身活动一下并向远方眺望放松一下眼部压力。";
            this.label_reminderText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_key
            // 
            this.label_key.BackColor = System.Drawing.Color.Transparent;
            this.label_key.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_key.ForeColor = System.Drawing.Color.Red;
            this.label_key.Location = new System.Drawing.Point(0, 92);
            this.label_key.Name = "label_key";
            this.label_key.Size = new System.Drawing.Size(320, 49);
            this.label_key.TabIndex = 1;
            this.label_key.Text = "Alt+Shift+I：忽视本次活动提醒\r\n\r\nAlt+Shift+G：起身活动/活动结束";
            this.label_key.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_activityTime
            // 
            this.label_activityTime.BackColor = System.Drawing.Color.Transparent;
            this.label_activityTime.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_activityTime.ForeColor = System.Drawing.Color.Red;
            this.label_activityTime.Location = new System.Drawing.Point(0, 92);
            this.label_activityTime.Name = "label_activityTime";
            this.label_activityTime.Size = new System.Drawing.Size(320, 49);
            this.label_activityTime.TabIndex = 2;
            this.label_activityTime.Text = "已经活动：00天00小时00分00秒";
            this.label_activityTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_activityTime.Visible = false;
            // 
            // timer_activity
            // 
            this.timer_activity.Interval = 1000;
            this.timer_activity.Tick += new System.EventHandler(this.timer_activity_Tick);
            // 
            // FormReminder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(320, 150);
            this.ControlBox = false;
            this.Controls.Add(this.label_activityTime);
            this.Controls.Add(this.label_key);
            this.Controls.Add(this.label_reminderText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormReminder";
            this.ShowIcon = false;
            this.Text = "FormReminder";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormReminder_FormClosing);
            this.Load += new System.EventHandler(this.FormReminder_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_reminderText;
        private System.Windows.Forms.Label label_key;
        private System.Windows.Forms.Label label_activityTime;
        private System.Windows.Forms.Timer timer_activity;
    }
}