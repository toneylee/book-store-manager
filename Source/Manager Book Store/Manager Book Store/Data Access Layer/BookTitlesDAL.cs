using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Manager_Book_Store.Data_Tranfer_Object;
using System.Data.SqlClient;
using System.Data;

namespace Manager_Book_Store.Data_Access_Layer
{
    class CBookTitlesDAL
    {
        private CBookTitlesDTO m_bookTitlesObject;
        private CDataExecute  m_bookTitlesExecute;
        private SqlCommand    m_cmd;

        public CBookTitlesDAL(CBookTitlesDTO _bookTitlesObject)
        {
            m_bookTitlesObject  =_bookTitlesObject;
            m_bookTitlesExecute = new CDataExecute();
            m_cmd           = new SqlCommand();
        }
        public CBookTitlesDAL()
        {
            m_bookTitlesObject  = null;
            m_bookTitlesExecute = new CDataExecute();
            m_cmd           = new SqlCommand();
        }
        public bool AddBookTitlesToDatabase(CBookTitlesDTO _bookTitlesObject)
        {
            m_cmd = new SqlCommand();
            m_cmd.CommandType = CommandType.StoredProcedure;
            m_cmd.CommandText = "AddBookTitlesDataToDatabase";
            m_cmd.Parameters.Add("MaDauSach", SqlDbType.NVarChar).Value = _bookTitlesObject.maDauSach;
            m_cmd.Parameters.Add("MaTL", SqlDbType.NVarChar).Value =_bookTitlesObject.maTheLoai;
            m_cmd.Parameters.Add("TenDauSach", SqlDbType.NVarChar).Value = _bookTitlesObject.tenDauSach;
            return m_bookTitlesExecute.updateData(m_cmd) > 0;
        }
        public bool DeleteBookTitlesToDatabase(CBookTitlesDTO _bookTitlesObject)
        {
            m_cmd = new SqlCommand();
            m_cmd.CommandType = CommandType.StoredProcedure;
            m_cmd.CommandText = "DeleteBookTitlesDataToDatabase";
            m_cmd.Parameters.Add("MaDauSach", SqlDbType.NVarChar).Value =_bookTitlesObject.maDauSach;
            return m_bookTitlesExecute.updateData(m_cmd) > 0;
        }
        public bool UpdateBookTitlesToDatabase(CBookTitlesDTO _bookTitlesObject)
        {
            m_cmd = new SqlCommand();
            m_cmd.CommandType = CommandType.StoredProcedure;
            m_cmd.CommandText = "UpdateBookTitlesDataToDatabase";
            m_cmd.Parameters.Add("MaDauSach", SqlDbType.NVarChar).Value = _bookTitlesObject.maDauSach;
            m_cmd.Parameters.Add("MaTL", SqlDbType.NVarChar).Value =_bookTitlesObject.maTheLoai;
            m_cmd.Parameters.Add("TenSach", SqlDbType.NVarChar).Value =_bookTitlesObject.tenDauSach;
            return m_bookTitlesExecute.updateData(m_cmd) > 0;
        }
        public DataTable getBookTitlesDataFromDatabase()
        {
            m_cmd = new SqlCommand();
            //SqlCommand sqlCommand = new SqlCommand();
            m_cmd.CommandType = CommandType.StoredProcedure;
            m_cmd.CommandText = "GetBookTitlesDataFromDatabase";
            return m_bookTitlesExecute.getData(m_cmd);
        }
        public String getBookTitlesMaxIdFromDatabase()
        {
            m_cmd = new SqlCommand();
            //SqlCommand sqlCommand = new SqlCommand();
            m_cmd.CommandType = CommandType.StoredProcedure;
            m_cmd.CommandText = "GetBookTitlesMaxIdFromDatabase";
            return m_bookTitlesExecute.getMaxId(m_cmd);
        }
    }
}
