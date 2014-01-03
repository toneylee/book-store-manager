using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Manager_Book_Store.Business_Layer;
using Manager_Book_Store.Data_Tranfer_Object;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Selection;
using Manager_Book_Store.Report;

namespace Manager_Book_Store.Presentation_Layer
{
    public partial class frmDeliveryNote : Form
    {
         #region "Variable"
        private CBookBUS m_BookExecute;
        private DataTable m_BookData;
        private CDeliveryNoteBUS m_DeliveryNoteExecute;
        private CDeliveryNoteDTO m_DeliveryNoteObject;
        private DataTable m_DeliveryNoteData;
        private CDeliveryNoteDetailBUS m_DeliveryNoteDetailExecute;
        private CDeliveryNoteDetailDTO m_DeliveryNoteDetailObject;
        private DataTable m_DeliveryNoteDetailData;
        private GridCheckMarksSelection m_DeliveryNoteDetailMultiselect;
        private DataTable m_CustomerData;
        private CCustomerBUS m_CustomerExecute;
        #endregion
        public frmDeliveryNote()
        {
            InitializeComponent();
            m_BookData              = new DataTable();
            m_BookExecute           = new CBookBUS();
            m_DeliveryNoteData       = new DataTable();
            m_DeliveryNoteDetailData = new DataTable();
            m_DeliveryNoteExecute    = new CDeliveryNoteBUS();
            m_DeliveryNoteDetailExecute = new CDeliveryNoteDetailBUS();
            m_CustomerData = new DataTable();
            m_CustomerExecute = new CCustomerBUS();
            m_DeliveryNoteDetailMultiselect = new GridCheckMarksSelection(grdvDeliveryBook);
            DeliveryNoteId.VisibleIndex = 1;
            //DateTime.Compare//
            labDeliveryDateValue.Text = DateTime.Now.ToString("dd/MM/yyyy");
            txtDeliveryNoteId.Text = m_DeliveryNoteExecute.getDeliveryNoteMaxIdFromDatabase();

        }

        private void frmDeliveryNote_Load(object sender, EventArgs e)
        {
            m_CustomerData = m_CustomerExecute.getCustomerDataFromDatabase();
            lkCustomerName.Properties.DataSource = m_CustomerData;
            lkCustomerName.Properties.DisplayMember = "TenKH";
            lkCustomerName.Properties.ValueMember = "MaKH";
            //
            m_BookData = m_BookExecute.getBookDataFromDatabase();
            grdListBook.DataSource = m_BookData;
            //
            m_DeliveryNoteDetailData = m_DeliveryNoteDetailExecute.getDeliveryNoteDetailDataFromDatabase();
            m_DeliveryNoteDetailData.Clear();
            DataColumn[] keys = new DataColumn[1];
            keys[0] = m_DeliveryNoteDetailData.Columns["MaSach"];
            m_DeliveryNoteDetailData.PrimaryKey = keys;
        }

        private void grdvDeliveryBook_CustomDrawFooterCell(object sender, DevExpress.XtraGrid.Views.Grid.FooterCellCustomDrawEventArgs e)
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

