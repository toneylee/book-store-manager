using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Manager_Book_Store.Data_Access_Layer;
using Manager_Book_Store.Data_Tranfer_Object;
using System.Data;

namespace Manager_Book_Store.Business_Layer
{
    class CRegulationsBUS
    {
        #region "Variable"
        private CRegulationsDAL m_RegulationsDAL;
        #endregion
        #region "Method"
        public CRegulationsBUS()
        {
            m_RegulationsDAL = new CRegulationsDAL();
        }
        public bool AddRegulationsToDatabase(CRegulationsDTO _RegulationsObject)
        {
            return m_RegulationsDAL.AddRegulationsToDatabase(_RegulationsObject);
        }
        public bool UpdateRegulationsToDatabase(CRegulationsDTO _RegulationsObject)
        {
            return m_RegulationsDAL.UpdateRegulationsToDatabase(_RegulationsObject);
        }
        public DataTable getRegulationsDataFromDatabase()
        {
            return m_RegulationsDAL.getRegulationsDataFromDatabase();
        }
        public int getRegulationsDataByRuleFromDatabase(String _tenQuyDinh)
        {
            return m_RegulationsDAL.getRegulationsDataByRuleFromDatabase(_tenQuyDinh);
        }
        #endregion
    }
}
