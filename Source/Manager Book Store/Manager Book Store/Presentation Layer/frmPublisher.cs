using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid.Selection;
using Manager_Book_Store.Business_Layer;
using Manager_Book_Store.Data_Tranfer_Object;
using DevExpress.XtraEditors;

namespace Manager_Book_Store.Presentation_Layer
{
    public partial class frmPublisher : Form
    {
        #region "variable"
        private GridCheckMarksSelection m_PublisherMulitSelect;
        private CPublisherBUS m_PublisherExecute;
        private DataTable m_PublisherData;
        private CPublisherDTO m_PublisherObject;
        #endregion
        public frmPublisher()
        {
            InitializeComponent();
            m_PublisherMulitSelect = new GridCheckMarksSelection(grdvListPublisher);
            m_PublisherExecute = new CPublisherBUS();
            m_PublisherData = new DataTable();
            PublisherSno.VisibleIndex = 1;
        }

        private void frmPublisher_Load(object sender, EventArgs e)
        {
            m_PublisherData = m_PublisherExecute.getPublisherDataFromDatabase();
            grdListPublisher.DataSource = m_PublisherData;
        }

        private void grdvListPublisher_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (e.FocusedRowHandle >= 0)
            {
                txtPublisherId.Text = grdvListPublisher.GetRowCellValue(e.FocusedRowHandle, grdvListPublisher.Columns["MaNXB"]).ToString();
                txtPublisherName.Text = grdvListPublisher.GetRowCellValue(e.FocusedRowHandle, grdvListPublisher.Columns["TenNXB"]).ToString();
                txtPublisherAddress.Text = grdvListPublisher.GetRowCellValue(e.FocusedRowHandle, grdvListPublisher.Columns["DiaChi"]).ToString();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnAdd.Visible = false;
            btnCancel.Visible = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            txtPublisherId.Text = "NXB0000000";
            txtPublisherName.Text = null;
            txtPublisherAddress.Text = null;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                m_PublisherObject = new CPublisherDTO(txtPublisherId.Text, txtPublisherName.Text, txtPublisherAddress.Text);
                m_PublisherExecute.UpdatePublisherToDatabase(m_PublisherObject);
                m_PublisherData = m_PublisherExecute.getPublisherDataFromDatabase();
                grdListPublisher.DataSource = m_PublisherData;
                grdvListPublisher.FocusedRowHandle = grdvListPublisher.DataRowCount - 1;
            }
            catch (System.Exception ex)
            {
                XtraMessageBox.Show(ex.ToString(), "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (object _rowObjectItem in m_PublisherMulitSelect.Selection)
                {
                    grdvListPublisher.FocusedRowHandle -= 1;
                    DataRowView _rowObjectDetail = _rowObjectItem as DataRowView;
                    m_PublisherObject = new CPublisherDTO(_rowObjectDetail.Row["MaNXB"].ToString(), _rowObjectDetail.Row["TenNXB"].ToString(), _rowObjectDetail.Row["DiaChi"].ToString());
                    m_PublisherExecute.DeletePublisherToDatabase(m_PublisherObject);
                    m_PublisherData = new DataTable();
                    m_PublisherData = m_PublisherExecute.getPublisherDataFromDatabase();
                    grdListPublisher.DataSource = m_PublisherData;
                    grdvListPublisher.FocusedRowHandle = grdvListPublisher.DataRowCount - 1;
                }
            }
            catch (System.Exception ex)
            {
                XtraMessageBox.Show(ex.ToString(), "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                m_PublisherObject = new CPublisherDTO(txtPublisherId.Text, txtPublisherName.Text, txtPublisherAddress.Text);
                m_PublisherExecute.AddPublisherToDatabase(m_PublisherObject);
                m_PublisherData = new DataTable();
                m_PublisherData = m_PublisherExecute.getPublisherDataFromDatabase();
                grdListPublisher.DataSource = m_PublisherData;
                grdvListPublisher.FocusedRowHandle = grdvListPublisher.DataRowCount - 1;
            }
            catch (System.Exception ex)
            {
                XtraMessageBox.Show(ex.ToString(), "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnAdd.Visible = true;
            btnCancel.Visible = false;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void txtPublisherNameLA_TextChanged(object sender, EventArgs e)
        {
            m_PublisherData = m_PublisherExecute.lookAtPublisherDataFromDatabase(txtPublisherNameLA.Text);
            grdListPublisher.DataSource = m_PublisherData;

        }
    }
}
