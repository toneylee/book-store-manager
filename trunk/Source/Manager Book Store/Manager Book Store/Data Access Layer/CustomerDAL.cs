using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Manager_Book_Store.Data_Tranfer_Object;
using System.Data.SqlClient;
using System.Data;

namespace Manager_Book_Store.Data_Access_Layer
{
    class CCustomerDAL
    {
        private CCustomerDTO m_CustomerObject;
        private CDataExecute  m_CustomerExecute;
        private SqlCommand    m_cmd;

        public CCustomerDAL(CCustomerDTO _CustomerObject)
        {
            m_CustomerObject  =_CustomerObject;
            m_CustomerExecute = new CDataExecute();
            m_cmd           = new SqlCommand();
        }
        public CCustomerDAL()
        {
            m_CustomerObject  = null;
            m_CustomerExecute = new CDataExecute();
            m_cmd           = new SqlCommand();
        }
        public bool AddCustomerToDatabase(CCustomerDTO _CustomerObject)
        {
            m_cmd = new SqlCommand();
            m_cmd.CommandType = CommandType.StoredProcedure;
            m_cmd.CommandText = "AddCustomerDataToDatabase";
            m_cmd.Parameters.Add("MaKH", SqlDbType.NVarChar).Value = _CustomerObject.maKhachHang;
            m_cmd.Parameters.Add("TenKH", SqlDbType.NVarChar).Value = _CustomerObject.tenKhachHang;
            m_cmd.Parameters.Add("GioiTinh", SqlDbType.NVarChar).Value =_CustomerObject.gioiTinh;
            m_cmd.Parameters.Add("SoDienThoai", SqlDbType.NVarChar).Value = _CustomerObject.soDienThoai;
            m_cmd.Parameters.Add("NgaySinh", SqlDbType.SmallDateTime).Value = _CustomerObject.ngaySinh;
            m_cmd.Parameters.Add("DiaChi", SqlDbType.NVarChar).Value = _CustomerObject.diaChi;
            m_cmd.Parameters.Add("Email", SqlDbType.NVarChar).Value = _CustomerObject.Email;
            m_cmd.Parameters.Add("TienNo", SqlDbType.Money).Value = _CustomerObject.tienNo;
            return m_CustomerExecute.updateData(m_cmd) > 0;
        }
        public bool DeleteCustomerToDatabase(CCustomerDTO _CustomerObject)
        {
            m_cmd = new SqlCommand();
            m_cmd.CommandType = CommandType.StoredProcedure;
            m_cmd.CommandText = "DeleteCustomerDataToDatabase";
            m_cmd.Parameters.Add("MaKH", SqlDbType.NVarChar).Value = _CustomerObject.maKhachHang;
            return m_CustomerExecute.updateData(m_cmd) > 0;
        }
        public bool UpdateCustomerToDatabase(CCustomerDTO _CustomerObject)
        {
            m_cmd = new SqlCommand();
            m_cmd.CommandType = CommandType.StoredProcedure;
            m_cmd.CommandText = "UpdateCustomerDataToDatabase";
            m_cmd.Parameters.Add("MaKH", SqlDbType.NVarChar).Value = _CustomerObject.maKhachHang;
            m_cmd.Parameters.Add("TenKH", SqlDbType.NVarChar).Value = _CustomerObject.tenKhachHang;
            m_cmd.Parameters.Add("GioiTinh", SqlDbType.NVarChar).Value = _CustomerObject.gioiTinh;
            m_cmd.Parameters.Add("NgaySinh", SqlDbType.SmallDateTime).Value = _CustomerObject.ngaySinh;
            m_cmd.Parameters.Add("DiaChi", SqlDbType.NVarChar).Value = _CustomerObject.diaChi;
            m_cmd.Parameters.Add("SoDienThoai", SqlDbType.NVarChar).Value = _CustomerObject.soDienThoai;
            m_cmd.Parameters.Add("Email", SqlDbType.NVarChar).Value = _CustomerObject.Email;
            m_cmd.Parameters.Add("TienNo", SqlDbType.Money).Value = _CustomerObject.tienNo;
            return m_CustomerExecute.updateData(m_cmd) > 0;
        }
        public DataTable getCustomerDataFromDatabase()
        {
            m_cmd = new SqlCommand();
            //SqlCommand sqlCommand = new SqlCommand();
            m_cmd.CommandType = CommandType.StoredProcedure;
            m_cmd.CommandText = "GetCustomerDataFromDatabase";
            return m_CustomerExecute.getData(m_cmd);
        }
        public DataTable lookAtCustomerDataFromDatabase(String _CustomerName)
        {
            m_cmd = new SqlCommand();
            //SqlCommand sqlCommand = new SqlCommand();
            m_cmd.CommandType = CommandType.StoredProcedure;
            m_cmd.CommandText = "LookAtCustomerDataFromDatabase";
            m_cmd.Parameters.Add("TenKH", SqlDbType.NVarChar).Value  = _CustomerName;
            return m_CustomerExecute.getData(m_cmd);
        }
        public bool UpdateDebitOfCustomerDataToDatabase(CCustomerDTO _CustomerObject)
        {
            m_cmd = new SqlCommand();
            m_cmd.CommandType = CommandType.StoredProcedure;
            m_cmd.CommandText = "UpdateDebitOfCustomerDataToDatabase";
            m_cmd.Parameters.Add("MaKH", SqlDbType.NVarChar).Value = _CustomerObject.maKhachHang;
            m_cmd.Parameters.Add("SoTienNo", SqlDbType.Money).Value = _CustomerObject.tienNo;
            return m_CustomerExecute.updateData(m_cmd) > 0;
        }
        public DataTable getCustomerDataByRuleFromDatabase(String _tenKH, String _diaChi, String _gioiTinh, String _email, String _soDienThoai, int _tienNo)
        {
            m_cmd = new SqlCommand();
            m_cmd.CommandType = CommandType.StoredProcedure;
            m_cmd.CommandText = "GetCustomerDataByRuleFromDatabase";
            m_cmd.Parameters.Add("TenKH", SqlDbType.NVarChar).Value = _tenKH;
            m_cmd.Parameters.Add("GioiTinh", SqlDbType.NVarChar).Value = _gioiTinh;
            m_cmd.Parameters.Add("DiaChi", SqlDbType.NVarChar).Value = _diaChi;
            m_cmd.Parameters.Add("SoDienThoai", SqlDbType.NVarChar).Value = _soDienThoai;
            m_cmd.Parameters.Add("Email", SqlDbType.NVarChar).Value = _email;
            m_cmd.Parameters.Add("TienNo", SqlDbType.Money).Value = _tienNo;
            return m_CustomerExecute.getData(m_cmd);
        }
        public int getCustomerDebitsDataFromDatabase(String _maKhachHang)
        {
            m_cmd = new SqlCommand();
            m_cmd.CommandType = CommandType.StoredProcedure;
            m_cmd.CommandText = "GetCustomerDebitsDataFromDatabase";
            m_cmd.Parameters.Add("MaKH", SqlDbType.NVarChar).Value = _maKhachHang;
            if (m_CustomerExecute.getMaxId(m_cmd) != "")
                return int.Parse(m_CustomerExecute.getMaxId(m_cmd));
            else
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Không tồn tại khách hàng này trong cơ sở dữ liệu!");
                return -1;
            }
        }
    }
}
