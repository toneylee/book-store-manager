using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Manager_Book_Store.Data_Tranfer_Object;
using System.Data.SqlClient;
using System.Data;

namespace Manager_Book_Store.Data_Access_Layer
{
    class CDeliveryNoteDAL
    {
        private CDeliveryNoteDTO m_DeliveryNoteObject;
        private CDataExecute    m_DeliveryNoteExecute;
        private SqlCommand      m_cmd;

        public CDeliveryNoteDAL(CDeliveryNoteDTO _DeliveryNoteObject)
        {
            m_DeliveryNoteObject     =_DeliveryNoteObject;
            m_DeliveryNoteExecute    = new CDataExecute();
            m_cmd                   = new SqlCommand();
        }
        public CDeliveryNoteDAL()
        {
            m_DeliveryNoteObject     = null;
            m_DeliveryNoteExecute    = new CDataExecute();
            m_cmd                   = new SqlCommand();
        }
        public bool AddDeliveryNoteToDatabase(CDeliveryNoteDTO _DeliveryNoteObject)
        {
            m_cmd = new SqlCommand();
            m_cmd.CommandType = CommandType.StoredProcedure;
            m_cmd.CommandText = "AddDeliveryNoteDataToDatabase";
            m_cmd.Parameters.Add("MaHD", SqlDbType.NVarChar).Value = _DeliveryNoteObject.soHoaDon;
            m_cmd.Parameters.Add("MaNV", SqlDbType.NVarChar).Value =_DeliveryNoteObject.maNhanVien;
            m_cmd.Parameters.Add("MaKH", SqlDbType.NVarChar).Value = _DeliveryNoteObject.maKhachHang;
            m_cmd.Parameters.Add("NgayHD", SqlDbType.SmallDateTime).Value = _DeliveryNoteObject.ngayHoaDon;
            m_cmd.Parameters.Add("TongSoLuong", SqlDbType.Int).Value = _DeliveryNoteObject.tongSoLuong;
            m_cmd.Parameters.Add("TongTien", SqlDbType.Int).Value = _DeliveryNoteObject.tongTien;
            return m_DeliveryNoteExecute.updateData(m_cmd) > 0;
        }
        public bool DeleteDeliveryNoteToDatabase(CDeliveryNoteDTO _DeliveryNoteObject)
        {
            m_cmd = new SqlCommand();
            m_cmd.CommandType = CommandType.StoredProcedure;
            m_cmd.CommandText = "DeleteDeliveryNoteDataToDatabase";
            m_cmd.Parameters.Add("MaHD", SqlDbType.NVarChar).Value =_DeliveryNoteObject.soHoaDon;
            return m_DeliveryNoteExecute.updateData(m_cmd) > 0;
        }
        public bool UpdateDeliveryNoteToDatabase(CDeliveryNoteDTO _DeliveryNoteObject)
        {
            m_cmd = new SqlCommand();
            m_cmd.CommandType = CommandType.StoredProcedure;
            m_cmd.CommandText = "UpdateDeliveryNoteDataToDatabase";
            m_cmd.Parameters.Add("MaHD", SqlDbType.NVarChar).Value = _DeliveryNoteObject.soHoaDon;
            m_cmd.Parameters.Add("MaNV", SqlDbType.NVarChar).Value = _DeliveryNoteObject.maNhanVien;
            m_cmd.Parameters.Add("MaKH", SqlDbType.NVarChar).Value = _DeliveryNoteObject.maKhachHang;
            m_cmd.Parameters.Add("NgayHD", SqlDbType.SmallDateTime).Value = _DeliveryNoteObject.ngayHoaDon;
            m_cmd.Parameters.Add("TongSoLuong", SqlDbType.Int).Value = _DeliveryNoteObject.tongSoLuong;
            m_cmd.Parameters.Add("TongTien", SqlDbType.Int).Value = _DeliveryNoteObject.tongTien;
            return m_DeliveryNoteExecute.updateData(m_cmd) > 0;
        }
        public DataTable getDeliveryNoteDataFromDatabase()
        {
            m_cmd = new SqlCommand();
            //SqlCommand sqlCommand = new SqlCommand();
            m_cmd.CommandType = CommandType.StoredProcedure;
            m_cmd.CommandText = "GetDeliveryNoteDateFromDatabase";
            return m_DeliveryNoteExecute.getData(m_cmd);
        }
        public DataTable lookAtDeliveryNoteDataFromDatabase(String _DeliveryNoteId)
        {
            m_cmd = new SqlCommand();
            //SqlCommand sqlCommand = new SqlCommand();
            m_cmd.CommandType = CommandType.StoredProcedure;
            m_cmd.CommandText = "LookAtDeliveryNoteDataFromDatabase";
            m_cmd.Parameters.Add("MaHD", SqlDbType.NVarChar).Value = _DeliveryNoteId;
            return m_DeliveryNoteExecute.getData(m_cmd);
        }
        public String getDeliveryNoteMaxIdFromDatabase()
        {
            m_cmd = new SqlCommand();
            //SqlCommand sqlCommand = new SqlCommand();
            m_cmd.CommandType = CommandType.StoredProcedure;
            m_cmd.CommandText = "GetDeliveryNoteMaxIdFromDatabase";
            if (m_DeliveryNoteExecute.getMaxId(m_cmd).Equals(""))
            {
                return "HD0000001";
            }
            return m_DeliveryNoteExecute.getMaxId(m_cmd);
        }
        public DataTable getDeliveryDataByRuleFromDatabase(String _tenNV, String _tenKH, String _soHD, DateTime _ngayHD)
        {
            m_cmd = new SqlCommand();
            m_cmd.CommandType = CommandType.StoredProcedure;
            m_cmd.CommandText = "GetDeliveryDataByRuleFromDatabase";
            m_cmd.Parameters.Add("TenNV", SqlDbType.NVarChar).Value = _tenNV;
            m_cmd.Parameters.Add("TenKH", SqlDbType.NVarChar).Value = _tenKH;
            m_cmd.Parameters.Add("SoHD", SqlDbType.NVarChar).Value = _soHD;
            m_cmd.Parameters.Add("NgayHD", SqlDbType.SmallDateTime).Value = _ngayHD;
            return m_DeliveryNoteExecute.getData(m_cmd);
        }
    }
}
