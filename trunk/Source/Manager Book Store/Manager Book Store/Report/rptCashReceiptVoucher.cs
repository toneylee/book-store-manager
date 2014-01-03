using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace Manager_Book_Store.Report
{
    public partial class rptCashReceiptVoucher : DevExpress.XtraReports.UI.XtraReport
    {
        public rptCashReceiptVoucher()
        {
            InitializeComponent();
        }
        public void LoadDataToReport(string _customerName
                                    , string _customerAddress
                                    , string _totalPayment
                                    , string _totalPaymentWord
                                    , string _cashReceiptVoucherId
                                    , string _customerEmail
                                    , string _customerPhone)
        {
            //
            xrlbCashReceiptVoucherIdValue.Text   = _cashReceiptVoucherId;
            xrlbCustomerNameValue.Text      = _customerName;
            xrlbCustomerAddressValue.Text   = _customerAddress;
            xrlbPaymentValue.Text           = _totalPayment;
            xrlbPaymentWordValue.Text       = _totalPaymentWord;
            xrlbCustomerEmailValue.Text     = _customerEmail;
            xrlbCustomerPhoneValue.Text     = _customerPhone;
            xrlbCashReceiptVoucherDateValue.Text = DateTime.Now.Day.ToString() + "/" + DateTime.Now.Month.ToString() + "/" + DateTime.Now.Year.ToString();
        }
    }
}
