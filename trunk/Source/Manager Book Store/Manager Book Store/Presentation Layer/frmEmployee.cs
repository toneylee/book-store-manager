using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Manager_Book_Store.Data_Tranfer_Object;
using Manager_Book_Store.Business_Layer;
using DevExpress.XtraGrid.Selection;
using DevExpress.XtraEditors;
using DevExpress.XtraBars;
using System.Collections;
using Manager_Book_Store.General;

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
            updateEnableButtonAndResetValueOfControl(ref btnAdd);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            updateEnableButtonAndResetValueOfControl(ref btnCancel);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            updateEnableButtonAndResetValueOfControl(ref btnUpdate);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                ArrayList _listEmployeeId = new ArrayList();
                grdvListEmployee.FocusedRowHandle -= 1;
                foreach (DataRowView _rowData in m_EmployeeMultiSelect.Selection)
                {
                    m_EmployeeObject = new CEmployeeDTO();
                    m_EmployeeObject.maNhanVien = _rowData["MaNV"].ToString();
                    if (m_EmployeeExecute.DeleteEmployeeToDatabase(m_EmployeeObject))
                    {
                        _listEmployeeId.Add(_rowData["MaNV"]);
                    }
                }
                if (_listEmployeeId.Count != 0)
                {
                    String _erroContent = "Không thể xóa các nhân viên có mã: \n";
                    foreach (var item in _listEmployeeId)
                    {
                        _erroContent += item.ToString() + "\n";
                    }
                    XtraCustomMessageBox.Show(_erroContent, "Lỗi", true);
                }
                else
                {
                    XtraCustomMessageBox.Show("Xóa dữ liệu thành công!", "Thông báo", true);
                }
            }
            catch (System.Exception)
            {
                XtraCustomMessageBox.Show("Xóa dữ liệu thất bại", "Lỗi", true);	
            }
            finally
            {
                updateEnableButtonAndResetValueOfControl(ref btnDelete);
            }

        }
        //Ham chuyen từ chuỗi có dấu sang không dấu
        public static string convertToUnSign3(string s)
        {
            Regex regex = new Regex("\\p{IsCombiningDiacriticalMarks}+");
            string temp = s.Normalize(NormalizationForm.FormD);
            return regex.Replace(temp, String.Empty).Replace('\u0111', 'd').Replace('\u0110', 'D');
        }
        //Ham tao ten dang nhap
        private string createUserName(string str, string ngayS)
        {
            str = convertToUnSign3(str).Trim();
            str = str.Substring(str.LastIndexOf(" ") + 1);
            //lay so id cua nhan vien
            int lenght = ngayS.LastIndexOf("/");
            string temp = ngayS.Substring(lenght + 3, 2);
            return (str + temp).ToLower();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!checkData())
                return;
            try
            {
                if (m_IsAdd)
                {
                    String _user = createUserName(txtEmployeeName.Text, dateBirthDay.DateTime.ToString());
                    String _pass = CodeDTO.getMD5Hash("123456789");
                    m_EmployeeObject = new CEmployeeDTO(txtEmployeeId.Text, txtEmployeeName.Text, cmbEmployeeGender.Text,
                    dateBirthDay.DateTime, txtEmployeePhone.Text, txtEmployeeAddress.Text, dateToWork.DateTime, 
                    lkEmployeeCharge.EditValue.ToString(),_user, _pass, txtEmployeeEmail.Text);
                    if (m_EmployeeExecute.AddEmployeeToDatabase(m_EmployeeObject))
                    {
                        XtraCustomMessageBox.Show("Thêm dữ liệu thành công!", "Thông báo", true);
                    }
                    else
                    {
                        XtraCustomMessageBox.Show("Thêm dữ liệu thất bại!", "Lỗi", true);
                    }
                }
                else
                {
                    m_EmployeeObject = new CEmployeeDTO(txtEmployeeId.Text, txtEmployeeName.Text, cmbEmployeeGender.Text,
                                        dateBirthDay.DateTime, txtEmployeePhone.Text, txtEmployeeAddress.Text,
                                        dateToWork.DateTime, lkEmployeeCharge.EditValue.ToString(), txtEmployeeName.Text, null, txtEmployeeEmail.Text);
                    if (m_EmployeeExecute.UpdateEmployeeToDatabaseNotPassWord(m_EmployeeObject))
                    {
                        XtraCustomMessageBox.Show("Cập nhật dữ liệu thành công!", "Thông báo", true);
                    }
                    else
                    {
                        XtraCustomMessageBox.Show("Cập nhật dữ liệu thất bại!", "Lỗi", true);
                    }
                }
            }
            catch (System.Exception)
            {
                XtraCustomMessageBox.Show("Lưu dữ liệu thất bại!", "Lỗi", true);
            }
            finally
            {
                updateEnableButtonAndResetValueOfControl(ref btnSave);
            }


        }
        private bool m_IsAdd = false;
        private void updateEnableButtonAndResetValueOfControl(ref SimpleButton _btnControl)
        {
            switch (_btnControl.Name)
            {
                case "btnAdd":
                    {
                        m_EmployeeMultiSelect.ClearSelection();
                        //
                        txtEmployeeId.Text = "NV00000**";
                        btnAdd.Visible = false;
                        btnCancel.Visible = true;
                        //
                        btnSave.Enabled = true;
                        btnUpdate.Enabled = false;
                        btnDelete.Enabled = false;
                        //
                        txtEmployeeName.Properties.ReadOnly = false;
                        txtEmployeeAddress.Properties.ReadOnly = false;
                        dateBirthDay.Properties.ReadOnly = false;
                        txtEmployeeEmail.Properties.ReadOnly = false;
                        cmbEmployeeGender.Properties.ReadOnly = false;
                        txtEmployeePhone.Properties.ReadOnly = false;
                        dateToWork.Properties.ReadOnly = false;
                        lkEmployeeCharge.Properties.ReadOnly = false;
                        //
                        grdvListEmployee.OptionsSelection.EnableAppearanceFocusedRow = false;
                        grdvListEmployee.Columns["CheckMarkSelection"].OptionsColumn.AllowEdit = false;
                        //
                        txtEmployeeName.EditValue = null;
                        txtEmployeeAddress.EditValue = null;
                        dateBirthDay.EditValue = null;
                        txtEmployeeEmail.EditValue = null;
                        cmbEmployeeGender.EditValue = null;
                        txtEmployeePhone.EditValue = null;
                        //
                        m_IsAdd = true;
                        break;
                    }
                case "btnCancel":
                    {
                        m_IsAdd = false;
                        //
                        btnAdd.Visible = true;
                        btnCancel.Visible = false;
                        btnCancelOfUpdate.Visible = false;
                        btnUpdate.Visible = true;
                        //
                        btnUpdate.Enabled = true;
                        btnDelete.Enabled = true;
                        btnAdd.Enabled = true;
                        btnSave.Enabled = false;
                        //
                        txtEmployeeName.Properties.ReadOnly = true;
                        txtEmployeeAddress.Properties.ReadOnly = true;
                        dateBirthDay.Properties.ReadOnly = true;
                        txtEmployeeEmail.Properties.ReadOnly = true;
                        cmbEmployeeGender.Properties.ReadOnly = true;
                        txtEmployeePhone.Properties.ReadOnly = true;
                        dateToWork.Properties.ReadOnly = true;
                        lkEmployeeCharge.Properties.ReadOnly = true;
                        //
                        grdvListEmployee.OptionsSelection.EnableAppearanceFocusedRow = true;
                        grdvListEmployee.Columns["CheckMarkSelection"].OptionsColumn.AllowEdit = true;
                        //
                        m_EmployeeData = m_EmployeeExecute.getEmployeeDataFromDatabase();
                        grdListEmployee.DataSource = m_EmployeeData;
                        grdvListEmployee.FocusedRowHandle = -1;
                        grdvListEmployee.FocusedRowHandle = 0;
                        break;
                    }
                case "btnCancelOfUpdate":
                    {
                        //
                        btnAdd.Visible = true;
                        btnCancel.Visible = false;
                        btnCancelOfUpdate.Visible = false;
                        btnUpdate.Visible = true;
                        //
                        btnUpdate.Enabled = true;
                        btnDelete.Enabled = true;
                        btnAdd.Enabled = true;
                        btnSave.Enabled = false;
                        //
                        txtEmployeeName.Properties.ReadOnly = true;
                        txtEmployeeAddress.Properties.ReadOnly = true;
                        dateBirthDay.Properties.ReadOnly = true;
                        txtEmployeeEmail.Properties.ReadOnly = true;
                        cmbEmployeeGender.Properties.ReadOnly = true;
                        txtEmployeePhone.Properties.ReadOnly = true;
                        dateToWork.Properties.ReadOnly = true;
                        lkEmployeeCharge.Properties.ReadOnly = true;
                        //
                        grdvListEmployee.OptionsSelection.EnableAppearanceFocusedRow = true;
                        grdvListEmployee.Columns["CheckMarkSelection"].OptionsColumn.AllowEdit = true;
                        //
                        m_EmployeeData = m_EmployeeExecute.getEmployeeDataFromDatabase();
                        grdListEmployee.DataSource = m_EmployeeData;
                        grdvListEmployee.FocusedRowHandle = -1;
                        grdvListEmployee.FocusedRowHandle = 0;
                        break;
                    }
                case "btnDelete":
                    {
                        m_EmployeeData = m_EmployeeExecute.getEmployeeDataFromDatabase();
                        grdListEmployee.DataSource = m_EmployeeData;
                        grdvListEmployee.FocusedRowHandle = grdvListEmployee.DataRowCount - 1;
                        m_EmployeeMultiSelect.ClearSelection();
                        break;
                    }
                case "btnUpdate":
                    {
                        m_IsAdd = false;
                        //
                        m_EmployeeMultiSelect.ClearSelection();
                        //
                        btnUpdate.Visible = false;
                        btnCancelOfUpdate.Visible = true;
                        btnAdd.Enabled = false;
                        //
                        btnSave.Enabled = true;
                        btnUpdate.Enabled = false;
                        btnDelete.Enabled = false;
                        //
                        txtEmployeeName.Properties.ReadOnly = false;
                        txtEmployeeAddress.Properties.ReadOnly = false;
                        dateBirthDay.Properties.ReadOnly = false;
                        txtEmployeeEmail.Properties.ReadOnly = false;
                        cmbEmployeeGender.Properties.ReadOnly = false;
                        txtEmployeePhone.Properties.ReadOnly = false;
                        dateToWork.Properties.ReadOnly = false;
                        lkEmployeeCharge.Properties.ReadOnly = false;
                        //
                        grdvListEmployee.OptionsSelection.EnableAppearanceFocusedRow = false;
                        grdvListEmployee.Columns["CheckMarkSelection"].OptionsColumn.AllowEdit = false;
                        //
                        break;
                    }
                case "btnSave":
                    {
                        m_IsAdd = false;
                        btnUpdate.Visible = true;
                        btnAdd.Enabled = true;
                        btnDelete.Enabled = true;
                        btnUpdate.Enabled = true;
                        btnUpdate.Visible = true;
                        btnSave.Enabled = false;
                        //
                        btnAdd.Visible = true;
                        btnCancel.Visible = false;
                        btnCancelOfUpdate.Visible = false;
                        //
                        txtEmployeeName.Properties.ReadOnly = true;
                        txtEmployeeAddress.Properties.ReadOnly = true;
                        dateBirthDay.Properties.ReadOnly = true;
                        dateToWork.Properties.ReadOnly = true;
                        lkEmployeeCharge.Properties.ReadOnly = true;
                        txtEmployeeEmail.Properties.ReadOnly = true;
                        cmbEmployeeGender.Properties.ReadOnly = true;
                        txtEmployeePhone.Properties.ReadOnly = true;
                        //
                        grdvListEmployee.OptionsSelection.EnableAppearanceFocusedRow = true;
                        grdvListEmployee.Columns["CheckMarkSelection"].OptionsColumn.AllowEdit = true;
                        //
                        m_EmployeeData = m_EmployeeExecute.getEmployeeDataFromDatabase();
                        grdListEmployee.DataSource = m_EmployeeData;
                        grdvListEmployee.FocusedRowHandle = grdvListEmployee.DataRowCount - 1;
                        m_EmployeeMultiSelect.ClearSelection();
                        break;
                    }
            }
        }

        private void btnCancelOfUpdate_Click(object sender, EventArgs e)
        {
            updateEnableButtonAndResetValueOfControl(ref btnCancelOfUpdate);
        }

        public delegate void setFormObject(object sender, ItemClickEventArgs e);
        public setFormObject _setFormObject; 

        private void btnAddCharge_Click(object sender, EventArgs e)
        {
            _setFormObject(null, null);
        }

        private bool checkData()
        {
            if (dateBirthDay.DateTime < DateTime.Now && dateToWork.DateTime <= DateTime.Now)
            {
                //if (!m_EmployeeExecute.checkAge(dateBirthDay.DateTime, dateToWork.DateTime))
                //{
                //    dateBirthDay.Focus();
                //    dateToWork.EditValue = null;
                //    dateBirthDay.EditValue = null;
                //    XtraCustomMessageBox.Show("Độ tuổi không phù hợp với quy định!\nXin vui lòng kiểm tra lại!", "Lỗi", true);
                //    return false;
                //}

            }
            else
            {
                XtraCustomMessageBox.Show("Ngày sinh hoặc ngày vào làm không thể lớn hơn ngày hiện tại", "Lỗi", true);
                return false;
            }
            if (CheckInformationEntered.checkDataInput(txtEmployeeName, "Dữ liệu không thể để trống", ref dxErrorProvider) &&
                CheckInformationEntered.checkDataInput(txtEmployeeAddress, "Dữ liệu không thể để trống", ref dxErrorProvider) &&
                CheckInformationEntered.checkDataInput(txtEmployeeEmail, "Dữ liệu không thể để trống", ref dxErrorProvider) &&
                CheckInformationEntered.checkDataInput(txtEmployeePhone, "Dữ liệu không thể để trống", ref dxErrorProvider) &&
                CheckInformationEntered.checkDataInput(dateBirthDay, "Dữ liệu không thể để trống", ref dxErrorProvider) &&
                CheckInformationEntered.checkDataInput(cmbEmployeeGender, "Dữ liệu không thể để trống", ref dxErrorProvider) &&
                CheckInformationEntered.checkDataInput(dateToWork, "Dữ liệu không thể để trống", ref dxErrorProvider) &&
                CheckInformationEntered.checkDataInput(lkEmployeeCharge, "Dữ liệu không thể để trống", ref dxErrorProvider))
            {
                return true;
            }
            return false;
        }

        private void txtEmployeeNameLA_TextChanged(object sender, EventArgs e)
        {
            m_EmployeeData = m_EmployeeExecute.lookAtEmployeeDataFromDatabase(txtEmployeeNameLA.Text);
            grdListEmployee.DataSource = m_EmployeeData;
        }

        private void lkEmployeeCharge_QueryPopUp(object sender, CancelEventArgs e)
        {
            m_ChargeData = m_ChargeExecute.getChargeDataFromDatabase();
            lkEmployeeCharge.Properties.DataSource = m_ChargeData;
        }

        private void txtEmployeeNameLA_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckInformationEntered.checkCharacterInput(e, 0);
        }

        private void frmEmployee_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (btnSave.Enabled)
            {
                if (XtraCustomMessageBox.Show("Dữ liệu chưa được lưu!\nBạn có thực sự muốn thoát hay không?", "Thông báo", false) == DialogResult.No)
                {
                    e.Cancel = true;
                    return;
                }
            }
        }

        private void txtEmployeePhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckInformationEntered.checkCharacterInput(e, 1);
        }

        private void dateBirthDay_Validated(object sender, EventArgs e)
        {
            if (dateBirthDay.DateTime > DateTime.Now)
            {
                dateBirthDay.Focus();
                dxErrorProvider.SetError(dateBirthDay, "Ngày sinh không thể lớn hơn ngày hiện tại!");
            }
            else if (dateBirthDay.DateTime.AddYears(m_EmployeeExecute.getAgeToRegulation(false)) > DateTime.Now)
                {
                    dateBirthDay.Focus();
                    dxErrorProvider.SetError(dateBirthDay, "Độ tuổi không đúng với quy định!");
                    //dateBirthDay.EditValue = null;
                }
            else
                dxErrorProvider.ClearErrors();
        }

        private void dateToWork_Validated(object sender, EventArgs e)
        {
            if (dateToWork.DateTime > DateTime.Now)
            {
                dateToWork.Focus();
                dxErrorProvider.SetError(dateToWork, "Ngày vào làm không thể lớn hơn ngày hiện tại!");
                return;
            }
            else
            {
                if (dateBirthDay.DateTime.AddYears(m_EmployeeExecute.getAgeToRegulation(false)) > DateTime.Now)
                {
                    dateBirthDay.Focus();
                    dxErrorProvider.SetError(dateBirthDay, "Độ tuổi không đúng với quy định!");
                    return;
                }
            }
            if (!String.IsNullOrEmpty(dateBirthDay.Text))
            {
                if (!m_EmployeeExecute.checkAge(dateBirthDay.DateTime, dateToWork.DateTime))
                {
                    dateBirthDay.Focus();
                    dateToWork.EditValue = null;
                    dateToWork.Focus();
                    dxErrorProvider.SetError(dateToWork, "Độ tuổi không đúng với quy định!");
                }
                else
                    dxErrorProvider.ClearErrors();
            }
        }
    }
}
