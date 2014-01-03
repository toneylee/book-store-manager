using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;
using Manager_Book_Store.Report;
namespace Manager_Book_Store.Presentation_Layer
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            DevExpress.UserSkins.BonusSkins.Register();
            DevExpress.LookAndFeel.UserLookAndFeel.Default.UseWindowsXPTheme = false;
            DevExpress.LookAndFeel.UserLookAndFeel.Default.UseDefaultLookAndFeel = true;
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = "Caramel";
            DevExpress.Utils.AppearanceObject.DefaultFont = new Font("Tohoma", 10);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmBook());
        }
    }
}
