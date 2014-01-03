using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Manager_Book_Store.Data_Tranfer_Object;
using Manager_Book_Store.Business_Layer;
using Manager_Book_Store.Report;

namespace Manager_Book_Store.Presentation_Layer
{
    public partial class frmCashReceiptVoucher : Form
    {
        #region "Variable"
        private CCashReceiptVoucherDTO m_CashReceiptVoucherObject;
        private CCashReceiptVoucherBUS m_CashReceiptVoucherExecute;
        //
        private CCustomerBUS m_CustomerExecute;
        private CCustomerDTO m_CustomerObject;
        private DataTable m_CustomerData;
        //
        private String m_maKhachHang;
        private decimal m_tienMuaHang;
        #endregion
        public frmCashReceiptVoucher()
        {
            InitializeComponent();
            m_CashReceiptVoucherObject          = new CCashReceiptVoucherDTO();
            m_CashReceiptVoucherExecute         = new CCashReceiptVoucherBUS();
            m_CustomerData                      = new DataTable();
            m_CustomerExecute                   = new CCustomerBUS();
        }
        public frmCashReceiptVoucher(String _maKhachHang,  decimal _tienMuaHang)
        {
            InitializeComponent();
            m_CashReceiptVoucherObject  = new CCashReceiptVoucherDTO();
            m_CashReceiptVoucherExecute = new CCashReceiptVoucherBUS();
            m_CustomerData              = new DataTable();
            m_CustomerExecute           = new CCustomerBUS();
            m_maKhachHang               = _maKhachHang;
            m_tienMuaHang               = _tienMuaHang;
        }
        private void frmCashReceiptVoucher_Load(object sender, EventArgs e)
        {
            m_CustomerData                              = m_CustomerExecute.getCustomerDataFromDatabase();
            lkCustomerName.Properties.DataSource        = m_CustomerData;
            lkCustomerName.Properties.DisplayMember     = "TenKH";
            lkCustomerName.Properties.ValueMember       = "MaKH";
            lkCustomerName.EditValue                    = m_maKhachHang;
            spPurchases.Value                           = m_tienMuaHang;
            //
            labCRVDateValue.Text                        = DateTime.Now.ToString("dd/MM/yyy");
            txtCRVId.Text                               = m_CashReceiptVoucherExecute.getCashReceiptVoucherMaxIdFromDatabase();
        }

        private void lkCustomerName_EditValueChanged(object sender, EventArgs e)
        {
            DevExpress.XtraEditors.LookUpEdit lkCustomer    = (sender as DevExpress.XtraEditors.LookUpEdit);
            DataRowView row                                 = lkCustomer.Properties.GetDataSourceRowByKeyValue(lkCustomer.EditValue) as DataRowView;
            txtCustomerAddress.Text                         = row["DiaChi"].ToString();
            txtCustomerEmail.Text                           = row["Email"].ToString();
            txtCustomerPhone.Text                           = row["SoDienThoai"].ToString();
            spDebitOld.EditValue                            = row["TienNo"];

        }

        private void spPurchases_TextChanged(object sender, EventArgs e)
        {
            spMoneyShouldPay.EditValue = spDebitOld.Value + spPurchases.Value;
        }

        private void spDebitOld_EditValueChanged(object sender, EventArgs e)
        {
            spMoneyShouldPay.EditValue = spDebitOld.Value + spPurchases.Value;
        }

        private void spMoneyShouldPay_TextChanged(object sender, EventArgs e)
        {
            spRemain.EditValue = spPayment.Value - spMoneyShouldPay.Value;
        }

        private void spPayment_TextChanged(object sender, EventArgs e)
        {
            spRemain.EditValue = spPayment.Value - spMoneyShouldPay.Value;
        }
        private decimal _sotienthu = 0;
        private void btnSave_Click(object sender, EventArgs e)
        {
            //_sotienthu = 0;
            if(spRemain.Value > 0)
                _sotienthu = spPayment.Value;
            else
                _sotienthu = spMoneyShouldPay.Value;
            m_CashReceiptVoucherObject = new CCashReceiptVoucherDTO("PT00000000",
                                                                    lkCustomerName.EditValue.ToString(),
                                                                    "NV0000001",
                                                                    DateTime.ParseExact(labCRVDateValue.Text,"dd/MM/yyyy",null),
                                                                    (int)_sotienthu);
            m_CashReceiptVoucherExecute.AddCashReceiptVoucherToDatabase(m_CashReceiptVoucherObject);
            //
            decimal _sotienno = 0;
            if(spRemain.Value > 0)
                _sotienno = spRemain.Value;
            m_CustomerObject                = new CCustomerDTO();
            m_CustomerObject.maKhachHang    = lkCustomerName.EditValue.ToString();
            m_CustomerObject.tenKhachHang   = lkCustomerName.Text;
            m_CustomerObject.diaChi         = txtCustomerAddress.Text;
            m_CustomerObject.soDienThoai    = txtCustomerPhone.Text;
            m_CustomerObject.Email          = txtCustomerEmail.Text;
            m_CustomerObject.tienNo         = (int)_sotienno;
            m_CustomerExecute.UpdateDebitOfCustomerDataToDatabase(m_CustomerObject);
        }

        private void btnView_Click(object sender, EventArgs e)
        {

            frmCashReceiptVoucherReport _frmCashReceiptVoucherReport = new frmCashReceiptVoucherReport(m_CustomerObject,
                                                                                                        m_CashReceiptVoucherExecute.getCashReceiptVoucherMaxIdFromDatabase(),
                                                                                                        _sotienthu,
                                                                                                        txtPaymentWord.Text);
            _frmCashReceiptVoucherReport.ShowDialog();
        }
    }
}
