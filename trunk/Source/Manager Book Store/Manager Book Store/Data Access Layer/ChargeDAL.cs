using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Manager_Book_Store.Data_Tranfer_Object;
using System.Data.SqlClient;
using System.Data;

namespace Manager_Book_Store.Data_Access_Layer
{
    class CChargeDAL
    {
         private CChargeDTO m_ChargeObject;
        private CDataExecute  m_ChargeExecute;
        private SqlCommand    m_cmd;

        public CChargeDAL(CChargeDTO _ChargeObject)
        {
            m_ChargeObject  =_ChargeObject;
            m_ChargeExecute = new CDataExecute();
            m_cmd           = new SqlCommand();
        }
        public CChargeDAL()
        {
            m_ChargeObject  = null;
            m_ChargeExecute = new CDataExecute();
            m_cmd           = new SqlCommand();
        }
        public bool AddChargeToDatabase(CChargeDTO _ChargeObject)
        {
            m_cmd = new SqlCommand();
            m_cmd.CommandType = CommandType.StoredProcedure;
            m_cmd.CommandText = "AddChargeDataToDatabase";
            m_cmd.Parameters.Add("MaCV", SqlDbType.NVarChar).Value = _ChargeObject.maChucVu;
            m_cmd.Parameters.Add("TenCV", SqlDbType.NVarChar).Value =_ChargeObject.tenChucVu;
            return m_ChargeExecute.updateData(m_cmd) > 0;
        }
        public bool DeleteChargeToDatabase(CChargeDTO _ChargeObject)
        {
            m_cmd = new SqlCommand();
            m_cmd.CommandType = CommandType.StoredProcedure;
            m_cmd.CommandText = "DeleteChargeDataToDatabase";
            m_cmd.Parameters.Add("MaCV", SqlDbType.NVarChar).Value =_ChargeObject.maChucVu;
            return m_ChargeExecute.updateData(m_cmd) > 0;
        }
        public bool UpdateChargeToDatabase(CChargeDTO _ChargeObject)
        {
            m_cmd = new SqlCommand();
            m_cmd.CommandType = CommandType.StoredProcedure;
            m_cmd.CommandText = "UpdateChargeDataToDatabase";
            m_cmd.Parameters.Add("MaCV", SqlDbType.NVarChar).Value = _ChargeObject.maChucVu;
            m_cmd.Parameters.Add("TenCV", SqlDbType.NVarChar).Value =_ChargeObject.tenChucVu;
            return m_ChargeExecute.updateData(m_cmd) > 0;
        }
        public DataTable getChargeDataFromDatabase()
        {
            m_cmd = new SqlCommand();
            //SqlCommand sqlCommand = new SqlCommand();
            m_cmd.CommandType = CommandType.StoredProcedure;
            m_cmd.CommandText = "GetChargeDataFromDatabase";
            return m_ChargeExecute.getData(m_cmd);
        }
        public DataTable lookAtChargeDataFromDatabase(String _ChargeName)
        {
            m_cmd = new SqlCommand();
            //SqlCommand sqlCommand = new SqlCommand();
            m_cmd.CommandType = CommandType.StoredProcedure;
            m_cmd.CommandText = "LookAtChargeDataFromDatabase";
            m_cmd.Parameters.Add("TenCV", SqlDbType.NVarChar).Value = _ChargeName;
            return m_ChargeExecute.getData(m_cmd);
        }
    }
}
