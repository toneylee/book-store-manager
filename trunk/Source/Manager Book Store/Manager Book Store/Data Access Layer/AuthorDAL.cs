using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Manager_Book_Store.Data_Tranfer_Object;
using System.Data.SqlClient;
using System.Data;

namespace Manager_Book_Store.Data_Access_Layer
{
    class CAuthorDAL
    {
        private CAuthorDTO m_AuthorObject;
        private CDataExecute m_AuthorExecute;
        private SqlCommand m_cmd;

        public CAuthorDAL(CAuthorDTO _authorObject)
        {
            m_AuthorObject = _authorObject;
            m_AuthorExecute = new CDataExecute();
            m_cmd = new SqlCommand();
        }
        public CAuthorDAL()
        {
            m_AuthorObject = null;
            m_AuthorExecute = new CDataExecute();
            m_cmd = new SqlCommand();
        }
        public bool AddAuthorToDatabase(CAuthorDTO _authorObject)
        {
            m_cmd = new SqlCommand();
            m_cmd.CommandType = CommandType.StoredProcedure;
            m_cmd.CommandText = "AddAuthorDataToDatabase";
            m_cmd.Parameters.Add("MaTG", SqlDbType.NVarChar).Value = _authorObject.maTacGia;
            m_cmd.Parameters.Add("TenTG", SqlDbType.NVarChar).Value = _authorObject.tenTacGia;
            m_cmd.Parameters.Add("DiaChi", SqlDbType.NVarChar).Value = _authorObject.diaChi;
            return m_AuthorExecute.updateData(m_cmd) > 0;
        }
        public bool DeleteAuthorToDatabase(CAuthorDTO _authorObject)
        {
            m_cmd = new SqlCommand();
            m_cmd.CommandType = CommandType.StoredProcedure;
            m_cmd.CommandText = "DeleteAuthorDataToDatabase";
            m_cmd.Parameters.Add("MaTG", SqlDbType.NVarChar).Value = _authorObject.maTacGia;
            return m_AuthorExecute.updateData(m_cmd) > 0;
        }
        public bool UpdateAuthorToDatabase(CAuthorDTO _authorObject)
        {
            m_cmd = new SqlCommand();
            m_cmd.CommandType = CommandType.StoredProcedure;
            m_cmd.CommandText = "UpdateAuthorDataToDatabase";
            m_cmd.Parameters.Add("MaTG", SqlDbType.NVarChar).Value = _authorObject.maTacGia;
            m_cmd.Parameters.Add("TenTG", SqlDbType.NVarChar).Value = _authorObject.tenTacGia;
            m_cmd.Parameters.Add("DiaChi", SqlDbType.NVarChar).Value = _authorObject.diaChi;
            return m_AuthorExecute.updateData(m_cmd) > 0;
        }
        public DataTable getAuthorDataFromDatabase()
        {
            m_cmd = new SqlCommand();
            //SqlCommand sqlCommand = new SqlCommand();
            m_cmd.CommandType = CommandType.StoredProcedure;
            m_cmd.CommandText = "GetAuthorDataFromDatabase";
            return m_AuthorExecute.getData(m_cmd);
        }
        public DataTable lookAtAuthorDataFromDatabase(String _authorName)
        {
            m_cmd = new SqlCommand();
            //SqlCommand sqlCommand = new SqlCommand();
            m_cmd.CommandType = CommandType.StoredProcedure;
            m_cmd.CommandText = "LookAtAuthorDataFromDatabase";
            m_cmd.Parameters.Add("TenTG", SqlDbType.NVarChar).Value = _authorName;
            return m_AuthorExecute.getData(m_cmd);
        }
    }
}