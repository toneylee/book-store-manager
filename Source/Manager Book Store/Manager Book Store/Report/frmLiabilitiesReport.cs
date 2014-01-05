using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Manager_Book_Store.Business_Layer;

namespace Manager_Book_Store.Report
{
    public partial class frmLiabilitiesReport : Form
    {
        private CLiabilitiesBUS m_LiabilitiesExecute;
        private rptLiabilities m_LiabilitiesReport;
        private DataTable m_LiabilitiesData;
        private DateTime m_Liabilitiesdate;
        public frmLiabilitiesReport()
        {
            InitializeComponent();
            m_LiabilitiesExecute = new CLiabilitiesBUS();
            m_LiabilitiesData = new DataTable();
            m_Liabilitiesdate = new DateTime();
            dateLiabilitiesValue.DateTime = DateTime.Now;
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            m_Liabilitiesdate = dateLiabilitiesValue.DateTime;
            m_LiabilitiesReport = new rptLiabilities(m_Liabilitiesdate);
            m_LiabilitiesData = m_LiabilitiesExecute.getLiabilitiesOfMonth(m_Liabilitiesdate);
            m_LiabilitiesReport.DataSource = m_LiabilitiesData;
            docLiabilitiesView.PrintingSystem = m_LiabilitiesReport.PrintingSystem;
            m_LiabilitiesReport.CreateDocument();
        }
    }
}
