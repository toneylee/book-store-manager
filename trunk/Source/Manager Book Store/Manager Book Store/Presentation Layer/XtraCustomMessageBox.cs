using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Manager_Book_Store.Presentation_Layer
{
    public partial class XtraCustomMessageBox : Form
    {
        private static XtraCustomMessageBox m_message;
        private static DialogResult m_result = DialogResult.OK;
        public XtraCustomMessageBox()
        {
            InitializeComponent();
        }
        public static DialogResult Show(String Text, String Caption, bool useDefault)
        {
            m_message = new XtraCustomMessageBox();
            m_message.labInfo.Text = Text;
            m_message.StartPosition = FormStartPosition.CenterParent;
            if (m_message.labInfo.Location.Y + m_message.labInfo.Height > m_message.panelView.Location.Y + m_message.panelView.Height)
                m_message.Height = m_message.Height + m_message.labInfo.Location.Y + m_message.labInfo.Height - m_message.panelView.Location.Y - m_message.panelView.Height;
            m_message.Text = Caption;
            if (useDefault)
            {
                m_message.btnAccept.Location = m_message.btnOK.Location;
                m_message.btnCancel.Visible = false;
                m_message.btnAccept.Text = "Vâng";
                //m_message.btnAccept.Location = m_message.btnCancel.Location;
            }
            m_message.btnOK.Visible = false;
            m_message.ShowDialog();
            return m_result;

        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            m_result = DialogResult.Yes;
            m_message.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            m_result = DialogResult.No;
            m_message.Close();
        }
    }
}
