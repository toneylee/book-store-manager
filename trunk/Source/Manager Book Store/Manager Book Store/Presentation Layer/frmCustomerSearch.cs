using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Manager_Book_Store.Business_Layer;
using Manager_Book_Store.General;

namespace Manager_Book_Store.Presentation_Layer
{
    public partial class frmCustomerSearch : Form
    {
        #region "Variable"
        private CCustomerBUS m_CustomerExecute;
        private DataTable m_CustomerData;
        private bool m_flag;
        #endregion
        public frmCustomerSearch()
        {
            InitializeComponent();
            m_CustomerExecute = new CCustomerBUS();
            m_CustomerData = new DataTable();
            m_flag = false;
        }

        private void raGChose_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckContraint();
        }

        private void frmCustomerSearch_Load(object sender, EventArgs e)
        {
            m_CustomerData = m_CustomerExecute.getCustomerDataFromDatabase();
            grdListCustomer.DataSource = m_CustomerData;
        }

        private void txtContentSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (m_flag)
            {
                CheckInformationEntered.checkCharacterInput(e, !m_flag);
            }
        }

        private void txtContentSearch_TextChanged(object sender, EventArgs e)
        {
            if(chkEnableSearchFast.Checked)
                CheckContraint();
        }

        private void cmbGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbGender.SelectedIndex == 0)
                cmbGender.Text = null;
            CheckContraint();
        }

        private void spDebits_TextChanged(object sender, EventArgs e)
        {
            CheckContraint();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            CheckContraint();
        }
        private void CheckContraint()
        {
            m_flag = false;
            if (raGChose.SelectedIndex == 0)
            {
                m_CustomerData = m_CustomerExecute.getCustomerDataByRuleFromDatabase(txtContentSearch.Text, "", cmbGender.Text, "", "", (int)spDebits.Value);
                grdListCustomer.DataSource = m_CustomerData;
            }
            else if (raGChose.SelectedIndex == 1)
            {
                m_CustomerData = m_CustomerExecute.getCustomerDataByRuleFromDatabase("", txtContentSearch.Text, cmbGender.Text, "", "", (int)spDebits.Value);
                grdListCustomer.DataSource = m_CustomerData;
            }
            else if (raGChose.SelectedIndex == 2)
            {
                m_CustomerData = m_CustomerExecute.getCustomerDataByRuleFromDatabase("", "", cmbGender.Text, txtContentSearch.Text, "", (int)spDebits.Value);
                grdListCustomer.DataSource = m_CustomerData;
            }
            else if (raGChose.SelectedIndex == 3)
            {

                m_CustomerData = m_CustomerExecute.getCustomerDataByRuleFromDatabase("", "", cmbGender.Text, "", txtContentSearch.Text, (int)spDebits.Value);
                grdListCustomer.DataSource = m_CustomerData;
                m_flag = true;
            }
            else
            {
                m_CustomerData = m_CustomerExecute.getCustomerDataByRuleFromDatabase("", "", cmbGender.Text, "", "", (int)spDebits.Value);
                grdListCustomer.DataSource = m_CustomerData;
            }
        }
    }
}
