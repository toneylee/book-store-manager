using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraBars.Docking2010.Views.WindowsUI;

namespace Manager_Book_Store.Presentation_Layer
{
    public partial class frmMenu : DevExpress.XtraEditors.XtraForm
    {

        DevExpress.XtraBars.Docking2010.Views.WindowsUI.FlyoutAction closeAppAction = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.FlyoutAction()
        {
            Caption = "Confirm",Description = "Quit the application?"
        };
        public frmMenu()
        {
            InitializeComponent();
            closeAppAction.Commands.Add(FlyoutCommand.OK);
            closeAppAction.Commands.Add(FlyoutCommand.Cancel);
            flyoutMenu.Action = closeAppAction;
        }

        private void windowsUIView1_NavigationBarsShowing(object sender, DevExpress.XtraBars.Docking2010.Views.WindowsUI.NavigationBarsCancelEventArgs e)
        {
            e.Cancel = true;
        }

        private void frmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            if (windowUIMenu.ShowFlyoutDialog(flyoutMenu) != System.Windows.Forms.DialogResult.OK){
                e.Cancel = true;
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void tileDesktop_Click(object sender, TileClickEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void frmMenu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }
        private void windowUIMenu_QueryControl(object sender, DevExpress.XtraBars.Docking2010.Views.QueryControlEventArgs e)
        {
            if (e.Document == docLogin)
                e.Control = new ucLogin();
            else
                e.Control = new PanelControl();
        }

    }
}