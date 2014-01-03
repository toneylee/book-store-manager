using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Manager_Book_Store.Data_Tranfer_Object;
using System.Data.SqlClient;
using System.Data;
using Manager_Book_Store.Data_Access_Layer;
namespace Manager_Book_Store.Business_Layer
{
    class CCashReceiptVoucherBUS
    {
        private CCashReceiptVoucherDAL m_CashReceiptVoucherDAL;

        public CCashReceiptVoucherBUS()
        {
            m_CashReceiptVoucherDAL = new CCashReceiptVoucherDAL();
        }
        public bool AddCashReceiptVoucherToDatabase(CCashReceiptVoucherDTO _CashReceiptVoucherObject)
        {
            return m_CashReceiptVoucherDAL.AddCashReceiptVoucherToDatabase(_CashReceiptVoucherObject);
        }
        public bool DeleteCashReceiptVoucherToDatabase(CCashReceiptVoucherDTO _CashReceiptVoucherObject)
        {
            return m_CashReceiptVoucherDAL.DeleteCashReceiptVoucherToDatabase(_CashReceiptVoucherObject);
        }
        public bool UpdateCashReceiptVoucherToDatabase(CCashReceiptVoucherDTO _CashReceiptVoucherObject)
        {
            return m_CashReceiptVoucherDAL.UpdateCashReceiptVoucherToDatabase(_CashReceiptVoucherObject);
        }
        public DataTable getCashReceiptVoucherDataFromDatabase()
        {
            return m_CashReceiptVoucherDAL.getCashReceiptVoucherDataFromDatabase();
        }
        public DataTable lookAtCashReceiptVoucherDataFromDatabase(String _CashReceiptVoucherId)
        {
            return m_CashReceiptVoucherDAL.lookAtCashReceiptVoucherDataFromDatabase(_CashReceiptVoucherId);
        }
        public String getCashReceiptVoucherMaxIdFromDatabase()
        {
            return m_CashReceiptVoucherDAL.getCashReceiptVoucherMaxIdFromDatabase();
        }
    }
}