        private void drbtnDeliveryNoteChose_Click(object sender, EventArgs e)
        {
            drbtnDeliveryNoteChose.ShowDropDown();
            //drbtnDeliveryNoteChose.HideDropDown();
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
                m_listBookObject.Add("GiaNhap", grdvListBook.GetRowCellValue(e.FocusedRowHandle, "GiaNhap"));
                m_listBookObject.Add("SoLuong", grdvListBook.GetRowCellValue(e.FocusedRowHandle, "SoLuong"));
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
                spPrices.EditValue = m_DeliveryNoteDetailExecute.convertPrice(decimal.Parse(m_listBookObject["GiaNhap"].ToString()));
                ppControlDeliveryNote.HidePopup();
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
            if(m_DeliveryNoteDetailExecute.checkQuantityDelivery((int)spQuantity.Value,txtBookId.Text))
            {
               DataRow _rowValue = m_DeliveryNoteDetailData.NewRow();
            _rowValue["MaSach"] = txtBookId.Text;
            _rowValue["TenSach"] = txtBookName.Text;
            _rowValue["TenTL"] = txtBookGenre.Text;
            _rowValue["TenNXB"] = txtPublisherName.Text;
            _rowValue["NhomTG"] = txtAuthorName.Text;
            _rowValue["SoLuong"] = spQuantity.Value;
            _rowValue["DonGia"] = spPrices.Value;
            _rowValue["ThanhTien"] = spAmount.Value;
            if (m_DeliveryNoteDetailData.Rows.Count != 0)
            {
                if (m_DeliveryNoteDetailData.Rows.Contains(txtBookId.Text))
                {
                    if (XtraMessageBox.Show("Cuốn sách này đã tồn tại trong danh sách!\nBạn có muốn cập nhật thông tin hay không?",
                                            "Thông báo",
                                            MessageBoxButtons.YesNo,
                                            MessageBoxIcon.Warning).Equals(DialogResult.Yes))
                    {
                        m_DeliveryNoteDetailData.Rows.Remove(m_DeliveryNoteDetailData.Rows.Find(txtBookId.Text));
                    }
                    else
                        return;
                }
            }
            m_DeliveryNoteDetailData.Rows.Add(_rowValue);
            grdListDeliveryBook.DataSource = m_DeliveryNoteDetailData;
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
            
        }

        private  String _soHoaDon;

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (m_DeliveryNoteDetailData.Rows.Count != 0)
            {
                m_DeliveryNoteObject = new CDeliveryNoteDTO("HD00000000",lkCustomerName.EditValue.ToString(),
                    DateTime.ParseExact(labDeliveryDateValue.Text,"dd/MM/yyyy",null), "NV0000001", 
                    int.Parse(grdvDeliveryBook.Columns["SoLuong"].SummaryItem.SummaryValue.ToString()),
                    int.Parse(grdvDeliveryBook.Columns["ThanhTien"].SummaryItem.SummaryValue.ToString()));
                _soHoaDon = m_DeliveryNoteExecute.getDeliveryNoteMaxIdFromDatabase();
                if (m_DeliveryNoteExecute.AddDeliveryNoteToDatabase(m_DeliveryNoteObject))
                {
                    foreach (DataRow _rowValue in m_DeliveryNoteDetailData.Select())
                    {
                        m_DeliveryNoteDetailObject = new CDeliveryNoteDetailDTO();
                        m_DeliveryNoteDetailObject.soHoaDon = _soHoaDon;
                        m_DeliveryNoteDetailObject.maSach =   _rowValue["MaSach"].ToString();
                        m_DeliveryNoteDetailObject.soLuong =  int.Parse(_rowValue["SoLuong"].ToString());
                        m_DeliveryNoteDetailObject.thanhTien = int.Parse(_rowValue["ThanhTien"].ToString());
                        m_DeliveryNoteDetailObject.giaBan = int.Parse(_rowValue["DonGia"].ToString());
                        m_DeliveryNoteDetailExecute.AddDeliveryNoteDetailToDatabase(m_DeliveryNoteDetailObject);
                    }
                }

            }
            else
            {
                XtraMessageBox.Show("Không có cuốn sách nào được bán!\nXin vui lòng kiểm tra lại",
                                    "Thông báo",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DataRow _rowValue = m_DeliveryNoteDetailData.Rows.Find(txtBookId.Text);
            //_rowValue["MaSach"] = txtBookId.Text;
            _rowValue["TenSach"] = txtBookName.Text;
            _rowValue["TenTL"] = txtBookGenre.Text;
            _rowValue["TenNXB"] = txtPublisherName.Text;
            _rowValue["NhomTG"] = txtAuthorName.Text;
            _rowValue["SoLuong"] = spQuantity.Value;
            _rowValue["DonGia"] = spPrices.Value;
            _rowValue["ThanhTien"] = spAmount.Value;
            //m_DeliveryNoteDetailData.Rows.Remove(m_DeliveryNoteDetailData.Rows.Find(txtBookId.Text));
            //m_DeliveryNoteDetailData.Rows.Add(_rowValue);
            grdListDeliveryBook.DataSource = m_DeliveryNoteDetailData;
            //Update value of controls
            txtBookId.Text = null;
            txtBookName.Text = null;
            txtBookGenre.Text = null;
            txtPublisherName.Text = null;
            txtAuthorName.Text = null;
            spQuantity.Value = 0;
            spPrices.Value = 0;
            spAmount.Value = 0;
            drbtnDeliveryNoteChose.Enabled = true;
            btnUpdate.Enabled = false;
            btnAdd.Enabled = true;
            btnDelete.Enabled = true;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            drbtnDeliveryNoteChose.Enabled = true;
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
            foreach (DataRowView _rowView in m_DeliveryNoteDetailMultiselect.Selection)
            {
                m_DeliveryNoteDetailData.Rows.Remove(_rowView.Row);
            }
            m_DeliveryNoteDetailMultiselect.ClearSelection();
        }

        private void grdvDeliveryBook_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            //if (e.FocusedRowHandle >= 0)
            //{
            //    txtBookId.Text = grdvDeliveryBook.GetRowCellValue(e.FocusedRowHandle, "MaSach").ToString();
            //    txtBookName.Text = grdvDeliveryBook.GetRowCellValue(e.FocusedRowHandle, "TenSach").ToString();
            //    txtBookGenre.Text = grdvDeliveryBook.GetRowCellValue(e.FocusedRowHandle, "TenTL").ToString();
            //    txtAuthorName.Text = grdvDeliveryBook.GetRowCellValue(e.FocusedRowHandle, "NhomTG").ToString();
            //    txtPublisherName.Text = grdvDeliveryBook.GetRowCellValue(e.FocusedRowHandle, "TenNXB").ToString();
            //    spQuantity.EditValue = grdvDeliveryBook.GetRowCellValue(e.FocusedRowHandle, "SoLuong").ToString();
            //    spPrices.EditValue = grdvDeliveryBook.GetRowCellValue(e.FocusedRowHandle, "DonGia").ToString();
            //    spAmount.EditValue = grdvDeliveryBook.GetRowCellValue(e.FocusedRowHandle, "ThanhTien").ToString();
            //}
        }

        private void grdvDeliveryBook_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            if (e.RowHandle >= 0)
            {
                txtBookId.Text = grdvDeliveryBook.GetRowCellValue(e.RowHandle, "MaSach").ToString();
                txtBookName.Text = grdvDeliveryBook.GetRowCellValue(e.RowHandle, "TenSach").ToString();
                txtBookGenre.Text = grdvDeliveryBook.GetRowCellValue(e.RowHandle, "TenTL").ToString();
                txtAuthorName.Text = grdvDeliveryBook.GetRowCellValue(e.RowHandle, "NhomTG").ToString();
                txtPublisherName.Text = grdvDeliveryBook.GetRowCellValue(e.RowHandle, "TenNXB").ToString();
                spQuantity.EditValue = grdvDeliveryBook.GetRowCellValue(e.RowHandle, "SoLuong").ToString();
                spPrices.EditValue = grdvDeliveryBook.GetRowCellValue(e.RowHandle, "DonGia").ToString();
                spAmount.EditValue = grdvDeliveryBook.GetRowCellValue(e.RowHandle, "ThanhTien").ToString();
            }
            drbtnDeliveryNoteChose.Enabled = false;
            spQuantity.Focus();
            btnAdd.Enabled = false;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = true;
        }

