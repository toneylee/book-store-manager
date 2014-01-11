using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraRichEdit.Layout;
using Manager_Book_Store.Business_Layer;
using DevExpress.XtraGrid.Selection;
using Manager_Book_Store.Data_Tranfer_Object;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using System.Collections;
using Manager_Book_Store.General;

namespace Manager_Book_Store.Presentation_Layer
{ 
    public partial class frmBookTitle : Form
    {
        #region "variable"
        private GridCheckMarksSelection m_BookTitlesMulitSelect;
        private CBookTitlesBUS m_BookTitlesExecute;
        private DataTable m_BookTitlesData;
        private CBookTitlesDTO m_BookTitlesObject;
        private CAuthorBUS m_AuthorExecute;
        private CBookGenreBUS m_BookGenreExecute;
        private DataTable m_AuthorData;
        private DataTable m_BookGenreData;
        private CAuthorDetailDTO m_AuthorDetailObject;
        private CAuthorDetailBUS m_AuthorDetailExecute;
        #endregion
        public frmBookTitle()
        {
            InitializeComponent();
            m_AuthorExecute = new CAuthorBUS();
            m_BookGenreExecute = new CBookGenreBUS();
            m_AuthorData = new DataTable();
            m_BookGenreData = new DataTable();
            m_BookTitlesMulitSelect = new GridCheckMarksSelection(grdvListBookTitles);
            m_BookTitlesExecute = new CBookTitlesBUS();
            m_BookTitlesData = new DataTable();        
            m_AuthorDetailExecute = new CAuthorDetailBUS();
            BookTiltesSno.VisibleIndex = 1;
            btnSave.Enabled = false;
        }

