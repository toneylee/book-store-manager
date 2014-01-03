using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Manager_Book_Store.Business_Layer;

namespace Manager_Book_Store.Presentation_Layer
{
    public partial class frmEmployeeSearch : Form
    {
        #region "Variable"
        private CEmployeeBUS m_EmployeeExecute;
        private DataTable m_EmployeeData;
        private CChargeBUS m_ChargeExecute;
        private DataTable m_ChargeData;
        #endregion
        public frmEmployeeSearch()
        {
            InitializeComponent();
            m_EmployeeData = new DataTable();
            m_EmployeeExecute = new CEmployeeBUS();
            m_ChargeData = new DataTable();
            m_ChargeExecute = new CChargeBUS();
        }

        private void raGChose_SelectedIndexChanged(object sender, EventArgs e)
        {
            getDataByRule();
        }

        private void lkCharge_TextChanged(object sender, EventArgs e)
        {
            getDataByRule();
        }

        private void cmbGender_TextChanged(object sender, EventArgs e)
        {
            if (cmbGender.SelectedIndex == 0)
                cmbGender.Text = null;
            getDataByRule();
        }

        private void chkEnableSearchFast_CheckedChanged(object sender, EventArgs e)
        {
            getDataByRule();
        }

        private void txtContentSearch_TextChanged(object sender, EventArgs e)
        {
            if(chkEnableSearchFast.Checked)
                getDataByRule();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            getDataByRule();
        }
        private void getDataByRule()
        {
            if (raGChose.SelectedIndex == 0)
            {
                m_EmployeeData = m_EmployeeExecute.getEmployeeDataByRuleFromDatabase(txtContentSearch.Text, "", cmbGender.Text, "", "", lkCharge.Text);
                grdListEmployee.DataSource = m_EmployeeData;
            }
            else if (raGChose.SelectedIndex == 1)
            {
                m_EmployeeData = m_EmployeeExecute.getEmployeeDataByRuleFromDatabase("", txtContentSearch.Text, cmbGender.Text, "", "", lkCharge.Text);
                grdListEmployee.DataSource = m_EmployeeData;
            }
            else if (raGChose.SelectedIndex == 2)
            {
                m_EmployeeData = m_EmployeeExecute.getEmployeeDataByRuleFromDatabase("", "", cmbGender.Text, txtContentSearch.Text, "", lkCharge.Text);
                grdListEmployee.DataSource = m_EmployeeData;
            }
            else if (raGChose.SelectedIndex == 3)
            {

                m_EmployeeData = m_EmployeeExecute.getEmployeeDataByRuleFromDatabase("", "", cmbGender.Text, "", txtContentSearch.Text, lkCharge.Text);
                grdListEmployee.DataSource = m_EmployeeData;
            }
            else
            {
                m_EmployeeData = m_EmployeeExecute.getEmployeeDataByRuleFromDatabase("", "", cmbGender.Text, "", "", lkCharge.Text);
                grdListEmployee.DataSource = m_EmployeeData;
            }
        }

        private void chkEnableChoseCharge_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkEnableChoseCharge.Checked)
                lkCharge.EditValue = null;
        }

        private void frmEmployeeSearch_Load(object sender, EventArgs e)
        {
            m_ChargeData = m_ChargeExecute.getChargeDataFromDatabase();
            lkCharge.Properties.DataSource = m_ChargeData;
            lkCharge.Properties.DisplayMember = "TenCV";
            lkCharge.Properties.ValueMember = "MaCV";
            //
            m_EmployeeData = m_EmployeeExecute.getEmployeeDataFromDatabase();
            grdListEmployee.DataSource = m_EmployeeData;
        }
    }
}
