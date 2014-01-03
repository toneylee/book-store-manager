using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manager_Book_Store.Data_Tranfer_Object
{
    class CCashReceiptVoucherDTO
    {
        #region "Variable"
        private String m_maPhieuThu;
        private String m_maKhachHang;
        private String m_maNhanVien;
        private DateTime m_ngayThu;
        private int m_soTienThu;
        #endregion
        #region "Properties"
        public System.String maPhieuThu
        {
            get { return m_maPhieuThu; }
            set { m_maPhieuThu = value; }
        }
        public System.String maKhachHang
        {
            get { return m_maKhachHang; }
            set { m_maKhachHang = value; }
        }
        public String maNhanVien
        {
            get { return m_maNhanVien; }
            set { m_maNhanVien = value; }
        }
        public DateTime ngayThu
        {
            get { return m_ngayThu; }
            set { m_ngayThu = value; }
        }
        public int soTienThu
        {
            get { return m_soTienThu; }
            set { m_soTienThu = value; }
        }
        #endregion
        #region "MeThod"
        public CCashReceiptVoucherDTO()
        {

        }
        public CCashReceiptVoucherDTO(String _maPhieuThu, String _maKhachHang, String _maNhanVien, DateTime _ngayThu, int _soTienThu)
        {
            this.m_maKhachHang = _maKhachHang;
            this.m_maNhanVien = _maNhanVien;
            this.m_maPhieuThu = _maPhieuThu;
            this.m_ngayThu = _ngayThu;
            this.m_soTienThu = _soTienThu;
        }
        #endregion
    }
}
