using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Manager_Book_Store.Data_Access_Layer;
using System.Data;
using Manager_Book_Store.Data_Tranfer_Object;

namespace Manager_Book_Store.Business_Layer
{
    class CDeliveryNoteDetailBUS
    {
        private CDeliveryNoteDetailDAL  m_DeliveryNoteDetailDAL;
        private CBookDAL m_BookDAL;
        private CRegulationsDAL m_RegulationsDAL;
        private CCustomerDAL m_CustomerDAL;
        public CDeliveryNoteDetailBUS()
        {
            m_DeliveryNoteDetailDAL = new CDeliveryNoteDetailDAL();
            m_BookDAL = new CBookDAL();
            m_RegulationsDAL = new CRegulationsDAL();
            m_CustomerDAL = new CCustomerDAL();

        }
        public bool AddDeliveryNoteDetailToDatabase(CDeliveryNoteDetailDTO _DeliveryNoteDetailObject)
        {
            return m_DeliveryNoteDetailDAL.AddDeliveryNoteDetailToDatabase(_DeliveryNoteDetailObject);
        }
        public bool DeleteDeliveryNoteDetailToDatabase(CDeliveryNoteDetailDTO _DeliveryNoteDetailObject)
        {
            return m_DeliveryNoteDetailDAL.DeleteDeliveryNoteDetailToDatabase(_DeliveryNoteDetailObject);
        }
        public bool UpdateDeliveryNoteDetailToDatabase(CDeliveryNoteDetailDTO _DeliveryNoteDetailObject)
        {
            return m_DeliveryNoteDetailDAL.UpdateDeliveryNoteDetailToDatabase(_DeliveryNoteDetailObject);
        }
        public DataTable getDeliveryNoteDetailDataFromDatabase()
        {
            return m_DeliveryNoteDetailDAL.getDeliveryNoteDetailDataFromDatabase();
        }
        public DataTable getDeliveryNoteDetailDataByRuleFromDatabase(String _maHD)
        {
            return m_DeliveryNoteDetailDAL.getDeliveryNoteDetailDataByRuleFromDatabase(_maHD);
        }
        public bool checkQuantityDelivery(int _soLuongBan, String _maSach)
        {
            if (m_BookDAL.getBookQuantityDataFromDatabase(_maSach) >= 0)
            {
                if ((m_BookDAL.getBookQuantityDataFromDatabase(_maSach) - _soLuongBan) >= m_RegulationsDAL.getRegulationsDataByRuleFromDatabase("SoLuongTonToiThieuSauBan"))
                {
                    return true;
                }
                else
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("Số lượng bán không phù hợp với quy định !");
                    return false;
                }
            }
            else
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Số lượng sách không đủ để thực hiện thao tác !");
                return false;
            }
        }
        public bool checkCustomerDebits(String _maKhachHang)
        {
            if (m_CustomerDAL.getCustomerDebitsDataFromDatabase(_maKhachHang) >= 0)
            {
                if (m_CustomerDAL.getCustomerDebitsDataFromDatabase(_maKhachHang) <= m_RegulationsDAL.getRegulationsDataByRuleFromDatabase("SoTienNoToiDa"))
                {
                    return true;
                }
                else
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("Số tiền nợ của khách hàng không phù hợp với quy định!");
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        public decimal convertPrice(decimal _giaNhap)
        {
            if (m_RegulationsDAL.getRegulationsDataByRuleFromDatabase("MucLoiNhuan") >= 0)
                return _giaNhap + _giaNhap * m_RegulationsDAL.getRegulationsDataByRuleFromDatabase("MucLoiNhuan")/100;
            else
                return _giaNhap;
        }
    }
}
