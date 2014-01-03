using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Manager_Book_Store.Data_Access_Layer;
using Manager_Book_Store.Data_Tranfer_Object;
using System.Data;

namespace Manager_Book_Store.Business_Layer
{
    class CReceiptNoteBUS
    {
        private CReceiptNoteDAL    m_ReceiptNoteDAL;

        public CReceiptNoteBUS()
        {
            m_ReceiptNoteDAL    = new CReceiptNoteDAL();
        }
        public bool AddReceiptNoteToDatabase(CReceiptNoteDTO _ReceiptNoteObject)
        {

            return m_ReceiptNoteDAL.AddReceiptNoteToDatabase(_ReceiptNoteObject);
        }
        public bool DeleteReceiptNoteToDatabase(CReceiptNoteDTO _ReceiptNoteObject)
        {
            return m_ReceiptNoteDAL.DeleteReceiptNoteToDatabase(_ReceiptNoteObject);
        }
        public bool UpdateReceiptNoteToDatabase(CReceiptNoteDTO _ReceiptNoteObject)
        {
            return m_ReceiptNoteDAL.UpdateReceiptNoteToDatabase(_ReceiptNoteObject);
        }
        public DataTable getReceiptNoteDataFromDatabase()
        {
            return m_ReceiptNoteDAL.getReceiptNoteDataFromDatabase();
        }
        public DataTable lookAtReceiptNoteDataFromDatabase(String _ReceiptNoteId)
        {
            return m_ReceiptNoteDAL.lookAtReceiptNoteDataFromDatabase(_ReceiptNoteId);
        }
        public String getReceiptNoteMaxIdFromDatabase()
        {
            return m_ReceiptNoteDAL.getReceiptNoteMaxIdFromDatabase();
        }
    }
}
