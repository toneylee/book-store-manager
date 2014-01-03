using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Manager_Book_Store.Data_Access_Layer;
using Manager_Book_Store.Data_Tranfer_Object;
using System.Data;

namespace Manager_Book_Store.Business_Layer
{
    class CPublisherBUS
    {
        private CPublisherDAL m_PublisherDAL;
        public CPublisherBUS()
        {
            m_PublisherDAL = new CPublisherDAL();
        }
        public bool AddPublisherToDatabase(CPublisherDTO _publisherObject)
        {
            return m_PublisherDAL.AddPublisherToDatabase(_publisherObject);
        }
        public bool DeletePublisherToDatabase(CPublisherDTO _publisherObject)
        {
            return m_PublisherDAL.DeletePublisherToDatabase(_publisherObject);
        }
        public bool UpdatePublisherToDatabase(CPublisherDTO _publisherObject)
        {
            return m_PublisherDAL.UpdatePublisherToDatabase(_publisherObject);
        }
         public DataTable getPublisherDataFromDatabase()
        {
            return m_PublisherDAL.getPublisherDataFromDatabase();
        }
         public DataTable lookAtPublisherDataFromDatabase(String _publisherName)
         {
             return m_PublisherDAL.lookAtPublisherDataFromDatabase(_publisherName);
         }
    }
}
