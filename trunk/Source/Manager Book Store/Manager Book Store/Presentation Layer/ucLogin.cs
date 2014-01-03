using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Manager_Book_Store.Presentation_Layer
{
    public partial class ucLogin : DevExpress.XtraEditors.XtraUserControl
    {
        public static bool loginSuccessFully = false;
        public ucLogin()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            loginSuccessFully = true;
            frmMain _main = new frmMain();
            _main.WindowState = FormWindowState.Maximized;
            _main.ShowDialog();
        }
    }
}
