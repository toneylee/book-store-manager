using Manager_Book_Store.Data_Access_Layer;
using Manager_Book_Store.Data_Tranfer_Object;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace Manager_Book_Store.Business_Layer
{
    class DecentralizationBUS
    {
        private DecentralizationDAL m_DecentralizationDAL;

        public DecentralizationBUS()
        {
            m_DecentralizationDAL = new DecentralizationDAL();
        }

        public bool AddDecentralizationToDatabase(DecentralizationDTO _DecentralizationOject)
        {
            return m_DecentralizationDAL.AddDecentralizationToDatabase(_DecentralizationOject);
        }

        public bool DeleteDecentralizationDataToDatabase(DecentralizationDTO _DecentralizationOject)
        {
            return m_DecentralizationDAL.DeleteDecentralizationDataToDatabase(_DecentralizationOject);
        }

        public bool UpdateDecentralizationToDatabase(DecentralizationDTO _DecentralizationOject)
        {
            return m_DecentralizationDAL.UpdateDecentralizationToDatabase(_DecentralizationOject);
        }

        public DataTable getDecentralizationFromDatabase()
        {
            return m_DecentralizationDAL.getDecentralizationFromDatabase();
        }

        public DataTable getDecentralizationWithMaCV(DecentralizationDTO _DecentralizationOject)
        {
            return m_DecentralizationDAL.getDecentralizationWithMaCV(_DecentralizationOject);
        }
    }
}
