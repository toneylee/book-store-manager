using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QUANLYCUAHANGSACH.Report
{
    public partial class rptDeliveryNote : DevExpress.XtraReports.UI.XtraReport
    {
        public rptDeliveryNote()
        {
            InitializeComponent();
        }

        public void LoadDataToReport(string _customerName
            , string _customerAddress
            , string _totalQuantity
            , string _totalAmount
            , string _deliveryNoteId
            , string _customerEmail
            , string _customerPhone)
        {
            //
            xrlbDeliveryNoteIdValue.Text = _deliveryNoteId;
            xrlbCustomerNameValue.Text = _customerName;
            xrlbCustomerAddressValue.Text = _customerAddress;
            xrlbTotalQuantityValue.Text = _totalQuantity;
            xrlbTotalAmountValue.Text = _totalAmount;
            xrlbCustomerEmailValue.Text = _customerEmail;
            xrlbCustomerPhoneValue.Text = _customerPhone;
            xrlbDeliveryNoteDateValue.Text = DateTime.Now.Day.ToString() + "/" + DateTime.Now.Month.ToString() + "/" + DateTime.Now.Year.ToString();
            //
            xrtbcBookNameValue.DataBindings.Add("Text", DataSource, "TenSach");
            xrtbrAuthorNameValue.DataBindings.Add("Text", DataSource, "NhomTG");
            xrtbcPublisherValue.DataBindings.Add("Text", DataSource, "TenNXB");
            xrtbcQuantityValue.DataBindings.Add("Text", DataSource, "SoLuong");
            xrtbcPricesValue.DataBindings.Add("Text", DataSource, "DonGia");
            xrtbAmountValue.DataBindings.Add("Text", DataSource, "ThanhTien");
            xrtbcSnoValue.DataBindings.Add("Text", DataSource, "STT");
        }

        private void Detail_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
        }


    }
}
