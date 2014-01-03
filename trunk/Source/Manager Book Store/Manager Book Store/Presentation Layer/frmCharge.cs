using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Manager_Book_Store.Data_Tranfer_Object;
using Manager_Book_Store.Business_Layer;
using DevExpress.XtraGrid.Selection;
using DevExpress.XtraEditors;

namespace Manager_Book_Store.Presentation_Layer
{
    public partial class frmCharge : Form
    {
        #region "variable"
        private CChargeDTO m_Charge;
        private DataTable m_ChargeData;
        private CChargeBUS m_ChargeBus;
        private GridCheckMarksSelection m_ChargeMultiSelectItem;
        #endregion
        public frmCharge()
        {
            InitializeComponent();
            m_Charge = new CChargeDTO();
            m_ChargeBus = new CChargeBUS();
            m_ChargeData = new DataTable();
            m_ChargeMultiSelectItem = new GridCheckMarksSelection(grdvListCharge);
        }
        private void frmForm_Load(object sender, EventArgs e)
        {
            ChargeSNo.VisibleIndex = 1;
            m_ChargeData = m_ChargeBus.getChargeDataFromDatabase();
            grdListCharge.DataSource = m_ChargeData;
            grdvListCharge.FocusedRowHandle = 0;
        }
        //Lấy thông tin chi tiết của thê loại.
        private void grdvListCharge_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (e.FocusedRowHandle >= 0)
            {
                txtChargeName.Text = grdvListCharge.GetRowCellValue(e.FocusedRowHandle, grdvListCharge.Columns["TenCV"]).ToString();
                txtChargeId.Text = grdvListCharge.GetRowCellValue(e.FocusedRowHandle, grdvListCharge.Columns["MaCV"]).ToString();
            }
        }
        //Thêm mới một thể loại vào cơ sở dữ liệu
        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnAdd.Visible = false;
            btnCancel.Visible = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            txtChargeId.Text = "CV000000";
            txtChargeName.Text = null;
        }
        //Cập nhật lại thông tin chi tiết thể loại
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                m_Charge = new CChargeDTO(txtChargeId.Text,txtChargeName.Text);
                m_Charge.maChucVu = txtChargeId.Text;
                m_ChargeBus.UpdateChargeToDatabase(m_Charge);
                m_ChargeData = m_ChargeBus.getChargeDataFromDatabase();
                grdListCharge.DataSource = m_ChargeData;
                grdvListCharge.FocusedRowHandle = grdvListCharge.DataRowCount - 1;
            }
            catch (System.Exception ex)
            {
                XtraMessageBox.Show(ex.ToString(), "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            }
        }
        //Xóa thông tin của thể loại
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (object _rowObjectItem in m_ChargeMultiSelectItem.Selection)
                {
                    grdvListCharge.FocusedRowHandle -= 1;
                    DataRowView _rowObjectDetail = _rowObjectItem as DataRowView;
                    m_Charge = new CChargeDTO(_rowObjectDetail.Row["MaCV"].ToString(), _rowObjectDetail.Row["TenCV"].ToString());
                    m_ChargeBus.DeleteChargeToDatabase(m_Charge);
                    m_ChargeData = new DataTable();
                    m_ChargeData = m_ChargeBus.getChargeDataFromDatabase();
                    grdListCharge.DataSource = m_ChargeData;
                    grdvListCharge.FocusedRowHandle = grdvListCharge.DataRowCount - 1;
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
                m_Charge = new CChargeDTO(txtChargeId.Text, txtChargeName.Text);
                m_ChargeBus.AddChargeToDatabase(m_Charge);
                m_ChargeData = m_ChargeBus.getChargeDataFromDatabase();
                grdListCharge.DataSource = m_ChargeData;
                grdvListCharge.FocusedRowHandle = grdvListCharge.DataRowCount - 1;
            }
            catch (System.Exception ex)
            {
                XtraMessageBox.Show(ex.ToString(), "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            }
        }

        private void txtChargeNameLA_TextChanged(object sender, EventArgs e)
        {
            m_ChargeData = m_ChargeBus.lookAtChargeDataFromDatabase(txtChargeNameLA.Text);
            grdListCharge.DataSource = m_ChargeData;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnAdd.Visible = true;
            btnCancel.Visible = false;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            grdvListCharge.FocusedRowHandle = 0;
        }


    }
}