        private void frmBookTitles_Load(object sender, EventArgs e)
        {
            m_AuthorData = m_AuthorExecute.getAuthorDataFromDatabase();
            m_BookGenreData = m_BookGenreExecute.getBookGenreDataFromDatabase();
            //Binding data
            chkCmbAuthorName.Properties.DataSource = m_AuthorData;
            chkCmbAuthorName.Properties.DisplayMember = "TenTG";
            chkCmbAuthorName.Properties.ValueMember = "MaTG";
            //Binding data
            lkBookGenreName.Properties.DataSource = m_BookGenreData;
            lkBookGenreName.Properties.DisplayMember = "TenTL";
            lkBookGenreName.Properties.ValueMember = "MaTL";
            //
            m_BookTitlesData = m_BookTitlesExecute.getBookTitlesDataFromDatabase();
            grdListBookTitles.DataSource = m_BookTitlesData;
        }
        public  ArrayList _listAuthorNameFirst;
        private void grdvListBookTitles_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (m_IsAdd)
                return;
            try
            {
                String _listAuthorNameValues = null;
                if (e.FocusedRowHandle >= 0)
                {
                    _listAuthorNameValues = grdvListBookTitles.GetRowCellValue(e.FocusedRowHandle, grdvListBookTitles.Columns["NhomTG"]).ToString();
                    txtBookTitlesId.Text = grdvListBookTitles.GetRowCellValue(e.FocusedRowHandle, grdvListBookTitles.Columns["MaDauSach"]).ToString();
                    txtBookTitlesName.Text = grdvListBookTitles.GetRowCellValue(e.FocusedRowHandle, grdvListBookTitles.Columns["TenSach"]).ToString();
                    lkBookGenreName.EditValue = grdvListBookTitles.GetRowCellValue(e.FocusedRowHandle, "MaTL").ToString();
                }
                String[] _listAuthorName = _listAuthorNameValues.Split(',');
                chkCmbAuthorName.RefreshEditValue();
                chkCmbAuthorName.SetEditValue(null);
                for (int i = 0; i < _listAuthorName.Length; i++)
                {
                    foreach (CheckedListBoxItem _authorName in chkCmbAuthorName.Properties.Items)
                    {
                        if (_authorName.Description.ToLower().Trim().Equals(_listAuthorName[i].ToLower().Trim()))
                        {
                            _authorName.CheckState = CheckState.Checked;
                        }
                    }
                }
                _listAuthorNameFirst = new ArrayList(chkCmbAuthorName.EditValue.ToString().Split(new string[] { ", " }, StringSplitOptions.None));
            }
            catch (System.Exception)
            {
            	
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            updateEnableButtonAndResetValueOfControl(ref btnAdd);
        }
        public ArrayList _listAuthorNameSecond;
        private void btnUpdate_Click(object sender, EventArgs e)
        {
             updateEnableButtonAndResetValueOfControl(ref btnUpdate);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                ArrayList _listBookTitleObjectInDelibility = new ArrayList();
                foreach (object _rowObjectItem in m_BookTitlesMulitSelect.Selection)
                {
                    grdvListBookTitles.FocusedRowHandle -= 1;
                    DataRowView _rowObjectDetail = _rowObjectItem as DataRowView;
                    m_BookTitlesObject = new CBookTitlesDTO();
                    m_BookTitlesObject.maDauSach = _rowObjectDetail["MaDauSach"].ToString();
                    m_AuthorDetailObject = new CAuthorDetailDTO();
                    m_AuthorDetailObject.maDauSach = _rowObjectDetail["MaDauSach"].ToString();
                    if (m_AuthorDetailExecute.DeleteAuthorDetailToDatabase(m_AuthorDetailObject))
                    {
                        if (!m_BookTitlesExecute.DeleteBookTitlesToDatabase(m_BookTitlesObject))
                        {
                            _listBookTitleObjectInDelibility.Add(_rowObjectDetail["MaDauSach"]);
                        }
                    }
                    else
                    {
                        _listBookTitleObjectInDelibility.Add(_rowObjectDetail["MaDauSach"]);
                    }
                }
                if (_listBookTitleObjectInDelibility.Count != 0)
                {
                    String _erroContent = "Không thể xóa các cuốn sách có mã: \n";
                    foreach (var item in _listBookTitleObjectInDelibility)
                    {
                        _erroContent += item.ToString() + "\n";
                    }
                    XtraMessageBox.Show(_erroContent);
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
                    m_BookTitlesObject = new CBookTitlesDTO(txtBookTitlesId.Text, lkBookGenreName.EditValue.ToString(), txtBookTitlesName.Text);
                    if (m_BookTitlesExecute.AddBookTitlesToDatabase(m_BookTitlesObject))
                    {
                        XtraCustomMessageBox.Show("Thêm dữ liệu thành công!", "Thông báo", true);
                    }
                    else
                    {
                        XtraCustomMessageBox.Show("Thêm dữ liệu thất bại!", "Lỗi", true);
                    }
                    foreach (CheckedListBoxItem _authorName in chkCmbAuthorName.Properties.Items)
                    {
                        if (_authorName.CheckState == CheckState.Checked)
                        {
                            m_AuthorDetailObject = new CAuthorDetailDTO(m_BookTitlesExecute.getBookTitlesMaxIdFromDatabase(),
                            _authorName.Value.ToString());
                            m_AuthorDetailExecute.AddAuthorDetailToDatabase(m_AuthorDetailObject);
                        }
                    }
                }
                else
                {
                    m_BookTitlesObject = new CBookTitlesDTO(txtBookTitlesId.Text,
                        lkBookGenreName.EditValue.ToString(), txtBookTitlesName.Text);
                    if (m_BookTitlesExecute.UpdateBookTitlesToDatabase(m_BookTitlesObject))
                    {
                        XtraCustomMessageBox.Show("Cập nhật dữ liệu thành công!", "Thông báo", true);
                    }
                    else
                    {
                        XtraCustomMessageBox.Show("Cập nhật dữ liệu thất bại!", "Lỗi", true);
                    }
                    _listAuthorNameSecond = new ArrayList(chkCmbAuthorName.EditValue.ToString().Split(new string[] { ", " }, StringSplitOptions.None));
                    foreach (object item in _listAuthorNameFirst)
                    {
                        if (!_listAuthorNameSecond.Contains(item))
                        {
                            m_AuthorDetailExecute.DeleteAuthorDetailToDatabase(new CAuthorDetailDTO(txtBookTitlesId.Text, item.ToString()));
                        }
                    }
                    foreach (object item in _listAuthorNameSecond)
                    {
                        if (!_listAuthorNameFirst.Contains(item))
                        {
                            m_AuthorDetailExecute.AddAuthorDetailToDatabase(new CAuthorDetailDTO(txtBookTitlesId.Text, item.ToString()));
                        }
                    }
                }
                //m_AuthorDetailObject = new CAuthorDetailDTO(m_BookTitlesExecute.getBookTitlesMaxIdFromDatabase(),chkCmbAuthorName.)
            }
            catch (System.Exception)
            {
                XtraCustomMessageBox.Show("Lưu dữ liệu thất bại", "Thông báo", true);
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

        private void txtBookTitlesNameLA_TextChanged(object sender, EventArgs e)
        {
            m_BookTitlesData = m_BookTitlesExecute.lookAtBookTitlesDataFromDatabase(txtBooktitlesNameLA.Text);
            grdListBookTitles.DataSource = m_BookTitlesData;

        }

        private void chkCmbAuthorName_EditValueChanged(object sender, EventArgs e)
        {
            //chkCmbAuthorName.RefreshEditValue();
            //MessageBox.Show(chkCmbAuthorName.EditValue.ToString());
        }

        private void chkCmbAuthorName_TextChanged(object sender, EventArgs e)
        {
            //chkCmbAuthorName.RefreshEditValue();
            //MessageBox.Show(chkCmbAuthorName.EditValue.ToString());
        }

        public delegate void setData(object sender, DevExpress.XtraBars.ItemClickEventArgs e);

        public setData _setAuthor;

        public setData _setBookGenre;

        private void btnAddBookGenre_Click(object sender, EventArgs e)
        {
            _setBookGenre(null, null);
        }

        private void btnAddAuthor_Click(object sender, EventArgs e)
        {
            _setAuthor(null,null);
        }

        private bool m_IsAdd = false;
        private void updateEnableButtonAndResetValueOfControl(ref SimpleButton _btnControl)
        {
            switch (_btnControl.Name)
            {
                case "btnAdd":
                    {
                        m_BookTitlesMulitSelect.ClearSelection();
                        //
                        m_IsAdd = true;
                        //
                        btnAdd.Visible = false;
                        btnCancel.Visible = true;
                        //
                        btnSave.Enabled = true;
                        btnUpdate.Enabled = false;
                        btnDelete.Enabled = false;
                        //grdListBookTitles.Enabled = false;
                        //
                        txtBookTitlesId.Text = "DS0000**";
                        txtBookTitlesName.Text = null;
                        lkBookGenreName.EditValue = null;
                        chkCmbAuthorName.SetEditValue(null);
                        //
                        grdvListBookTitles.OptionsSelection.EnableAppearanceFocusedRow = false;
                        grdvListBookTitles.Columns["CheckMarkSelection"].OptionsColumn.AllowEdit = false;
                        //
                        txtBookTitlesName.Properties.ReadOnly = false;
                        lkBookGenreName.Properties.ReadOnly = false;
                        chkCmbAuthorName.Properties.ReadOnly = false;
                        //
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
                        txtBookTitlesName.Properties.ReadOnly = true;
                        lkBookGenreName.Properties.ReadOnly = true;
                        chkCmbAuthorName.Properties.ReadOnly = true;
                        //
                        grdvListBookTitles.OptionsSelection.EnableAppearanceFocusedRow = true;
                        grdvListBookTitles.Columns["CheckMarkSelection"].OptionsColumn.AllowEdit = true;
                        //
                        dxErrorProvider.ClearErrors();
                        //
                        m_BookTitlesData = m_BookTitlesExecute.getBookTitlesDataFromDatabase();
                        grdListBookTitles.DataSource = m_BookTitlesData;
                        grdvListBookTitles.FocusedRowHandle = -1;
                        grdvListBookTitles.FocusedRowHandle = 0;
                        break;
                    }
                case "btnCacelOfUpdate":
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
                        txtBookTitlesName.Properties.ReadOnly = true;
                        lkBookGenreName.Properties.ReadOnly = true;
                        chkCmbAuthorName.Properties.ReadOnly = true;
                        //
                        grdvListBookTitles.OptionsSelection.EnableAppearanceFocusedRow = true;
                        grdvListBookTitles.Columns["CheckMarkSelection"].OptionsColumn.AllowEdit = true;
                        // 
                        dxErrorProvider.ClearErrors();
                        //
                        m_BookTitlesData = m_BookTitlesExecute.getBookTitlesDataFromDatabase();
                        grdListBookTitles.DataSource = m_BookTitlesData;
                        grdvListBookTitles.FocusedRowHandle = -1;
                        grdvListBookTitles.FocusedRowHandle = 0;
                        break;
                    }
                case "btnDelete":
                    {
                        txtBookTitlesName.Properties.ReadOnly = true;
                        lkBookGenreName.Properties.ReadOnly = true;
                        chkCmbAuthorName.Properties.ReadOnly = true;
                        //
                        m_BookTitlesData = m_BookTitlesExecute.getBookTitlesDataFromDatabase();
                        grdListBookTitles.DataSource = m_BookTitlesData;
                        grdvListBookTitles.FocusedRowHandle = -1;
                        grdvListBookTitles.FocusedRowHandle = 0;
                        m_BookTitlesMulitSelect.ClearSelection();
                        break;
                    }
                case "btnUpdate":
                    {
                        m_IsAdd = false;
                        //
                        m_BookTitlesMulitSelect.ClearSelection();
                        //
                        btnUpdate.Visible = false;
                        btnCancelOfUpdate.Visible = true;
                        //
                        txtBookTitlesName.Properties.ReadOnly = false;
                        lkBookGenreName.Properties.ReadOnly = false;
                        chkCmbAuthorName.Properties.ReadOnly = false;
                        //
                        grdvListBookTitles.OptionsSelection.EnableAppearanceFocusedRow = true;
                        grdvListBookTitles.Columns["CheckMarkSelection"].OptionsColumn.AllowEdit = true;
                        //
                        btnDelete.Enabled = false;
                        btnAdd.Enabled = false;
                        btnSave.Enabled = true;
                        break;
                    }
                case "btnSave":
                    {
                        m_IsAdd = false;
                        //
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
                        txtBookTitlesName.Properties.ReadOnly = true;
                        lkBookGenreName.Properties.ReadOnly = true;
                        chkCmbAuthorName.Properties.ReadOnly = true;
                        //
                        m_BookTitlesData = m_BookTitlesExecute.getBookTitlesDataFromDatabase();
                        grdListBookTitles.DataSource = m_BookTitlesData;
                        grdvListBookTitles.FocusedRowHandle = grdvListBookTitles.DataRowCount - 1;
                        //
                        grdvListBookTitles.OptionsSelection.EnableAppearanceFocusedRow = true;
                        grdvListBookTitles.Columns["CheckMarkSelection"].OptionsColumn.AllowEdit = true;
                        //
                        dxErrorProvider.ClearErrors();
                        //

                        break;
                    }
            }
        }

        private void txtBookTitlesName_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckInformationEntered.checkCharacterInput(e, true);
        }

        private bool checkData()
        {
            if(CheckInformationEntered.checkDataInput(lkBookGenreName,"Dữ liệu không thể để trống",ref dxErrorProvider)&&
                CheckInformationEntered.checkDataInput(chkCmbAuthorName,"Dữ liệu không thể để trống", ref dxErrorProvider) &&
                CheckInformationEntered.checkDataInput(txtBookTitlesName, "Dữ liệu không thể để trống", ref dxErrorProvider))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void lkBookGenreName_QueryPopUp(object sender, CancelEventArgs e)
        {
            m_BookGenreData = m_BookGenreExecute.getBookGenreDataFromDatabase();
            lkBookGenreName.Properties.DataSource = m_BookGenreData;
        }

        private void chkCmbAuthorName_QueryPopUp(object sender, CancelEventArgs e)
        {
            m_AuthorData = m_AuthorExecute.getAuthorDataFromDatabase();
            chkCmbAuthorName.Properties.DataSource = m_AuthorData;
        }
    }

}
