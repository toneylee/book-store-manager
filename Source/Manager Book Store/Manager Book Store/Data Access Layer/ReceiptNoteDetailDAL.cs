using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Manager_Book_Store.Data_Tranfer_Object;
using Manager_Book_Store.Data_Access_Layer;
using System.Data.SqlClient;
using System.Data;

namespace Manager_ReceiptNoteDetail_Store.Data_Access_Layer
{
    class CReceiptNoteDetailDAL
    {
        private CReceiptNoteDetailDTO m_ReceiptNoteDetailObject;
        private CDataExecute  m_ReceiptNoteDetailExecute;
        private SqlCommand    m_cmd;

        public CReceiptNoteDetailDAL(CReceiptNoteDetailDTO _ReceiptNoteDetailObject)
        {
            m_ReceiptNoteDetailObject  =_ReceiptNoteDetailObject;
            m_ReceiptNoteDetailExecute = new CDataExecute();
            m_cmd           = new SqlCommand();
        }
        public CReceiptNoteDetailDAL()
        {
            m_ReceiptNoteDetailObject  = null;
            m_ReceiptNoteDetailExecute = new CDataExecute();
            m_cmd           = new SqlCommand();
        }
        public bool AddReceiptNoteDetailToDatabase(CReceiptNoteDetailDTO _ReceiptNoteDetailObject)
        {
            m_cmd = new SqlCommand();
            m_cmd.CommandType = CommandType.StoredProcedure;
            m_cmd.CommandText = "AddReceiptNoteDetailDataToDatabase";
            m_cmd.Parameters.Add("MaPhieuNhap", SqlDbType.NVarChar).Value = _ReceiptNoteDetailObject.maPhieuNhap;
            m_cmd.Parameters.Add("MaSach", SqlDbType.NVarChar).Value = _ReceiptNoteDetailObject.maSach;
            m_cmd.Parameters.Add("DonGia", SqlDbType.Money).Value = _ReceiptNoteDetailObject.giaNhap;
            m_cmd.Parameters.Add("SoLuong", SqlDbType.Int).Value = _ReceiptNoteDetailObject.soLuong;
            m_cmd.Parameters.Add("ThanhTien", SqlDbType.Money).Value = _ReceiptNoteDetailObject.thanhTien;
            return m_ReceiptNoteDetailExecute.updateData(m_cmd) > 0;
        }
        public bool DeleteReceiptNoteDetailToDatabase(CReceiptNoteDetailDTO _ReceiptNoteDetailObject)
        {
            m_cmd = new SqlCommand();
            m_cmd.CommandType = CommandType.StoredProcedure;
            m_cmd.CommandText = "DeleteReceiptNoteDetailDataToDatabase";
            m_cmd.Parameters.Add("MaPhieuNhap", SqlDbType.NVarChar).Value = _ReceiptNoteDetailObject.maPhieuNhap;
            return m_ReceiptNoteDetailExecute.updateData(m_cmd) > 0;
        }
        public bool UpdateReceiptNoteDetailToDatabase(CReceiptNoteDetailDTO _ReceiptNoteDetailObject)
        {
            m_cmd = new SqlCommand();
            m_cmd.CommandType = CommandType.StoredProcedure;
            m_cmd.CommandText = "UpdateReceiptNoteDetailDataToDatabase";
            m_cmd.Parameters.Add("MaPhieuNhap", SqlDbType.NVarChar).Value = _ReceiptNoteDetailObject.maPhieuNhap;
            m_cmd.Parameters.Add("MaSach", SqlDbType.NVarChar).Value = _ReceiptNoteDetailObject.maSach;
            m_cmd.Parameters.Add("DonGia", SqlDbType.Money).Value = _ReceiptNoteDetailObject.giaNhap;
            m_cmd.Parameters.Add("SoLuong", SqlDbType.Int).Value = _ReceiptNoteDetailObject.soLuong;
            m_cmd.Parameters.Add("ThanhTien", SqlDbType.Money).Value = _ReceiptNoteDetailObject.thanhTien;
            return m_ReceiptNoteDetailExecute.updateData(m_cmd) > 0;
        }
        public DataTable getReceiptNoteDetailDataFromDatabase()
        {
            m_cmd = new SqlCommand();
            //SqlCommand sqlCommand = new SqlCommand();
            m_cmd.CommandType = CommandType.StoredProcedure;
            m_cmd.CommandText = "GetReceiptNoteDetailDataFromDatabase";
            return m_ReceiptNoteDetailExecute.getData(m_cmd);
        }
    }
}
