using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Manager_Book_Store.Data_Tranfer_Object;
using Manager_Book_Store.Data_Access_Layer;
using System.Data;

namespace Manager_Book_Store.Business_Layer
{

    class CBookBUS
    {
        #region "Variable"
        //private CBookDTO m_BookObject;
        private CBookDAL m_BookDAL;
        #endregion
        #region "Properties"
        public CBookBUS()
        {
            m_BookDAL = new CBookDAL();
        }
        #endregion
        #region "Method"
        public bool AddBookToDatabase(CBookDTO _bookObject)
        {
            return m_BookDAL.AddBookToDatabase(_bookObject);
        }
        public bool DeleteBookToDatabase(CBookDTO _bookObject)
        {
            return m_BookDAL.DeleteBookToDatabase(_bookObject);
        }
        public bool UpdateBookToDatabase(CBookDTO _bookObject)
        {
            return m_BookDAL.UpdateBookToDatabase(_bookObject);
        }
        public DataTable getBookDataFromDatabase()
        {
            return m_BookDAL.getBookDataFromDatabase();
        }
        public DataTable GetBookDataByRuleFromDatabase(String _tensach, String _tenTG, String _tenTL, String _tenNXB, int _namXB, int _soLuong, int _giaNhap)
        {
            return m_BookDAL.GetBookDataByRuleFromDatabase(_tensach, _tenTG, _tenTL, _tenNXB, _namXB, _soLuong, _giaNhap);
        }

        #endregion
    }
}
