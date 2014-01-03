using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Manager_Book_Store.Data_Access_Layer;
using System.Data;

namespace Manager_Book_Store.Business_Layer
{
    class CSurvivalBUS
    {
        #region "Variable"
        private CSurvivalDAL m_SurvivalDAL;
        #endregion
        #region "Method"
        public CSurvivalBUS()
        {
            this.m_SurvivalDAL = new CSurvivalDAL();

        }
        public DataTable getSurvivalOfMonth(DateTime m_thangNam)
        {
            return m_SurvivalDAL.getSurvivalOfMonth(m_thangNam);
        }
        #endregion
    }
}
