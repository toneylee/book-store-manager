using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manager_Book_Store.Data_Tranfer_Object
{
    class CDeliveryNoteDTO
    {
       #region "Variable"
        private String m_soHoaDon;
        private String m_maNhanVien;
        private String m_maKhachHang;
        private DateTime m_ngayHoaDon;
        private int m_tongSoLuong;
        private int m_tongTien;
        #endregion
        #region "Properties"
        public String soHoaDon
        {
            get { return m_soHoaDon; }
            set { m_soHoaDon = value; }
        }
        public System.String maNhanVien
        {
            get { return m_maNhanVien; }
            set { m_maNhanVien = value; }
        }
        public System.String maKhachHang
        {
            get { return m_maKhachHang; }
            set { m_maKhachHang = value; }
        }
        public System.DateTime ngayHoaDon
        {
            get { return m_ngayHoaDon; }
            set { m_ngayHoaDon = value; }
        }
        public int tongSoLuong
        {
            get { return m_tongSoLuong; }
            set { m_tongSoLuong = value; }
        }
        public int tongTien
        {
            get { return m_tongTien; }
            set { m_tongTien = value; }
        }
        #endregion
        #region "Method"
        public CDeliveryNoteDTO()
        {

        }
        public CDeliveryNoteDTO(String _soHoaDon, String _maKhachHang, DateTime _ngayHoaDon, String _maNhanVien, int _tongSoLuong, int _tongTien)
        {
            this.m_maKhachHang    = _maKhachHang;
            this.m_maNhanVien     = _maNhanVien;
            this.m_soHoaDon       = _soHoaDon;
            this.m_ngayHoaDon     = _ngayHoaDon;
            this.m_tongTien       = _tongTien;
            this.m_tongSoLuong    = _tongSoLuong;
        }
        #endregion
    }
}
