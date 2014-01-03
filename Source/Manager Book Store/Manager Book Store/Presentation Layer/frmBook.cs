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
            txtBookId.Text = "SA0000000";

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
            DataRowView row = lkBooTitles.Properties.GetDataSourceRowByKeyValue(lkBooTitles.EditValue) as DataRowView;
            txtBookGenre.Text = row["TenTL"].ToString();
            txtAuthorName.Text = row["NhomTG"].ToString();
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
            m_BookObject = new CBookDTO(txtBookId.Text, lkBookTitlesName.EditValue.ToString(), lkPublisherName.EditValue.ToString(), (int)spBookRealeaseYear.Value, spBookPrices.Value, 0);
            m_BookExecute.AddBookToDatabase(m_BookObject);
            m_BookData = m_BookExecute.getBookDataFromDatabase();
            grdListBook.DataSource = m_BookData;
            grdListBookView.DataSource = m_BookData;
            grdvListBook.FocusedRowHandle = grdvListBook.DataRowCount - 1;
            grdvListBookView.FocusedRowHandle = grdvListBookView.DataRowCount - 1;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            m_BookObject = new CBookDTO(txtBookId.Text, lkBookTitlesName.EditValue.ToString(), lkPublisherName.EditValue.ToString(), (int)spBookRealeaseYear.Value, spBookPrices.Value, (int)spBookCount.Value);
            m_BookExecute.UpdateBookToDatabase(m_BookObject);
            m_BookData = m_BookExecute.getBookDataFromDatabase();
            grdListBook.DataSource = m_BookData;
            grdListBookView.DataSource = m_BookData;
            grdvListBook.FocusedRowHandle = grdvListBook.DataRowCount - 1;
            grdvListBookView.FocusedRowHandle = grdvListBookView.DataRowCount - 1;
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
                m_BookData = m_BookExecute.getBookDataFromDatabase();
                grdListBook.DataSource = m_BookData;
                grdListBookView.DataSource = m_BookData;
                grdvListBook.FocusedRowHandle = grdvListBook.DataRowCount - 1;
                grdvListBookView.FocusedRowHandle = grdvListBookView.DataRowCount - 1;
            }
        }
    }
}