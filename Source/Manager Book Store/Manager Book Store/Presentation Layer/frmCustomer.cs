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
using DevExpress.Utils;
using DevExpress.XtraEditors;
using System.Collections;
using Manager_Book_Store.General;

namespace Manager_Book_Store.Presentation_Layer
{
    public partial class frmCustomer : Form
    {
        #region "Variable"
        private CCustomerDTO m_CustomerObject;
        private CCustomerBUS m_CustomerExecute;
        private DataTable    m_CustomerData;
        private GridCheckMarksSelection m_CustomerMultiSelect;
        #endregion
        public frmCustomer()
        {
            InitializeComponent();
            m_CustomerObject    = new CCustomerDTO();
            m_CustomerExecute   = new CCustomerBUS();
            m_CustomerData      = new DataTable();
            m_CustomerMultiSelect = new GridCheckMarksSelection(grdvListCustomer);
            btnSave.Enabled = false;
            CustomerSno.VisibleIndex = 1;
        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            m_CustomerData = m_CustomerExecute.getCustomerDataFromDatabase();
            grdListCustomer.DataSource = m_CustomerData;
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
                ArrayList _listCustomerId = new ArrayList();
                grdvListCustomer.FocusedRowHandle -= 1;
                foreach (DataRowView _rowData in m_CustomerMultiSelect.Selection)
                {
                    m_CustomerObject = new CCustomerDTO();
                    m_CustomerObject.maKhachHang = _rowData["MaKH"].ToString();
                    if (m_CustomerExecute.DeleteCustomerToDatabase(m_CustomerObject))
                    {
                        _listCustomerId.Add(_rowData["MaKH"]);
                    }
                }
                if (_listCustomerId.Count != 0)
                {
                    String _erroContent = "Không thể xóa các khách hàng có mã: \n";
                    foreach (var item in _listCustomerId)
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
                XtraCustomMessageBox.Show("Xóa dữ liệu thất bại!", "Lỗi", true);
            }
            finally
            {
                updateEnableButtonAndResetValueOfControl(ref btnDelete);
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!checkData())
                return;
            try
            {
                if (m_IsAdd)
                {
                    m_CustomerObject = new CCustomerDTO("KH0000000", txtCustomerName.Text, cmbCustomerGender.Text,
                                                        dateBirthDay.DateTime, txtCustomerAddress.Text,
                                                        txtCustomerPhone.Text, txtCustomerEmail.Text, 0);
                    if (m_CustomerExecute.AddCustomerToDatabase(m_CustomerObject))
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
                    m_CustomerObject = new CCustomerDTO(txtCustomerId.Text, txtCustomerName.Text, cmbCustomerGender.Text,
                                                        dateBirthDay.DateTime, txtCustomerAddress.Text, txtCustomerPhone.Text,
                                                        txtCustomerEmail.Text, (int)spCustomerDebit.Value);
                    if (m_CustomerExecute.UpdateCustomerToDatabase(m_CustomerObject))
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

        private void grdvListCustomer_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (m_IsAdd)
                return;
            try
            {
                if (e.FocusedRowHandle >= 0)
                {
                    txtCustomerId.Text = grdvListCustomer.GetRowCellValue(e.FocusedRowHandle, "MaKH").ToString();
                    txtCustomerName.Text = grdvListCustomer.GetRowCellValue(e.FocusedRowHandle, "TenKH").ToString();
                    txtCustomerAddress.Text = grdvListCustomer.GetRowCellValue(e.FocusedRowHandle, "DiaChi").ToString();
                    dateBirthDay.DateTime = Convert.ToDateTime(grdvListCustomer.GetRowCellValue(e.FocusedRowHandle, "NgaySinh").ToString());
                    txtCustomerEmail.Text = grdvListCustomer.GetRowCellValue(e.FocusedRowHandle, "Email").ToString();
                    cmbCustomerGender.Text = grdvListCustomer.GetRowCellValue(e.FocusedRowHandle, "GioiTinh").ToString();
                    txtCustomerPhone.Text = grdvListCustomer.GetRowCellValue(e.FocusedRowHandle, "SoDienThoai").ToString();
                    spCustomerDebit.EditValue = grdvListCustomer.GetRowCellValue(e.FocusedRowHandle, "TienNo");
                }
            }
            catch (System.Exception) { }
        }

        private void grdvListCustomer_MouseDown(object sender, MouseEventArgs e)
        {

        }
        private bool m_IsAdd = false;
        private void updateEnableButtonAndResetValueOfControl(ref SimpleButton _btnControl)
        {
            switch (_btnControl.Name)
            {
                case "btnAdd":
                    {
                        m_CustomerMultiSelect.ClearSelection();
                        //
                        txtCustomerId.Text = "KH00000**";
                        btnAdd.Visible = false;
                        btnCancel.Visible = true;
                        //
                        btnSave.Enabled = true;
                        btnUpdate.Enabled = false;
                        btnDelete.Enabled = false;
                        //
                        txtCustomerName.Properties.ReadOnly = false;
                        txtCustomerAddress.Properties.ReadOnly = false;
                        dateBirthDay.Properties.ReadOnly = false;
                        txtCustomerEmail.Properties.ReadOnly = false;
                        cmbCustomerGender.Properties.ReadOnly = false;
                        txtCustomerPhone.Properties.ReadOnly = false;
                        //
                        grdvListCustomer.OptionsSelection.EnableAppearanceFocusedRow = false;
                        grdvListCustomer.Columns["CheckMarkSelection"].OptionsColumn.AllowEdit = false;
                        //
                        txtCustomerName.EditValue = null;
                        txtCustomerAddress.EditValue = null;
                        dateBirthDay.EditValue = null;
                        txtCustomerEmail.EditValue = null;
                        cmbCustomerGender.EditValue = null;
                        txtCustomerPhone.EditValue = null;
                        spCustomerDebit.EditValue = 0;
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
                        txtCustomerName.Properties.ReadOnly = true;
                        txtCustomerAddress.Properties.ReadOnly = true;
                        dateBirthDay.Properties.ReadOnly = true;
                        txtCustomerEmail.Properties.ReadOnly = true;
                        cmbCustomerGender.Properties.ReadOnly = true;
                        txtCustomerPhone.Properties.ReadOnly = true;
                        //
                        grdvListCustomer.OptionsSelection.EnableAppearanceFocusedRow = true;
                        grdvListCustomer.Columns["CheckMarkSelection"].OptionsColumn.AllowEdit = true;
                        //
                        m_CustomerData = m_CustomerExecute.getCustomerDataFromDatabase();
                        grdListCustomer.DataSource = m_CustomerData;
                        grdvListCustomer.FocusedRowHandle = -1;
                        grdvListCustomer.FocusedRowHandle = 0;
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
                        txtCustomerName.Properties.ReadOnly = true;
                        txtCustomerAddress.Properties.ReadOnly = true;
                        dateBirthDay.Properties.ReadOnly = true;
                        txtCustomerEmail.Properties.ReadOnly = true;
                        cmbCustomerGender.Properties.ReadOnly = true;
                        txtCustomerPhone.Properties.ReadOnly = true;
                        //
                        grdvListCustomer.OptionsSelection.EnableAppearanceFocusedRow = true;
                        grdvListCustomer.Columns["CheckMarkSelection"].OptionsColumn.AllowEdit = true;
                        //
                        m_CustomerData = m_CustomerExecute.getCustomerDataFromDatabase();
                        grdListCustomer.DataSource = m_CustomerData;
                        grdvListCustomer.FocusedRowHandle = -1;
                        grdvListCustomer.FocusedRowHandle = 0;
                        break;
                    }
                case "btnDelete":
                    {
                        m_CustomerData = m_CustomerExecute.getCustomerDataFromDatabase();
                        grdListCustomer.DataSource = m_CustomerData;
                        grdvListCustomer.FocusedRowHandle = grdvListCustomer.DataRowCount - 1;
                        m_CustomerMultiSelect.ClearSelection();
                        break;
                    }
                case "btnUpdate":
                    {
                        m_IsAdd = false;
                        //
                        m_CustomerMultiSelect.ClearSelection();
                        //
                        btnUpdate.Visible = false;
                        btnCancelOfUpdate.Visible = true;
                        btnAdd.Enabled = false;
                        //
                        btnSave.Enabled = true;
                        btnUpdate.Enabled = false;
                        btnDelete.Enabled = false;
                        //
                        txtCustomerName.Properties.ReadOnly = false;
                        txtCustomerAddress.Properties.ReadOnly = false;
                        dateBirthDay.Properties.ReadOnly = false;
                        txtCustomerEmail.Properties.ReadOnly = false;
                        cmbCustomerGender.Properties.ReadOnly = false;
                        txtCustomerPhone.Properties.ReadOnly = false;
                        //
                        grdvListCustomer.OptionsSelection.EnableAppearanceFocusedRow = false;
                        grdvListCustomer.Columns["CheckMarkSelection"].OptionsColumn.AllowEdit = false;
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
                        txtCustomerName.Properties.ReadOnly = true;
                        txtCustomerAddress.Properties.ReadOnly = true;
                        dateBirthDay.Properties.ReadOnly = true;
                        txtCustomerEmail.Properties.ReadOnly = true;
                        cmbCustomerGender.Properties.ReadOnly = true;
                        txtCustomerPhone.Properties.ReadOnly = true;
                        //
                        grdvListCustomer.OptionsSelection.EnableAppearanceFocusedRow = true;
                        grdvListCustomer.Columns["CheckMarkSelection"].OptionsColumn.AllowEdit = true;
                        //
                        m_CustomerData = m_CustomerExecute.getCustomerDataFromDatabase();
                        grdListCustomer.DataSource = m_CustomerData;
                        grdvListCustomer.FocusedRowHandle = grdvListCustomer.DataRowCount - 1;
                        m_CustomerMultiSelect.ClearSelection();
                        break;
                    }
            }
        }

        private void btnCancelOfUpdate_Click(object sender, EventArgs e)
        {
            updateEnableButtonAndResetValueOfControl(ref btnCancelOfUpdate);
        }

        private bool checkData()
        {
            if (dateBirthDay.DateTime >= DateTime.Now)
                {
                    XtraCustomMessageBox.Show("Ngày sinh không thể lớn hơn ngày hiện tại", "Lỗi", true);
                    dateBirthDay.Focus();
                    return false;
                }
            if( CheckInformationEntered.checkDataInput(txtCustomerName, "Dữ liệu không thể để trống",ref dxErrorProvider) &&
                CheckInformationEntered.checkDataInput(txtCustomerAddress, "Dữ liệu không thể để trống",ref dxErrorProvider) &&
                CheckInformationEntered.checkDataInput(txtCustomerEmail, "Dữ liệu không thể để trống",ref dxErrorProvider) &&
                CheckInformationEntered.checkDataInput(txtCustomerPhone, "Dữ liệu không thể để trống",ref dxErrorProvider) &&
                CheckInformationEntered.checkDataInput(dateBirthDay, "Dữ liệu không thể để trống",ref dxErrorProvider) &&
                CheckInformationEntered.checkDataInput(cmbCustomerGender, "Dữ liệu không thể để trống",ref dxErrorProvider) &&
                CheckInformationEntered.checkDataInput(spCustomerDebit, "Dữ liệu không thể để trống", ref dxErrorProvider))
            {
                return true;
            }
            return false;
        }

        private void txtCustomerNameLA_TextChanged(object sender, EventArgs e)
        {
            m_CustomerData = m_CustomerExecute.lookAtCustomerDataFromDatabase(txtCustomerNameLA.Text);
            grdListCustomer.DataSource = m_CustomerData;
        }

        private void txtCustomerName_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckInformationEntered.checkCharacterInput(e, true);
        }

        private void txtCustomerPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckInformationEntered.checkCharacterInput(e, false);
        }
    }
}
