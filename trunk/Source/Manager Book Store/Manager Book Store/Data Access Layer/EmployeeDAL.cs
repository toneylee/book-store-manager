using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Manager_Book_Store.Data_Tranfer_Object;
using System.Data.SqlClient;
using System.Data;

namespace Manager_Book_Store.Data_Access_Layer
{
    class CEmployeeDAL
    {
        private CEmployeeDTO m_EmployeeObject;
        private CDataExecute  m_EmployeeExecute;
        private SqlCommand    m_cmd;

        public CEmployeeDAL(CEmployeeDTO _EmployeeObject)
        {
            m_EmployeeObject  =_EmployeeObject;
            m_EmployeeExecute = new CDataExecute();
            m_cmd           = new SqlCommand();
        }
        public CEmployeeDAL()
        {
            m_EmployeeObject  = null;
            m_EmployeeExecute = new CDataExecute();
            m_cmd           = new SqlCommand();
        }
        public bool AddEmployeeToDatabase(CEmployeeDTO _EmployeeObject)
        {
            m_cmd = new SqlCommand();
            m_cmd.CommandType = CommandType.StoredProcedure;
            m_cmd.CommandText = "AddEmployeeDataToDatabase";
            m_cmd.Parameters.Add("MaNV", SqlDbType.NVarChar).Value = _EmployeeObject.maNhanVien;
            m_cmd.Parameters.Add("TenNV", SqlDbType.NVarChar).Value = _EmployeeObject.tenNhanVien;
            m_cmd.Parameters.Add("GioiTinh", SqlDbType.NVarChar).Value =_EmployeeObject.gioiTinh;
            m_cmd.Parameters.Add("NgaySinh", SqlDbType.SmallDateTime).Value = _EmployeeObject.ngaySinh;
            m_cmd.Parameters.Add("NgayVaoLam", SqlDbType.SmallDateTime).Value = _EmployeeObject.ngayVaoLam;
            m_cmd.Parameters.Add("DiaChi", SqlDbType.NVarChar).Value = _EmployeeObject.diaChi;
            m_cmd.Parameters.Add("SoDienThoai", SqlDbType.NVarChar).Value = _EmployeeObject.soDienThoai;
            m_cmd.Parameters.Add("MaCV", SqlDbType.NVarChar).Value = _EmployeeObject.maChucVu;
            m_cmd.Parameters.Add("TenDangNhap", SqlDbType.NVarChar).Value = _EmployeeObject.tenDangNhap;
            m_cmd.Parameters.Add("MatKhau", SqlDbType.NVarChar).Value = _EmployeeObject.matKhau;
            m_cmd.Parameters.Add("Email", SqlDbType.NVarChar).Value = _EmployeeObject.email;
            return m_EmployeeExecute.updateData(m_cmd) > 0;
        }
        public bool DeleteEmployeeToDatabase(CEmployeeDTO _EmployeeObject)
        {
            m_cmd = new SqlCommand();
            m_cmd.CommandType = CommandType.StoredProcedure;
            m_cmd.CommandText = "DeleteEmployeeDataToDatabase";
            m_cmd.Parameters.Add("MaNV", SqlDbType.NVarChar).Value = _EmployeeObject.maNhanVien;
            return m_EmployeeExecute.updateData(m_cmd) > 0;
        }
        public bool UpdateEmployeeToDatabase(CEmployeeDTO _EmployeeObject)
        {
            m_cmd = new SqlCommand();
            m_cmd.CommandType = CommandType.StoredProcedure;
            m_cmd.CommandText = "UpdateEmployeeDataToDatabase";
            m_cmd.Parameters.Add("MaNV", SqlDbType.NVarChar).Value = _EmployeeObject.maNhanVien;
            m_cmd.Parameters.Add("TenNV", SqlDbType.NVarChar).Value = _EmployeeObject.tenNhanVien;
            m_cmd.Parameters.Add("GioiTinh", SqlDbType.NVarChar).Value = _EmployeeObject.gioiTinh;
            m_cmd.Parameters.Add("NgaySinh", SqlDbType.SmallDateTime).Value = _EmployeeObject.ngaySinh;
            m_cmd.Parameters.Add("NgayVaoLam", SqlDbType.SmallDateTime).Value = _EmployeeObject.ngayVaoLam;
            m_cmd.Parameters.Add("DiaChi", SqlDbType.NVarChar).Value = _EmployeeObject.diaChi;
            m_cmd.Parameters.Add("MaCV", SqlDbType.NVarChar).Value = _EmployeeObject.maChucVu;
            m_cmd.Parameters.Add("SoDienThoai", SqlDbType.NVarChar).Value = _EmployeeObject.soDienThoai;
            m_cmd.Parameters.Add("Email", SqlDbType.NVarChar).Value = _EmployeeObject.email;
            return m_EmployeeExecute.updateData(m_cmd) > 0;
        }
        public DataTable getEmployeeDataFromDatabase()
        {
            m_cmd = new SqlCommand();
            //SqlCommand sqlCommand = new SqlCommand();
            m_cmd.CommandType = CommandType.StoredProcedure;
            m_cmd.CommandText = "GetEmployeeDataFromDatabase";
            return m_EmployeeExecute.getData(m_cmd);
        }
        public DataTable lookAtEmployeeDataFromDatabase(String _EmployeeName)
        {
            m_cmd = new SqlCommand();
            //SqlCommand sqlCommand = new SqlCommand();
            m_cmd.CommandType = CommandType.StoredProcedure;
            m_cmd.CommandText = "LookAtEmployeeDataFromDatabase";
            m_cmd.Parameters.Add("TenNV", SqlDbType.NVarChar).Value  = _EmployeeName;
            return m_EmployeeExecute.getData(m_cmd);
        }
        public DataTable getEmployeeDataByRuleFromDatabase(String _tenKH, String _diaChi, String _gioiTinh, String _email, String _soDienThoai, String _tenCV)
        {
            m_cmd = new SqlCommand();
            m_cmd.CommandType = CommandType.StoredProcedure;
            m_cmd.CommandText = "GetEmployeeDataByRuleFromDatabase";
            m_cmd.Parameters.Add("TenNV", SqlDbType.NVarChar).Value = _tenKH;
            m_cmd.Parameters.Add("GioiTinh", SqlDbType.NVarChar).Value = _gioiTinh;
            m_cmd.Parameters.Add("DiaChi", SqlDbType.NVarChar).Value = _diaChi;
            m_cmd.Parameters.Add("SoDienThoai", SqlDbType.NVarChar).Value = _soDienThoai;
            m_cmd.Parameters.Add("Email", SqlDbType.NVarChar).Value = _email;
            m_cmd.Parameters.Add("TenCV", SqlDbType.NVarChar).Value = _tenCV;
            return m_EmployeeExecute.getData(m_cmd);
        }
    }
}
