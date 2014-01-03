using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Manager_Book_Store.Data_Access_Layer;
using Manager_Book_Store.Data_Tranfer_Object;
using System.Data;

namespace Manager_Book_Store.Business_Layer
{
    class CBookGenreBUS
    {
        private CBookGenreDAL m_BookGenreDAL;

        public CBookGenreBUS()
        {
            m_BookGenreDAL = new CBookGenreDAL();
        }
        public bool AddBookGenreToDatabase(CBookGenreDTO _bookGenreObject)
        {
            return m_BookGenreDAL.AddBookGenreToDatabase(_bookGenreObject);
        }
        public bool DeleteBookGenreToDatabase(CBookGenreDTO _bookGenreObject)
        {
            return m_BookGenreDAL.DeleteBookGenreToDatabase(_bookGenreObject);
        }
        public bool UpdateBookGenreToDatabase(CBookGenreDTO _bookGenreObject)
        {
            return m_BookGenreDAL.UpdateBookGenreToDatabase(_bookGenreObject);
        }
         public DataTable getBookGenreDataFromDatabase()
        {
            return m_BookGenreDAL.getBookGenreDataFromDatabase();
        }
         public DataTable lookAtBookGenreDataFromDatabase(String _bookGenreName)
         {
             return m_BookGenreDAL.lookAtBookGenreDataFromDatabase(_bookGenreName);
         }
    }
}
