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
        private CRegulationsDAL m_RegulationDAL;
        private CCustomerDAL m_CustomerDAL;

        public CCashReceiptVoucherBUS()
        {
            m_CashReceiptVoucherDAL = new CCashReceiptVoucherDAL();
            m_RegulationDAL = new CRegulationsDAL();
            m_CustomerDAL = new CCustomerDAL();
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
        public bool checkRegulation()
        {
            if (m_RegulationDAL.getRegulationsDataByRuleFromDatabase("SuDungQuyDinh4") == 1)
                return true;
            else
            {
                return false;
            }
        }

        public bool checkDebitsQuantity(String _idCustomer)
        {
            if (m_CustomerDAL.getCustomerDebitsDataFromDatabase(_idCustomer) > 0)
            {
                return false;//co no
            }
            else
                return true;//khong no
        }
    }
}
