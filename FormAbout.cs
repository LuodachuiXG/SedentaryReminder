using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace SedentaryReminder
{
    public partial class FormAbout : Form
    {
        public FormAbout()
        {
            InitializeComponent();
        }

        private void FormAbout_Load(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.ico;

            label_version.Text = "版本：" + Application.ProductVersion;
        }

        private void label_author_Click(object sender, EventArgs e)
        {
            Process.Start("https://lpddr5.cn");
        }
    }
}
