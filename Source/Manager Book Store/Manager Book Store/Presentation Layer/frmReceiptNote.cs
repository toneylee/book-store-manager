using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid;
using DevExpress.Utils;
using Manager_Book_Store.Business_Layer;
using Manager_Book_Store.Data_Tranfer_Object;
using DevExpress.XtraGrid.Selection;
using DevExpress.XtraEditors;
using Manager_Book_Store.Report;

namespace Manager_Book_Store.Presentation_Layer
{
    public partial class frmReceiptNote : Form
    {
        #region "Variable"
        private CBookBUS m_BookExecute;
        private DataTable m_BookData;
        private CReceiptNoteBUS m_ReceiptNoteExecute;
        private CReceiptNoteDTO m_ReceiptNoteObject;
        private DataTable m_ReceiptNoteData;
        private CReceiptNoteDateilBUS m_ReceiptNoteDetailExecute;
        private CReceiptNoteDetailDTO m_ReceiptNoteDetailObject;
        private DataTable m_ReceiptNoteDetailData;
        private GridCheckMarksSelection m_ReceiptNoteDetailMultiselect;
        #endregion
        public frmReceiptNote()
        {
            InitializeComponent();
            m_BookData              = new DataTable();
            m_BookExecute           = new CBookBUS();
            m_ReceiptNoteData       = new DataTable();
            m_ReceiptNoteDetailData = new DataTable();
            m_ReceiptNoteExecute    = new CReceiptNoteBUS();
            m_ReceiptNoteDetailExecute = new CReceiptNoteDateilBUS();
            m_ReceiptNoteDetailMultiselect = new GridCheckMarksSelection(grdvReceiptBook);
            ReceiptNoteId.VisibleIndex = 1;
            //DateTime.Compare//
            labReceiptDateValue.Text = DateTime.Now.ToString("dd/MM/yyyy");
            txtReceiptNoteId.Text = "PN000000**";

        }

        private void frmReceiptNote_Load(object sender, EventArgs e)
        {
            m_BookData = m_BookExecute.getBookDataFromDatabase();
            grdListBook.DataSource = m_BookData;

            m_ReceiptNoteDetailData = m_ReceiptNoteDetailExecute.getReceiptNoteDetailDataFromDatabase();
            m_ReceiptNoteDetailData.Clear();
            DataColumn[] keys = new DataColumn[1];
            keys[0] = m_ReceiptNoteDetailData.Columns["MaSach"];
            m_ReceiptNoteDetailData.PrimaryKey = keys;
        }

        private void grdvReceiptBook_CustomDrawFooterCell(object sender, DevExpress.XtraGrid.Views.Grid.FooterCellCustomDrawEventArgs e)
        {
            if (e.Column.FieldName == "TenNXB")
            {
                bool isPrinting = e.Handled;
                e.Handled = true;
                //e.Appearance.BackColor = Color.Violet;
                //e.Appearance.FillRectangle(e.Cache, e.Bounds);
                e.Graphics.DrawString("\tTổng số lượng ", AppearanceObject.DefaultFont, Brushes.Blue, e.Bounds);
            }
            else if (e.Column.FieldName == "DonGia")
            {
                bool isPrinting = e.Handled;
                e.Handled = true;
                //e.Appearance.BackColor = Color.Violet;//Chọn màu cho cột
                //e.Appearance.FillRectangle(e.Cache, e.Bounds);
                e.Graphics.DrawString("\tTổng số tiền ", AppearanceObject.DefaultFont, Brushes.Blue, e.Bounds);
            }
            else
                return;
        }

