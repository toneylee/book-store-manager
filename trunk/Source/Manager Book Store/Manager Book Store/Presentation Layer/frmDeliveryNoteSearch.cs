using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Manager_Book_Store.Business_Layer;
using DevExpress.Utils;

namespace Manager_Book_Store.Presentation_Layer
{
    public partial class frmDeliveryNoteSearch : Form
    {
        #region "Variable"
        private CDeliveryNoteBUS m_DeliveryNoteExecute;
        private DataTable m_DeliveryNoteData;
        private CDeliveryNoteDetailBUS m_DeliveryNoteDetailExecute;
        private DataTable m_DeliveryNoteDetailData;
        private CEmployeeBUS m_EmployeeExecute;
        private DataTable m_EmployeeNoteData;
        private CCustomerBUS m_CustomerExecute;
        private DataTable m_CustomerData;
        #endregion
        public frmDeliveryNoteSearch()
        {
            InitializeComponent();
            m_CustomerData = new DataTable();
            m_CustomerExecute = new CCustomerBUS();
            m_DeliveryNoteData = new DataTable();
            m_DeliveryNoteExecute = new CDeliveryNoteBUS();
            m_EmployeeNoteData = new DataTable();
            m_EmployeeExecute = new CEmployeeBUS();
            m_DeliveryNoteDetailData = new DataTable();
            m_DeliveryNoteDetailExecute = new CDeliveryNoteDetailBUS();
            dateDelivery.DateTime = DateTime.Now;
        }

        private void frmDeliveryNoteSearch_Load(object sender, EventArgs e)
        {
            m_DeliveryNoteData = m_DeliveryNoteExecute.getDeliveryDataByRuleFromDatabase(lkEmployeeName.Text, lkCustomerName.Text, txtContentSearch.Text, dateDelivery.DateTime);
            grdListDeliveryNote.DataSource = m_DeliveryNoteData;
            //
            m_EmployeeNoteData = m_EmployeeExecute.getEmployeeDataFromDatabase();
            lkEmployeeName.Properties.DataSource = m_EmployeeNoteData;
            lkEmployeeName.Properties.DisplayMember = "TenNV";
            lkEmployeeName.Properties.ValueMember = "TenNV";
            //
            m_CustomerData = m_CustomerExecute.getCustomerDataFromDatabase();
            lkCustomerName.Properties.DataSource = m_CustomerData;
            lkCustomerName.Properties.DisplayMember = "TenKH";
            lkCustomerName.Properties.ValueMember = "TenKH";
            
        }
        private void grdvDeliveryBook_CustomDrawFooterCell(object sender, DevExpress.XtraGrid.Views.Grid.FooterCellCustomDrawEventArgs e)
        {
            if (e.Column.FieldName == "TenNXB")
            {
                bool isPrinting = e.Handled;
                e.Handled = true;
                //e.Appearance.BackColor = Color.Violet;
                //e.Appearance.FillRectangle(e.Cache, e.Bounds);
                e.Graphics.DrawString("\tTổng số lượng ", AppearanceObject.DefaultFont, Brushes.Blue, e.Bounds);
            }
            else if (e.Column.FieldName == "DonGia")
            {
                bool isPrinting = e.Handled;
                e.Handled = true;
                //e.Appearance.BackColor = Color.Violet;//Chọn màu cho cột
                //e.Appearance.FillRectangle(e.Cache, e.Bounds);
                e.Graphics.DrawString("\tTổng số tiền ", AppearanceObject.DefaultFont, Brushes.Blue, e.Bounds);
            }
            else
                return;
        }

        private void grdvListDeliveryNote_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (e.FocusedRowHandle >= 0 && grdvListDeliveryNote.DataRowCount >= e.FocusedRowHandle)
            {

                m_DeliveryNoteDetailData = m_DeliveryNoteDetailExecute.getDeliveryNoteDetailDataByRuleFromDatabase(grdvListDeliveryNote.GetRowCellValue(e.FocusedRowHandle, "MaHD").ToString());
                grdListDeliveryBook.DataSource = m_DeliveryNoteDetailData;
            }
            else
                grdListDeliveryBook.DataSource = null;
        }

        private void lkEmployeeName_TextChanged(object sender, EventArgs e)
        {
            m_DeliveryNoteData = m_DeliveryNoteExecute.getDeliveryDataByRuleFromDatabase(lkEmployeeName.Text,lkCustomerName.Text,txtContentSearch.Text,dateDelivery.DateTime);
            grdListDeliveryNote.DataSource = m_DeliveryNoteData;
        }

        private void lkCustomerName_TextChanged(object sender, EventArgs e)
        {
            m_DeliveryNoteData = m_DeliveryNoteExecute.getDeliveryDataByRuleFromDatabase(lkEmployeeName.Text, lkCustomerName.Text, txtContentSearch.Text, dateDelivery.DateTime);
            grdListDeliveryNote.DataSource = m_DeliveryNoteData;
        }

        private void dateDelivery_EditValueChanged(object sender, EventArgs e)
        {
            m_DeliveryNoteData = m_DeliveryNoteExecute.getDeliveryDataByRuleFromDatabase(lkEmployeeName.Text, lkCustomerName.Text, txtContentSearch.Text, dateDelivery.DateTime);
            grdListDeliveryNote.DataSource = m_DeliveryNoteData;
        }

        private void txtContentSearch_TextChanged(object sender, EventArgs e)
        {
            m_DeliveryNoteData = m_DeliveryNoteExecute.getDeliveryDataByRuleFromDatabase(lkEmployeeName.Text, lkCustomerName.Text, txtContentSearch.Text, dateDelivery.DateTime);
            grdListDeliveryNote.DataSource = m_DeliveryNoteData;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            m_DeliveryNoteData = m_DeliveryNoteExecute.getDeliveryDataByRuleFromDatabase(lkEmployeeName.Text, lkCustomerName.Text, txtContentSearch.Text, dateDelivery.DateTime);
            grdListDeliveryNote.DataSource = m_DeliveryNoteData;
        }
    }
}
