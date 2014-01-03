using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Manager_Book_Store.Data_Tranfer_Object;
using System.Data.SqlClient;
using System.Data;

namespace Manager_Book_Store.Data_Access_Layer
{
    class CPublisherDAL
    {
        private CPublisherDTO m_publisherObject;
        private CDataExecute  m_publisherExecute;
        private SqlCommand    m_cmd;

        public CPublisherDAL(CPublisherDTO _publisherObject)
        {
            m_publisherObject  =_publisherObject;
            m_publisherExecute = new CDataExecute();
            m_cmd           = new SqlCommand();
        }
        public CPublisherDAL()
        {
            m_publisherObject  = null;
            m_publisherExecute = new CDataExecute();
            m_cmd           = new SqlCommand();
        }
        public bool AddPublisherToDatabase(CPublisherDTO _publisherObject)
        {
            m_cmd = new SqlCommand();
            m_cmd.CommandType = CommandType.StoredProcedure;
            m_cmd.CommandText = "AddPublisherDataToDatabase";
            m_cmd.Parameters.Add("MaNXB", SqlDbType.NVarChar).Value = _publisherObject.maNhaXuatBan;
            m_cmd.Parameters.Add("TenNXB", SqlDbType.NVarChar).Value =_publisherObject.tenNhaXuatBan;
            m_cmd.Parameters.Add("DiaChi", SqlDbType.NVarChar).Value = _publisherObject.diaChi;
            return m_publisherExecute.updateData(m_cmd) > 0;
        }
        public bool DeletePublisherToDatabase(CPublisherDTO _publisherObject)
        {
            m_cmd = new SqlCommand();
            m_cmd.CommandType = CommandType.StoredProcedure;
            m_cmd.CommandText = "DeletePublisherDataToDatabase";
            m_cmd.Parameters.Add("MaNXB", SqlDbType.NVarChar).Value =_publisherObject.maNhaXuatBan;
            return m_publisherExecute.updateData(m_cmd) > 0;
        }
        public bool UpdatePublisherToDatabase(CPublisherDTO _publisherObject)
        {
            m_cmd = new SqlCommand();
            m_cmd.CommandType = CommandType.StoredProcedure;
            m_cmd.CommandText = "UpdatePublisherDataToDatabase";
            m_cmd.Parameters.Add("MaNXB", SqlDbType.NVarChar).Value = _publisherObject.maNhaXuatBan;
            m_cmd.Parameters.Add("TenNXB", SqlDbType.NVarChar).Value = _publisherObject.tenNhaXuatBan;
            m_cmd.Parameters.Add("DiaChi", SqlDbType.NVarChar).Value = _publisherObject.diaChi;
            return m_publisherExecute.updateData(m_cmd) > 0;
        }
        public DataTable getPublisherDataFromDatabase()
        {
            m_cmd = new SqlCommand();
            //SqlCommand sqlCommand = new SqlCommand();
            m_cmd.CommandType = CommandType.StoredProcedure;
            m_cmd.CommandText = "GetPublisherDataFromDatabase";
            return m_publisherExecute.getData(m_cmd);
        }
        public DataTable lookAtPublisherDataFromDatabase(String _publisherName)
        {
            m_cmd = new SqlCommand();
            //SqlCommand sqlCommand = new SqlCommand();
            m_cmd.CommandType = CommandType.StoredProcedure;
            m_cmd.CommandText = "LookAtPublisherDataFromDatabase";
            m_cmd.Parameters.Add("TenNXB", SqlDbType.NVarChar).Value = _publisherName;
            return m_publisherExecute.getData(m_cmd);
        }
    }
}
