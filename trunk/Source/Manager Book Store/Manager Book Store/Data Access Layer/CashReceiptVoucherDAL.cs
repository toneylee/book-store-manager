using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Manager_Book_Store.Data_Tranfer_Object;
using System.Data.SqlClient;
using System.Data;
namespace Manager_Book_Store.Data_Access_Layer
{
    class CCashReceiptVoucherDAL
    {
        private CCashReceiptVoucherDTO m_CashReceiptVoucherObject;
        private CDataExecute    m_CashReceiptVoucherExecute;
        private SqlCommand      m_cmd;

        public CCashReceiptVoucherDAL(CCashReceiptVoucherDTO _CashReceiptVoucherObject)
        {
            m_CashReceiptVoucherObject     =_CashReceiptVoucherObject;
            m_CashReceiptVoucherExecute    = new CDataExecute();
            m_cmd                   = new SqlCommand();
        }
        public CCashReceiptVoucherDAL()
        {
            m_CashReceiptVoucherObject     = null;
            m_CashReceiptVoucherExecute    = new CDataExecute();
            m_cmd                   = new SqlCommand();
        }
        public bool AddCashReceiptVoucherToDatabase(CCashReceiptVoucherDTO _CashReceiptVoucherObject)
        {
            m_cmd = new SqlCommand();
            m_cmd.CommandType = CommandType.StoredProcedure;
            m_cmd.CommandText = "AddCashReceiptVoucherDataToDatabase";
            m_cmd.Parameters.Add("MaPhieuThu", SqlDbType.NVarChar).Value = _CashReceiptVoucherObject.maPhieuThu;
            m_cmd.Parameters.Add("MaKH", SqlDbType.NVarChar).Value = _CashReceiptVoucherObject.maKhachHang;
            m_cmd.Parameters.Add("MaNV", SqlDbType.NVarChar).Value =_CashReceiptVoucherObject.maNhanVien;
            m_cmd.Parameters.Add("NgayThu", SqlDbType.SmallDateTime).Value = _CashReceiptVoucherObject.ngayThu;
            m_cmd.Parameters.Add("SoTienThu", SqlDbType.Int).Value = _CashReceiptVoucherObject.soTienThu;
            return m_CashReceiptVoucherExecute.updateData(m_cmd) > 0;
        }
        public bool DeleteCashReceiptVoucherToDatabase(CCashReceiptVoucherDTO _CashReceiptVoucherObject)
        {
            m_cmd = new SqlCommand();
            m_cmd.CommandType = CommandType.StoredProcedure;
            m_cmd.CommandText = "DeleteCashReceiptVoucherDataToDatabase";
            m_cmd.Parameters.Add("MaPhieuNhap", SqlDbType.NVarChar).Value =_CashReceiptVoucherObject.maPhieuThu;
            return m_CashReceiptVoucherExecute.updateData(m_cmd) > 0;
        }
        public bool UpdateCashReceiptVoucherToDatabase(CCashReceiptVoucherDTO _CashReceiptVoucherObject)
        {
            m_cmd = new SqlCommand();
            m_cmd.CommandType = CommandType.StoredProcedure;
            m_cmd.CommandText = "UpdateCashReceiptVoucherDataToDatabase";
            m_cmd.Parameters.Add("MaPhieuThu", SqlDbType.NVarChar).Value = _CashReceiptVoucherObject.maPhieuThu;
            m_cmd.Parameters.Add("MaKH", SqlDbType.NVarChar).Value = _CashReceiptVoucherObject.maKhachHang;
            m_cmd.Parameters.Add("MaNV", SqlDbType.NVarChar).Value = _CashReceiptVoucherObject.maNhanVien;
            m_cmd.Parameters.Add("NgayThu", SqlDbType.SmallDateTime).Value = _CashReceiptVoucherObject.ngayThu;
            m_cmd.Parameters.Add("SoTienThu", SqlDbType.Int).Value = _CashReceiptVoucherObject.soTienThu;
            return m_CashReceiptVoucherExecute.updateData(m_cmd) > 0;
        }
        public DataTable getCashReceiptVoucherDataFromDatabase()
        {
            m_cmd = new SqlCommand();
            //SqlCommand sqlCommand = new SqlCommand();
            m_cmd.CommandType = CommandType.StoredProcedure;
            m_cmd.CommandText = "GetCashReceiptVoucherDataFromDatabase";
            return m_CashReceiptVoucherExecute.getData(m_cmd);
        }
        public DataTable lookAtCashReceiptVoucherDataFromDatabase(String _CashReceiptVoucherId)
        {
            m_cmd = new SqlCommand();
            //SqlCommand sqlCommand = new SqlCommand();
            m_cmd.CommandType = CommandType.StoredProcedure;
            m_cmd.CommandText = "LookAtCashReceiptVoucherDataFromDatabase";
            m_cmd.Parameters.Add("MaPhieuThu", SqlDbType.NVarChar).Value = _CashReceiptVoucherId;
            return m_CashReceiptVoucherExecute.getData(m_cmd);
        }
        public String getCashReceiptVoucherMaxIdFromDatabase()
        {
            m_cmd = new SqlCommand();
            //SqlCommand sqlCommand = new SqlCommand();
            m_cmd.CommandType = CommandType.StoredProcedure;
            m_cmd.CommandText = "GetCashReceiptVoucherMaxIdFromDatabase";
            if (m_CashReceiptVoucherExecute.getMaxId(m_cmd).Equals(""))
            {
                return "PT0000001";
            }
            return m_CashReceiptVoucherExecute.getMaxId(m_cmd);
        }
    }
}
