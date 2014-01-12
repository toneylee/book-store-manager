using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Manager_Book_Store.Data_Tranfer_Object;
using Manager_Book_Store.Business_Layer;
using DevExpress.XtraGrid.Selection;
using DevExpress.XtraBars;
using Manager_Book_Store.General;

namespace Manager_Book_Store.Presentation_Layer
{
    public partial class frmBook : DevExpress.XtraEditors.XtraForm
    {
        #region "Variable"
        private CBookDTO m_BookObject;
        private DataTable m_BookData;
        private CBookBUS m_BookExecute;
        private DataTable m_PublisherData;
        private CPublisherBUS m_PublisherExecute;
        private DataTable m_BookTitlesData;
        private CBookTitlesBUS m_BookTitlesExecute;
        private GridCheckMarksSelection m_BookMultiSelect;
        #endregion
        public frmBook()
        {
            InitializeComponent();
            m_BookData          = new DataTable();
            m_PublisherData     = new DataTable();
            m_PublisherExecute  = new CPublisherBUS();
            m_BookTitlesData    = new DataTable();
            m_BookExecute       = new CBookBUS();
            m_BookTitlesExecute = new CBookTitlesBUS();
            m_BookMultiSelect   = new GridCheckMarksSelection(grdvListBook);
            BooksSno.VisibleIndex = 1;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            updateEnableButtonAndResetValueOfControl(ref btnAdd);
        }

        private void drBtnShowListBook_Click(object sender, EventArgs e)
        {
            //drBtnShowListBook.ShowDropDown();
            drBtnShowListBook.HideDropDown();
        }

        private void frmBook_Load(object sender, EventArgs e)
        {
            //
            m_BookTitlesData = m_BookTitlesExecute.getBookTitlesDataFromDatabase();
            lkBookTitlesName.Properties.DataSource = m_BookTitlesData;
            lkBookTitlesName.Properties.DisplayMember = "TenSach";
            lkBookTitlesName.Properties.ValueMember = "MaDauSach";
            //
            m_PublisherData = m_PublisherExecute.getPublisherDataFromDatabase();
            lkPublisherName.Properties.DataSource = m_PublisherData;
            lkPublisherName.Properties.DisplayMember = "TenNXB";
            lkPublisherName.Properties.ValueMember = "MaNXB";
            //
            btnSave.Enabled = false;
            lkBookTitlesName.Properties.ReadOnly = true;
            lkPublisherName.Properties.ReadOnly = true;
            txtBookRealeaseYear.Properties.ReadOnly = true;
            //
            m_BookData = m_BookExecute.getBookDataFromDatabase();
            grdListBook.DataSource = m_BookData;
            grdListBookView.DataSource = m_BookData;
        }

