using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Manager_Book_Store.Data_Access_Layer;
using Manager_Book_Store.Data_Tranfer_Object;
using System.Data;

namespace Manager_Book_Store.Business_Layer
{
    class CAuthorDetailBUS
    {
        private CAuthorDetailDAL m_AuthorDetailDAL;

        public CAuthorDetailBUS()
        {
            m_AuthorDetailDAL = new CAuthorDetailDAL();
        }
        public bool AddAuthorDetailToDatabase(CAuthorDetailDTO _authorDetailObject)
        {
            return m_AuthorDetailDAL.AddAuthorDetailToDatabase(_authorDetailObject);
        }
        public bool DeleteAuthorDetailToDatabase(CAuthorDetailDTO _authorDetailObject)
        {
            return m_AuthorDetailDAL.DeleteAuthorDetailToDatabase(_authorDetailObject);
        }
        public bool UpdateAuthorDetailToDatabase(CAuthorDetailDTO _authorDetailObject)
        {
            return m_AuthorDetailDAL.UpdateAuthorDetailToDatabase(_authorDetailObject);
        }
         public DataTable getAuthorDetailDataFromDatabase()
        {
            return m_AuthorDetailDAL.getAuthorDetailDataFromDatabase();
        }
    }
}
