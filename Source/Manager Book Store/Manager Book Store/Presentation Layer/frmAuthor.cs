using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Selection;
using Manager_Book_Store.Business_Layer;
using Manager_Book_Store.Data_Tranfer_Object;
using Manager_Book_Store.General;

namespace Manager_Book_Store.Presentation_Layer
{
    public partial class frmAuthor : DevExpress.XtraEditors.XtraForm
    {
        #region "variable"
        private GridCheckMarksSelection m_AuthorMulitSelect;
        private CAuthorBUS m_AuthorExecute;
        private DataTable m_AuthorData;
        private CAuthorDTO m_AuthorObject;
        private bool m_IsAdd;
        #endregion
        public frmAuthor()
        {
            InitializeComponent();
            m_AuthorMulitSelect = new GridCheckMarksSelection(grdvListAuthor);
            m_AuthorExecute     = new CAuthorBUS();
            m_AuthorData    = new DataTable();
            AuthorSno.VisibleIndex = 1;
            m_IsAdd = false;
        }
       
        private void frmAuthor_Load(object sender, EventArgs e)
        {
            m_AuthorData = m_AuthorExecute.getAuthorDataFromDatabase();
            grdListAuthor.DataSource = m_AuthorData;
        }
      
        private void grdvListAuthor_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (e.FocusedRowHandle >= 0)
            {
                txtAuthorId.Text = grdvListAuthor.GetRowCellValue(e.FocusedRowHandle, grdvListAuthor.Columns["MaTG"]).ToString();
                txtAuthorName.Text = grdvListAuthor.GetRowCellValue(e.FocusedRowHandle, grdvListAuthor.Columns["TenTG"]).ToString();
                txtAuthorAddress.Text = grdvListAuthor.GetRowCellValue(e.FocusedRowHandle, grdvListAuthor.Columns["DiaChi"]).ToString();
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
                System.Collections.ArrayList _listAuthorObjectInDelibility = new System.Collections.ArrayList();
                foreach (object _rowObjectItem in m_AuthorMulitSelect.Selection)
                {
                    grdvListAuthor.FocusedRowHandle -= 1;
                    DataRowView _rowObjectDetail = _rowObjectItem as DataRowView;
                    m_AuthorObject = new CAuthorDTO(_rowObjectDetail.Row["MaTG"].ToString(), _rowObjectDetail.Row["TenTG"].ToString(), _rowObjectDetail.Row["DiaChi"].ToString());
                    if (!m_AuthorExecute.DeleteAuthorToDatabase(m_AuthorObject))
                    {
                        _listAuthorObjectInDelibility.Add(_rowObjectDetail.Row["MaTG"]);
                    }
                }
                String _erroContent = "Không thể xóa thông tin các tác giả có mã số: \n";
                if (_listAuthorObjectInDelibility.Count != 0)
                {
                    foreach (var item in _listAuthorObjectInDelibility)
                    {
                        _erroContent += item.ToString() + "\n";
                    }
                    XtraMessageBox.Show(_erroContent);
                }
            }
            catch (System.Exception ex)
            {
                //XtraMessageBox.Show(ex.ToString(), "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            }
            finally
            {
                updateEnableButtonAndResetValueOfControl(ref btnDelete);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (m_IsAdd)
                {
                    m_AuthorObject = new CAuthorDTO(txtAuthorId.Text, txtAuthorName.Text, txtAuthorAddress.Text);
                    m_AuthorExecute.AddAuthorToDatabase(m_AuthorObject);
                }
                else
                {            
                    m_AuthorObject = new CAuthorDTO(txtAuthorId.Text, txtAuthorName.Text, txtAuthorAddress.Text);
                    m_AuthorExecute.UpdateAuthorToDatabase(m_AuthorObject);
                    m_AuthorData = m_AuthorExecute.getAuthorDataFromDatabase();
                    grdListAuthor.DataSource = m_AuthorData;
                    grdvListAuthor.FocusedRowHandle = grdvListAuthor.DataRowCount - 1;
                }

            }
            catch (System.Exception ex)
            {
                XtraMessageBox.Show(ex.ToString(), "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
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

        private void txtAuthorNameLA_TextChanged(object sender, EventArgs e)
        {
            grdvListAuthor.FocusedRowHandle = 0;
            m_AuthorData = m_AuthorExecute.lookAtAuthorDataFromDatabase(txtAuthorNameLA.Text);
            grdListAuthor.DataSource = m_AuthorData;
        }
        private void updateEnableButtonAndResetValueOfControl(ref SimpleButton _btnControl)
        {
            switch (_btnControl.Name)
            {
                case "btnAdd":
                    {
                        btnAdd.Visible = false;
                        btnCancel.Visible = true;
                        //
                        btnSave.Enabled = true;
                        btnUpdate.Enabled = false;
                        btnDelete.Enabled = false;
                        //
                        txtAuthorId.Text = "TG0000**";
                        txtAuthorName.Text = null;
                        txtAuthorAddress.Text = null;
                        txtAuthorAddress.Properties.ReadOnly = false;
                        txtAuthorName.Properties.ReadOnly = false;
                        //
                        m_IsAdd = true;
                        break;
                    }
                case "btnCancel":
                    {
                        //
                        btnAdd.Visible = true;
                        btnCancel.Visible = false;
                        btnCacelOfUpdate.Visible = false;
                        btnUpdate.Visible = true;
                        //
                        btnUpdate.Enabled = true;
                        btnDelete.Enabled = true;
                        btnAdd.Enabled = true;
                        btnSave.Enabled = false;
                        //
                        txtAuthorName.Properties.ReadOnly = true;
                        txtAuthorAddress.Properties.ReadOnly = true;
                        //
                        m_AuthorData = m_AuthorExecute.getAuthorDataFromDatabase();
                        grdListAuthor.DataSource = m_AuthorData;
                        grdvListAuthor.FocusedRowHandle = grdvListAuthor.DataRowCount - 1;
                        break;
                    }
                case "btnCacelOfUpdate":
                    {
                        //
                        btnAdd.Visible = true;
                        btnCancel.Visible = false;
                        btnCacelOfUpdate.Visible = false;
                        btnUpdate.Visible = true;
                        //
                        btnUpdate.Enabled = true;
                        btnDelete.Enabled = true;
                        btnAdd.Enabled = true;
                        btnSave.Enabled = false;
                        //
                        txtAuthorName.Properties.ReadOnly = true;
                        txtAuthorAddress.Properties.ReadOnly = true;
                        //
                        m_AuthorData = m_AuthorExecute.getAuthorDataFromDatabase();
                        grdListAuthor.DataSource = m_AuthorData;
                        grdvListAuthor.FocusedRowHandle = grdvListAuthor.DataRowCount - 1;
                        break;
                    }
                case "btnDelete":
                    {
                        txtAuthorName.Properties.ReadOnly = true;
                        txtAuthorAddress.Properties.ReadOnly = true;
                        m_AuthorData = new DataTable();
                        m_AuthorData = m_AuthorExecute.getAuthorDataFromDatabase();
                        grdListAuthor.DataSource = m_AuthorData;
                        grdvListAuthor.FocusedRowHandle = 0;
                        m_AuthorMulitSelect.ClearSelection();
                        break;
                    }
                case "btnUpdate":
                    {
                        m_IsAdd = false;
                        //
                        btnUpdate.Visible = false;
                        btnCacelOfUpdate.Visible = true;
                        //
                        txtAuthorName.Properties.ReadOnly = false;
                        txtAuthorAddress.Properties.ReadOnly = false;
                        //
                        btnDelete.Enabled = false;
                        btnAdd.Enabled = false;
                        btnSave.Enabled = true;
                        break;
                    }
                case "btnSave":
                    {
                        btnAdd.Enabled = true;
                        btnDelete.Enabled = true;
                        btnUpdate.Enabled = true;
                        btnSave.Enabled = false;
                        //
                        btnUpdate.Visible = true;
                        btnAdd.Visible = true;
                        btnCancel.Visible = false;
                        btnCacelOfUpdate.Visible = false;
                        //
                        txtAuthorName.Properties.ReadOnly = true; 
                        txtAuthorAddress.Properties.ReadOnly = true;
                        //
                        m_AuthorData = m_AuthorExecute.getAuthorDataFromDatabase();
                        grdListAuthor.DataSource = m_AuthorData;
                        grdvListAuthor.FocusedRowHandle = grdvListAuthor.DataRowCount - 1;
                        break;
                    }
            }
        }

        private void btnCacelOfUpdate_Click(object sender, EventArgs e)
        {
            updateEnableButtonAndResetValueOfControl(ref btnCacelOfUpdate);
        }

        private void txtAuthorName_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckInformationEntered.checkCharacterInput(e, true);
        }

    }
}