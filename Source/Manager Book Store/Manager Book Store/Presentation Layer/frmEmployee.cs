using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Manager_Book_Store.Data_Tranfer_Object;
using Manager_Book_Store.Business_Layer;
using DevExpress.XtraGrid.Selection;

namespace Manager_Book_Store.Presentation_Layer
{
    public partial class frmEmployee : Form
    {
        #region "Variable"
        private CChargeDTO m_ChargeObject;
        private DataTable m_ChargeData;
        private CChargeBUS m_ChargeExecute;
        private CEmployeeDTO m_EmployeeObject;
        private CEmployeeBUS m_EmployeeExecute;
        private DataTable m_EmployeeData;
        private GridCheckMarksSelection m_EmployeeMultiSelect;
        #endregion
        public frmEmployee()
        {
            InitializeComponent();
            m_ChargeData                = new DataTable();
            m_ChargeExecute             = new CChargeBUS();
            m_ChargeObject              = new CChargeDTO();
            m_EmployeeData              = new DataTable();
            m_EmployeeExecute           = new CEmployeeBUS();
            m_EmployeeObject            = new CEmployeeDTO();
            m_EmployeeMultiSelect       = new GridCheckMarksSelection(grdvListEmployee);
            EmployeeSno.VisibleIndex    = 1;
        }

        private void frmEmployee_Load(object sender, EventArgs e)
        {
            //
            m_ChargeData = m_ChargeExecute.getChargeDataFromDatabase();
            lkEmployeeCharge.Properties.DataSource = m_ChargeData;
            lkEmployeeCharge.Properties.DisplayMember = "TenCV";
            lkEmployeeCharge.Properties.ValueMember = "MaCV";
            //
            m_EmployeeData = m_EmployeeExecute.getEmployeeDataFromDatabase();
            grdListEmployee.DataSource = m_EmployeeData;
        }

        private void grdvListEmployee_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (e.FocusedRowHandle >= 0)
            {
                txtEmployeeId.Text      = grdvListEmployee.GetRowCellValue(e.FocusedRowHandle, "MaNV").ToString();
                txtEmployeeName.Text    = grdvListEmployee.GetRowCellValue(e.FocusedRowHandle, "TenNV").ToString();
                txtEmployeeAddress.Text = grdvListEmployee.GetRowCellValue(e.FocusedRowHandle, "DiaChi").ToString();
                dateBirthDay.DateTime   = Convert.ToDateTime(grdvListEmployee.GetRowCellValue(e.FocusedRowHandle, "NgaySinh").ToString());
                dateToWork.DateTime     = Convert.ToDateTime(grdvListEmployee.GetRowCellValue(e.FocusedRowHandle, "NgayVaoLam").ToString());
                txtEmployeeEmail.Text   = grdvListEmployee.GetRowCellValue(e.FocusedRowHandle, "Email").ToString();
                cmbEmployeeGender.Text  = grdvListEmployee.GetRowCellValue(e.FocusedRowHandle, "GioiTinh").ToString();
                txtEmployeePhone.Text   = grdvListEmployee.GetRowCellValue(e.FocusedRowHandle, "DienThoai").ToString();
                lkEmployeeCharge.EditValue = grdvListEmployee.GetRowCellValue(e.FocusedRowHandle, "MaCV");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtEmployeeId.Text = "NV00000000";
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
            btnAdd.Visible = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnDelete.Enabled = true;
            btnUpdate.Enabled = true;
            btnCancel.Visible = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            m_EmployeeObject = new CEmployeeDTO(txtEmployeeId.Text, txtEmployeeName.Text, cmbEmployeeGender.Text,
            dateBirthDay.DateTime, txtEmployeePhone.Text, txtEmployeeAddress.Text, dateToWork.DateTime,lkEmployeeCharge.EditValue.ToString(),null,null,txtEmployeeEmail.Text);
            m_EmployeeExecute.UpdateEmployeeToDatabase(m_EmployeeObject);
            m_EmployeeData = m_EmployeeExecute.getEmployeeDataFromDatabase();
            grdListEmployee.DataSource = m_EmployeeData;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            grdvListEmployee.FocusedRowHandle -= 1;
            foreach (DataRowView _rowData in m_EmployeeMultiSelect.Selection)
            {
                m_EmployeeObject = new CEmployeeDTO();
                m_EmployeeObject.maNhanVien = _rowData["MaNV"].ToString();
                m_EmployeeExecute.DeleteEmployeeToDatabase(m_EmployeeObject);
            }
            m_EmployeeData = m_EmployeeExecute.getEmployeeDataFromDatabase();
            grdListEmployee.DataSource = m_EmployeeData;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            m_EmployeeObject = new CEmployeeDTO(txtEmployeeId.Text, txtEmployeeName.Text, cmbEmployeeGender.Text,
            dateBirthDay.DateTime, txtEmployeePhone.Text, txtEmployeeAddress.Text, dateToWork.DateTime, lkEmployeeCharge.EditValue.ToString(), "", "",txtEmployeeEmail.Text);
            m_EmployeeExecute.AddEmployeeToDatabase(m_EmployeeObject);
            m_EmployeeData = m_EmployeeExecute.getEmployeeDataFromDatabase();
            grdListEmployee.DataSource = m_EmployeeData;
            grdvListEmployee.FocusedRowHandle = grdvListEmployee.DataRowCount - 1;
        }
    }
}
