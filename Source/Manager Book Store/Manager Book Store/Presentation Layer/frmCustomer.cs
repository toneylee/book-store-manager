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
using DevExpress.Utils;

namespace Manager_Book_Store.Presentation_Layer
{
    public partial class frmCustomer : Form
    {
        #region "Variable"
        private CCustomerDTO m_CustomerObject;
        private CCustomerBUS m_CustomerExecute;
        private DataTable    m_CustomerData;
        private GridCheckMarksSelection m_CustomerMultiSelect;
        #endregion
        public frmCustomer()
        {
            InitializeComponent();
            m_CustomerObject    = new CCustomerDTO();
            m_CustomerExecute   = new CCustomerBUS();
            m_CustomerData      = new DataTable();
            m_CustomerMultiSelect = new GridCheckMarksSelection(grdvListCustomer);
            CustomerSno.VisibleIndex = 1;
            //dateBirthDay.Properties.DisplayFormat.FormatType = FormatType.DateTime;
            //dateBirthDay.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            //dateBirthDay.Properties.Mask.EditMask = "dd/MM/yyyy";
        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            m_CustomerData = m_CustomerExecute.getCustomerDataFromDatabase();
            grdListCustomer.DataSource = m_CustomerData;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtCustomerId.Text = "KH00000000";
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
            btnAdd.Visible = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnDelete.Enabled = true;
            btnUpdate.Enabled = true;
            btnCancel.Visible = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            m_CustomerObject = new CCustomerDTO(txtCustomerId.Text, txtCustomerName.Text, cmbCustomerGender.Text,
            dateBirthDay.DateTime, txtCustomerAddress.Text, txtCustomerPhone.Text, txtCustomerEmail.Text,(int)spCustomerDebit.Value);
            m_CustomerExecute.UpdateCustomerToDatabase(m_CustomerObject);
            m_CustomerData = m_CustomerExecute.getCustomerDataFromDatabase();
            grdListCustomer.DataSource = m_CustomerData;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            grdvListCustomer.FocusedRowHandle -= 1;
            foreach (DataRowView _rowData in m_CustomerMultiSelect.Selection)
            {
                m_CustomerObject = new CCustomerDTO();
                m_CustomerObject.maKhachHang = _rowData["MaKH"].ToString();
                m_CustomerExecute.DeleteCustomerToDatabase(m_CustomerObject);
            }
            m_CustomerData = m_CustomerExecute.getCustomerDataFromDatabase();
            grdListCustomer.DataSource = m_CustomerData;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            m_CustomerObject = new CCustomerDTO(txtCustomerId.Text, txtCustomerName.Text, cmbCustomerGender.Text,
            dateBirthDay.DateTime, txtCustomerAddress.Text, txtCustomerPhone.Text, txtCustomerEmail.Text, 0);
            m_CustomerExecute.AddCustomerToDatabase(m_CustomerObject);
            m_CustomerData = m_CustomerExecute.getCustomerDataFromDatabase();
            grdListCustomer.DataSource = m_CustomerData;
            //
            btnDelete.Enabled = true;
            btnUpdate.Enabled = true;
            btnCancel.Visible = false;
        }

        private void grdvListCustomer_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (e.FocusedRowHandle >= 0)
            {
                txtCustomerId.Text = grdvListCustomer.GetRowCellValue(e.FocusedRowHandle, "MaKH").ToString();
                txtCustomerName.Text = grdvListCustomer.GetRowCellValue(e.FocusedRowHandle, "TenKH").ToString();
                txtCustomerAddress.Text = grdvListCustomer.GetRowCellValue(e.FocusedRowHandle, "DiaChi").ToString();
                dateBirthDay.DateTime =Convert.ToDateTime(grdvListCustomer.GetRowCellValue(e.FocusedRowHandle, "NgaySinh").ToString());
                txtCustomerEmail.Text = grdvListCustomer.GetRowCellValue(e.FocusedRowHandle, "Email").ToString();
                cmbCustomerGender.Text = grdvListCustomer.GetRowCellValue(e.FocusedRowHandle, "GioiTinh").ToString();
                txtCustomerPhone.Text = grdvListCustomer.GetRowCellValue(e.FocusedRowHandle, "SoDienThoai").ToString();
                spCustomerDebit.EditValue = grdvListCustomer.GetRowCellValue(e.FocusedRowHandle, "TienNo");
            }
            
        }

    }
}
