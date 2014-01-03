using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manager_Book_Store.Data_Tranfer_Object
{
    class CReceiptNoteDTO
    {
        #region "Variable"
        private String m_maPhieuNhap;
        private String m_maNhanVien;
        private DateTime m_ngayNhap;
        private int m_TongTien;
        private int m_TongSoLuong;
        #endregion
        #region "Properties"
        public String maPhieuNhap
        {
            get { return m_maPhieuNhap; }
            set { m_maPhieuNhap = value; }
        }
        public System.String maNhanVien
        {
            get { return m_maNhanVien; }
            set { m_maNhanVien = value; }
        }
        public System.DateTime ngayNhap
        {
            get { return m_ngayNhap; }
            set { m_ngayNhap = value; }
        }
        public int TongTien
        {
            get { return m_TongTien; }
            set { m_TongTien = value; }
        }
        public int TongSoLuong
        {
            get { return m_TongSoLuong; }
            set { m_TongSoLuong = value; }
        }
        #endregion
        #region "Method"
        public CReceiptNoteDTO()
        {

        }
        public CReceiptNoteDTO(String _maPhieuNhap, DateTime _ngayNhap, String _maNhanVien, int _TongTien, int _TongSoLuong)
        {
            this.m_maNhanVien       = _maNhanVien;
            this.m_maPhieuNhap      = _maPhieuNhap;
            this.m_ngayNhap         = _ngayNhap;
            this.m_TongSoLuong      = _TongSoLuong;
            this.m_TongTien         = _TongTien;
        }
        #endregion
    }
}
