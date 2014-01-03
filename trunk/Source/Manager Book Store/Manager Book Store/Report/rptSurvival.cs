using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace Manager_Book_Store.Report
{
    public partial class rptSurvival : DevExpress.XtraReports.UI.XtraReport
    {
        private DateTime m_date = new DateTime();
        public rptSurvival()
        {
            InitializeComponent();

        }
        public rptSurvival(DateTime _date)
        {
            InitializeComponent();
            this.m_date = _date;
        }

        private void rptSurvival_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            //
            xrlbDateSurvival.Text = "Ngày " + DateTime.Now.Day.ToString() + " tháng " + DateTime.Now.Month.ToString() + "  năm " + DateTime.Now.Year.ToString();
            xrlbDateValue.Text = "Tháng " + m_date.Month.ToString() + " năm " + m_date.Year.ToString();
            //
            xrtSTTValue.DataBindings.Add("Text", DataSource, "STT");
            xrtbBookIdValue.DataBindings.Add("Text", DataSource, "MaSach");
            xrtbBookNameValue.DataBindings.Add("Text", DataSource, "TenSach");
            xrtbSurvivalFirstValue.DataBindings.Add("Text", DataSource, "TonDau");
            xrtbSurvivalSecondValue.DataBindings.Add("Text", DataSource, "PhatSinh");
            xrtbSurvivalThirdValue.DataBindings.Add("Text", DataSource, "TonCuoi");
        }

    }
}
