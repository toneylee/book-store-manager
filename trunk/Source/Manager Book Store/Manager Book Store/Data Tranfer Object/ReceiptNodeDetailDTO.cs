using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manager_Book_Store.Data_Tranfer_Object
{
    class CReceiptNoteDetailDTO
    {
        #region "Variable"
        private String m_maPhieuNhap;
        private String m_maSach;
        private int m_soLuong;
        private int m_thanhTien;
        private int m_giaNhap;
        #endregion
        #region "Properties"
        public System.String maPhieuNhap
        {
            get { return m_maPhieuNhap; }
            set { m_maPhieuNhap = value; }
        }
        public System.String maSach
        {
            get { return m_maSach; }
            set { m_maSach = value; }
        }
        public int soLuong
        {
            get { return m_soLuong; }
            set { m_soLuong = value; }
        }
        public int thanhTien
        {
            get { return m_thanhTien; }
            set { m_thanhTien = value; }
        }
        public int giaNhap
        {
            get { return m_giaNhap; }
            set { m_giaNhap = value; }
        }
        #endregion
        #region "Method"
        public CReceiptNoteDetailDTO()
        {

        }
        public CReceiptNoteDetailDTO(String _maPhieuNhap, String _maSach, int _soLuong, int _giaNhap, int _thanhTien)
        {
            this.m_maPhieuNhap  = _maPhieuNhap;
            this.m_maSach       = _maSach;
            this.m_soLuong      = _soLuong;
            this.m_giaNhap      = _giaNhap;
            this.m_thanhTien    = _thanhTien;
        }
        #endregion
    }
}
