using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Manager_Book_Store.Data_Access_Layer;
using Manager_Book_Store.Data_Tranfer_Object;
using System.Data;

namespace Manager_Book_Store.Business_Layer
{
    class CCustomerBUS
    {
        private CCustomerDAL m_CustomerDAL ;

        public CCustomerBUS()
        {
            m_CustomerDAL = new CCustomerDAL();
        }
        public bool AddCustomerToDatabase(CCustomerDTO _CustomerObject)
        {
            return m_CustomerDAL.AddCustomerToDatabase(_CustomerObject);
        }
        public bool DeleteCustomerToDatabase(CCustomerDTO _CustomerObject)
        {
            return m_CustomerDAL.DeleteCustomerToDatabase(_CustomerObject);
        }
        public bool UpdateCustomerToDatabase(CCustomerDTO _CustomerObject)
        {
            return m_CustomerDAL.UpdateCustomerToDatabase(_CustomerObject);
        }
        public DataTable getCustomerDataFromDatabase()
        {
            return m_CustomerDAL.getCustomerDataFromDatabase();
        }
        public DataTable lookAtCustomerDataFromDatabase(String _CustomerName)
        {
            return m_CustomerDAL.getCustomerDataFromDatabase();
        }
        public bool UpdateDebitOfCustomerDataToDatabase(CCustomerDTO _CustomerObject)
        {
            return m_CustomerDAL.UpdateDebitOfCustomerDataToDatabase(_CustomerObject);
        }
        public DataTable getCustomerDataByRuleFromDatabase(String _tenKH, String _diaChi, String _gioiTinh, String _email, String _soDienThoai, int _tienNo)
        {
            return m_CustomerDAL.getCustomerDataByRuleFromDatabase(_tenKH, _diaChi, _gioiTinh, _email, _soDienThoai, _tienNo);
        }
    }
}
