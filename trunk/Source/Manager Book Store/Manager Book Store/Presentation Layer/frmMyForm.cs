using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Card;

namespace Manager_Book_Store.Presentation_Layer
{
    public partial class frmHome : XtraUserControl
    {
        public frmHome()
        {
            InitializeComponent();
           
        }

        private void frmMyForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
               // this.WindowState = FormWindowState.Minimized;
            }
        }

        private void tileControl1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
               // this.WindowState = FormWindowState.Minimized;
            }
        }

        private void picminimize_Click(object sender, EventArgs e)
        {
           // this.WindowState = FormWindowState.Minimized;
        }

        private void picClose_Click(object sender, EventArgs e)
        {
           // this.Close();
        }

        private void chkShowElement_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowElement.Checked)
            {
                titleAbout.Visible = false;
                titleLogin.Visible = false;
                titleHelp.Visible = false;
                titleOption.Visible = false;
            }
            else
            {
                titleAbout.Visible = true;
                titleLogin.Visible = true;
                titleHelp.Visible = true;
                titleOption.Visible = true;
            }
        }


    }
}