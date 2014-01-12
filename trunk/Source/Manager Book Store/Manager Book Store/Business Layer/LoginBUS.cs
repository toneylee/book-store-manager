using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Manager_Book_Store.Data_Access_Layer
{
    class CLoginBUS
    {
        private CLoginDAL m_LoginDAL;
        public CLoginBUS()
        {
            m_LoginDAL = new CLoginDAL();
        }

        public DataTable getEmployee_UserName_Pass(String _userName, String _passWord)
        {
            return m_LoginDAL.getEmployee_UserName_Pass(_userName, _passWord);
        }

        public String getStringEmployee_UserName(String _userName)
        {
            return m_LoginDAL.getStringEmployee_UserName(_userName);
        }

        public DataTable getEmployeeDataFromDatabase()
        {
            return m_LoginDAL.getEmployeeDataFromDatabase();
        }
    }
}
