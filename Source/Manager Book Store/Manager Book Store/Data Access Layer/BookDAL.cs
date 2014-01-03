using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Manager_Book_Store.Data_Tranfer_Object;
using System.Data.SqlClient;
using System.Data;

namespace Manager_Book_Store.Data_Access_Layer
{
    class CBookDAL
    {
        private CBookDTO m_bookObject;
        private CDataExecute  m_bookExecute;
        private SqlCommand    m_cmd;

        public CBookDAL(CBookDTO _bookObject)
        {
            m_bookObject  =_bookObject;
            m_bookExecute = new CDataExecute();
            m_cmd           = new SqlCommand();
        }
        public CBookDAL()
        {
            m_bookObject  = null;
            m_bookExecute = new CDataExecute();
            m_cmd           = new SqlCommand();
        }
        public bool AddBookToDatabase(CBookDTO _bookObject)
        {
            m_cmd = new SqlCommand();
            m_cmd.CommandType = CommandType.StoredProcedure;
            m_cmd.CommandText = "AddBookDataToDatabase";
            m_cmd.Parameters.Add("MaSach", SqlDbType.NVarChar).Value = _bookObject.maSach;
            m_cmd.Parameters.Add("MaDauSach", SqlDbType.NVarChar).Value = _bookObject.maDauSach;
            m_cmd.Parameters.Add("MaNXB", SqlDbType.NVarChar).Value = _bookObject.maNhaXuatBan;
            m_cmd.Parameters.Add("GiaNhap", SqlDbType.Int).Value = _bookObject.giaNhap;
            m_cmd.Parameters.Add("SoLuong", SqlDbType.Int).Value = _bookObject.soLuong;
            m_cmd.Parameters.Add("NamXB", SqlDbType.Int).Value = _bookObject.namXuatBan;
            return m_bookExecute.updateData(m_cmd) > 0;
        }
        public bool DeleteBookToDatabase(CBookDTO _bookObject)
        {
            m_cmd = new SqlCommand();
            m_cmd.CommandType = CommandType.StoredProcedure;
            m_cmd.CommandText = "DeleteBookDataToDatabase";
            m_cmd.Parameters.Add("MaSach", SqlDbType.NVarChar).Value =_bookObject.maSach;
            return m_bookExecute.updateData(m_cmd) > 0;
        }
        public bool UpdateBookToDatabase(CBookDTO _bookObject)
        {
            m_cmd = new SqlCommand();
            m_cmd.CommandType = CommandType.StoredProcedure;
            m_cmd.CommandText = "UpdateBookDataToDatabase";
            m_cmd.Parameters.Add("MaSach", SqlDbType.NVarChar).Value = _bookObject.maSach;
            m_cmd.Parameters.Add("MaDauSach", SqlDbType.NVarChar).Value = _bookObject.maDauSach;
            m_cmd.Parameters.Add("MaNXB", SqlDbType.NVarChar).Value = _bookObject.maNhaXuatBan;
            m_cmd.Parameters.Add("GiaNhap", SqlDbType.Int).Value = _bookObject.giaNhap;
            m_cmd.Parameters.Add("SoLuong", SqlDbType.Int).Value = _bookObject.soLuong;
            m_cmd.Parameters.Add("NamXB", SqlDbType.Int).Value = _bookObject.namXuatBan;
            return m_bookExecute.updateData(m_cmd) > 0;
        }
        public DataTable getBookDataFromDatabase()
        {
            m_cmd = new SqlCommand();
            //SqlCommand sqlCommand = new SqlCommand();
            m_cmd.CommandType = CommandType.StoredProcedure;
            m_cmd.CommandText = "GetBookDataFromDatabase";
            return m_bookExecute.getData(m_cmd);
        }
        public DataTable GetBookDataByRuleFromDatabase(String _tensach, String _tenTG, String _tenTL, String _tenNXB, int _namXB, int _soLuong, int _giaNhap)
        {
            m_cmd = new SqlCommand();
            m_cmd.CommandType = CommandType.StoredProcedure;
            m_cmd.CommandText = "GetBookDataByRuleFromDatabase";
            m_cmd.Parameters.Add("TenSach", SqlDbType.NVarChar).Value = _tensach;
            m_cmd.Parameters.Add("TenTL", SqlDbType.NVarChar).Value = _tenTL;
            m_cmd.Parameters.Add("TenNXB", SqlDbType.NVarChar).Value = _tenNXB;
            m_cmd.Parameters.Add("NhomTG", SqlDbType.NVarChar).Value = _tenTG;
            m_cmd.Parameters.Add("GiaNhap", SqlDbType.Int).Value = _giaNhap;
            m_cmd.Parameters.Add("SoLuong", SqlDbType.Int).Value = _soLuong;
            m_cmd.Parameters.Add("NamXB", SqlDbType.Int).Value = _namXB;
            return m_bookExecute.getData(m_cmd);
        }
        public int getBookQuantityDataFromDatabase(String _maSach)
        {
            m_cmd = new SqlCommand();
            m_cmd.CommandType = CommandType.StoredProcedure;
            m_cmd.CommandText = "GetBookQuantityDataFromDatabase";
            m_cmd.Parameters.Add("MaSach", SqlDbType.NVarChar).Value = _maSach;
            if (m_bookExecute.getMaxId(m_cmd) != "")
                return int.Parse(m_bookExecute.getMaxId(m_cmd));
            else
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Không tồn tại cuốn sách này trong cơ sở dữ liệu!");
                return -1;
            }

        }
    }
}
