using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Manager_Book_Store.Data_Access_Layer;
using Manager_Book_Store.Data_Tranfer_Object;
using System.Data;

namespace Manager_Book_Store.Business_Layer
{
    class CChargeBUS
    {
        private CChargeDAL m_ChargeDAL;

        public CChargeBUS()
        {
            m_ChargeDAL = new CChargeDAL();
        }
        public bool AddChargeToDatabase(CChargeDTO _ChargeObject)
        {
            return m_ChargeDAL.AddChargeToDatabase(_ChargeObject);
        }
        public bool DeleteChargeToDatabase(CChargeDTO _ChargeObject)
        {
            return m_ChargeDAL.DeleteChargeToDatabase(_ChargeObject);
        }
        public bool UpdateChargeToDatabase(CChargeDTO _ChargeObject)
        {
            return m_ChargeDAL.UpdateChargeToDatabase(_ChargeObject);
        }
         public DataTable getChargeDataFromDatabase()
        {
            return m_ChargeDAL.getChargeDataFromDatabase();
        }
         public DataTable lookAtChargeDataFromDatabase(String _ChargeName)
         {
             return m_ChargeDAL.lookAtChargeDataFromDatabase(_ChargeName);
         }
    }
}
