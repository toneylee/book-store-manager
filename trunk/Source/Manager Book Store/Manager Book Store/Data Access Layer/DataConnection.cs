using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Xml;

namespace Manager_Book_Store.Data_Access_Layer
{
    class CDataConnection
    {
        #region "variable"
        protected SqlConnection m_conn;
        protected SqlCommand m_cmd;
        protected String m_connecstring;
        #endregion
        #region "method"
        public CDataConnection()
        {
        }
        private bool getConnectionString()
        {
            XmlDocument xmlDoc = CGetSetConnectString.getConnectString("Connection.xml");
            XmlElement xmlEle = xmlDoc.DocumentElement;

            try
            {
                if (xmlEle.SelectSingleNode("authorities").InnerText == "true")
                {
                    m_connecstring = "Data Source=" + xmlEle.SelectSingleNode("servname").InnerText + ";Initial Catalog=" + xmlEle.SelectSingleNode("database").InnerText + ";Integrated Security=True;";
                }
                else
                {
                    m_connecstring = "Data Source=" + xmlEle.SelectSingleNode("servname").InnerText + ";Initial Catalog=" + xmlEle.SelectSingleNode("database").InnerText + ";User Id=" + xmlEle.SelectSingleNode("username").InnerText + ";Password=" + xmlEle.SelectSingleNode("password").InnerText + ";";
                }
                return true;
            }
            catch
            {
                return false;
                //XtraCustomMessageBox.Show("Lỗi kết nối đến cơ sở dữ liệu ! Xin vui lòng thiết lập lại kết nối...","Thông báo","Vâng");
            }
        }
        public bool openConnection()
        {
            if (getConnectionString())
            {
                try
                {
                    if (m_conn == null)
                    {
                        m_conn = new SqlConnection(m_connecstring);
                    }
                    if (m_conn.State == ConnectionState.Closed)
                    {
                        m_conn.Open();
                    }
                    return true;
                }
                catch (SqlException)
                {
                    //DevExpress.XtraEditors.XtraMessageBox.Show(ex.ToString());
                    return false;
                }

            }
            else
            {
                return false;
            }

        }
        public void closeConnection()
        {
            if (m_conn.State == ConnectionState.Open)
            {
                m_conn.Close();
            }
        }
        #endregion
    }
}
