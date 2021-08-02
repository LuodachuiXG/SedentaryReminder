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

        public FormCloseOrMinimize(Form form)
        {
            this.form = form;
            InitializeComponent();
        }

        private void FormCloseOrMinimize_Load(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.ico;
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
