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
        public delegate void showLogin(object sender, FormClosedEventArgs e);
        public showLogin _loginShow;
        //


        private CodeDTO md5 = new CodeDTO();
        public static CEmployeeDTO m_EmployeeObject;
        private CDataExecute userExecute = new CDataExecute();

        public ucLogin()
        {
            InitializeComponent();
            initLogin();
        }

        private void initLogin()
        {
            md5 = new CodeDTO();
            m_EmployeeObject = new CEmployeeDTO();
            userExecute = new CDataExecute();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            actionLogin();
        }

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                actionLogin();
            }
        }
        
        private void btnCancel_Click(object sender, EventArgs e)
        {
            _loginClose();
        }
        
        
        //CAC HAM
        private bool login(String _userName, String _passWord)
        {
            try
            {
                if (checkLogin(_userName, _passWord))
                {
                    txtPass.Text = null;
                    txtUser.Text = null;
                    return true;
                }
                else
                {
                    XtraMessageBox.Show("Tên đăng nhập hoặc password không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUser.Text = null;
                    txtPass.Text = null;
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
                        if (txtPass.Text.Equals(Pass))
                        {
                            temp = true;
                            m_EmployeeObject.maNhanVien = dt.Rows[0]["MaNV"].ToString();
                            m_EmployeeObject.tenNhanVien = dt.Rows[0]["TenNV"].ToString();
                            m_EmployeeObject.gioiTinh = dt.Rows[0]["GioiTinh"].ToString();
                            m_EmployeeObject.ngaySinh = Convert.ToDateTime(dt.Rows[0]["NgaySinh"].ToString());
                            m_EmployeeObject.email = dt.Rows[0]["Email"].ToString();
                            m_EmployeeObject.soDienThoai = dt.Rows[0]["DienThoai"].ToString();
                            m_EmployeeObject.diaChi = dt.Rows[0]["DiaChi"].ToString();
                            m_EmployeeObject.ngayVaoLam = Convert.ToDateTime(dt.Rows[0]["NgayVaoLam"].ToString());
                            m_EmployeeObject.maChucVu = dt.Rows[0]["MaCV"].ToString();
                            m_EmployeeObject.tenDangNhap = dt.Rows[0]["UserName"].ToString();
                            m_EmployeeObject.matKhau = dt.Rows[0]["Password"].ToString();
                        }
                    }
                }
                else
                    temp = false;
                return temp;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private void loginShow(object sender, FormClosedEventArgs e)
        {
            _loginShow(sender, e);
        }

        public DataTable getEmployee_UserName_Pass()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "GetEmployeeUserNamePassWord";
            SqlParameter pram;
            pram = new SqlParameter("@UserName", txtUser.Text.Trim());
            SqlParameter pram1;
            pram1 = new SqlParameter("@PassWord", txtPass.Text.Trim());
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

        //Ham thuc hien dang nhap
        private void actionLogin()
        {
            try
            {
                if (txtUser.Text.Equals("") || txtPass.Text.Equals(""))
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
                    if (login(txtUser.Text, txtPass.Text))
                    {
                        frmMain _frmMain = new frmMain();
                        _frmMain.WindowState = FormWindowState.Maximized;
                        _frmMain.Show();
                        _frmMain._loginShow = new frmMain.showLogin(loginShow);
                        _loginHide();
                    }
                }
            }
            catch (Exception) { }
        }

    }
}