        private void spPayment_TextChanged(object sender, EventArgs e)
        {
            //spExcessCash.EditValue = decimal.Parse(grdvDeliveryBook.Columns["ThanhTien"].SummaryItem.SummaryValue.ToString()) - spPayment.Value;
        }

        private void btnCashReceiptVoucher_Click(object sender, EventArgs e)
        {
            frmCashReceiptVoucher _frmCashReceiptVoucher = new frmCashReceiptVoucher(lkCustomerName.EditValue.ToString(),
                                                           decimal.Parse(grdvDeliveryBook.Columns["ThanhTien"].SummaryItem.SummaryValue.ToString()));
            _frmCashReceiptVoucher.ShowDialog();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            CCustomerDTO _CustomerObject = new CCustomerDTO();
            DataRowView _rowValue = lkCustomerName.Properties.GetDataSourceRowByKeyValue(lkCustomerName.EditValue) as DataRowView;
            _CustomerObject.tenKhachHang = _rowValue["TenKH"].ToString();
            _CustomerObject.diaChi = _rowValue["DiaChi"].ToString();
            _CustomerObject.Email = _rowValue["Email"].ToString();
            _CustomerObject.soDienThoai = _rowValue["SoDienThoai"].ToString();
            //
            frmDeliveryReport m_deliveryReportForm = new frmDeliveryReport(m_DeliveryNoteDetailData,
                                        _CustomerObject,
                                        _soHoaDon,
                                        decimal.Parse(grdvDeliveryBook.Columns["SoLuong"].SummaryItem.SummaryValue.ToString()),
                                        decimal.Parse(grdvDeliveryBook.Columns["ThanhTien"].SummaryItem.SummaryValue.ToString()));
            //frmDeliveryReport.getAndSetData(m_DeliveryNoteDetailData,
            //                            _CustomerObject,
            //                            _soHoaDon,
            //                            int.Parse(grdvDeliveryBook.Columns["SoLuong"].SummaryItem.SummaryValue.ToString()),
            //                            int.Parse(grdvDeliveryBook.Columns["ThanhTien"].SummaryItem.SummaryValue.ToString()));
            m_deliveryReportForm.ShowDialog();
        }

        private void lkCustomerName_EditValueChanged(object sender, EventArgs e)
        {
            if (!m_DeliveryNoteDetailExecute.checkCustomerDebits(lkCustomerName.EditValue.ToString()))
            {
                lkCustomerName.EditValue = null;
                XtraMessageBox.Show("Khách hàng này không đủ điều kiện để mua hàng !\nXin vui lòng kiểm tra lại !");
                lkCustomerName.Focus();
            }
        }


    }
}
