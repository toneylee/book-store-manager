using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Manager_Book_Store.Business_Layer;
using Manager_Book_Store.Data_Tranfer_Object;

namespace Manager_Book_Store.Presentation_Layer
{
    public partial class frmInfoEmployee : DevExpress.XtraEditors.XtraForm
    {
        #region "Valiable"
        private CEmployeeDTO m_EmployeeObject;
        private CEmployeeBUS m_EmployeeExecute;
        private frmChangePassWord frmChangePass;
        private CChargeBUS m_ChargeExecute;
        private CChargeDTO m_ChargeObj;
        private DataTable m_ChargeData;
        #endregion

        public frmInfoEmployee()
        {
            InitializeComponent();
            InitEmployeeObj();
        }

        private void InitDisplay(bool _update)
        {
            if (_update)
            {
                this.txtEmployeeName.Properties.ReadOnly = false;
                this.txtEmployeePhone.Properties.ReadOnly = false;
                this.txtEmployeeEmail.Properties.ReadOnly = false;
                this.txtEmployeeAddress.Properties.ReadOnly = false;
                this.txtUser.Properties.ReadOnly = true;
                this.dateBirthDay.Properties.ReadOnly = false;
                this.dateToWork.Properties.ReadOnly = false;
                this.cmbEmployeeGender.Properties.ReadOnly = false;
            }
            else
            {
                this.txtEmployeeName.Properties.ReadOnly = true;
                this.txtEmployeePhone.Properties.ReadOnly = true;
                this.txtEmployeeEmail.Properties.ReadOnly = true;
                this.txtEmployeeAddress.Properties.ReadOnly = true;
                this.txtUser.Properties.ReadOnly = true;
                this.dateBirthDay.Properties.ReadOnly = true;
                this.dateToWork.Properties.ReadOnly = true;
                this.cmbEmployeeGender.Properties.ReadOnly = true;
            }
        }

        private void InitEmployeeObj()
        {
            m_EmployeeExecute = new CEmployeeBUS();
            m_ChargeData = new DataTable();
            m_ChargeExecute = new CChargeBUS();
            m_ChargeObj = new CChargeDTO();
            m_ChargeObj.maChucVu = ucLogin.m_EmployeeObject.maChucVu;
            m_ChargeObj.tenChucVu = m_ChargeExecute.getChargeWithMaCV(m_ChargeObj);
        }

        private void InitfrmInfoEmployee()
        {
            this.txtEmployeeId.Text = ucLogin.m_EmployeeObject.maNhanVien;
            this.txtEmployeeName.Text = ucLogin.m_EmployeeObject.tenNhanVien;
            this.txtEmployeePhone.Text = ucLogin.m_EmployeeObject.soDienThoai;
            this.txtEmployeeEmail.Text = ucLogin.m_EmployeeObject.email;
            this.txtEmployeeAddress.Text = ucLogin.m_EmployeeObject.diaChi;
            this.txtUser.Text = ucLogin.m_EmployeeObject.tenDangNhap;
            this.txtPass.Text = ucLogin.m_EmployeeObject.matKhau;
            this.dateBirthDay.Text = ucLogin.m_EmployeeObject.ngaySinh.ToShortDateString();
            this.dateToWork.Text = ucLogin.m_EmployeeObject.ngayVaoLam.ToShortDateString();
            this.cmbEmployeeGender.Text = ucLogin.m_EmployeeObject.gioiTinh;
            this.txtEmployeeCharge.Text = m_ChargeObj.tenChucVu;
        }

        private void frmInfoEmployee_Load(object sender, EventArgs e)
        {
            InitfrmInfoEmployee();
            InitDisplay(false);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChangePassWord_Click(object sender, EventArgs e)
        {
            frmChangePass = new frmChangePassWord();
            frmChangePass.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            InitDisplay(true);
            sbtnDetroyUpdate.Visible = true;
            sbtnSave.Visible = true;
            btnUpdate.Visible = false;
            btnCancel.Visible = false;
        }

        private void sbtnDetroyUpdate_Click(object sender, EventArgs e)
        {
            InitDisplay(false);
            sbtnDetroyUpdate.Visible = false;
            sbtnSave.Visible = false;
            btnUpdate.Visible = true;
            btnCancel.Visible = true;
        }

        private void sbtnSave_Click(object sender, EventArgs e)
        {
            m_EmployeeObject = new CEmployeeDTO(ucLogin.m_EmployeeObject.maNhanVien, this.txtEmployeeName.Text, cmbEmployeeGender.Text,
                  Convert.ToDateTime(dateBirthDay.Text), this.txtEmployeePhone.Text, this.txtEmployeeAddress.Text,
                  Convert.ToDateTime(this.dateToWork.Text), ucLogin.m_EmployeeObject.maChucVu, txtUser.Text,
                  this.txtEmployeeEmail.Text);
            if (m_EmployeeExecute.UpdateEmployeeToDatabaseNotPassWord(m_EmployeeObject))
            {
                m_EmployeeObject.matKhau = ucLogin.m_EmployeeObject.matKhau;
                ucLogin.m_EmployeeObject = m_EmployeeObject;
                InitDisplay(false);
                XtraMessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                XtraMessageBox.Show("Cập nhật thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //
            sbtnDetroyUpdate.Visible = false;
            sbtnSave.Visible = false;
            btnUpdate.Visible = true;
            btnCancel.Visible = true;
        }
    }
}