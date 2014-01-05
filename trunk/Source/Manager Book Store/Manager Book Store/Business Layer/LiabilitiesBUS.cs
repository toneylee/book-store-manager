using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Manager_Book_Store.Data_Access_Layer;
using System.Data;

namespace Manager_Book_Store.Business_Layer
{
    class CLiabilitiesBUS
    {
        #region "Variable"
        private CLiabilitiesDAL m_LiabilitiesDAL;
        #endregion
        #region "Method"
        public CLiabilitiesBUS()
        {
            this.m_LiabilitiesDAL = new CLiabilitiesDAL();

        }
        public DataTable getLiabilitiesOfMonth(DateTime m_thangNam)
        {
            return m_LiabilitiesDAL.getLiabilitiesOfMonth(m_thangNam);
        }
        #endregion
    }
}
