
namespace SedentaryReminder.pages
{
    partial class FormCloseOrMinimize
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
            this.rb_minimize = new System.Windows.Forms.RadioButton();
            this.rb_finishProgram = new System.Windows.Forms.RadioButton();
            this.cb_remeberMyChoice = new System.Windows.Forms.CheckBox();
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rb_minimize
            // 
            this.rb_minimize.AutoSize = true;
            this.rb_minimize.Checked = true;
            this.rb_minimize.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rb_minimize.Location = new System.Drawing.Point(23, 24);
            this.rb_minimize.Name = "rb_minimize";
            this.rb_minimize.Size = new System.Drawing.Size(188, 25);
            this.rb_minimize.TabIndex = 0;
            this.rb_minimize.TabStop = true;
            this.rb_minimize.Text = "最小化程序到系统托盘";
            this.rb_minimize.UseVisualStyleBackColor = true;
            // 
            // rb_finishProgram
            // 
            this.rb_finishProgram.AutoSize = true;
            this.rb_finishProgram.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rb_finishProgram.Location = new System.Drawing.Point(238, 24);
            this.rb_finishProgram.Name = "rb_finishProgram";
            this.rb_finishProgram.Size = new System.Drawing.Size(124, 25);
            this.rb_finishProgram.TabIndex = 1;
            this.rb_finishProgram.Text = "结束程序运行";
            this.rb_finishProgram.UseVisualStyleBackColor = true;
            // 
            // cb_remeberMyChoice
            // 
            this.cb_remeberMyChoice.AutoSize = true;
            this.cb_remeberMyChoice.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cb_remeberMyChoice.Location = new System.Drawing.Point(23, 66);
            this.cb_remeberMyChoice.Name = "cb_remeberMyChoice";
            this.cb_remeberMyChoice.Size = new System.Drawing.Size(125, 25);
            this.cb_remeberMyChoice.TabIndex = 2;
            this.cb_remeberMyChoice.Text = "记住我的选择";
            this.cb_remeberMyChoice.UseVisualStyleBackColor = true;
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(194, 82);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(107, 30);
            this.btn_ok.TabIndex = 3;
            this.btn_ok.Text = "确定";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(307, 82);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(107, 30);
            this.btn_cancel.TabIndex = 4;
            this.btn_cancel.Text = "取消";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // FormCloseOrMinimize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 124);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.cb_remeberMyChoice);
            this.Controls.Add(this.rb_finishProgram);
            this.Controls.Add(this.rb_minimize);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCloseOrMinimize";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "温馨提示";
            this.Load += new System.EventHandler(this.FormCloseOrMinimize_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rb_minimize;
        private System.Windows.Forms.RadioButton rb_finishProgram;
        private System.Windows.Forms.CheckBox cb_remeberMyChoice;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_cancel;
    }
}