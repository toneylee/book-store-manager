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
using DevExpress.XtraEditors;
using Manager_Book_Store.General;
using System.Collections;

namespace Manager_Book_Store.Presentation_Layer
{
    public partial class frmCharge : Form
    {
        #region "variable"
        private CChargeDTO m_Charge;
        private DataTable m_ChargeData;
        private CChargeBUS m_ChargeBus;
        private GridCheckMarksSelection m_ChargeMultiSelectItem;
        #endregion
        public frmCharge()
        {
            InitializeComponent();
            m_Charge = new CChargeDTO();
            m_ChargeBus = new CChargeBUS();
            m_ChargeData = new DataTable();
            m_ChargeMultiSelectItem = new GridCheckMarksSelection(grdvListCharge);
        }
        private void frmForm_Load(object sender, EventArgs e)
        {
            ChargeSNo.VisibleIndex = 1;
            m_ChargeData = m_ChargeBus.getChargeDataFromDatabase();
            grdListCharge.DataSource = m_ChargeData;
            grdvListCharge.FocusedRowHandle = 0;
            btnSave.Enabled = false;
        }
        //Lấy thông tin chi tiết của thê loại.
        private void grdvListCharge_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                if (!m_IsAdd)
                {
                    if (e.FocusedRowHandle >= 0)
                    {
                        txtChargeName.Text = grdvListCharge.GetRowCellValue(e.FocusedRowHandle, grdvListCharge.Columns["TenCV"]).ToString();
                        txtChargeId.Text = grdvListCharge.GetRowCellValue(e.FocusedRowHandle, grdvListCharge.Columns["MaCV"]).ToString();
                    }
                }
            }
            catch (System.Exception)
            {
            	
            }

        }
        //Thêm mới một thể loại vào cơ sở dữ liệu
        private void btnAdd_Click(object sender, EventArgs e)
        {
            updateEnableButtonAndResetValueOfControl(ref btnAdd);
        }
        //Cập nhật lại thông tin chi tiết thể loại
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            updateEnableButtonAndResetValueOfControl(ref btnUpdate);
        }
        //Xóa thông tin của thể loại
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                ArrayList _litsAuthorID = new ArrayList();
                foreach (object _rowObjectItem in m_ChargeMultiSelectItem.Selection)
                {
                    grdvListCharge.FocusedRowHandle -= 1;
                    DataRowView _rowObjectDetail = _rowObjectItem as DataRowView;
                    m_Charge = new CChargeDTO(_rowObjectDetail.Row["MaCV"].ToString(), _rowObjectDetail.Row["TenCV"].ToString());
                    if (!m_ChargeBus.DeleteChargeToDatabase(m_Charge))
                    {
                        _litsAuthorID.Add(_rowObjectDetail.Row["MaCV"]);
                    }
                }
                if (_litsAuthorID.Count != 0)
                {
                    String _erroContent = "Không thể xóa các thể loại có mã: \n";
                    foreach (var item in _litsAuthorID)
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
            if (!CheckInformationEntered.checkDataInput(txtChargeName, "Không thể để trống dữ liệu!", ref dxErrorProvider))
                return;
            try
            {
                if (m_IsAdd)
                {
                    m_Charge = new CChargeDTO("CV0000000", txtChargeName.Text);
                    if (m_ChargeBus.AddChargeToDatabase(m_Charge))
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
                    m_Charge = new CChargeDTO(txtChargeId.Text, txtChargeName.Text);
                    m_Charge.maChucVu = txtChargeId.Text;
                    if (m_ChargeBus.UpdateChargeToDatabase(m_Charge))
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
                XtraCustomMessageBox.Show("Lưu thất bại", "Lỗi", true);
            }
            finally
            {
                updateEnableButtonAndResetValueOfControl(ref btnSave);
            }
        }

        private void txtChargeNameLA_TextChanged(object sender, EventArgs e)
        {
            m_ChargeData = m_ChargeBus.lookAtChargeDataFromDatabase(txtChargeNameLA.Text);
            grdListCharge.DataSource = m_ChargeData;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            updateEnableButtonAndResetValueOfControl(ref btnCancel);
        }

        private void txtChargeName_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckInformationEntered.checkCharacterInput(e, 0);
        }
        private bool m_IsAdd = false;
        private void updateEnableButtonAndResetValueOfControl(ref SimpleButton _btnControl)
        {
            switch (_btnControl.Name)
            {
                case "btnAdd":
                    {
                        m_ChargeMultiSelectItem.ClearSelection();
                        //
                        btnAdd.Visible = false;
                        btnCancel.Visible = true;
                        //
                        btnSave.Enabled = true;
                        btnUpdate.Enabled = false;
                        btnDelete.Enabled = false;
                        //
                        txtChargeId.Text = "CV00000**";
                        txtChargeName.Text = null;
                        txtChargeName.Properties.ReadOnly = false;
                        grdvListCharge.OptionsSelection.EnableAppearanceFocusedRow = false;
                        grdvListCharge.Columns["CheckMarkSelection"].OptionsColumn.AllowEdit = false;
                        //
                        m_IsAdd = true;
                        break;
                    }
                case "btnCancel":
                    {
                        //
                        m_IsAdd = false;
                        dxErrorProvider.ClearErrors();
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
                        txtChargeName.Properties.ReadOnly = true;
                        //
                        grdvListCharge.OptionsSelection.EnableAppearanceFocusedRow = true;
                        grdvListCharge.Columns["CheckMarkSelection"].OptionsColumn.AllowEdit = true;
                        //
                        m_ChargeData = m_ChargeBus.getChargeDataFromDatabase();
                        grdListCharge.DataSource = m_ChargeData;
                        grdvListCharge.FocusedRowHandle = -1;
                        grdvListCharge.FocusedRowHandle = 0;
                        //
                        break;
                    }
                case "btnCancelOfUpdate":
                    {
                        //
                        dxErrorProvider.ClearErrors();
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
                        txtChargeName.Properties.ReadOnly = true;
                        //
                        grdvListCharge.OptionsSelection.EnableAppearanceFocusedRow = true;
                        grdvListCharge.Columns["CheckMarkSelection"].OptionsColumn.AllowEdit = true;
                        //
                        m_ChargeData = m_ChargeBus.getChargeDataFromDatabase();
                        grdvListCharge.FocusedRowHandle = -1;
                        grdvListCharge.FocusedRowHandle = 0;
                        break;
                    }
                case "btnDelete":
                    {
                        txtChargeName.Properties.ReadOnly = true;
                        //
                        m_ChargeData = m_ChargeBus.getChargeDataFromDatabase();
                        grdListCharge.DataSource = m_ChargeData;
                        grdvListCharge.FocusedRowHandle = -1;
                        grdvListCharge.FocusedRowHandle = 0;
                        //
                        m_ChargeMultiSelectItem.ClearSelection();
                        break;
                    }
                case "btnUpdate":
                    {
                        m_ChargeMultiSelectItem.ClearSelection();
                        //
                        m_IsAdd = false;
                        //
                        btnUpdate.Visible = false;
                        btnCancelOfUpdate.Visible = true;
                        //
                        txtChargeName.Properties.ReadOnly = false;
                        //
                        grdvListCharge.OptionsSelection.EnableAppearanceFocusedRow = true;
                        grdvListCharge.Columns["CheckMarkSelection"].OptionsColumn.AllowEdit = false;
                        //
                        btnDelete.Enabled = false;
                        btnAdd.Enabled = false;
                        btnSave.Enabled = true;
                        break;
                    }
                case "btnSave":
                    {
                        //
                        m_IsAdd = false;
                        dxErrorProvider.ClearErrors();
                        //
                        btnUpdate.Visible = true;
                        btnAdd.Enabled = true;
                        btnSave.Enabled = false;
                        btnDelete.Enabled = true;
                        btnUpdate.Enabled = true;
                        btnUpdate.Visible = true;
                        //
                        btnAdd.Visible = true;
                        btnCancel.Visible = false;
                        btnCancelOfUpdate.Visible = false;
                        //
                        txtChargeName.Properties.ReadOnly = false;
                        //
                        grdvListCharge.OptionsSelection.EnableAppearanceFocusedRow = true;
                        grdvListCharge.Columns["CheckMarkSelection"].OptionsColumn.AllowEdit = true;
                        //
                        m_ChargeData = m_ChargeBus.getChargeDataFromDatabase();
                        grdListCharge.DataSource = m_ChargeData;
                        grdvListCharge.FocusedRowHandle = grdvListCharge.DataRowCount - 1;
                        break;
                    }
            }
        }

        private void btnCancelOfUpdate_Click(object sender, EventArgs e)
        {
            updateEnableButtonAndResetValueOfControl(ref btnCancelOfUpdate);
        }

        private void frmCharge_FormClosing(object sender, FormClosingEventArgs e)
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
    }
}
