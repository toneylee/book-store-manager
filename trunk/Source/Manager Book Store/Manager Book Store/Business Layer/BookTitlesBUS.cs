using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Manager_Book_Store.Data_Access_Layer;
using Manager_Book_Store.Data_Tranfer_Object;
using System.Data;

namespace Manager_Book_Store.Business_Layer
{
    class CBookTitlesBUS
    {
        private CBookTitlesDAL m_BookTitlesDAL;

        public CBookTitlesBUS()
        {
            m_BookTitlesDAL = new CBookTitlesDAL();
        }
        public bool AddBookTitlesToDatabase(CBookTitlesDTO _bookTitlesObject)
        {
            return m_BookTitlesDAL.AddBookTitlesToDatabase(_bookTitlesObject);
        }
        public bool DeleteBookTitlesToDatabase(CBookTitlesDTO _bookTitlesObject)
        {
            return m_BookTitlesDAL.DeleteBookTitlesToDatabase(_bookTitlesObject);
        }
        public bool UpdateBookTitlesToDatabase(CBookTitlesDTO _bookTitlesObject)
        {
            return m_BookTitlesDAL.UpdateBookTitlesToDatabase(_bookTitlesObject);
        }
        public DataTable getBookTitlesDataFromDatabase()
        {
            return m_BookTitlesDAL.getBookTitlesDataFromDatabase();
        }
        public String getBookTitlesMaxIdFromDatabase()
        {
            return m_BookTitlesDAL.getBookTitlesMaxIdFromDatabase();
        }
    }
}
