using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Manager_Book_Store.Data_Tranfer_Object;
using System.Data.SqlClient;
using System.Data;

namespace Manager_Book_Store.Data_Access_Layer
{
    class CReceiptNoteDAL
    {
        private CReceiptNoteDTO m_ReceiptNoteObject;
        private CDataExecute    m_ReceiptNoteExecute;
        private SqlCommand      m_cmd;

        public CReceiptNoteDAL(CReceiptNoteDTO _ReceiptNoteObject)
        {
            m_ReceiptNoteObject     =_ReceiptNoteObject;
            m_ReceiptNoteExecute    = new CDataExecute();
            m_cmd                   = new SqlCommand();
        }
        public CReceiptNoteDAL()
        {
            m_ReceiptNoteObject     = null;
            m_ReceiptNoteExecute    = new CDataExecute();
            m_cmd                   = new SqlCommand();
        }
        public bool AddReceiptNoteToDatabase(CReceiptNoteDTO _ReceiptNoteObject)
        {
            m_cmd = new SqlCommand();
            m_cmd.CommandType = CommandType.StoredProcedure;
            m_cmd.CommandText = "AddReceiptNoteDataToDatabase";
            m_cmd.Parameters.Add("MaPhieuNhap", SqlDbType.NVarChar).Value = _ReceiptNoteObject.maPhieuNhap;
            m_cmd.Parameters.Add("MaNV", SqlDbType.NVarChar).Value =_ReceiptNoteObject.maNhanVien;
            m_cmd.Parameters.Add("NgayNhapSach", SqlDbType.SmallDateTime).Value = _ReceiptNoteObject.ngayNhap;
            m_cmd.Parameters.Add("TongSoLuong", SqlDbType.Int).Value = _ReceiptNoteObject.TongSoLuong;
            m_cmd.Parameters.Add("TongTien", SqlDbType.Int).Value = _ReceiptNoteObject.TongTien;
            return m_ReceiptNoteExecute.updateData(m_cmd) > 0;
        }
        public bool DeleteReceiptNoteToDatabase(CReceiptNoteDTO _ReceiptNoteObject)
        {
            m_cmd = new SqlCommand();
            m_cmd.CommandType = CommandType.StoredProcedure;
            m_cmd.CommandText = "DeleteReceiptNoteDataToDatabase";
            m_cmd.Parameters.Add("MaPhieuNhap", SqlDbType.NVarChar).Value =_ReceiptNoteObject.maPhieuNhap;
            return m_ReceiptNoteExecute.updateData(m_cmd) > 0;
        }
        public bool UpdateReceiptNoteToDatabase(CReceiptNoteDTO _ReceiptNoteObject)
        {
            m_cmd = new SqlCommand();
            m_cmd.CommandType = CommandType.StoredProcedure;
            m_cmd.CommandText = "UpdateReceiptNoteDataToDatabase";
            m_cmd.Parameters.Add("MaPhieuNhap", SqlDbType.NVarChar).Value = _ReceiptNoteObject.maPhieuNhap;
            m_cmd.Parameters.Add("MaNV", SqlDbType.NVarChar).Value = _ReceiptNoteObject.maNhanVien;
            m_cmd.Parameters.Add("NgayNhapSach", SqlDbType.SmallDateTime).Value = _ReceiptNoteObject.ngayNhap;
            m_cmd.Parameters.Add("TongSoLuong", SqlDbType.Int).Value = _ReceiptNoteObject.TongSoLuong;
            m_cmd.Parameters.Add("TongTien", SqlDbType.Int).Value = _ReceiptNoteObject.TongTien;
            return m_ReceiptNoteExecute.updateData(m_cmd) > 0;
        }
        public DataTable getReceiptNoteDataFromDatabase()
        {
            m_cmd = new SqlCommand();
            //SqlCommand sqlCommand = new SqlCommand();
            m_cmd.CommandType = CommandType.StoredProcedure;
            m_cmd.CommandText = "GetReceiptNoteDataFromDatabase";
            return m_ReceiptNoteExecute.getData(m_cmd);
        }
        public DataTable lookAtReceiptNoteDataFromDatabase(String _ReceiptNoteId)
        {
            m_cmd = new SqlCommand();
            //SqlCommand sqlCommand = new SqlCommand();
            m_cmd.CommandType = CommandType.StoredProcedure;
            m_cmd.CommandText = "LookAtReceiptNoteDataFromDatabase";
            m_cmd.Parameters.Add("MaPhieuNhap", SqlDbType.NVarChar).Value = _ReceiptNoteId;
            return m_ReceiptNoteExecute.getData(m_cmd);
        }
        public String getReceiptNoteMaxIdFromDatabase()
        {
            m_cmd = new SqlCommand();
            //SqlCommand sqlCommand = new SqlCommand();
            m_cmd.CommandType = CommandType.StoredProcedure;
            m_cmd.CommandText = "GetReceiptNoteMaxIdFromDatabase";
            if (m_ReceiptNoteExecute.getMaxId(m_cmd).Equals(""))
            {
                return "PN0000001";
            }
            return m_ReceiptNoteExecute.getMaxId(m_cmd);
        }
    }
}
