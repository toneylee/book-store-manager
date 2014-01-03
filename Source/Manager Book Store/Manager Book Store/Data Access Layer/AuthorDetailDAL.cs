using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Manager_Book_Store.Data_Tranfer_Object;
using System.Data.SqlClient;
using System.Data;

namespace Manager_Book_Store.Data_Access_Layer
{
    class CAuthorDetailDAL
    {
        private CAuthorDetailDTO m_auhorDetailObject;
        private CDataExecute  m_auhorDetailExecute;
        private SqlCommand    m_cmd;

        public CAuthorDetailDAL(CAuthorDetailDTO _auhorDetailObject)
        {
            m_auhorDetailObject  =_auhorDetailObject;
            m_auhorDetailExecute = new CDataExecute();
            m_cmd           = new SqlCommand();
        }
        public CAuthorDetailDAL()
        {
            m_auhorDetailObject  = null;
            m_auhorDetailExecute = new CDataExecute();
            m_cmd           = new SqlCommand();
        }
        public bool AddAuthorDetailToDatabase(CAuthorDetailDTO _auhorDetailObject)
        {
            m_cmd = new SqlCommand();
            m_cmd.CommandType = CommandType.StoredProcedure;
            m_cmd.CommandText = "AddAuthorDetailDataToDatabase";
            m_cmd.Parameters.Add("MaTG", SqlDbType.NVarChar).Value = _auhorDetailObject.maTacGia;
            m_cmd.Parameters.Add("MaDauSach", SqlDbType.NVarChar).Value = _auhorDetailObject.maDauSach;
            return m_auhorDetailExecute.updateData(m_cmd) > 0;
        }
        public bool DeleteAuthorDetailToDatabase(CAuthorDetailDTO _auhorDetailObject)
        {
            m_cmd = new SqlCommand();
            m_cmd.CommandType = CommandType.StoredProcedure;
            m_cmd.CommandText = "DeleteAuthorDetailDataToDatabase";
            m_cmd.Parameters.Add("MaDauSach", SqlDbType.NVarChar).Value = _auhorDetailObject.maDauSach;
            return m_auhorDetailExecute.updateData(m_cmd) > 0;
        }
        public bool UpdateAuthorDetailToDatabase(CAuthorDetailDTO _auhorDetailObject)
        {
            m_cmd = new SqlCommand();
            m_cmd.CommandType = CommandType.StoredProcedure;
            m_cmd.CommandText = "UpdateAuthorDetailDataToDatabase";
            m_cmd.Parameters.Add("MaTG", SqlDbType.NVarChar).Value = _auhorDetailObject.maTacGia;
            m_cmd.Parameters.Add("MaDauSach", SqlDbType.NVarChar).Value = _auhorDetailObject.maDauSach;
            return m_auhorDetailExecute.updateData(m_cmd) > 0;
        }
        public DataTable getAuthorDetailDataFromDatabase()
        {
            m_cmd = new SqlCommand();
            //SqlCommand sqlCommand = new SqlCommand();
            m_cmd.CommandType = CommandType.StoredProcedure;
            m_cmd.CommandText = "GetAuthorDetailDataFromDatabase";
            return m_auhorDetailExecute.getData(m_cmd);
        }
    }
}