        private void lkBookTitlesName_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                DevExpress.XtraEditors.LookUpEdit lkBooTitles = (sender as DevExpress.XtraEditors.LookUpEdit);
                DataRowView row = lkBooTitles.Properties.GetDataSourceRowByKeyValue(lkBooTitles.EditValue) as DataRowView;
                if (row != null)
                {
                    txtBookGenre.Text = row["TenTL"].ToString();
                    txtAuthorName.Text = row["NhomTG"].ToString();
                }
                else
                {
                    txtBookGenre.Text = null;
                    txtAuthorName.Text = null;
                }
            }
            catch (System.Exception)
            {

            }

        }

        private void grdvListBook_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (m_IsAdd)
                return;
            try
            {
                if (e.FocusedRowHandle >= 0)
                {
                    txtBookId.Text = grdvListBook.GetRowCellValue(e.FocusedRowHandle, "MaSach").ToString();
                    //lkBookTitlesName.RefreshEditValue();
                    //lkBookTitlesName.ResetText();
                    lkBookTitlesName.EditValue = grdvListBook.GetRowCellValue(e.FocusedRowHandle, "MaDauSach").ToString();
                    lkPublisherName.EditValue = grdvListBook.GetRowCellValue(e.FocusedRowHandle, "MaNXB").ToString();
                    txtBookRealeaseYear.EditValue = grdvListBook.GetRowCellValue(e.FocusedRowHandle, "NamXB").ToString();
                    txtBookPrices.EditValue = grdvListBook.GetRowCellValue(e.FocusedRowHandle, "GiaNhap").ToString();
                    txtBookCount.EditValue = grdvListBook.GetRowCellValue(e.FocusedRowHandle, "SoLuong").ToString();
                    //grdvListBookView.FocusedRowHandle = e.FocusedRowHandle;
                }
            }
            catch (System.Exception)
            {
            	
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!checkData())
                return;
            if (m_IsAdd)
            {
                try
                {
                    m_BookObject = new CBookDTO("SA0000000",
                            lkBookTitlesName.EditValue.ToString(),
                            lkPublisherName.EditValue.ToString(),
                            int.Parse(txtBookRealeaseYear.Text),
                            0, 0);
                    if (m_BookExecute.AddBookToDatabase(m_BookObject))
                    {
                        XtraCustomMessageBox.Show("Thêm dữ liệu thành công!", "Thông báo", true);
                    }
                    else
                    {
                        XtraCustomMessageBox.Show("Thêm dữ liệu thất bại!", "Lỗi", true);
                    }
                }
                catch (System.Exception)
                {
                    XtraCustomMessageBox.Show("Thêm dữ liệu thất bại!", "Lỗi", true);
                }

            }
            else
            {
                try
                {
                    m_BookObject = new CBookDTO(txtBookId.Text,
                            lkBookTitlesName.EditValue.ToString(),
                            lkPublisherName.EditValue.ToString(),
                            int.Parse(txtBookRealeaseYear.Text),
                            int.Parse(txtBookPrices.Text), int.Parse(txtBookCount.Text));
                    if (!m_BookExecute.UpdateBookToDatabase(m_BookObject))
                    {
                        XtraCustomMessageBox.Show("Cập nhật dữ liệu thất bại!", "Thông báo", true);
                    }
                    else
                        XtraCustomMessageBox.Show("Cập nhật dữ liệu thành công!", "Thông báo", true);
                }
                catch (System.Exception)
                {
                	
                }
            }
            updateEnableButtonAndResetValueOfControl(ref btnSave);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
          updateEnableButtonAndResetValueOfControl(ref btnUpdate);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                ArrayList _listBookObject = new ArrayList();
                foreach (object _rowObjectItem in m_BookMultiSelect.Selection)
                {
                    grdvListBook.FocusedRowHandle -= 1;
                    DataRowView _rowObjectDetail = _rowObjectItem as DataRowView;
                    m_BookObject = new CBookDTO();
                    m_BookObject.maSach = _rowObjectDetail["MaSach"].ToString();
                    //m_BookObject = new CBookDTO(txtBookId.Text, lkBookTitlesName.EditValue.ToString(), lkPublisherName.EditValue.ToString(), (int)spBookRealeaseYear.Value, spBookPrices.Value, (int)spBookCount.Value);
                    if (!m_BookExecute.DeleteBookToDatabase(m_BookObject))
                        _listBookObject.Add(_rowObjectDetail.Row["MaSach"]);

                }
                if (_listBookObject.Count != 0)
                {
                    String _erroContent = "Không thể xóa các cuốn sách có mã sau: \n";
                    foreach (var item in _listBookObject)
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
                XtraCustomMessageBox.Show("Xóa dữ liệu thất bại!", "Thông báo", true);
            }
            finally
            {
                updateEnableButtonAndResetValueOfControl(ref btnDelete);
            }
        }
        public delegate void m_setPublisher(object sender, ItemClickEventArgs e);
        public m_setPublisher _setpublisher;

        private void btnAddPublisher_Click(object sender, EventArgs e)
        {
            _setpublisher(null, null);
        }
        private bool m_IsAdd = false;

        private void updateEnableButtonAndResetValueOfControl(ref SimpleButton _btnControl)
        {
            switch (_btnControl.Name)
            {
                case "btnAdd":
                    {
                        m_BookMultiSelect.ClearSelection();
                        //
                        txtBookId.Text = "SA00000**";
                        btnAdd.Visible = false;
                        btnCancel.Visible = true;
                        //
                        btnSave.Enabled = true;
                        btnUpdate.Enabled = false;
                        btnDelete.Enabled = false;
                        //
                        lkBookTitlesName.Properties.ReadOnly = false;
                        lkPublisherName.Properties.ReadOnly = false;
                        txtBookRealeaseYear.Properties.ReadOnly = false;
                        //
                        grdvListBook.OptionsSelection.EnableAppearanceFocusedRow = false;
                        grdvListBook.Columns["CheckMarkSelection"].OptionsColumn.AllowEdit = false;
                        //
                        lkBookTitlesName.EditValue = null;
                        lkPublisherName.EditValue = null;
                        txtBookRealeaseYear.EditValue = 0;
                        txtBookCount.EditValue = 0;
                        txtBookPrices.EditValue = 0;
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
                        lkBookTitlesName.Properties.ReadOnly = true;
                        lkPublisherName.Properties.ReadOnly = true;
                        txtBookRealeaseYear.Properties.ReadOnly = true;
                        //
                        grdvListBook.OptionsSelection.EnableAppearanceFocusedRow = true;
                        grdvListBook.Columns["CheckMarkSelection"].OptionsColumn.AllowEdit = true;
                        //
                        m_BookData = m_BookExecute.getBookDataFromDatabase();
                        grdListBook.DataSource = m_BookData;
                        grdListBookView.DataSource = m_BookData;
                        grdvListBook.FocusedRowHandle = -1;
                        grdvListBook.FocusedRowHandle = 0;
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
                        lkBookTitlesName.Properties.ReadOnly = true;
                        lkPublisherName.Properties.ReadOnly = true;
                        txtBookRealeaseYear.Properties.ReadOnly = true;
                        //
                        grdvListBook.OptionsSelection.EnableAppearanceFocusedRow = true;
                        grdvListBook.Columns["CheckMarkSelection"].OptionsColumn.AllowEdit = true;
                        //
                        m_BookData = m_BookExecute.getBookDataFromDatabase();
                        grdListBook.DataSource = m_BookData;
                        grdListBookView.DataSource = m_BookData;
                        grdvListBook.FocusedRowHandle = -1;
                        grdvListBook.FocusedRowHandle = 0;
                        break;
                    }
                case "btnDelete":
                    {
                        m_BookData = m_BookExecute.getBookDataFromDatabase();
                        grdListBook.DataSource = m_BookData;
                        grdListBookView.DataSource = m_BookData;
                        grdvListBook.FocusedRowHandle = grdvListBook.DataRowCount - 1;
                        grdvListBookView.FocusedRowHandle = grdvListBookView.DataRowCount - 1;
                        m_BookMultiSelect.ClearSelection();
                        break;
                    }
                case "btnUpdate":
                    {
                        m_IsAdd = false;
                        //
                        m_BookMultiSelect.ClearSelection();
                        //
                        btnUpdate.Visible = false;
                        btnCancelOfUpdate.Visible = true;
                        btnAdd.Enabled = false;
                        //
                        btnSave.Enabled = true;
                        btnUpdate.Enabled = false;
                        btnDelete.Enabled = false;
                        //
                        lkBookTitlesName.Properties.ReadOnly = false;
                        lkPublisherName.Properties.ReadOnly = false;
                        txtBookRealeaseYear.Properties.ReadOnly = false;
                        //
                        grdvListBook.OptionsSelection.EnableAppearanceFocusedRow = true;
                        grdvListBook.Columns["CheckMarkSelection"].OptionsColumn.AllowEdit = true;
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
                        lkBookTitlesName.Properties.ReadOnly = true;
                        lkPublisherName.Properties.ReadOnly = true;
                        txtBookRealeaseYear.Properties.ReadOnly = true;
                        //
                        grdvListBook.OptionsSelection.EnableAppearanceFocusedRow = true;
                        grdvListBook.Columns["CheckMarkSelection"].OptionsColumn.AllowEdit = true;
                        //
                        m_BookData = m_BookExecute.getBookDataFromDatabase();
                        grdListBook.DataSource = m_BookData;
                        grdListBookView.DataSource = m_BookData;
                        grdvListBook.FocusedRowHandle = grdvListBook.DataRowCount - 1;
                        grdvListBookView.FocusedRowHandle = grdvListBookView.DataRowCount - 1;
                        m_BookMultiSelect.ClearSelection();
                        break;
                    }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            updateEnableButtonAndResetValueOfControl(ref btnCancel);
        }

        private void btnCancelOfUpdate_Click(object sender, EventArgs e)
        {
            updateEnableButtonAndResetValueOfControl(ref btnCancelOfUpdate);
        }

        private bool checkData()
        {
            try
            {
                if (int.Parse(txtBookRealeaseYear.Text) > DateTime.Now.Year)
                {
                    XtraCustomMessageBox.Show("Năm xuất bản không thể lớn hơn năm hiện tại", "Lỗi", true);
                    txtBookRealeaseYear.ResetText();
                    txtBookRealeaseYear.Focus();
                    return false;
                }
            }
            catch (System.Exception) { }
            if(CheckInformationEntered.checkDataInput(lkBookTitlesName,"Dữ liệu không được để trống", ref dxErrorProvider) && 
                CheckInformationEntered.checkDataInput(lkPublisherName,"Dữ liệu không được để trống", ref dxErrorProvider) &&
                CheckInformationEntered.checkDataInput(txtBookRealeaseYear, "Dữ liệu không được để trống", ref dxErrorProvider))
            {
                return true;
            }
            return false;
        }

        private void txtBookRealeaseYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckInformationEntered.checkCharacterInput(e, false);
        }

        public delegate void m_setBookTitle(object sender, ItemClickEventArgs e);
        public m_setBookTitle _setBookTitle;

        private void btnAddBookTitles_Click(object sender, EventArgs e)
        {
            _setBookTitle(null, null);
        }

        private void txtBookTitlesNameLA_TextChanged(object sender, EventArgs e)
        {
           m_BookData = m_BookExecute.lookAtBookDataFromDatabase(txtBookTitlesNameLA.Text);
           grdListBook.DataSource = m_BookData;
        }

        private void lkBookTitlesName_QueryPopUp(object sender, CancelEventArgs e)
        {
            m_BookTitlesData = m_BookTitlesExecute.getBookTitlesDataFromDatabase();
            lkBookTitlesName.Properties.DataSource = m_BookTitlesData;
        }

        private void lkPublisherName_QueryPopUp(object sender, CancelEventArgs e)
        {
            m_PublisherData = m_PublisherExecute.getPublisherDataFromDatabase();
            lkPublisherName.Properties.DataSource = m_PublisherData;
        }

        private void txtBookTitlesNameLA_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckInformationEntered.checkCharacterInput(e, true);
        }
    }
}