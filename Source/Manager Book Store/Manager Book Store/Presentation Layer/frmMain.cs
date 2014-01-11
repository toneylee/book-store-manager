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
using Manager_Book_Store.Business_Layer;
using Manager_Book_Store.Data_Access_Layer;
using Manager_Book_Store.Data_Tranfer_Object;

namespace Manager_Book_Store.Presentation_Layer
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        //delegate Show Menu when closed Main
        //delegate exit menu + application

        //Valids
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
        private frmLiabilitiesReport m_LiabilitiesReportObject;
        private frmInfoEmployee m_InfoEmployeeFormObject;
        private frmDecentralization m_DecentralizationFormObect;
        public frmMain()
        {
            InitializeComponent();
        }
   
        private void frmMain_Load(object sender, EventArgs e)
        {
            barStaticItem_TenNV.Caption = "Nhân viên: " + ucLogin.m_EmployeeObject.tenNhanVien;
            barStaticItem_Date.Caption = "   " + DateTime.Now.ToShortDateString();
            LoadDecentralization();
            setTime();
        }

        private void bbtnBook_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!xtraTabbedMdiManagerMenu.FloatForms.Contains(m_BookFormObject))
            {
                m_BookFormObject = new frmBook();
                m_BookFormObject._setpublisher = new frmBook.m_setPublisher(bbtnPublisher_ItemClick);
                m_BookFormObject._setBookTitle = new frmBook.m_setBookTitle(bbtnBookTitles_ItemClick);
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

        private void bbtnEmployee_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!xtraTabbedMdiManagerMenu.FloatForms.Contains(m_EmployeeFormObject))
            {
                m_EmployeeFormObject = new frmEmployee();
                xtraTabbedMdiManagerMenu.FloatForms.Add(m_EmployeeFormObject);
                m_EmployeeFormObject._setFormObject = new frmEmployee.setFormObject(bbtnOffice_ItemClick);
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
                m_ReceiptNoteFormObject._setFormObject = new frmReceiptNote.setFormObject(bbtnBook_ItemClick);

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
                m_DeliveryNoteFormObject.setFormObject = new frmDeliveryNote.m_setFormObject(bbtnCustomer_ItemClick);
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

        private void bbtnLiabilities_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!xtraTabbedMdiManagerMenu.FloatForms.Contains(m_LiabilitiesReportObject))
            {
                m_LiabilitiesReportObject = new frmLiabilitiesReport();
                xtraTabbedMdiManagerMenu.FloatForms.Add(m_LiabilitiesReportObject);
                m_LiabilitiesReportObject.MdiParent = this;
                m_LiabilitiesReportObject.Show();
            }
            else
                m_LiabilitiesReportObject.Activate();
        }

        private void bbtnBackup_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (xtraTabbedMdiManagerMenu.FloatForms.Count != 0)
            {
                XtraMessageBox.Show("Xin vui lòng đóng tất cả cửa sổ\ntrước khi sao lưu dữ liệu!");
                return;
            }
            frmBackupAndRestoreDatabase _frmBackup = new frmBackupAndRestoreDatabase(true);
            _frmBackup.StartPosition = FormStartPosition.CenterParent;
            _frmBackup.ShowDialog();
        }

        private void bbtnRestore_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (xtraTabbedMdiManagerMenu.FloatForms.Count != 0)
            {
                XtraMessageBox.Show("Xin vui lòng đóng tất cả cửa sổ\ntrước khi phục hồi dữ liệu!");
                return;
            }
            frmBackupAndRestoreDatabase _frmRestore = new frmBackupAndRestoreDatabase(false);
            _frmRestore._restart = new frmBackupAndRestoreDatabase.m_restartFormMain(frmMain_FormClosed);
            _frmRestore.StartPosition = FormStartPosition.CenterParent;
            _frmRestore.ShowDialog();

        }

        public delegate void showLogin(object sender, FormClosedEventArgs e);
        public showLogin _loginShow;

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            _loginShow(null,null);
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            _loginShow(null, null);
        }

        private void setTime()
        {
            Timer _timer = new Timer();
            _timer.Interval = 1000;
            _timer.Start();
            _timer.Tick += _timer_Tick;
        }

        void _timer_Tick(object sender, EventArgs e)
        {
            barStaticItem_Time.Caption = DateTime.Now.ToShortTimeString();
        }

        private void bbtnLogOut_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (xtraTabbedMdiManagerMenu.FloatForms.Count != 0)
            {
                XtraCustomMessageBox.Show("Xin vui lòng đóng tất cả các của sổ trước khi đăng xuất!", "Thông báo", true);
            }
            else
            {
                _loginShow(null, null);
                this.Dispose();
                this.Close();
            }
        }

        private void bbtnInfoLogin_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!xtraTabbedMdiManagerMenu.FloatForms.Contains(m_InfoEmployeeFormObject))
            {
                m_InfoEmployeeFormObject = new frmInfoEmployee();
                xtraTabbedMdiManagerMenu.FloatForms.Add(m_InfoEmployeeFormObject);
                m_InfoEmployeeFormObject.MdiParent = this;
                m_InfoEmployeeFormObject.Show();

            }
            else
                m_InfoEmployeeFormObject.Activate();
        }

        private void bbtnDecentization_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!xtraTabbedMdiManagerMenu.FloatForms.Contains(m_DecentralizationFormObect))
            {
                m_DecentralizationFormObect = new frmDecentralization();
                xtraTabbedMdiManagerMenu.FloatForms.Add(m_DecentralizationFormObect);
                m_DecentralizationFormObect.MdiParent = this;
                m_DecentralizationFormObect.Show();

            }
        }
        private void LoadDecentralization()
        {
            DecentralizationDTO _decentralizationObject  = new DecentralizationDTO();
            DecentralizationBUS _decentralizationExecute = new DecentralizationBUS();
            DataTable _decentralizationData              = new DataTable();
            _decentralizationObject.maChucVu             = ucLogin.m_EmployeeObject.maChucVu;
            _decentralizationData = _decentralizationExecute.getDecentralizationWithMaCV(_decentralizationObject);
            if (_decentralizationData.Rows[0][2].ToString().Equals("False"))
            {
                ribpgBackupAndRestore.Enabled = false;
                ribpgDecentralization.Enabled = false;
            }
            if (_decentralizationData.Rows[0][3].ToString().Equals("False"))
            {
                ribpgRegulation.Enabled = false;
            }
            if (_decentralizationData.Rows[0][4].ToString().Equals("False"))
            {
                ribpgbook.Enabled = false;
            }
            if (_decentralizationData.Rows[0][5].ToString().Equals("False"))
            {
                ribpgemployee.Enabled = false;
            }
            if (_decentralizationData.Rows[0][6].ToString().Equals("False"))
            {
                ribpgCustomer.Enabled = false;
            }
            if (_decentralizationData.Rows[0][7].ToString().Equals("False"))
            {
                ribgImportProduct.Enabled = false;
            }
            if (_decentralizationData.Rows[0][8].ToString().Equals("False"))
            {
                bbtnExportProduct.Enabled = false;
            }
            if (_decentralizationData.Rows[0][9].ToString().Equals("False"))
            {
                bbtnReceipts.Enabled = false;
            }
            if (_decentralizationData.Rows[0][10].ToString().Equals("False"))
            {
                bbtnBookSearch.Enabled = false;
            }
            if (_decentralizationData.Rows[0][11].ToString().Equals("False"))
            {
                bbtnEmployeeSearch.Enabled = false;
            }
            if (_decentralizationData.Rows[0][12].ToString().Equals("False"))
            {
                bbtnCustomerSearch.Enabled = false;
            }
            if (_decentralizationData.Rows[0][13].ToString().Equals("False"))
            {
                bbtnNoteSearch.Enabled = false;
            }
            if (_decentralizationData.Rows[0][14].ToString().Equals("False"))
            {
                bbtnSurvival.Enabled = false;
                bbtnLiabilities.Enabled = false;
            }
        }

    }
}