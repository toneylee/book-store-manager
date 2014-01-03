using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Manager_Book_Store.Data_Tranfer_Object;
using System.Data.SqlClient;
using Manager_Book_Store.Data_Access_Layer;

namespace Manager_Book_Store.Presentation_Layer
{
    public partial class ucLogin : DevExpress.XtraEditors.XtraUserControl
    {
        //delegate exit menu + application
        public delegate void closeLogin();
        public closeLogin _loginClose, _loginHide;
        //


        public static bool loginSuccessFully = false;
        private MaHoaDTO md5 = new MaHoaDTO();
        private CDataConnection connectData = new CDataConnection();
        private CDataExecute userExecute = new CDataExecute();

        public ucLogin()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUser.Text.Equals("") || txtpass.Text.Equals(""))
                {
                    XtraMessageBox.Show("Tên đăng nhập hoặc password chưa được nhập. Vui lòng nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    /* if (login(txtUser.Text, md5.getMD5Hash(txtpass.Text)))
                     {
                         frmMain _frmMain = new frmMain();
                         _frmMain.Show();
                     }
                     */
                    if (login(txtUser.Text, txtpass.Text))
                    {
                        frmMain _frmMain = new frmMain();
                        _frmMain.WindowState = FormWindowState.Maximized;
                        _frmMain.Show();
                        _loginHide();
                    }
                }
            }
            catch (Exception) { }
        }

        //CAC HAM
        private bool login(String _userName, String _passWord)
        {
            try
            {
                if (checkLogin(_userName, _passWord))
                {
                    return true;
                }
                else
                {
                    XtraMessageBox.Show("Tên đăng nhập hoặc password không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUser.Text = null;
                    txtpass.Text = null;
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
                throw ex;
            }
        }

        private bool checkLogin(string _userName, string _passWord)
        {
            try
            {
                bool temp = false;
                DataTable dt = getEmployee_UserName_Pass();
                if (dt != null)
                {
                    String User = dt.Rows[0]["UserName"].ToString();
                    String Pass = dt.Rows[0]["PassWord"].ToString();

                    if (txtUser.Text.Equals(User))
                    {
                        if (txtpass.Text.Equals(Pass))
                            temp = true;
                    }
                }
                else
                    temp = false;
                return temp;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public DataTable getEmployee_UserName_Pass()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "GetEmployeeUserNamePassWord";
            SqlParameter pram;
            pram = new SqlParameter("@UserName", txtUser.Text.Trim());
            SqlParameter pram1;
            pram1 = new SqlParameter("@PassWord", txtpass.Text.Trim());
            cmd.Parameters.Add(pram);
            cmd.Parameters.Add(pram1);

            return userExecute.getData(cmd);
        }

        public String getStringEmployee_UserName()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "GetEmployeeUserName";
            SqlParameter pram = new SqlParameter("@UserName", txtUser.Text.Trim());
            cmd.Parameters.Add(pram);

            return userExecute.getStringExecuter(cmd);
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            _loginClose();
        }
    }
}

