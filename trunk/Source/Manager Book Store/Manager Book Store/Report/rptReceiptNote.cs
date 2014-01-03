using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace Manager_Book_Store.Report
{
    public partial class rptReceiptNote : DevExpress.XtraReports.UI.XtraReport
    {
        public rptReceiptNote()
        {
            InitializeComponent();
        }
        public void LoadDataToReport(string _totalQuantity
            , string _totalAmount
            , string _deliveryNoteId)
        {
            //
            xrlbReceiptNoteIdValue.Text = _deliveryNoteId;
            xrlbTotalQuantityValue.Text = _totalQuantity;
            xrlbTotalAmountValue.Text = _totalAmount;
            xrlbReceiptNoteDateValue.Text = DateTime.Now.Day.ToString() + "/" + DateTime.Now.Month.ToString() + "/" + DateTime.Now.Year.ToString();
            //
            xrtbcBookNameValue.DataBindings.Add("Text", DataSource, "TenSach");
            xrtbrAuthorNameValue.DataBindings.Add("Text", DataSource, "NhomTG");
            xrtbcPublisherValue.DataBindings.Add("Text", DataSource, "TenNXB");
            xrtbcQuantityValue.DataBindings.Add("Text", DataSource, "SoLuong");
            xrtbcPricesValue.DataBindings.Add("Text", DataSource, "DonGia");
            xrtbAmountValue.DataBindings.Add("Text", DataSource, "ThanhTien");
            xrtbcSnoValue.DataBindings.Add("Text", DataSource, "STT");
        }

    }
}
