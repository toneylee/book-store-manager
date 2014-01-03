using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Manager_Book_Store.General;
using Manager_Book_Store.Business_Layer;
using Manager_Book_Store.Data_Tranfer_Object;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Selection;
using System.Collections;

namespace Manager_Book_Store.Presentation_Layer
{
    public partial class frmBookGenre : DevExpress.XtraEditors.XtraForm
    {
        #region "variable"
        private CBookGenreDTO m_bookGenre;
        private DataTable     m_bookGenreData;
        private CBookGenreBUS m_bookGenreBus;
        private GridCheckMarksSelection m_bookGenreMultiSelectItem;
        private bool          m_IsUpdate;
        #endregion
        public frmBookGenre()
        {
            InitializeComponent();
            m_bookGenre     = new CBookGenreDTO();
            m_bookGenreBus  = new CBookGenreBUS();
            m_bookGenreData = new DataTable();
            m_bookGenreMultiSelectItem  = new GridCheckMarksSelection(grdvListBookGenre);
            m_IsUpdate = false;
            btnSave.Enabled = false;
        }

        private void frmForm_Load(object sender, EventArgs e)
        {
            txtBookGenreName.Properties.ReadOnly = true;
            bookGenreSNo.VisibleIndex = 1;
            m_bookGenreData                     = m_bookGenreBus.getBookGenreDataFromDatabase();
            grdListBookGenre.DataSource         = m_bookGenreData;
            grdvListBookGenre.FocusedRowHandle  = 0;
        }
        //Lấy thông tin chi tiết của thê loại.
        private void grdvListBookGenre_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (e.FocusedRowHandle >= 0)
            {
                txtBookGenreName.Text   = grdvListBookGenre.GetRowCellValue(e.FocusedRowHandle, grdvListBookGenre.Columns["TenTL"]).ToString();
                txtBookGenreId.Text     = grdvListBookGenre.GetRowCellValue(e.FocusedRowHandle, grdvListBookGenre.Columns["MaTL"]).ToString();
                //btnAdd.Enabled = false;
                btnCancel.Visible = false;
                btnCacelOfUpdate.Visible = false;
                btnUpdate.Visible = true;
                btnDelete.Visible = true;
                btnDelete.Enabled = true;
                btnUpdate.Enabled = true;
                //btnSave.Enabled = true;
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
            if (m_bookGenreMultiSelectItem.Selection.Count == 0)
                return;
            try
            {
                ArrayList _listBookObjectInDelibility = new ArrayList();
                foreach (object _rowObjectItem in m_bookGenreMultiSelectItem.Selection)
                {
                    grdvListBookGenre.FocusedRowHandle -= 1;
                    DataRowView _rowObjectDetail = _rowObjectItem as DataRowView;
                    m_bookGenre = new CBookGenreDTO(_rowObjectDetail.Row["MaTL"].ToString(), _rowObjectDetail.Row["TenTL"].ToString());
                    if (!m_bookGenreBus.DeleteBookGenreToDatabase(m_bookGenre))
                    {
                        _listBookObjectInDelibility.Add(_rowObjectDetail.Row["MaTL"]);
                    }

                }
                if (_listBookObjectInDelibility.Count == 0)
                {
                    XtraMessageBox.Show("Xóa dữ liệu thành công!");
                }
                else
                {
                    String _erroContent = "Không thể xóa thể loại có mã: \n";
                    foreach (var item in _listBookObjectInDelibility)
                    {
                        _erroContent += item.ToString() + "\n";
                    }
                    XtraMessageBox.Show(_erroContent);
                }
            }
            catch (System.Exception ex)
            {
                XtraMessageBox.Show(ex.ToString(), "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
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
                DataRow _rowValue = m_bookGenreData.AsEnumerable().FirstOrDefault(tt => tt.Field<string>("TenTL") == txtBookGenreName.Text);
                if (_rowValue != null)
                {
                    XtraMessageBox.Show("Dữ liệu đã tồn tại");
                    return;
                }
                if (!CheckInformationEntered.checkDataInput(txtBookGenreName, "Dữ liệu không thể để trống !", ref dxEPBookGenre))
                {
                    txtBookGenreName.Focus();
                    return;
                }
                if (!m_IsUpdate)
                {
                    m_bookGenre = new CBookGenreDTO(txtBookGenreName.Text);
                    m_bookGenre.maTheLoai = txtBookGenreId.Text;
                    if (!m_bookGenreBus.UpdateBookGenreToDatabase(m_bookGenre))
                        XtraMessageBox.Show("Cập nhật dữ liệu thất bại!");
                    else
                        XtraMessageBox.Show("Cập nhật dữ liệu thành công!");
                }
                else
                {
                    m_bookGenre = new CBookGenreDTO("TL0000000", txtBookGenreName.Text);
                    if (!m_bookGenreBus.AddBookGenreToDatabase(m_bookGenre))
                        XtraMessageBox.Show("Thêm dữ liệu thất bại!");
                    else
                        XtraMessageBox.Show("Thêm dữ liệu thành công!");

                }
            }
            catch (System.Exception ex)
            {
                XtraMessageBox.Show("Không thể lưu!\n" + ex.ToString(), "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            }
            finally
            {
                updateEnableButtonAndResetValueOfControl(ref btnSave);
            }
        }

        private void txtBookGenreNameLA_TextChanged(object sender, EventArgs e)
        {
            grdvListBookGenre.FocusedRowHandle = 0;
            m_bookGenreData             = m_bookGenreBus.lookAtBookGenreDataFromDatabase(txtBookGenreNameLA.Text);
            grdListBookGenre.DataSource = m_bookGenreData;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            updateEnableButtonAndResetValueOfControl(ref btnCancel);
        }

        private void updateEnableButtonAndResetValueOfControl(ref SimpleButton _btnControl)
        {
            switch (_btnControl.Name)
            {
                case "btnAdd":
                    {
                        btnAdd.Visible      = false;
                        btnCancel.Visible   = true;
                        //
                        btnSave.Enabled     = true;
                        btnUpdate.Enabled   = false;
                        btnDelete.Enabled   = false;
                        //
                        txtBookGenreId.Text     = "TL0000**";
                        txtBookGenreName.Text   = null;
                        txtBookGenreName.Properties.ReadOnly = false;
                        //
                        m_IsUpdate = true;
                        break;
                    }
                case "btnCancel":
                    {
                        //
                        btnAdd.Visible              = true;
                        btnCancel.Visible           = false;
                        btnCacelOfUpdate.Visible    = false;
                        btnUpdate.Visible           = true;
                        //
                        btnUpdate.Enabled           = true;
                        btnDelete.Enabled           = true;
                        btnAdd.Enabled              = true;
                        btnSave.Enabled             = false;
                        //
                        txtBookGenreName.Properties.ReadOnly = true;
                        //
                        m_bookGenreData             = m_bookGenreBus.getBookGenreDataFromDatabase();
                        grdListBookGenre.DataSource = m_bookGenreData;
                        grdvListBookGenre.FocusedRowHandle = grdvListBookGenre.DataRowCount - 1;
                        break;
                    }
                case "btnCancelOfUpdate":
                    {
                        //
                        btnAdd.Visible           = true;
                        btnCancel.Visible        = false;
                        btnCacelOfUpdate.Visible = false;
                        btnUpdate.Visible        = true;
                        //
                        btnUpdate.Enabled        = true;
                        btnDelete.Enabled        = true;
                        btnAdd.Enabled           = true;
                        btnSave.Enabled          = false;
                        //
                        txtBookGenreName.Properties.ReadOnly = true;
                        //
                        m_bookGenreData             = m_bookGenreBus.getBookGenreDataFromDatabase();
                        grdListBookGenre.DataSource = m_bookGenreData;
                        grdvListBookGenre.FocusedRowHandle = grdvListBookGenre.DataRowCount - 1;
                        break;
                    }
                case "btnDelete":
                    {
                        txtBookGenreName.Properties.ReadOnly = true;
                        m_bookGenreData                     = new DataTable();
                        m_bookGenreData                     = m_bookGenreBus.getBookGenreDataFromDatabase();
                        grdListBookGenre.DataSource         = m_bookGenreData;
                        grdvListBookGenre.FocusedRowHandle  = 0;
                        m_bookGenreMultiSelectItem.ClearSelection();
                        break;
                    }
                case "btnUpdate":
                    {
                        m_IsUpdate                  = false;
                        //
                        btnUpdate.Visible           = false;
                        btnCacelOfUpdate.Visible    = true;
                        //
                        txtBookGenreName.Properties.ReadOnly = false;
                        //
                        btnDelete.Enabled           = false;
                        btnAdd.Enabled              = false;
                        btnSave.Enabled             = true;
                        break;
                    }
                case "btnSave":
                    {
                        btnUpdate.Visible = true;
                        btnAdd.Enabled              = true;
                        btnDelete.Enabled = false;
                        btnUpdate.Enabled = false;
                        btnUpdate.Visible = true;
                        //
                        btnAdd.Visible              = true;
                        btnCancel.Visible           = false;
                        btnCacelOfUpdate.Visible    = false;
                        //
                        txtBookGenreName.Properties.ReadOnly = false;
                        //
                        m_bookGenreData             = m_bookGenreBus.getBookGenreDataFromDatabase();
                        grdListBookGenre.DataSource = m_bookGenreData;
                        grdvListBookGenre.FocusedRowHandle = grdvListBookGenre.DataRowCount - 1;
                        break;
                    }
            }
        }

        private void txtBookGenreName_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckInformationEntered.checkCharacterInput(e, true);
        }



    }
}
