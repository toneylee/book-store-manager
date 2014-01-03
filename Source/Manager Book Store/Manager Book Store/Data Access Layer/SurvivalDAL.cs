using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Manager_Book_Store.Data_Tranfer_Object;
using System.Data;
using System.Data.SqlClient;

namespace Manager_Book_Store.Data_Access_Layer
{
    class CSurvivalDAL
    {
        #region "Variable"
        private SqlCommand m_cmd;
        private CDataExecute m_SurvivalExecute;
        #endregion
        #region "Method"
        public CSurvivalDAL()
        {
            m_SurvivalExecute = new CDataExecute();
        }
        public DataTable getSurvivalOfMonth(DateTime m_thangNam)
        {
            m_cmd = new SqlCommand();
            m_cmd.CommandType = CommandType.StoredProcedure;
            m_cmd.CommandText = "GetSurvivalOfMonth";
            m_cmd.Parameters.Add("ThangNam", SqlDbType.Date).Value = m_thangNam;
            return m_SurvivalExecute.getData(m_cmd);
        }
        #endregion
    }
}
