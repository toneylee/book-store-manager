using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid.Selection;
using Manager_Book_Store.Business_Layer;
using Manager_Book_Store.Data_Tranfer_Object;
using DevExpress.XtraEditors;
using System.Collections;
using Manager_Book_Store.General;

namespace Manager_Book_Store.Presentation_Layer
{
    public partial class frmPublisher : Form
    {
        #region "variable"
        private GridCheckMarksSelection m_PublisherMulitSelect;
        private CPublisherBUS m_PublisherExecute;
        private DataTable m_PublisherData;
        private CPublisherDTO m_PublisherObject;
        #endregion
        public frmPublisher()
        {
            InitializeComponent();
            m_PublisherMulitSelect = new GridCheckMarksSelection(grdvListPublisher);
            m_PublisherExecute = new CPublisherBUS();
            m_PublisherData = new DataTable();
            PublisherSno.VisibleIndex = 1;
        }

        private void frmPublisher_Load(object sender, EventArgs e)
        {
            m_PublisherData = m_PublisherExecute.getPublisherDataFromDatabase();
            grdListPublisher.DataSource = m_PublisherData;
        }

        private void grdvListPublisher_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (m_IsAdd)
                return;
            try
            {
                if (e.FocusedRowHandle >= 0)
                {
                    txtPublisherId.Text = grdvListPublisher.GetRowCellValue(e.FocusedRowHandle, grdvListPublisher.Columns["MaNXB"]).ToString();
                    txtPublisherName.Text = grdvListPublisher.GetRowCellValue(e.FocusedRowHandle, grdvListPublisher.Columns["TenNXB"]).ToString();
                    txtPublisherAddress.Text = grdvListPublisher.GetRowCellValue(e.FocusedRowHandle, grdvListPublisher.Columns["DiaChi"]).ToString();
                }
            }
            catch (System.Exception)
            {
            	
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            updateEnableButtonAndResetValueOfControl(ref btnAdd);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            updateEnableButtonAndResetValueOfControl(ref btnUpdate);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                ArrayList _listPublisherId = new ArrayList();
                foreach (object _rowObjectItem in m_PublisherMulitSelect.Selection)
                {
                    grdvListPublisher.FocusedRowHandle -= 1;
                    DataRowView _rowObjectDetail = _rowObjectItem as DataRowView;
                    m_PublisherObject = new CPublisherDTO(_rowObjectDetail.Row["MaNXB"].ToString(), _rowObjectDetail.Row["TenNXB"].ToString(), _rowObjectDetail.Row["DiaChi"].ToString());
                    if (!m_PublisherExecute.DeletePublisherToDatabase(m_PublisherObject))
                    {
                        _listPublisherId.Add(_rowObjectDetail.Row["MaNXB"]);
                    }
                }
                if (_listPublisherId.Count != 0)
                {
                    String _erroContent = "Không thể xóa các nhà xuất bản có mã: \n";
                    foreach (var item in _listPublisherId)
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
            {
                return;
            }
            try
            {
                if (m_IsAdd)
                {
                    m_PublisherObject = new CPublisherDTO(txtPublisherId.Text, txtPublisherName.Text, txtPublisherAddress.Text);
                    if (m_PublisherExecute.AddPublisherToDatabase(m_PublisherObject))
                    {
                        XtraCustomMessageBox.Show("Thêm dữ liệu thành công !", "Thông báo", true);
                    }
                    else
                    {
                        XtraCustomMessageBox.Show("Thêm dữ liệu thất bại !", "Lỗi", true);
                    }
                }
                else
                {
                    m_PublisherObject = new CPublisherDTO(txtPublisherId.Text, txtPublisherName.Text, txtPublisherAddress.Text); 
                    if (m_PublisherExecute.UpdatePublisherToDatabase(m_PublisherObject))
                    {
                        XtraCustomMessageBox.Show("Cập nhật dữ liệu thành công !", "Thông báo", true);
                    }
                    else
                    {
                        XtraCustomMessageBox.Show("Cập nhật dữ liệu thất bại !", "Lỗi", true);
                    }
                }
            }
            catch (System.Exception)
            {
                XtraCustomMessageBox.Show("Lưu dữ liệu thất bại!", "Lỗi",true);
            }
            finally
            {
                updateEnableButtonAndResetValueOfControl(ref btnSave);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            updateEnableButtonAndResetValueOfControl(ref btnCancel);
        }

        private void txtPublisherNameLA_TextChanged(object sender, EventArgs e)
        {
            m_PublisherData = m_PublisherExecute.lookAtPublisherDataFromDatabase(txtPublisherNameLA.Text);
            grdListPublisher.DataSource = m_PublisherData;

        }

        private bool m_IsAdd = false;

        private void updateEnableButtonAndResetValueOfControl(ref SimpleButton _btnControl)
        {
            switch (_btnControl.Name)
            {
                case "btnAdd":
                    {
                        m_PublisherMulitSelect.ClearSelection();
                        //
                        btnAdd.Visible = false;
                        btnCancel.Visible = true;
                        //
                        btnSave.Enabled = true;
                        btnUpdate.Enabled = false;
                        btnDelete.Enabled = false;
                        //
                        txtPublisherId.Text = "NXB0000**";
                        txtPublisherName.Text = null;
                        txtPublisherAddress.Text = null;
                        txtPublisherAddress.Properties.ReadOnly = false;
                        txtPublisherName.Properties.ReadOnly = false;
                        //
                        grdvListPublisher.OptionsSelection.EnableAppearanceFocusedRow = false;
                        grdvListPublisher.Columns["CheckMarkSelection"].OptionsColumn.AllowEdit = false;
                        //
                        m_IsAdd = true;
                        break;
                    }
                case "btnCancel":
                    {
                        //
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
                        txtPublisherName.Properties.ReadOnly = true;
                        txtPublisherAddress.Properties.ReadOnly = true;
                        //
                        grdvListPublisher.OptionsSelection.EnableAppearanceFocusedRow = true;
                        grdvListPublisher.Columns["CheckMarkSelection"].OptionsColumn.AllowEdit = true;
                        //
                        m_PublisherData = m_PublisherExecute.getPublisherDataFromDatabase();
                        grdListPublisher.DataSource = m_PublisherData;
                        grdvListPublisher.FocusedRowHandle = -1;
                        grdvListPublisher.FocusedRowHandle = 0;
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
                        txtPublisherName.Properties.ReadOnly = true;
                        txtPublisherAddress.Properties.ReadOnly = true;
                        //
                        grdvListPublisher.OptionsSelection.EnableAppearanceFocusedRow = true;
                        grdvListPublisher.Columns["CheckMarkSelection"].OptionsColumn.AllowEdit = true;
                        //
                        m_PublisherData = m_PublisherExecute.getPublisherDataFromDatabase();
                        grdListPublisher.DataSource = m_PublisherData;
                        grdvListPublisher.FocusedRowHandle = -1;
                        grdvListPublisher.FocusedRowHandle = 0;
                        break;
                    }
                case "btnDelete":
                    {
                        txtPublisherName.Properties.ReadOnly = true;
                        txtPublisherAddress.Properties.ReadOnly = true;
                        //
                        m_PublisherData = m_PublisherExecute.getPublisherDataFromDatabase();
                        grdListPublisher.DataSource = m_PublisherData;
                        //
                        grdvListPublisher.FocusedRowHandle = -1;
                        grdvListPublisher.FocusedRowHandle = 0;
                        //
                        m_PublisherMulitSelect.ClearSelection();
                        break;
                    }
                case "btnUpdate":
                    {
                        m_PublisherMulitSelect.ClearSelection();
                        m_IsAdd = false;
                        //
                        btnUpdate.Visible = false;
                        btnCancelOfUpdate.Visible = true;
                        //
                        txtPublisherName.Properties.ReadOnly = false;
                        txtPublisherAddress.Properties.ReadOnly = false;
                        //
                        grdvListPublisher.OptionsSelection.EnableAppearanceFocusedRow = true;
                        grdvListPublisher.Columns["CheckMarkSelection"].OptionsColumn.AllowEdit = false;
                        //
                        btnDelete.Enabled = false;
                        btnAdd.Enabled = false;
                        btnSave.Enabled = true;
                        break;
                    }
                case "btnSave":
                    {
                        m_IsAdd = false;
                        btnAdd.Enabled = true;
                        btnDelete.Enabled = true;
                        btnUpdate.Enabled = true;
                        btnSave.Enabled = false;
                        //
                        btnUpdate.Visible = true;
                        btnAdd.Visible = true;
                        btnCancel.Visible = false;
                        btnCancelOfUpdate.Visible = false;
                        //
                        txtPublisherName.Properties.ReadOnly = true;
                        txtPublisherAddress.Properties.ReadOnly = true;
                        //
                        grdvListPublisher.OptionsSelection.EnableAppearanceFocusedRow = true;
                        grdvListPublisher.Columns["CheckMarkSelection"].OptionsColumn.AllowEdit = true;
                        //
                        m_PublisherData = m_PublisherExecute.getPublisherDataFromDatabase();
                        grdListPublisher.DataSource = m_PublisherData;
                        grdvListPublisher.FocusedRowHandle = grdvListPublisher.DataRowCount - 1;
                        break;
                    }
            }
        }

        private void btnCancelOfUpdate_Click(object sender, EventArgs e)
        {
            updateEnableButtonAndResetValueOfControl(ref btnCancelOfUpdate);
        }

        private void txtPublisherName_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckInformationEntered.checkCharacterInput(e, true);
        }

        private bool checkData()
        {
            if (CheckInformationEntered.checkDataInput(txtPublisherName, "Dữ liệu không thể để trống", ref dxErrorProvider) &&
                CheckInformationEntered.checkDataInput(txtPublisherAddress, "Dữ liệu không thể để trống", ref dxErrorProvider))
            {
                return true;
            }
            return false;
        }
    }
}
