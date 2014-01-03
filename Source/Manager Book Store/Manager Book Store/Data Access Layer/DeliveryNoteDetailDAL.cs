using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Manager_Book_Store.Data_Tranfer_Object;
using System.Data.SqlClient;
using System.Data;

namespace Manager_Book_Store.Data_Access_Layer
{
    class CDeliveryNoteDetailDAL
    {
        private CDeliveryNoteDetailDTO m_DeliveryNoteDetailObject;
        private CDataExecute  m_DeliveryNoteDetailExecute;
        private SqlCommand    m_cmd;

        public CDeliveryNoteDetailDAL(CDeliveryNoteDetailDTO _DeliveryNoteDetailObject)
        {
            m_DeliveryNoteDetailObject  =_DeliveryNoteDetailObject;
            m_DeliveryNoteDetailExecute = new CDataExecute();
            m_cmd           = new SqlCommand();
        }
        public CDeliveryNoteDetailDAL()
        {
            m_DeliveryNoteDetailObject  = null;
            m_DeliveryNoteDetailExecute = new CDataExecute();
            m_cmd           = new SqlCommand();
        }
        public bool AddDeliveryNoteDetailToDatabase(CDeliveryNoteDetailDTO _DeliveryNoteDetailObject)
        {
            m_cmd = new SqlCommand();
            m_cmd.CommandType = CommandType.StoredProcedure;
            m_cmd.CommandText = "AddDeliveryNoteDetailDataToDatabase";
            m_cmd.Parameters.Add("MaHD", SqlDbType.NVarChar).Value = _DeliveryNoteDetailObject.soHoaDon;
            m_cmd.Parameters.Add("MaSach", SqlDbType.NVarChar).Value = _DeliveryNoteDetailObject.maSach;
            m_cmd.Parameters.Add("DonGia", SqlDbType.Money).Value = _DeliveryNoteDetailObject.giaBan;
            m_cmd.Parameters.Add("SoLuong", SqlDbType.Int).Value = _DeliveryNoteDetailObject.soLuong;
            m_cmd.Parameters.Add("ThanhTien", SqlDbType.Money).Value = _DeliveryNoteDetailObject.thanhTien;
            return m_DeliveryNoteDetailExecute.updateData(m_cmd) > 0;
        }
        public bool DeleteDeliveryNoteDetailToDatabase(CDeliveryNoteDetailDTO _DeliveryNoteDetailObject)
        {
            m_cmd = new SqlCommand();
            m_cmd.CommandType = CommandType.StoredProcedure;
            m_cmd.CommandText = "DeleteDeliveryNoteDetailDataToDatabase";
            m_cmd.Parameters.Add("MaHD", SqlDbType.NVarChar).Value = _DeliveryNoteDetailObject.soHoaDon;
            return m_DeliveryNoteDetailExecute.updateData(m_cmd) > 0;
        }
        public bool UpdateDeliveryNoteDetailToDatabase(CDeliveryNoteDetailDTO _DeliveryNoteDetailObject)
        {
            m_cmd = new SqlCommand();
            m_cmd.CommandType = CommandType.StoredProcedure;
            m_cmd.CommandText = "UpdateDeliveryNoteDetailDataToDatabase";
            m_cmd.Parameters.Add("MaHD", SqlDbType.NVarChar).Value = _DeliveryNoteDetailObject.soHoaDon;
            m_cmd.Parameters.Add("MaSach", SqlDbType.NVarChar).Value = _DeliveryNoteDetailObject.maSach;
            m_cmd.Parameters.Add("DonGia", SqlDbType.Money).Value = _DeliveryNoteDetailObject.giaBan;
            m_cmd.Parameters.Add("SoLuong", SqlDbType.Int).Value = _DeliveryNoteDetailObject.soLuong;
            m_cmd.Parameters.Add("ThanhTien", SqlDbType.Money).Value = _DeliveryNoteDetailObject.thanhTien;
            return m_DeliveryNoteDetailExecute.updateData(m_cmd) > 0;
        }
        public DataTable getDeliveryNoteDetailDataFromDatabase()
        {
            m_cmd = new SqlCommand();
            //SqlCommand sqlCommand = new SqlCommand();
            m_cmd.CommandType = CommandType.StoredProcedure;
            m_cmd.CommandText = "GetDeliveryNoteDetailDataFromDatabase";
            return m_DeliveryNoteDetailExecute.getData(m_cmd);
        }
        public DataTable getDeliveryNoteDetailDataByRuleFromDatabase(String _maHD)
        {
            m_cmd = new SqlCommand();
            //SqlCommand sqlCommand = new SqlCommand();
            m_cmd.CommandType = CommandType.StoredProcedure;
            m_cmd.CommandText = "GetDeliveryNoteDetailDataByRuleFromDatabase";
            m_cmd.Parameters.Add("MaHD", SqlDbType.NVarChar).Value = _maHD;
            return m_DeliveryNoteDetailExecute.getData(m_cmd);
        }
    }
}
