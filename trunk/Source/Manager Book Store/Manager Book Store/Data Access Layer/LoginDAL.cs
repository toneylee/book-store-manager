using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Manager_Book_Store.Data_Access_Layer
{
    class CLoginDAL
    {
        private CDataExecute m_LoginExecute;
        private SqlCommand m_cmd;

        public CLoginDAL()
        {
            m_LoginExecute = new CDataExecute();
        }

        public DataTable getEmployee_UserName_Pass(String _userName, String _passWord)
        {
            m_cmd = new SqlCommand();
            m_cmd.CommandType = CommandType.StoredProcedure;
            m_cmd.CommandText = "GetEmployeeUserNamePassWord";
            m_cmd.Parameters.Add(new SqlParameter("UserName", SqlDbType.NVarChar)).Value = _userName;
            m_cmd.Parameters.Add(new SqlParameter("PassWord", SqlDbType.NVarChar)).Value = _passWord;
            return m_LoginExecute.getData(m_cmd);
        }

        public String getStringEmployee_UserName(String _userName)
        {
            m_cmd = new SqlCommand();
            m_cmd.CommandType = CommandType.StoredProcedure;
            m_cmd.CommandText = "GetEmployeeUserName";
            m_cmd.Parameters.Add(new SqlParameter("UserName", SqlDbType.NVarChar)).Value = _userName;
            return m_LoginExecute.getStringExecuter(m_cmd);
        }
        
        public DataTable getEmployeeDataFromDatabase()
        {
            m_cmd = new SqlCommand();
            m_cmd.CommandType = CommandType.StoredProcedure;
            m_cmd.CommandText = "GetEmployeeDataFromDatabase";
            return m_LoginExecute.getData(m_cmd);
        }
    }
}
