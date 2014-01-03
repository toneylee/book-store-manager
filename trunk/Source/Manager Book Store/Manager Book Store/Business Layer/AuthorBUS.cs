using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Manager_Book_Store.Data_Access_Layer;
using Manager_Book_Store.Data_Tranfer_Object;
using System.Data;

namespace Manager_Book_Store.Business_Layer
{
    class CAuthorBUS
    {
        private CAuthorDAL m_AuthorDAL;

        public CAuthorBUS()
        {
            m_AuthorDAL = new CAuthorDAL();
        }
        public bool AddAuthorToDatabase(CAuthorDTO _AuthorObject)
        {
            return m_AuthorDAL.AddAuthorToDatabase(_AuthorObject);
        }
        public bool DeleteAuthorToDatabase(CAuthorDTO _AuthorObject)
        {
            return m_AuthorDAL.DeleteAuthorToDatabase(_AuthorObject);
        }
        public bool UpdateAuthorToDatabase(CAuthorDTO _AuthorObject)
        {
            return m_AuthorDAL.UpdateAuthorToDatabase(_AuthorObject);
        }
         public DataTable getAuthorDataFromDatabase()
        {
            return m_AuthorDAL.getAuthorDataFromDatabase();
        }
         public DataTable lookAtAuthorDataFromDatabase(String _authorName)
         {
             return m_AuthorDAL.lookAtAuthorDataFromDatabase(_authorName);
         }
    }
}