        private void drbtnReceiptNoteChose_Click(object sender, EventArgs e)
        {
            drbtnReceiptNoteChose.ShowDropDown();
            //drbtnReceiptNoteChose.HideDropDown();
        }
        Dictionary<String, Object> m_listBookObject = new Dictionary<String, Object>();
        private void grdvListBook_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (e.FocusedRowHandle >= 0)
            {
                m_listBookObject.Clear();
                m_listBookObject.Add("MaSach", grdvListBook.GetRowCellValue(e.FocusedRowHandle, "MaSach"));
                m_listBookObject.Add("TenSach", grdvListBook.GetRowCellValue(e.FocusedRowHandle, "TenSach"));
                m_listBookObject.Add("TenTL", grdvListBook.GetRowCellValue(e.FocusedRowHandle, "TenTL"));
                m_listBookObject.Add("NhomTG", grdvListBook.GetRowCellValue(e.FocusedRowHandle, "NhomTG"));
                m_listBookObject.Add("TenNXB", grdvListBook.GetRowCellValue(e.FocusedRowHandle, "TenNXB"));
                //m_listBookObject.Add("GiaNhap", grdvListBook.GetRowCellValue(e.FocusedRowHandle, "GiaNhap"));
            }

        }

        private void btnChose_Click(object sender, EventArgs e)
        {
            if (m_listBookObject.Count != 0)
            {
                txtBookId.Text = m_listBookObject["MaSach"].ToString();
                txtBookName.Text = m_listBookObject["TenSach"].ToString();
                txtBookGenre.Text = m_listBookObject["TenTL"].ToString();
                txtPublisherName.Text = m_listBookObject["TenNXB"].ToString();
                txtAuthorName.Text = m_listBookObject["NhomTG"].ToString();
                //txtPrices.Text = m_listBookObject["GiaNhap"].ToString();
                ppControlReceiptNote.HidePopup();
            } 
        }

        private void spQuantity_EditValueChanged(object sender, EventArgs e)
        {
            if (spQuantity.Value.Equals(0) && spPrices.Value.Equals(0))
            {
                spAmount.EditValue = spPrices.Value * spQuantity.Value; 
            }

        }

        private void spPrices_EditValueChanged(object sender, EventArgs e)
        {
            if (spQuantity.Value.Equals(0) && spPrices.Value.Equals(0))
            {
                spAmount.EditValue = spPrices.Value * spQuantity.Value;
            }
        }

        private void spPrices_TextChanged(object sender, EventArgs e)
        {
            try
            {
                spAmount.EditValue = spPrices.Value * spQuantity.Value;
            }
            catch (System.Exception)
            {
            	
            }

        }

        private void spQuantity_TextChanged(object sender, EventArgs e)
        {
            try
            {
                spAmount.EditValue = spPrices.Value * spQuantity.Value;
            }
            catch (System.Exception)
            {

            }
        }

