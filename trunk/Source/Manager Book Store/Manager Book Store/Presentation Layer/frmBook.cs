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
        public delegate void addPublisher();
        public addPublisher m_addPublisher;
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
            //
            m_BookData = m_BookExecute.getBookDataFromDatabase();
            grdListBook.DataSource = m_BookData;
            grdListBookView.DataSource = m_BookData;
            //txtAuthorName.DataBindings.Add(new Binding("Text", m_BookTitlesData, "NhomTG" ,true, DataSourceUpdateMode.OnPropertyChanged));
            //txtBookGenre.DataBindings.Add(new Binding("Text", m_BookTitlesData, "TenTL" ,true, DataSourceUpdateMode.OnPropertyChanged));
        }

        private void lkBookTitlesName_EditValueChanged(object sender, EventArgs e)
        {
            DevExpress.XtraEditors.LookUpEdit lkBooTitles = (sender as DevExpress.XtraEditors.LookUpEdit);
            //lkBookTitlesName.RefreshEditValue();
            //lkBooTitles.RefreshEditValue();
            //MessageBox.Show((lkBooTitles.Properties.DataSource as DataTable).Rows.Count.ToString());
            DataRowView _rowValue = lkBooTitles.Properties.GetDataSourceRowByKeyValue(lkBooTitles.EditValue) as DataRowView;
            if (_rowValue != null)
            {
                txtBookGenre.Text = _rowValue["TenTL"].ToString();
                txtAuthorName.Text = _rowValue["NhomTG"].ToString();
            }
        }

        private void grdvListBook_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (e.FocusedRowHandle >= 0)
            {
                txtBookId.Text = grdvListBook.GetRowCellValue(e.FocusedRowHandle,"MaSach").ToString();
                //lkBookTitlesName.RefreshEditValue();
                //lkBookTitlesName.ResetText();
                lkBookTitlesName.EditValue = grdvListBook.GetRowCellValue(e.FocusedRowHandle, "MaDauSach").ToString();
                lkPublisherName.EditValue = grdvListBook.GetRowCellValue(e.FocusedRowHandle, "MaNXB").ToString();
                spBookRealeaseYear.EditValue = grdvListBook.GetRowCellValue(e.FocusedRowHandle, "NamXB").ToString();
                spBookPrices.EditValue = grdvListBook.GetRowCellValue(e.FocusedRowHandle, "GiaNhap").ToString();
                spBookCount.EditValue = grdvListBook.GetRowCellValue(e.FocusedRowHandle, "SoLuong").ToString();
                //grdvListBookView.FocusedRowHandle = e.FocusedRowHandle;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (m_IsAdd)
                {
                    m_BookObject = new CBookDTO(txtBookId.Text,
                                                lkBookTitlesName.EditValue.ToString(),
                                                lkPublisherName.EditValue.ToString(),
                                                (int)spBookRealeaseYear.Value,
                                                spBookPrices.Value, 0);
                    m_BookExecute.AddBookToDatabase(m_BookObject);
                    m_BookData = m_BookExecute.getBookDataFromDatabase();
                }
                else
                {
                    m_BookObject = new CBookDTO(txtBookId.Text,
                                                lkBookTitlesName.EditValue.ToString(),
                                                lkPublisherName.EditValue.ToString(),
                                                (int)spBookRealeaseYear.Value,
                                                spBookPrices.Value,
                                                (int)spBookCount.Value);
                    m_BookExecute.UpdateBookToDatabase(m_BookObject);
                }
            }
            catch (System.Exception)
            {

            }
            finally
            {
                updateEnableButtonAndResetValueOfControl(ref btnUpdate);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach (object _rowObjectItem in m_BookMultiSelect.Selection)
            {
                grdvListBook.FocusedRowHandle -= 1;
                DataRowView _rowObjectDetail = _rowObjectItem as DataRowView;
                //m_BookObject = new CBookDTO(_rowObjectDetail.Row["MaSach"].ToString(), _rowObjectDetail.Row["TenSach"].ToString(), _rowObjectDetail.Row["DiaChi"].ToString());
                //m_BookObject = new CBookDTO(txtBookId.Text, lkBookTitlesName.EditValue.ToString(), lkPublisherName.EditValue.ToString(), (int)spBookRealeaseYear.Value, spBookPrices.Value, (int)spBookCount.Value);
                m_BookExecute.DeleteBookToDatabase(m_BookObject);
                updateEnableButtonAndResetValueOfControl(ref btnDelete);
            }
        }

        private void btnAddPublisher_Click(object sender, EventArgs e)
        {
            m_addPublisher();
        }
        private bool m_IsAdd = true;
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
                        //grdListBookTitles.Enabled = false;
                        //
                        txtBookId.Text = "SA0000**";
                        lkBookTitlesName.EditValue  = null;
                        lkPublisherName.EditValue   = null;
                        spBookCount.EditValue       = 0;
                        spBookPrices.EditValue      = 0;
                        spBookRealeaseYear.EditValue = 0;
                        lkBookTitlesName.Properties.ReadOnly = false;
                        lkBookTitlesName.Properties.AppearanceReadOnly.BackColor = Color.WhiteSmoke;
                        lkPublisherName.Properties.ReadOnly = false;
                        lkPublisherName.Properties.AppearanceReadOnly.BackColor = Color.WhiteSmoke;
                        spBookRealeaseYear.Properties.ReadOnly = false;
                        spBookRealeaseYear.Properties.AppearanceReadOnly.BackColor = Color.WhiteSmoke;
                        //
                        m_IsAdd = true;
                        break;
                    }
                case "btnCancel":
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
                        lkBookTitlesName.Properties.AppearanceReadOnly.BackColor = Color.WhiteSmoke;
                        lkPublisherName.Properties.ReadOnly = true;
                        lkPublisherName.Properties.AppearanceReadOnly.BackColor = Color.WhiteSmoke;
                        spBookRealeaseYear.Properties.ReadOnly = true;
                        spBookRealeaseYear.Properties.AppearanceReadOnly.BackColor = Color.WhiteSmoke;
                        //
                        m_BookData = m_BookExecute.getBookDataFromDatabase();
                        grdListBook.DataSource = m_BookData;
                        grdListBookView.DataSource = m_BookData;
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
                        lkBookTitlesName.Properties.AppearanceReadOnly.BackColor = Color.WhiteSmoke;
                        lkPublisherName.Properties.ReadOnly = true;
                        lkPublisherName.Properties.AppearanceReadOnly.BackColor = Color.WhiteSmoke;
                        spBookRealeaseYear.Properties.ReadOnly = true;
                        spBookRealeaseYear.Properties.AppearanceReadOnly.BackColor = Color.WhiteSmoke;
                        //
                        m_BookData = m_BookExecute.getBookDataFromDatabase();
                        grdListBook.DataSource = m_BookData;
                        grdListBookView.DataSource = m_BookData;
                        break;
                    }
                case "btnDelete":
                    {
                        lkBookTitlesName.Properties.ReadOnly = false;
                        lkBookTitlesName.Properties.AppearanceReadOnly.BackColor = Color.WhiteSmoke;
                        lkPublisherName.Properties.ReadOnly = false;
                        lkPublisherName.Properties.AppearanceReadOnly.BackColor = Color.WhiteSmoke;
                        spBookRealeaseYear.Properties.ReadOnly = false;
                        spBookRealeaseYear.Properties.AppearanceReadOnly.BackColor = Color.WhiteSmoke;
                        //
                        m_BookData = m_BookExecute.getBookDataFromDatabase();
                        grdListBook.DataSource = m_BookData;
                        grdListBookView.DataSource = m_BookData;
                        m_BookMultiSelect.ClearSelection();
                        break;
                    }
                case "btnUpdate":
                    {
                        m_IsAdd = false;
                        //
                        btnUpdate.Visible = false;
                        btnCancelOfUpdate.Visible = true;
                        //
                        lkBookTitlesName.Properties.ReadOnly = false;
                        lkBookTitlesName.Properties.AppearanceReadOnly.BackColor = Color.WhiteSmoke;
                        lkPublisherName.Properties.ReadOnly = false;
                        lkPublisherName.Properties.AppearanceReadOnly.BackColor = Color.WhiteSmoke;
                        spBookRealeaseYear.Properties.ReadOnly = false;
                        spBookRealeaseYear.Properties.AppearanceReadOnly.BackColor = Color.WhiteSmoke;
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
                        btnCancelOfUpdate.Visible = false;
                        //
                        lkBookTitlesName.Properties.ReadOnly = true;
                        lkBookTitlesName.Properties.AppearanceReadOnly.BackColor = Color.WhiteSmoke;
                        lkPublisherName.Properties.ReadOnly = true;
                        lkPublisherName.Properties.AppearanceReadOnly.BackColor = Color.WhiteSmoke;
                        spBookRealeaseYear.Properties.ReadOnly = true;
                        spBookRealeaseYear.Properties.AppearanceReadOnly.BackColor = Color.WhiteSmoke;
                        //
                        m_BookData = m_BookExecute.getBookDataFromDatabase();
                        grdListBook.DataSource = m_BookData;
                        grdListBookView.DataSource = m_BookData;
                        break;
                    }
            }
        }

        private void btnCancelOfUpdate_Click(object sender, EventArgs e)
        {
            updateEnableButtonAndResetValueOfControl(ref btnCancelOfUpdate);
        }
    }
}