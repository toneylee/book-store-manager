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
using DevExpress.XtraBars;

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
            m_BookData = m_BookExecute.getBookDataFromDatabase();
            grdListBook.DataSource = m_BookData;
            drbtnReceiptNoteChose.ShowDropDown();
            //drbtnReceiptNoteChose.HideDropDown();
        }

        Dictionary<String, Object> m_listBookObject = new Dictionary<String, Object>();

        private void grdvListBook_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
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
            catch (System.Exception)
            {
            	
            }


        }

        private void btnChose_Click(object sender, EventArgs e)
        {
            if (m_ReceiptNoteDetailExecute.checkSurvivalQuantity(m_listBookObject["MaSach"].ToString()))
                chooseBookAddInReceiptNote();
            else
            {
                drbtnReceiptNoteChose.HideDropDown();
                XtraCustomMessageBox.Show("Không thể nhập thêm sách này.\nSố lượng tồn nhiều hơn số lượng quy định.", "Thông báo", true);
            }
        }
        private void grdvListBook_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            if (m_ReceiptNoteDetailExecute.checkSurvivalQuantity(grdvListBook.GetRowCellValue(e.RowHandle, "MaSach").ToString()))
                chooseBookAddInReceiptNote();
            else
            {
                drbtnReceiptNoteChose.HideDropDown();
                XtraCustomMessageBox.Show("Không thể nhập thêm sách này.\nSố lượng sách tồn nhiều hơn số lượng quy định.", "Thông báo", true);
            }
        }

        private void chooseBookAddInReceiptNote()
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
                    //txtPrices.Text = m_listBookObject["GiaNhap"].ToString();
                    lblSoLuongMax.Text = "Số lượng >= " + m_ReceiptNoteDetailExecute.getRegulationByConsider("SoLuongNhapToiThieu");
                    //spQuantity.Properties.MaxValue = m_ReceiptNoteDetailExecute.getRegulationByConsider("SoLuongNhapToiThieu");
                    ppControlReceiptNote.HidePopup();

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
            if (spPrices.Value == 0)
            {
                XtraCustomMessageBox.Show("Giá nhập không hợp lệ!", "Lỗi", true);
                spPrices.Focus();
                return;
            }
            if (!m_ReceiptNoteDetailExecute.checkQuantityReceipt((int)spQuantity.Value, txtBookId.Text))
            {
                spQuantity.EditValue = 0;
                spQuantity.Focus();
                return;
            }
            try
            {
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
                        if (XtraCustomMessageBox.Show("Cuốn sách này đã tồn tại trong danh sách!\nBạn có muốn cập nhật thông tin hay không?", "Thông báo",false).Equals(DialogResult.Yes))
                        {
                            m_ReceiptNoteDetailData.Rows.Remove(m_ReceiptNoteDetailData.Rows.Find(txtBookId.Text));
                        }
                        else
                            return;
                    }
                }
                m_ReceiptNoteDetailData.Rows.Add(_rowValue);
                grdListReceiptBook.DataSource = m_ReceiptNoteDetailData;
            }
            catch (System.Exception)
            {
            	
            }
            finally
            {
                updateEnableButtonAndResetValueOfControl(ref btnAddInListBookDetail);
            }

        }

        private String _maPhieuNhap;

        private void btnWrite_Click(object sender, EventArgs e)
        {
            try
            {
                if (m_ReceiptNoteDetailData.Rows.Count != 0)
                {
                    m_ReceiptNoteObject = new CReceiptNoteDTO("PN00000000",
                                                            DateTime.ParseExact(labReceiptDateValue.Text, "dd/MM/yyyy", null),
                                                            ucLogin.m_EmployeeObject.maNhanVien,
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
                    updateEnableButtonAndResetValueOfControl(ref btnWrite);
                    XtraCustomMessageBox.Show("Ghi dữ liệu thành công!", "Thông báo", true);
                }
                else
                {
                    XtraCustomMessageBox.Show("Không có cuốn sách nào được nhập!\nXin vui lòng kiểm tra lại", "Thông báo", true);
                }
            }
            catch (System.Exception)
            {
                XtraCustomMessageBox.Show("Không thể ghi dữ liệu!", "Lỗi", true);
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            updateEnableButtonAndResetValueOfControl(ref btnUpdate);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (m_ReceiptNoteDetailData.Rows.Count != 0)
            {
                if (!m_Saved)
                {
                    if (XtraCustomMessageBox.Show("Dữ liệu chưa được lưu!\nBạn có muốn lưu dữ liệu trước khi tạo mới hay không?", "Thông báo", false) == DialogResult.Yes)
                    {
                        btnWrite_Click(null, null);
                    }
                }
                m_ReceiptNoteDetailData.Rows.Clear();
                grdListReceiptBook.DataSource = m_ReceiptNoteDetailData;
            }
            updateEnableButtonAndResetValueOfControl(ref btnAdd);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach (DataRowView _rowView in m_ReceiptNoteDetailMultiselect.Selection)
            {
                m_ReceiptNoteDetailData.Rows.Remove(_rowView.Row);
            }
            if (m_ReceiptNoteDetailData.Rows.Count == 0)
            {
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
            }
            m_ReceiptNoteDetailMultiselect.ClearSelection();
        }

        private void grdvReceiptBook_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                if (e.FocusedRowHandle >= 0)
                {
                    txtBookId.Text = grdvReceiptBook.GetRowCellValue(e.FocusedRowHandle, "MaSach").ToString();
                    txtBookName.Text = grdvReceiptBook.GetRowCellValue(e.FocusedRowHandle, "TenSach").ToString();
                    txtBookGenre.Text = grdvReceiptBook.GetRowCellValue(e.FocusedRowHandle, "TenTL").ToString();
                    txtAuthorName.Text = grdvReceiptBook.GetRowCellValue(e.FocusedRowHandle, "NhomTG").ToString();
                    txtPublisherName.Text = grdvReceiptBook.GetRowCellValue(e.FocusedRowHandle, "TenNXB").ToString();
                    spQuantity.EditValue = grdvReceiptBook.GetRowCellValue(e.FocusedRowHandle, "SoLuong").ToString();
                    spPrices.EditValue = grdvReceiptBook.GetRowCellValue(e.FocusedRowHandle, "DonGia").ToString();
                    spAmount.EditValue = grdvReceiptBook.GetRowCellValue(e.FocusedRowHandle, "ThanhTien").ToString();
                }
                else
                {
                    txtBookId.Text = null;
                    txtBookName.Text = null;
                    txtBookGenre.Text = null;
                    txtAuthorName.Text = null;
                    txtPublisherName.Text = null;
                    spQuantity.EditValue = null;
                    spPrices.EditValue = null;
                    spAmount.EditValue = null;
                }
            }
            catch (System.Exception)
            {
            	
            }

        }

        private void btnView_Click(object sender, EventArgs e)
        {
            frmReceiptNoteReport m_deliveryReportForm = new frmReceiptNoteReport(m_ReceiptNoteDetailData,
                                        _maPhieuNhap,
                                        decimal.Parse(grdvReceiptBook.Columns["SoLuong"].SummaryItem.SummaryValue.ToString()),
                                        decimal.Parse(grdvReceiptBook.Columns["ThanhTien"].SummaryItem.SummaryValue.ToString()));
            m_deliveryReportForm.ShowDialog();
        }

        public delegate void setFormObject(object sender, ItemClickEventArgs e);
        public setFormObject _setFormObject;

        private void btnAddNewBook_Click(object sender, EventArgs e)
        {
            _setFormObject(null, null);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
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
                grdListReceiptBook.DataSource = m_ReceiptNoteDetailData;
                updateEnableButtonAndResetValueOfControl(ref btnSave);
            }
            catch (System.Exception) { }

        }

        private void btnCancelOfUpdate_Click(object sender, EventArgs e)
        {
            updateEnableButtonAndResetValueOfControl(ref btnCancelOfUpdate);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (m_ReceiptNoteDetailData.Rows.Count != 0)
            {
                if (XtraCustomMessageBox.Show("Bạn có muốn hủy bỏ hóa đơn này hay không?", "Thông báo", false) ==  DialogResult.Yes)
                    {
                        updateEnableButtonAndResetValueOfControl(ref btnCancel);
                        m_ReceiptNoteDetailData.Clear();
                    }

            }
        }

        private bool m_Saved = false;

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
                        txtReceiptNoteId.Text = "PN00000**";
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
                        drbtnReceiptNoteChose.Enabled = true;
                        btnUpdate.Enabled = false;
                        btnDelete.Enabled = false;
                        btnView.Enabled = false;
                        btnWrite.Enabled = true;
                        //
                        btnCancel.Visible = true;
                        btnAdd.Visible = false;
                        //
                        break;
                    }
                case "btnCancel":
                    {
                        txtReceiptNoteId.Text = "PN00000**";
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
                        btnUpdate.Enabled = true;
                        btnDelete.Enabled = true;
                        btnAdd.Enabled = true;
                        btnSave.Enabled = false;
                        drbtnReceiptNoteChose.Enabled = true;
                        //
                        spPrices.Properties.ReadOnly = true;
                        spQuantity.Properties.ReadOnly = true;
                        //
                        grdvReceiptBook.OptionsSelection.EnableAppearanceFocusedRow = true;
                        grdvReceiptBook.Columns["CheckMarkSelection"].OptionsColumn.AllowEdit = true;

                        break;
                    }
                case "btnDelete":
                    {
                        break;
                    }
                case "btnChose":
                    {
                        spQuantity.Properties.ReadOnly = false;
                        spPrices.Properties.ReadOnly = false;
                        btnAddInListBookDetail.Enabled = true;
                        spQuantity.EditValue = 0;
                        break;
                    }
                case "btnUpdate":
                    {

                        spPrices.Properties.ReadOnly = false;
                        spQuantity.Properties.ReadOnly = false;
                        //
                        btnSave.Enabled = true;
                        btnDelete.Enabled = false;              
                        btnAddInListBookDetail.Enabled = false;
                        drbtnReceiptNoteChose.Enabled = false;
                        //
                        btnUpdate.Visible = false;
                        btnCancelOfUpdate.Visible = true;
                        //
                        grdvReceiptBook.OptionsSelection.EnableAppearanceFocusedRow = false;
                        grdvReceiptBook.Columns["CheckMarkSelection"].OptionsColumn.AllowEdit = false;
                        m_ReceiptNoteDetailMultiselect.ClearSelection();
                        break;
                    }
                case "btnSave":
                    {
                   
                        btnCancelOfUpdate.Visible = false;   
                        //
                        btnSave.Enabled = false;
                        btnUpdate.Visible = true;
                        btnUpdate.Enabled = true;
                        btnDelete.Enabled = true;
                        btnAddInListBookDetail.Enabled = true;
                        drbtnReceiptNoteChose.Enabled = true;
                        //
                        spPrices.Properties.ReadOnly = true;
                        spQuantity.Properties.ReadOnly = true;
                        //
                        grdvReceiptBook.OptionsSelection.EnableAppearanceFocusedRow = true;
                        grdvReceiptBook.Columns["CheckMarkSelection"].OptionsColumn.AllowEdit = true;
                        break;
                    }
                case "btnWrite":
                    {
                        m_Saved = true;
                        m_BookData = m_BookExecute.getBookDataFromDatabase();
                        grdListBook.DataSource = m_BookData;
                        btnView.Enabled = true;
                        btnWrite.Enabled = false;
                        btnAdd.Visible = true;
                        btnCancel.Visible = false;
                        drbtnReceiptNoteChose.Enabled = false;
                        break;
                    }
            }
        }

        private void frmReceiptNote_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (btnSave.Enabled)
            {
                if (XtraCustomMessageBox.Show("Dữ liệu chưa được lưu!\nBạn có thực sự muốn thoát hay không?", "Thông báo", false) == DialogResult.No)
                {
                    e.Cancel = true;
                    return;
                }
            }
        }

        private void spQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '-' || e.KeyChar == '.')
            {
                e.Handled = true;
                return;
            }
        }
    }
}
