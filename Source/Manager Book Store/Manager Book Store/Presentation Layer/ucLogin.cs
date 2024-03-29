﻿using System;
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
using Manager_Book_Store.General;

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
        public static CEmployeeDTO m_EmployeeObject;
        private CLoginBUS m_loginExecute;
        private DataTable          m_EmployeeData;
        private bool m_checkTypeLogin; 
        public ucLogin()
        {
            InitializeComponent();
            m_EmployeeObject = new CEmployeeDTO();
            m_loginExecute = new CLoginBUS();
        }

        private void ucLogin_Load(object sender, EventArgs e)
        {
            if (m_loginExecute.getEmployeeDataFromDatabase().Rows.Count > 0)
                m_checkTypeLogin = true;
            else
            {
                m_checkTypeLogin = false;
                XtraCustomMessageBox.Show("Chưa có nhân viên nào trong cơ sở dữ liệu.\nVui lòng đăng nhập với tài khoản 'admin'!", "Thông báo!", true);
                txtUser.Text = "admin";
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (m_checkTypeLogin)
                actionLogin();
            else
            {
                loginWithAdmin(txtUser.Text, txtPass.Text);
            }
        }

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (m_checkTypeLogin)
                    actionLogin();
                else
                {
                    loginWithAdmin(txtUser.Text, txtPass.Text);
                }
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
                m_EmployeeData = m_loginExecute.getEmployee_UserName_Pass(_userName, _passWord);
                if (m_EmployeeData.Rows.Count > 0)
                {
                    String User = m_EmployeeData.Rows[0]["UserName"].ToString();
                    String Pass = m_EmployeeData.Rows[0]["PassWord"].ToString();

                    if (_userName.Equals(User))
                    {
                        if (_passWord.Equals(Pass))
                        {
                            m_EmployeeObject.maNhanVien = m_EmployeeData.Rows[0]["MaNV"].ToString();
                            m_EmployeeObject.tenNhanVien = m_EmployeeData.Rows[0]["TenNV"].ToString();
                            m_EmployeeObject.gioiTinh = m_EmployeeData.Rows[0]["GioiTinh"].ToString();
                            m_EmployeeObject.ngaySinh = Convert.ToDateTime(m_EmployeeData.Rows[0]["NgaySinh"].ToString());
                            m_EmployeeObject.email = m_EmployeeData.Rows[0]["Email"].ToString();
                            m_EmployeeObject.soDienThoai = m_EmployeeData.Rows[0]["DienThoai"].ToString();
                            m_EmployeeObject.diaChi = m_EmployeeData.Rows[0]["DiaChi"].ToString();
                            m_EmployeeObject.ngayVaoLam = Convert.ToDateTime(m_EmployeeData.Rows[0]["NgayVaoLam"].ToString());
                            m_EmployeeObject.maChucVu = m_EmployeeData.Rows[0]["MaCV"].ToString();
                            m_EmployeeObject.tenDangNhap = m_EmployeeData.Rows[0]["UserName"].ToString();
                            m_EmployeeObject.matKhau = m_EmployeeData.Rows[0]["Password"].ToString();
                            return true;
                        }
                    }
                }
                return false;
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
                    if (login(txtUser.Text, CodeDTO.getMD5Hash(txtPass.Text.Trim())))
                    {
                        frmMain _frmMain = new frmMain();
                        _frmMain.WindowState = FormWindowState.Maximized;
                        _frmMain.Show();
                        _frmMain._loginShow = new frmMain.showLogin(loginShow);
                        _loginHide();
                    }
                }
            }
            catch (Exception)
            {

            }
        }

        //Login neu chua co nhan vien nao trong co so du lieu
        private void loginWithAdmin(String _userName, String _passWord)
        {
            if (_userName.Equals("admin"))
            {
                if (_passWord.Equals("123456789"))
                {
                    m_EmployeeObject.maNhanVien = "NV0000000";
                    m_EmployeeObject.tenNhanVien = "Admin";
                    m_EmployeeObject.gioiTinh = "";
                    m_EmployeeObject.ngaySinh = DateTime.Now;
                    m_EmployeeObject.email = "vovantinhpy@gmail.com";
                    m_EmployeeObject.soDienThoai = "0993379109";
                    m_EmployeeObject.diaChi = "HCM city";
                    m_EmployeeObject.ngayVaoLam = DateTime.Now;
                    m_EmployeeObject.maChucVu = "CV0000003";
                    m_EmployeeObject.tenDangNhap = "admin";
                    m_EmployeeObject.matKhau = "123456789";
                    //
                    frmMain _frmMain = new frmMain();
                    _frmMain.WindowState = FormWindowState.Maximized;
                    _frmMain.Show();
                    _frmMain._loginShow = new frmMain.showLogin(loginShow);
                    _loginHide();
                }
                else
                {
                    txtPass.Text = null;
                    XtraCustomMessageBox.Show("Sai mật khẩu. Vui lòng nhập lại!", "Thông báo", true);
                }
            }
            else
            {
                txtUser.Text = null;
                txtPass.Text = null;
                XtraCustomMessageBox.Show("Tên đăng nhập không đúng. Vui lòng nhập lại!", "Thông báo", true);
            }
        }
    }
}

