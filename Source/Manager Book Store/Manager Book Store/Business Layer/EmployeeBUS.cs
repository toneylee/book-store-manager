using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Manager_Book_Store.Data_Access_Layer;
using Manager_Book_Store.Data_Tranfer_Object;
using System.Data;
using DevExpress.XtraEditors;

namespace Manager_Book_Store.Presentation_Layer
{
    class CEmployeeBUS
    {
        private CEmployeeDAL m_employeeDAL ;
        private CRegulationsDAL m_RegulationDAL;
        public CEmployeeBUS()
        {
            m_employeeDAL = new CEmployeeDAL();
            m_RegulationDAL = new CRegulationsDAL();
        }
        public bool AddEmployeeToDatabase(CEmployeeDTO _EmployeeObject)
        {
            return m_employeeDAL.AddEmployeeToDatabase(_EmployeeObject);
        }
        public bool DeleteEmployeeToDatabase(CEmployeeDTO _EmployeeObject)
        {
            return m_employeeDAL.DeleteEmployeeToDatabase(_EmployeeObject);
        }
        public bool UpdateEmployeeToDatabase(CEmployeeDTO _EmployeeObject)
        {
            return m_employeeDAL.UpdateEmployeeToDatabase(_EmployeeObject);
        }
        public DataTable getEmployeeDataFromDatabase()
        {
            return m_employeeDAL.getEmployeeDataFromDatabase();
        }
        public DataTable lookAtEmployeeDataFromDatabase(String _EmployeeName)
        {
            return m_employeeDAL.getEmployeeDataFromDatabase();
        }
        public DataTable getEmployeeDataByRuleFromDatabase(String _tenKH, String _diaChi, String _gioiTinh, String _email, String _soDienThoai, String _tenCV)
        {
            return m_employeeDAL.getEmployeeDataByRuleFromDatabase(_tenKH, _diaChi, _gioiTinh, _email, _soDienThoai, _tenCV);
        }
        public bool checkAge(DateTime _ngaySinh, DateTime _ngayVaoLam)
        {
            if ((_ngayVaoLam.Year - _ngaySinh.Year) >= m_RegulationDAL.getRegulationsDataByRuleFromDatabase("DoTuoiNhanVienToiThieu") && (_ngayVaoLam.Year - _ngaySinh.Year) <= m_RegulationDAL.getRegulationsDataByRuleFromDatabase("DoTuoiNhanVienToiDa"))
                return true;
            else
            {
                XtraMessageBox.Show("Độ tuổi không hợp lệ!\nXin vui lòng kiểm tra lại quy định");
                return false;
            }
        }

    }
}
