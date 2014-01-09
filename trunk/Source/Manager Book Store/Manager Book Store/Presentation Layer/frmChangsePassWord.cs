using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Manager_Book_Store.Data_Tranfer_Object;
using Manager_Book_Store.Business_Layer;
using Manager_Book_Store.General;

namespace Manager_Book_Store.Presentation_Layer
{
    public partial class frmChangePassWord : DevExpress.XtraEditors.XtraForm
    {
        private CEmployeeDTO m_EmployeeObject;
        private CEmployeeBUS m_EmployeeExecute;


        public frmChangePassWord()
        {
            InitializeComponent();
            initChangePassWord();
        }

        private void initChangePassWord()
        {
            m_EmployeeExecute = new CEmployeeBUS();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            changePassWord();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPassReplay_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                changePassWord();
        }
        //Ham thay doi mat khau
        private void changePassWord()
        {
            if (CodeDTO.getMD5Hash(txtPassOld.Text).Equals(ucLogin.m_EmployeeObject.matKhau))
            {
                if (txtPassReplay.Text.Equals(txtPassNew.Text))
                {
                    //thục hiện Update mật khẩu
                    ucLogin.m_EmployeeObject.matKhau = CodeDTO.getMD5Hash(txtPassReplay.Text.Trim());
                    //
                    m_EmployeeObject = new CEmployeeDTO(ucLogin.m_EmployeeObject.maNhanVien, ucLogin.m_EmployeeObject.tenNhanVien, ucLogin.m_EmployeeObject.gioiTinh,
                    ucLogin.m_EmployeeObject.ngaySinh, ucLogin.m_EmployeeObject.soDienThoai, ucLogin.m_EmployeeObject.diaChi, ucLogin.m_EmployeeObject.ngayVaoLam, ucLogin.m_EmployeeObject.maChucVu, ucLogin.m_EmployeeObject.tenDangNhap, ucLogin.m_EmployeeObject.matKhau, ucLogin.m_EmployeeObject.email);
                    if (m_EmployeeExecute.UpdateEmployeeToDatabase(m_EmployeeObject))
                    {
                        ucLogin.m_EmployeeObject = m_EmployeeObject;
                        XtraMessageBox.Show("Đổi mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        txtPassNew.Text = txtPassOld.Text = txtPassReplay.Text = "";
                        XtraMessageBox.Show("Đổi mậu khẩu thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    txtPassNew.Text = txtPassReplay.Text = "";
                    XtraMessageBox.Show("Mật khẩu mới và xác nhận không hợp lệ. Vui lòng nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                XtraMessageBox.Show("Sai mật khẩu. Vui lòng nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}