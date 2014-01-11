using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Manager_Book_Store.Data_Tranfer_Object;

namespace Manager_Book_Store.Report
{
    public partial class frmCashReceiptVoucherReport : Form
    {
        public frmCashReceiptVoucherReport()
        {
            InitializeComponent();
        }
        public frmCashReceiptVoucherReport(CCustomerDTO _customerObject, String _ReceiptNoteId, decimal _totalPayment, String _totalPaymentWord, String _debitValue, String _moneyPay)
        {
            rptCashReceiptVoucher _rptCashReceiptVoucher = new rptCashReceiptVoucher();
            InitializeComponent();
            _rptCashReceiptVoucher.LoadDataToReport(
                                              _customerObject.tenKhachHang,
                                              _customerObject.diaChi,
                                              _totalPayment.ToString(),
                                              _totalPaymentWord.ToString(),
                                              _ReceiptNoteId,
                                              _customerObject.Email,
                                              _customerObject.soDienThoai,
                                              _debitValue,
                                              _moneyPay);
            docCRVView.PrintingSystem = _rptCashReceiptVoucher.PrintingSystem;
            _rptCashReceiptVoucher.CreateDocument();
        }
    }
}
