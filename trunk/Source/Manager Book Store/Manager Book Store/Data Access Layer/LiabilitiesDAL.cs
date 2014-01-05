using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Manager_Book_Store.Data_Tranfer_Object;
using System.Data;
using System.Data.SqlClient;

namespace Manager_Book_Store.Data_Access_Layer
{
    class CLiabilitiesDAL
    {
        #region "Variable"
        private SqlCommand m_cmd;
        private CDataExecute m_LiabilitiesExecute;
        #endregion
        #region "Method"
        public CLiabilitiesDAL()
        {
            m_LiabilitiesExecute = new CDataExecute();
        }
        public DataTable getLiabilitiesOfMonth(DateTime m_thangNam)
        {
            m_cmd = new SqlCommand();
            m_cmd.CommandType = CommandType.StoredProcedure;
            m_cmd.CommandText = "GetLiabilitesOfMonth";
            m_cmd.Parameters.Add("ThangNam", SqlDbType.Date).Value = m_thangNam;
            return m_LiabilitiesExecute.getData(m_cmd);
        }
        #endregion
    }
}
