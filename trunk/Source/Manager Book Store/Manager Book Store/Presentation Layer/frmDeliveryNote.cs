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
using DevExpress.XtraBars;

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
            if (!m_DeliveryNoteDetailExecute.checkSurvivalQuantity(m_listBookObject["MaSach"].ToString()))
                choseBookAddDelivery();
        }
        private void grdvListBook_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            if(!m_DeliveryNoteDetailExecute.checkSurvivalQuantity(grdvListBook.GetRowCellValue(e.RowHandle, "MaSach").ToString()))
                choseBookAddDelivery();
        }


        private void choseBookAddDelivery()
        {
            try
            {
                if (m_listBookObject.Count != 0)
                {
                    txtBookId.Text = m_listBookObject["MaSach"].ToString();
                    txtBookName.Text = m_listBookObject["TenSach"].ToString();
                    txtBookGenre.Text = m_listBookObject["TenTL"].ToString();
                    txtPublisherName.Text = m_listBookObject["TenNXB"].ToString();
                    txtAuthorName.Text = m_listBookObject["NhomTG"].ToString();
                    lblSoLuongMax.Text = "Số lượng <= " + m_DeliveryNoteDetailExecute.getCountBookMaxCanSale(txtBookId.Text);
                    lblSoLuongMax.ForeColor = Color.Red;
                    spPrices.EditValue = m_DeliveryNoteDetailExecute.convertPrice(decimal.Parse(m_listBookObject["GiaNhap"].ToString()));
                    ppControlDeliveryNote.HidePopup();
                }
            }
            catch (System.Exception) { }
            finally
            {
                updateEnableButtonAndResetValueOfControl(ref btnChose);
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
            if (lkCustomerName.Text == "")
            {
                XtraCustomMessageBox.Show("Thông tin khách hàng khồng thể để trống!", "Lỗi", true);
                lkCustomerName.Focus();
                return;
            }
            if (spQuantity.Value == 0)
            {
                XtraCustomMessageBox.Show("Số lượng bán phải lớn hơn 0", "Lỗi", true);
                spQuantity.Focus();
                return;
            }
            try
            {
                if (m_DeliveryNoteDetailExecute.checkQuantityDelivery((int)spQuantity.Value, txtBookId.Text))
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
                    updateEnableButtonAndResetValueOfControl(ref btnAddInListBookDetail);
                }
            }
            catch (System.Exception) { }    
        }

        private  String _soHoaDon;

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            updateEnableButtonAndResetValueOfControl(ref btnUpdate);
        }

        private bool m_Saved = false;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (m_DeliveryNoteDetailData.Rows.Count != 0)
            {
                if (!m_Saved)
                {
                    if (XtraCustomMessageBox.Show("Dữ liệu chưa được lưu!\nBạn có muốn lưu dữ liệu trước khi tạo mới hay không?", "Thông báo", false) == DialogResult.Yes)
                    {
                        btnWrite_Click(null, null);
                    }
                }
                m_DeliveryNoteDetailData.Rows.Clear();
                grdListDeliveryBook.DataSource = m_DeliveryNoteDetailData;
            }
            updateEnableButtonAndResetValueOfControl(ref btnAdd);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach (DataRowView _rowView in m_DeliveryNoteDetailMultiselect.Selection)
            {
                m_DeliveryNoteDetailData.Rows.Remove(_rowView.Row);
            }
            if (m_DeliveryNoteDetailData.Rows.Count == 0)
            {
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
            }
            m_DeliveryNoteDetailMultiselect.ClearSelection();
        }

        private void grdvDeliveryBook_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (e.FocusedRowHandle >= 0)
            {
                txtBookId.Text = grdvDeliveryBook.GetRowCellValue(e.FocusedRowHandle, "MaSach").ToString();
                txtBookName.Text = grdvDeliveryBook.GetRowCellValue(e.FocusedRowHandle, "TenSach").ToString();
                txtBookGenre.Text = grdvDeliveryBook.GetRowCellValue(e.FocusedRowHandle, "TenTL").ToString();
                txtAuthorName.Text = grdvDeliveryBook.GetRowCellValue(e.FocusedRowHandle, "NhomTG").ToString();
                txtPublisherName.Text = grdvDeliveryBook.GetRowCellValue(e.FocusedRowHandle, "TenNXB").ToString();
                spQuantity.EditValue = grdvDeliveryBook.GetRowCellValue(e.FocusedRowHandle, "SoLuong").ToString();
                spPrices.EditValue = grdvDeliveryBook.GetRowCellValue(e.FocusedRowHandle, "DonGia").ToString();
                spAmount.EditValue = grdvDeliveryBook.GetRowCellValue(e.FocusedRowHandle, "ThanhTien").ToString();
            }
            else
                {
                    txtBookId.Text = null;
                    txtBookName.Text = null;
                    txtBookGenre.Text = null;
                    txtAuthorName.Text = null;
                    txtPublisherName.Text = null;
                    spQuantity.EditValue = 0;
                    spPrices.EditValue = 0;
                    spAmount.EditValue = 0;
                }
        }

        private void btnCashReceiptVoucher_Click(object sender, EventArgs e)
        {
            try
            {
                m_enableCashReceiptVoucher = false;
                frmCashReceiptVoucher _frmCashDeliveryVoucher = new frmCashReceiptVoucher(lkCustomerName.EditValue.ToString(),
                                               decimal.Parse(grdvDeliveryBook.Columns["ThanhTien"].SummaryItem.SummaryValue.ToString()));
                _frmCashDeliveryVoucher.ShowDialog();
            }
            catch (System.Exception) { }

        }

        private void btnView_Click(object sender, EventArgs e)
        {
            try
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
                m_deliveryReportForm.ShowDialog();
            }
            catch (System.Exception)
            {
            	
            }

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

        private bool m_enableCashReceiptVoucher = false;

        private void updateEnableButtonAndResetValueOfControl(ref SimpleButton _btnControl)
        {
            switch (_btnControl.Name)
            {
                case "btnAddInListBookDetail":
                    {
                        btnDelete.Enabled = true;
                        btnUpdate.Enabled = true;
                        btnAddInListBookDetail.Enabled = false;
                        //
                        spPrices.Properties.ReadOnly = true;
                        spQuantity.Properties.ReadOnly = true;
                        break;
                    }
                case "btnAdd":
                    {
                        txtDeliveryNoteId.Text = "HD00000**";
                        txtBookId.Text = null;
                        txtBookName.Text = null;
                        txtBookGenre.Text = null;
                        txtPublisherName.Text = null;
                        txtAuthorName.Text = null;
                        //
                        spQuantity.Value = 0;
                        spPrices.Value = 0;
                        spAmount.Value = 0;
                        //
                        drbtnDeliveryNoteChose.Enabled = true;
                        btnUpdate.Enabled = false;
                        btnDelete.Enabled = false;
                        btnView.Enabled = false;
                        btnWrite.Enabled = true;
                        btnCashReceiptVoucher.Enabled = false;
                        //
                        btnCancel.Visible = true;
                        btnAdd.Visible = false;
                        //
                        break;
                    }
                case "btnCancel":
                    {
                        txtDeliveryNoteId.Text = "HD00000**";
                        txtBookId.Text = null;
                        txtBookName.Text = null;
                        txtBookGenre.Text = null;
                        txtPublisherName.Text = null;
                        txtAuthorName.Text = null;
                        //
                        spQuantity.Value = 0;
                        spPrices.Value = 0;
                        spAmount.Value = 0;
                        //
                        btnCancel.Visible = false;
                        btnAdd.Visible = true;
                        btnWrite.Enabled = false;
                        btnUpdate.Enabled = false;
                        btnDelete.Enabled = false;
                        btnAddInListBookDetail.Enabled = true;
                        //
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
                        drbtnDeliveryNoteChose.Enabled = true;
                        btnUpdate.Enabled = true;
                        btnDelete.Enabled = true;
                        btnAdd.Enabled = true;
                        btnSave.Enabled = false;
                        spPrices.Properties.ReadOnly = true;
                        spQuantity.Properties.ReadOnly = true;
                        //
                        grdvDeliveryBook.OptionsSelection.EnableAppearanceFocusedRow = true;
                        grdvDeliveryBook.Columns["CheckMarkSelection"].OptionsColumn.AllowEdit = true;

                        break;
                    }
                case "btnDelete":
                    {
                        break;
                    }
                case "btnChose":
                    {
                        spQuantity.Properties.ReadOnly = false;
                        btnAddInListBookDetail.Enabled = true;
                        spQuantity.EditValue = 0;
                        break;
                    }
                case "btnUpdate":
                    {

                        spQuantity.Properties.ReadOnly = false;
                        //
                        btnSave.Enabled = true;
                        btnDelete.Enabled = false;
                        btnAddInListBookDetail.Enabled = false;
                        drbtnDeliveryNoteChose.Enabled = false;
                        //
                        btnUpdate.Visible = false;
                        btnCancelOfUpdate.Visible = true;
                        //
                        grdvDeliveryBook.OptionsSelection.EnableAppearanceFocusedRow = false;
                        grdvDeliveryBook.Columns["CheckMarkSelection"].OptionsColumn.AllowEdit = false;
                        m_DeliveryNoteDetailMultiselect.ClearSelection();
                        break;
                    }
                case "btnSave":
                    {

                        btnCancelOfUpdate.Visible = false;  
                        btnUpdate.Visible = true;
                        //
                        drbtnDeliveryNoteChose.Enabled = true;
                        btnSave.Enabled = false;
                        btnUpdate.Enabled = true;
                        btnDelete.Enabled = true;
                        btnAddInListBookDetail.Enabled = true;
                        //
                        spPrices.Properties.ReadOnly = true;
                        spQuantity.Properties.ReadOnly = true;
                        //
                        grdvDeliveryBook.OptionsSelection.EnableAppearanceFocusedRow = true;
                        grdvDeliveryBook.Columns["CheckMarkSelection"].OptionsColumn.AllowEdit = true;
                        break;
                    }
                case "btnWrite":
                    {
                        m_BookData = m_BookExecute.getBookDataFromDatabase();
                        grdListBook.DataSource = m_BookData;
                        btnView.Enabled = true;
                        btnCashReceiptVoucher.Enabled = true;
                        btnWrite.Enabled = false;
                        btnAdd.Visible = true;
                        btnCancel.Visible = false;
                        m_Saved = true;
                        break;
                    }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
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
                updateEnableButtonAndResetValueOfControl(ref btnSave);
            }
            catch (System.Exception)
            {

            }

        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            try
            {
                if (m_DeliveryNoteDetailData.Rows.Count != 0)
                {
                    m_DeliveryNoteObject = new CDeliveryNoteDTO("HD00000000", lkCustomerName.EditValue.ToString(),
                        DateTime.ParseExact(labDeliveryDateValue.Text, "dd/MM/yyyy", null), ucLogin.m_EmployeeObject.maNhanVien,
                        int.Parse(grdvDeliveryBook.Columns["SoLuong"].SummaryItem.SummaryValue.ToString()),
                        int.Parse(grdvDeliveryBook.Columns["ThanhTien"].SummaryItem.SummaryValue.ToString()));
                    _soHoaDon = m_DeliveryNoteExecute.getDeliveryNoteMaxIdFromDatabase();
                    if (m_DeliveryNoteExecute.AddDeliveryNoteToDatabase(m_DeliveryNoteObject))
                    {
                        foreach (DataRow _rowValue in m_DeliveryNoteDetailData.Select())
                        {
                            m_DeliveryNoteDetailObject = new CDeliveryNoteDetailDTO();
                            m_DeliveryNoteDetailObject.soHoaDon = _soHoaDon;
                            m_DeliveryNoteDetailObject.maSach = _rowValue["MaSach"].ToString();
                            m_DeliveryNoteDetailObject.soLuong = int.Parse(_rowValue["SoLuong"].ToString());
                            m_DeliveryNoteDetailObject.thanhTien = int.Parse(_rowValue["ThanhTien"].ToString());
                            m_DeliveryNoteDetailObject.giaBan = int.Parse(_rowValue["DonGia"].ToString());
                            m_DeliveryNoteDetailExecute.AddDeliveryNoteDetailToDatabase(m_DeliveryNoteDetailObject);
                        }
                    }
                    updateEnableButtonAndResetValueOfControl(ref btnWrite);
                    m_enableCashReceiptVoucher = true;
                    XtraCustomMessageBox.Show("Ghi dữ liệu thành công!", "Thông báo", true);

                }
                else
                {
                    XtraCustomMessageBox.Show("Không có cuốn sách nào được bán!\nXin vui lòng kiểm tra lại",
                                        "Thông báo",
                                        true);
                }
            }
            catch (System.Exception)
            {
                XtraCustomMessageBox.Show("Không thể ghi dữ liệu!", "Lỗi", true);
            }
        }

        private void btnCancelOfUpdate_Click(object sender, EventArgs e)
        {
            updateEnableButtonAndResetValueOfControl(ref btnCancelOfUpdate);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (m_DeliveryNoteDetailData.Rows.Count != 0)
            {
                if (XtraCustomMessageBox.Show("Bạn có muốn hủy bỏ hóa đơn này hay không?", "Thông báo", false) == DialogResult.Yes)
                {
                    updateEnableButtonAndResetValueOfControl(ref btnCancel);
                    m_DeliveryNoteDetailData.Clear();
                }

            }
        }

        private void frmDeliveryNote_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (m_enableCashReceiptVoucher)
            {
                XtraCustomMessageBox.Show("Bạn chưa lập phiếu thu tiền!\nXin vui lòng lập phiếu thu trước khi thoát!", "Thông", true);
                e.Cancel = true;
            }

        }

        public delegate void m_setFormObject(object sender, ItemClickEventArgs e);

        public m_setFormObject setFormObject;

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            setFormObject(null, null);
        }

        private void lkCustomerName_QueryPopUp(object sender, CancelEventArgs e)
        {
            m_CustomerData = m_CustomerExecute.getCustomerDataFromDatabase();
            lkCustomerName.Properties.DataSource = m_CustomerData;
        }

        private void grdvListBook_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            if(e.RowHandle >= 0)
            {
                string strBookId = grdvListBook.GetRowCellValue(e.RowHandle, "MaSach").ToString();
                if (m_DeliveryNoteDetailExecute.setColorBackgroundRow(strBookId) == 0)
                    e.Appearance.BackColor = Color.Salmon;
                else    
                    if (m_DeliveryNoteDetailExecute.setColorBackgroundRow(strBookId) == 1)
                        e.Appearance.BackColor = Color.Khaki;
            }
        }

       
    }
}