        private void btnAddInListBookDetail_Click(object sender, EventArgs e)
        {
            if (!m_ReceiptNoteDetailExecute.checkQuantityReceipt((int)spQuantity.Value, txtBookId.Text))
            {
                spQuantity.EditValue = 0;
                spQuantity.Focus();
                return;
            }
            DataRow _rowValue = m_ReceiptNoteDetailData.NewRow();
            _rowValue["MaSach"] = txtBookId.Text;
            _rowValue["TenSach"] = txtBookName.Text;
            _rowValue["TenTL"] = txtBookGenre.Text;
            _rowValue["TenNXB"] = txtPublisherName.Text;
            _rowValue["NhomTG"] = txtAuthorName.Text;
            _rowValue["SoLuong"] = spQuantity.Value;
            _rowValue["DonGia"] = spPrices.Value;
            _rowValue["ThanhTien"] = spAmount.Value;
            if (m_ReceiptNoteDetailData.Rows.Count != 0)
            {
                if (m_ReceiptNoteDetailData.Rows.Contains(txtBookId.Text))
                {
                    if (XtraMessageBox.Show("Cuốn sách này đã tồn tại trong danh sách!\nBạn có muốn cập nhật thông tin hay không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning).Equals(DialogResult.Yes))
                    {
                        m_ReceiptNoteDetailData.Rows.Remove(m_ReceiptNoteDetailData.Rows.Find(txtBookId.Text));
                    }
                    else
                        return;
                }
            }
            m_ReceiptNoteDetailData.Rows.Add(_rowValue);
            grdListReceiptBook.DataSource = m_ReceiptNoteDetailData;
            txtBookId.Text = null;
            txtBookName.Text = null;
            txtBookGenre.Text = null;
            txtPublisherName.Text = null;
            txtAuthorName.Text = null;
            spQuantity.Value = 0;
            spPrices.Value = 0;
            spAmount.Value = 0;
            btnAdd.Enabled = true;
            btnDelete.Enabled = true;
        }
        private String _maPhieuNhap;
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (m_ReceiptNoteDetailData.Rows.Count != 0)
            {
                m_ReceiptNoteObject = new CReceiptNoteDTO("PN00000000",
                                                        DateTime.ParseExact(labReceiptDateValue.Text, "dd/MM/yyyy", null),
                                                        "NV0000001",
                                                        int.Parse(grdvReceiptBook.Columns["SoLuong"].SummaryItem.SummaryValue.ToString()),
                                                        int.Parse(grdvReceiptBook.Columns["ThanhTien"].SummaryItem.SummaryValue.ToString()));
                if (m_ReceiptNoteExecute.AddReceiptNoteToDatabase(m_ReceiptNoteObject))
                {
                    _maPhieuNhap = m_ReceiptNoteExecute.getReceiptNoteMaxIdFromDatabase();
                    foreach (DataRow _rowValue in m_ReceiptNoteDetailData.Select())
                    {
                        m_ReceiptNoteDetailObject = new CReceiptNoteDetailDTO();
                        m_ReceiptNoteDetailObject.maPhieuNhap = _maPhieuNhap;
                        m_ReceiptNoteDetailObject.maSach = _rowValue["MaSach"].ToString();
                        m_ReceiptNoteDetailObject.soLuong = int.Parse(_rowValue["SoLuong"].ToString());
                        m_ReceiptNoteDetailObject.thanhTien = int.Parse(_rowValue["ThanhTien"].ToString());
                        m_ReceiptNoteDetailObject.giaNhap = int.Parse(_rowValue["DonGia"].ToString());
                        m_ReceiptNoteDetailExecute.AddReceiptNoteDetailToDatabase(m_ReceiptNoteDetailObject);
                    }
                }
                m_BookData = m_BookExecute.getBookDataFromDatabase();
                grdListBook.DataSource = m_BookData;
            }
            else
            {
                XtraMessageBox.Show("Không có cuốn sách nào được nhập!\nXin vui lòng kiểm tra lại", "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DataRow _rowValue = m_ReceiptNoteDetailData.Rows.Find(txtBookId.Text);
            //_rowValue["MaSach"] = txtBookId.Text;
            _rowValue["TenSach"] = txtBookName.Text;
            _rowValue["TenTL"] = txtBookGenre.Text;
            _rowValue["TenNXB"] = txtPublisherName.Text;
            _rowValue["NhomTG"] = txtAuthorName.Text;
            _rowValue["SoLuong"] = spQuantity.Value;
            _rowValue["DonGia"] = spPrices.Value;
            _rowValue["ThanhTien"] = spAmount.Value;
            //m_ReceiptNoteDetailData.Rows.Remove(m_ReceiptNoteDetailData.Rows.Find(txtBookId.Text));
            //m_ReceiptNoteDetailData.Rows.Add(_rowValue);
            grdListReceiptBook.DataSource = m_ReceiptNoteDetailData;
            //Update value of controls
            txtBookId.Text = null;
            txtBookName.Text = null;
            txtBookGenre.Text = null;
            txtPublisherName.Text = null;
            txtAuthorName.Text = null;
            spQuantity.Value = 0;
            spPrices.Value = 0;
            spAmount.Value = 0;
            drbtnReceiptNoteChose.Enabled = true;
            btnUpdate.Enabled = false;
            btnAdd.Enabled = true;
            btnDelete.Enabled = true;

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            drbtnReceiptNoteChose.Enabled = true;
            txtBookId.Text = null;
            txtBookName.Text = null;
            txtBookGenre.Text = null;
            txtPublisherName.Text = null;
            txtAuthorName.Text = null;
            spQuantity.Value = 0;
            spPrices.Value = 0;
            spAmount.Value = 0;
            btnAdd.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach (DataRowView _rowView in m_ReceiptNoteDetailMultiselect.Selection)
            {
                m_ReceiptNoteDetailData.Rows.Remove(_rowView.Row);
            }
            m_ReceiptNoteDetailMultiselect.ClearSelection();
        }

        private void grdvReceiptBook_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            //if (e.FocusedRowHandle >= 0)
            //{
            //    txtBookId.Text = grdvReceiptBook.GetRowCellValue(e.FocusedRowHandle, "MaSach").ToString();
            //    txtBookName.Text = grdvReceiptBook.GetRowCellValue(e.FocusedRowHandle, "TenSach").ToString();
            //    txtBookGenre.Text = grdvReceiptBook.GetRowCellValue(e.FocusedRowHandle, "TenTL").ToString();
            //    txtAuthorName.Text = grdvReceiptBook.GetRowCellValue(e.FocusedRowHandle, "NhomTG").ToString();
            //    txtPublisherName.Text = grdvReceiptBook.GetRowCellValue(e.FocusedRowHandle, "TenNXB").ToString();
            //    spQuantity.EditValue = grdvReceiptBook.GetRowCellValue(e.FocusedRowHandle, "SoLuong").ToString();
            //    spPrices.EditValue = grdvReceiptBook.GetRowCellValue(e.FocusedRowHandle, "DonGia").ToString();
            //    spAmount.EditValue = grdvReceiptBook.GetRowCellValue(e.FocusedRowHandle, "ThanhTien").ToString();
            //}
        }

        private void grdvReceiptBook_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            if (e.RowHandle >= 0)
            {
                txtBookId.Text = grdvReceiptBook.GetRowCellValue(e.RowHandle, "MaSach").ToString();
                txtBookName.Text = grdvReceiptBook.GetRowCellValue(e.RowHandle, "TenSach").ToString();
                txtBookGenre.Text = grdvReceiptBook.GetRowCellValue(e.RowHandle, "TenTL").ToString();
                txtAuthorName.Text = grdvReceiptBook.GetRowCellValue(e.RowHandle, "NhomTG").ToString();
                txtPublisherName.Text = grdvReceiptBook.GetRowCellValue(e.RowHandle, "TenNXB").ToString();
                spQuantity.EditValue = grdvReceiptBook.GetRowCellValue(e.RowHandle, "SoLuong").ToString();
                spPrices.EditValue = grdvReceiptBook.GetRowCellValue(e.RowHandle, "DonGia").ToString();
                spAmount.EditValue = grdvReceiptBook.GetRowCellValue(e.RowHandle, "ThanhTien").ToString();
            }
            drbtnReceiptNoteChose.Enabled = false;
            spQuantity.Focus();
            btnAdd.Enabled = false;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = true;
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            //
            frmReceiptNoteReport m_deliveryReportForm = new frmReceiptNoteReport(m_ReceiptNoteDetailData,
                                        _maPhieuNhap,
                                        decimal.Parse(grdvReceiptBook.Columns["SoLuong"].SummaryItem.SummaryValue.ToString()),
                                        decimal.Parse(grdvReceiptBook.Columns["ThanhTien"].SummaryItem.SummaryValue.ToString()));
            m_deliveryReportForm.ShowDialog();
        }

        private void spQuantity_Validated(object sender, EventArgs e)
        {

        }



    }
}
