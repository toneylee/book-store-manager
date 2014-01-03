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
    public partial class frmBookSearch : Form
    {
        #region "Variable"
        private CAuthorBUS m_AuthorExecute;
        private CPublisherBUS m_PublisherExecute;
        private CBookGenreBUS m_BookGenreExecute;
        private CBookBUS m_BookExecute;
        private DataTable m_BookGenreData;
        private DataTable m_AuthorData;
        private DataTable m_PublisherData;
        private DataTable m_BookData;
        #endregion
        public frmBookSearch()
        {
            InitializeComponent();
            m_AuthorExecute = new CAuthorBUS();
            m_BookGenreExecute = new CBookGenreBUS();
            m_PublisherExecute = new CPublisherBUS();
            m_BookGenreData = new DataTable();
            m_AuthorData = new DataTable();
            m_PublisherData = new DataTable();
            m_BookData = new DataTable();
            m_BookExecute = new CBookBUS();
        }

        private void frmBookSearch_Load(object sender, EventArgs e)
        {
            //
            m_AuthorData = m_AuthorExecute.getAuthorDataFromDatabase();
            lkAuthorName.Properties.DataSource = m_AuthorData;
            lkAuthorName.Properties.DisplayMember = "TenTG";
            lkAuthorName.Properties.ValueMember = "MaTG";
            //
            m_BookGenreData = m_BookGenreExecute.getBookGenreDataFromDatabase();
            lkBookGenreName.Properties.DataSource = m_BookGenreData;
            lkBookGenreName.Properties.DisplayMember = "TenTL";
            lkBookGenreName.Properties.ValueMember = "MaTL";
            //
            m_PublisherData = m_PublisherExecute.getPublisherDataFromDatabase();
            lkPublisherName.Properties.DataSource = m_PublisherData;
            lkPublisherName.Properties.DisplayMember = "TenNXB";
            lkPublisherName.Properties.ValueMember = "MaNXB";
            //
            m_BookData = m_BookExecute.GetBookDataByRuleFromDatabase(txtContentSearch.Text, lkAuthorName.Text,
             lkBookGenreName.Text, lkPublisherName.Text, (int)spYear.Value, (int)spQuatityLimit.Value, (int)spPrice.Value);
            grdListBook.DataSource = m_BookData;
        }

        private void lkBookGenreName_EditValueChanged(object sender, EventArgs e)
        {
            m_BookData = m_BookExecute.GetBookDataByRuleFromDatabase(txtContentSearch.Text, lkAuthorName.Text,
                lkBookGenreName.Text, lkPublisherName.Text, (int)spYear.Value, (int)spQuatityLimit.Value, (int)spPrice.Value);
            grdListBook.DataSource = m_BookData;
        }

        private void lkAuthorName_EditValueChanged(object sender, EventArgs e)
        {
            m_BookData = m_BookExecute.GetBookDataByRuleFromDatabase(txtContentSearch.Text, lkAuthorName.Text,
                lkBookGenreName.Text, lkPublisherName.Text, (int)spYear.Value, (int)spQuatityLimit.Value, (int)spPrice.Value);
            grdListBook.DataSource = m_BookData;
        }

        private void lkPublisherName_EditValueChanged(object sender, EventArgs e)
        {
            m_BookData = m_BookExecute.GetBookDataByRuleFromDatabase(txtContentSearch.Text, lkAuthorName.Text,
                lkBookGenreName.Text, lkPublisherName.Text, (int)spYear.Value, (int)spQuatityLimit.Value, (int)spPrice.Value);
            grdListBook.DataSource = m_BookData;
        }

        private void spQuatityLimit_TextChanged(object sender, EventArgs e)
        {
            m_BookData = m_BookExecute.GetBookDataByRuleFromDatabase(txtContentSearch.Text, lkAuthorName.Text,
                lkBookGenreName.Text, lkPublisherName.Text, (int)spYear.Value, (int)spQuatityLimit.Value, (int)spPrice.Value);
            grdListBook.DataSource = m_BookData;
        }

        private void spPrice_TextChanged(object sender, EventArgs e)
        {
            m_BookData = m_BookExecute.GetBookDataByRuleFromDatabase(txtContentSearch.Text, lkAuthorName.Text,
                lkBookGenreName.Text, lkPublisherName.Text, (int)spYear.Value, (int)spQuatityLimit.Value, (int)spPrice.Value);
            grdListBook.DataSource = m_BookData;
        }

        private void spYear_TextChanged(object sender, EventArgs e)
        {
            m_BookData = m_BookExecute.GetBookDataByRuleFromDatabase(txtContentSearch.Text, lkAuthorName.Text,
                lkBookGenreName.Text, lkPublisherName.Text, (int)spYear.Value, (int)spQuatityLimit.Value, (int)spPrice.Value);
            grdListBook.DataSource = m_BookData;
        }

        private void txtContentSearch_TextChanged(object sender, EventArgs e)
        {
            if (chkEnableSearchFast.Checked)
            {
                m_BookData = m_BookExecute.GetBookDataByRuleFromDatabase(txtContentSearch.Text, lkAuthorName.Text,
                     lkBookGenreName.Text, lkPublisherName.Text, (int)spYear.Value, (int)spQuatityLimit.Value, (int)spPrice.Value);
                grdListBook.DataSource = m_BookData;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            m_BookData = m_BookExecute.GetBookDataByRuleFromDatabase(txtContentSearch.Text, lkAuthorName.Text,
                lkBookGenreName.Text, lkPublisherName.Text, (int)spYear.Value, (int)spQuatityLimit.Value, (int)spPrice.Value);
            grdListBook.DataSource = m_BookData;
        }

        private void chkEnableChoseBookGenre_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEnableChoseBookGenre.Checked)
                lkBookGenreName.Enabled = true;
            else
            {
                lkBookGenreName.Enabled = false;
                lkBookGenreName.EditValue = null;
            }
        }

        private void chkEnableChoseAuthor_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEnableChoseAuthor.Checked)
                lkAuthorName.Enabled = true;
            else
            {
                lkAuthorName.Enabled = false;
                lkAuthorName.EditValue = null;
            }
        }

        private void chkEnableChosePublisher_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEnableChosePublisher.Checked)
                lkPublisherName.Enabled = true;
            else
            {
                lkPublisherName.Enabled = false;
                lkPublisherName.EditValue = null;
            }
        }

    }
}
