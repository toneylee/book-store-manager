using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Manager_Book_Store.Data_Access_Layer;
using Manager_Book_Store.Data_Tranfer_Object;
using System.Data;

namespace Manager_Book_Store.Business_Layer
{
    class CDeliveryNoteBUS
    {
        private CDeliveryNoteDAL    m_DeliveryNoteDAL;

        public CDeliveryNoteBUS()
        {
            m_DeliveryNoteDAL    = new CDeliveryNoteDAL();
        }
        public bool AddDeliveryNoteToDatabase(CDeliveryNoteDTO _DeliveryNoteObject)
        {

            return m_DeliveryNoteDAL.AddDeliveryNoteToDatabase(_DeliveryNoteObject);
        }
        public bool DeleteDeliveryNoteToDatabase(CDeliveryNoteDTO _DeliveryNoteObject)
        {
            return m_DeliveryNoteDAL.DeleteDeliveryNoteToDatabase(_DeliveryNoteObject);
        }
        public bool UpdateDeliveryNoteToDatabase(CDeliveryNoteDTO _DeliveryNoteObject)
        {
            return m_DeliveryNoteDAL.UpdateDeliveryNoteToDatabase(_DeliveryNoteObject);
        }
        public DataTable getDeliveryNoteDataFromDatabase()
        {
            return m_DeliveryNoteDAL.getDeliveryNoteDataFromDatabase();
        }
        public DataTable lookAtDeliveryNoteDataFromDatabase(String _DeliveryNoteId)
        {
            return m_DeliveryNoteDAL.lookAtDeliveryNoteDataFromDatabase(_DeliveryNoteId);
        }
        public String getDeliveryNoteMaxIdFromDatabase()
        {
            return m_DeliveryNoteDAL.getDeliveryNoteMaxIdFromDatabase();
        }
        public DataTable getDeliveryDataByRuleFromDatabase(String _tenNV, String _tenKH, String _soHD, DateTime _ngayHD)
        {
            return m_DeliveryNoteDAL.getDeliveryDataByRuleFromDatabase(_tenNV, _tenKH, _soHD, _ngayHD);
        }
    }
}
