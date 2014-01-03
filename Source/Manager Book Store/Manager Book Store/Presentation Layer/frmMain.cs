using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using Manager_Book_Store.Report;

namespace Manager_Book_Store.Presentation_Layer
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private frmBook m_BookFormObject;
        private frmBookGenre m_BookGenreFormObject;
        private frmAuthor m_AuthorFormObject;
        private frmBookTitle m_BookTitleFormObject;
        private frmPublisher m_PublisherFormObject;
        private frmCustomer m_CustomerFormObject;
        private frmCharge m_ChargeFormObject;
        private frmEmployee m_EmployeeFormObject;
        private frmReceiptNote m_ReceiptNoteFormObject;
        private frmDeliveryNote m_DeliveryNoteFormObject;
        private frmCashReceiptVoucher m_CashReceiptVoucherFormObject;
        private frmBookSearch m_BookSearchFormObject;
        private frmCustomerSearch m_CustomerSearchFormObject;
        private frmEmployeeSearch m_EmployeeSearchFormObject;
        private frmDeliveryNoteSearch m_DeliveryNoteSearchFormObject;
        private frmSurvivalReport m_SurvivalReportFormObject;
        private frmRegulations m_RegulationFormObject;
        public frmMain()
        {
            InitializeComponent();
        }

        private void bbtnBook_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!xtraTabbedMdiManagerMenu.FloatForms.Contains(m_BookFormObject))
            {
                m_BookFormObject = new frmBook();
                xtraTabbedMdiManagerMenu.FloatForms.Add(m_BookFormObject);
                m_BookFormObject.MdiParent = this;
                m_BookFormObject.Show();

            }
            else
                m_BookFormObject.Activate();

        }
        private void bbtnCategoryBook_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!xtraTabbedMdiManagerMenu.FloatForms.Contains(m_BookGenreFormObject))
            {
                m_BookGenreFormObject = new frmBookGenre();
                xtraTabbedMdiManagerMenu.FloatForms.Add(m_BookGenreFormObject);
                m_BookGenreFormObject.MdiParent = this;
                m_BookGenreFormObject.Show();

            }
            else
                m_BookGenreFormObject.Activate();
        }
        private void bbtnAuthor_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!xtraTabbedMdiManagerMenu.FloatForms.Contains(m_AuthorFormObject))
            {
                m_AuthorFormObject = new frmAuthor();
                xtraTabbedMdiManagerMenu.FloatForms.Add(m_AuthorFormObject);
                m_AuthorFormObject.MdiParent = this;
                m_AuthorFormObject.Show();

            }
            else
                m_AuthorFormObject.Activate();
        }
        private void bbtnBookTitles_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!xtraTabbedMdiManagerMenu.FloatForms.Contains(m_BookTitleFormObject))
            {
                m_BookTitleFormObject = new frmBookTitle();
                m_BookTitleFormObject._setAuthor = new frmBookTitle.setData(bbtnAuthor_ItemClick);
                m_BookTitleFormObject._setBookGenre = new frmBookTitle.setData(bbtnCategoryBook_ItemClick);
                xtraTabbedMdiManagerMenu.FloatForms.Add(m_BookTitleFormObject);
                m_BookTitleFormObject.MdiParent = this;
                m_BookTitleFormObject.Show();

            }
            else
                m_BookTitleFormObject.Activate();
        }

        private void bbtnPublisher_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!xtraTabbedMdiManagerMenu.FloatForms.Contains(m_PublisherFormObject))
            {
                m_PublisherFormObject = new frmPublisher();
                xtraTabbedMdiManagerMenu.FloatForms.Add(m_PublisherFormObject);
                m_PublisherFormObject.MdiParent = this;
                m_PublisherFormObject.Show();

            }
            else 
                m_PublisherFormObject.Activate();
        }

        private void bbtnemploye_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!xtraTabbedMdiManagerMenu.FloatForms.Contains(m_EmployeeFormObject))
            {
                m_EmployeeFormObject = new frmEmployee();
                xtraTabbedMdiManagerMenu.FloatForms.Add(m_EmployeeFormObject);
                m_EmployeeFormObject.MdiParent = this;
                m_EmployeeFormObject.Show();

            }
            else 
                m_EmployeeFormObject.Activate();
        }

        private void bbtnOffice_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!xtraTabbedMdiManagerMenu.FloatForms.Contains(m_ChargeFormObject))
            {
                m_ChargeFormObject = new frmCharge();
                xtraTabbedMdiManagerMenu.FloatForms.Add(m_ChargeFormObject);
                m_ChargeFormObject.MdiParent = this;
                m_ChargeFormObject.Show();

            }
            else 
                m_ChargeFormObject.Activate();
        }

        private void bbtnCustomer_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!xtraTabbedMdiManagerMenu.FloatForms.Contains(m_CustomerFormObject))
            {
                m_CustomerFormObject = new frmCustomer();
                xtraTabbedMdiManagerMenu.FloatForms.Add(m_CustomerFormObject);
                m_CustomerFormObject.MdiParent = this;
                m_CustomerFormObject.Show();

            }
            else 
                m_CustomerFormObject.Activate();
        }

        private void bbtnImportProduct_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!xtraTabbedMdiManagerMenu.FloatForms.Contains(m_ReceiptNoteFormObject))
            {
                m_ReceiptNoteFormObject = new frmReceiptNote();
                xtraTabbedMdiManagerMenu.FloatForms.Add(m_ReceiptNoteFormObject);
                m_ReceiptNoteFormObject.MdiParent = this;
                m_ReceiptNoteFormObject.Show();

            }
            else
                m_ReceiptNoteFormObject.Activate();
        }

        private void bbtnExportProduct_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!xtraTabbedMdiManagerMenu.FloatForms.Contains(m_DeliveryNoteFormObject))
            {
                m_DeliveryNoteFormObject = new frmDeliveryNote();
                xtraTabbedMdiManagerMenu.FloatForms.Add(m_DeliveryNoteFormObject);
                m_DeliveryNoteFormObject.MdiParent = this;
                m_DeliveryNoteFormObject.Show();

            }
            else
                m_DeliveryNoteFormObject.Activate();
        }

        private void bbtnReceipts_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!xtraTabbedMdiManagerMenu.FloatForms.Contains(m_CashReceiptVoucherFormObject))
            {
                m_CashReceiptVoucherFormObject = new frmCashReceiptVoucher();
                xtraTabbedMdiManagerMenu.FloatForms.Add(m_CashReceiptVoucherFormObject);
                m_CashReceiptVoucherFormObject.MdiParent = this;
                //m_CashReceiptVoucherFormObject.MaximumSize = new System.Drawing.Size(1000,900);
                m_CashReceiptVoucherFormObject.Dock = DockStyle.Fill;
                m_CashReceiptVoucherFormObject.Show();

            }
            else
                m_CashReceiptVoucherFormObject.Activate();
        }

        private void bbtnBookSearch_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!xtraTabbedMdiManagerMenu.FloatForms.Contains(m_BookSearchFormObject))
            {
                m_BookSearchFormObject = new frmBookSearch();
                xtraTabbedMdiManagerMenu.FloatForms.Add(m_BookSearchFormObject);
                m_BookSearchFormObject.MdiParent = this;
                m_BookSearchFormObject.Show();

            }
            else
                m_BookSearchFormObject.Activate();
        }

        private void bbtnEmployeeSearch_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!xtraTabbedMdiManagerMenu.FloatForms.Contains(m_EmployeeSearchFormObject))
            {
                m_EmployeeSearchFormObject = new frmEmployeeSearch();
                xtraTabbedMdiManagerMenu.FloatForms.Add(m_EmployeeSearchFormObject);
                m_EmployeeSearchFormObject.MdiParent = this;
                m_EmployeeSearchFormObject.Show();

            }
            else
                m_EmployeeSearchFormObject.Activate();
        }

        private void bbtnCustomerSearch_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!xtraTabbedMdiManagerMenu.FloatForms.Contains(m_CustomerSearchFormObject))
            {
                m_CustomerSearchFormObject = new frmCustomerSearch();
                xtraTabbedMdiManagerMenu.FloatForms.Add(m_CustomerSearchFormObject);
                m_CustomerSearchFormObject.MdiParent = this;
                m_CustomerSearchFormObject.Show();
            }
            else
                m_CustomerSearchFormObject.Activate();
        }

        private void bbtnNoteSearch_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!xtraTabbedMdiManagerMenu.FloatForms.Contains(m_DeliveryNoteSearchFormObject))
            {
                m_DeliveryNoteSearchFormObject = new frmDeliveryNoteSearch();
                xtraTabbedMdiManagerMenu.FloatForms.Add(m_DeliveryNoteSearchFormObject);
                m_DeliveryNoteSearchFormObject.MdiParent = this;
                m_DeliveryNoteSearchFormObject.Show();
            }
            else
                m_DeliveryNoteSearchFormObject.Activate();
        }

        private void bbtnSurvival_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!xtraTabbedMdiManagerMenu.FloatForms.Contains(m_SurvivalReportFormObject))
            {
                m_SurvivalReportFormObject = new frmSurvivalReport();
                xtraTabbedMdiManagerMenu.FloatForms.Add(m_SurvivalReportFormObject);
                m_SurvivalReportFormObject.MdiParent = this;
                m_SurvivalReportFormObject.Show();
            }
            else
                m_SurvivalReportFormObject.Activate();
        }

        private void bbtnRegulation_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!xtraTabbedMdiManagerMenu.FloatForms.Contains(m_RegulationFormObject))
            {
                m_RegulationFormObject = new frmRegulations();
                xtraTabbedMdiManagerMenu.FloatForms.Add(m_RegulationFormObject);
                m_RegulationFormObject.MdiParent = this;
                m_RegulationFormObject.Show();
            }
            else
                m_RegulationFormObject.Activate();
        }
 
    }
}