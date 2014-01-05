using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace Manager_Book_Store.Report
{
    public partial class rptLiabilities : DevExpress.XtraReports.UI.XtraReport
    {
        public rptLiabilities()
        {
            InitializeComponent();
        }
        private DateTime m_date = new DateTime();
        public rptLiabilities(DateTime _date)
        {
            InitializeComponent();
            this.m_date = _date;
        }

        private void rptLiabilities_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            //
            xrlbDateLiabilities.Text = "Ngày " + DateTime.Now.Day.ToString() + " tháng " + DateTime.Now.Month.ToString() + "  năm " + DateTime.Now.Year.ToString();
            xrlbDateValue.Text = "Tháng " + m_date.Month.ToString() + " năm " + m_date.Year.ToString();
            //
            xrtSTTValue.DataBindings.Add("Text", DataSource, "STT");
            xrtbCustomerIdValue.DataBindings.Add("Text", DataSource, "MaKH");
            xrtbCustomerNameValue.DataBindings.Add("Text", DataSource, "TenKH");
            xrtbLiabilitiesFirstValue.DataBindings.Add("Text", DataSource, "NoDau");
            xrtbLiabilitiesSecondValue.DataBindings.Add("Text", DataSource, "PhatSinh");
            xrtbLiabilitiesThirdValue.DataBindings.Add("Text", DataSource, "NoCuoi");
        }
    }
}
