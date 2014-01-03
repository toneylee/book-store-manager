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
    public partial class frmSurvivalReport : Form
    {
        private CSurvivalBUS m_SurvivalExecute;
        private rptSurvival m_SurvivalReport;
        private DataTable m_SurvivalData;
        private DateTime m_Survivaldate;
        public frmSurvivalReport()
        {
            InitializeComponent();
            m_SurvivalExecute = new CSurvivalBUS();
            m_SurvivalData = new DataTable();
            m_Survivaldate = new DateTime();
            dateSurvivalValue.DateTime = DateTime.Now;
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            m_Survivaldate = dateSurvivalValue.DateTime;
            m_SurvivalReport = new rptSurvival(m_Survivaldate);
            m_SurvivalData = m_SurvivalExecute.getSurvivalOfMonth(m_Survivaldate);
            m_SurvivalReport.DataSource = m_SurvivalData;
            docSurvivalView.PrintingSystem = m_SurvivalReport.PrintingSystem;
            m_SurvivalReport.CreateDocument();
        }

    }
}
