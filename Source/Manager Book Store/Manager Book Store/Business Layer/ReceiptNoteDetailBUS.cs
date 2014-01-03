using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Manager_ReceiptNoteDetail_Store.Data_Access_Layer;
using Manager_Book_Store.Data_Tranfer_Object;
using System.Data;
using Manager_Book_Store.Data_Access_Layer;

namespace Manager_Book_Store.Business_Layer
{
    class CReceiptNoteDateilBUS
    {
        private CReceiptNoteDetailDAL  m_ReceiptNoteDetailDAL;
        private CBookDAL m_BookDAL;
        private CRegulationsDAL m_RegulationsDAL;
        public CReceiptNoteDateilBUS()
        {
            m_ReceiptNoteDetailDAL = new CReceiptNoteDetailDAL();
            m_BookDAL = new CBookDAL();
            m_RegulationsDAL = new CRegulationsDAL();
        }
        public bool AddReceiptNoteDetailToDatabase(CReceiptNoteDetailDTO _ReceiptNoteDetailObject)
        {
            return m_ReceiptNoteDetailDAL.AddReceiptNoteDetailToDatabase(_ReceiptNoteDetailObject);
        }
        public bool DeleteReceiptNoteDetailToDatabase(CReceiptNoteDetailDTO _ReceiptNoteDetailObject)
        {
            return m_ReceiptNoteDetailDAL.DeleteReceiptNoteDetailToDatabase(_ReceiptNoteDetailObject);
        }
        public bool UpdateReceiptNoteDetailToDatabase(CReceiptNoteDetailDTO _ReceiptNoteDetailObject)
        {
            return m_ReceiptNoteDetailDAL.UpdateReceiptNoteDetailToDatabase(_ReceiptNoteDetailObject);
        }
        public DataTable getReceiptNoteDetailDataFromDatabase()
        {
            return m_ReceiptNoteDetailDAL.getReceiptNoteDetailDataFromDatabase();
        }
        public bool checkQuantityReceipt(int _soLuongNhap, String _maSach)
        {
            if (m_BookDAL.getBookQuantityDataFromDatabase(_maSach) >= 0)
            {
                if(_soLuongNhap >= m_RegulationsDAL.getRegulationsDataByRuleFromDatabase("SoLuongNhapToiThieu")
                    && (m_BookDAL.getBookQuantityDataFromDatabase(_maSach) + _soLuongNhap )< m_RegulationsDAL.getRegulationsDataByRuleFromDatabase("SoLuongTonToiDaTruocNhap"))
                {
                    return true;
                }
                else
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("Số lượng nhập không phù hợp với quy định!");
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
