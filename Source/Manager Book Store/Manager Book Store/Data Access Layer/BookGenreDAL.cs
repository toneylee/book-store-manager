using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Manager_Book_Store.Data_Tranfer_Object;
using System.Data;
using System.Data.SqlClient;

namespace Manager_Book_Store.Data_Access_Layer
{
    class CBookGenreDAL
    {
        private CBookGenreDTO m_BookGenreObject;
        private CDataExecute  m_BookGenreExecute;
        private SqlCommand    m_cmd;

        public CBookGenreDAL(CBookGenreDTO _bookGenreObject)
        {
            m_BookGenreObject  =_bookGenreObject;
            m_BookGenreExecute = new CDataExecute();
            m_cmd           = new SqlCommand();
        }
        public CBookGenreDAL()
        {
            m_BookGenreObject  = null;
            m_BookGenreExecute = new CDataExecute();
            m_cmd           = new SqlCommand();
        }
        public bool AddBookGenreToDatabase(CBookGenreDTO _bookGenreObject)
        {
            m_cmd = new SqlCommand();
            m_cmd.CommandType = CommandType.StoredProcedure;
            m_cmd.CommandText = "AddBookGenreDataToDatabase";
            m_cmd.Parameters.Add("MaTL", SqlDbType.NVarChar).Value = _bookGenreObject.maTheLoai;
            m_cmd.Parameters.Add("TenTL", SqlDbType.NVarChar).Value =_bookGenreObject.tenTheLoai;
            return m_BookGenreExecute.updateData(m_cmd) > 0;
        }
        public bool DeleteBookGenreToDatabase(CBookGenreDTO _bookGenreObject)
        {
            m_cmd = new SqlCommand();
            m_cmd.CommandType = CommandType.StoredProcedure;
            m_cmd.CommandText = "DeleteBookGenreDataToDatabase";
            m_cmd.Parameters.Add("MaTL", SqlDbType.NVarChar).Value =_bookGenreObject.maTheLoai;
            return m_BookGenreExecute.updateData(m_cmd) > 0;
        }
        public bool UpdateBookGenreToDatabase(CBookGenreDTO _bookGenreObject)
        {
            m_cmd = new SqlCommand();
            m_cmd.CommandType = CommandType.StoredProcedure;
            m_cmd.CommandText = "UpdateBookGenreDataToDatabase";
            m_cmd.Parameters.Add("MaTL", SqlDbType.NVarChar).Value = _bookGenreObject.maTheLoai;
            m_cmd.Parameters.Add("TenTL", SqlDbType.NVarChar).Value =_bookGenreObject.tenTheLoai;
            return m_BookGenreExecute.updateData(m_cmd) > 0;
        }
        public DataTable getBookGenreDataFromDatabase()
        {
            m_cmd = new SqlCommand();
            //SqlCommand sqlCommand = new SqlCommand();
            m_cmd.CommandType = CommandType.StoredProcedure;
            m_cmd.CommandText = "GetBookGenreDataFromDatabase";
            return m_BookGenreExecute.getData(m_cmd);
        }
        public DataTable lookAtBookGenreDataFromDatabase(String _bookGenreName)
        {
            m_cmd = new SqlCommand();
            //SqlCommand sqlCommand = new SqlCommand();
            m_cmd.CommandType = CommandType.StoredProcedure;
            m_cmd.CommandText = "LookAtBookGenreDataFromDatabase";
            m_cmd.Parameters.Add("TenTL", SqlDbType.NVarChar).Value = _bookGenreName;
            return m_BookGenreExecute.getData(m_cmd);
        }
    }
}
