using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manager_Book_Store.Data_Tranfer_Object
{
    class DecentralizationDTO
    {
        #region "Variable"
        private String m_maChucVu;
        private bool m_ThietLapHeThong;
        private bool m_ThayDoiQuyDinh;
        private bool m_QuanLySach;
        private bool m_QuanLyNhanVien;
        private bool m_QuanLyKhachHang;
        private bool m_LapPhieuNhapSach;
        private bool m_LapHoaDonBanSach;
        private bool m_LapPhieuThuTien;
        private bool m_TraCuuSach;
        private bool m_TraCuuNhanVien;
        private bool m_TraCuuHoaDon;
        private bool m_TraCuuKhachHang;
        private bool m_LapBaoCaoThang;
      
        #endregion
       
        #region "Properties"
        public String maChucVu
        {
            get { return m_maChucVu; }
            set { m_maChucVu = value; }
        }
        public bool ThietLapHeThong
        {
            get { return m_ThietLapHeThong; }
            set { m_ThietLapHeThong = value; }
        }
        public bool QuanLySach
        {
            get { return m_QuanLySach; }
            set { m_QuanLySach = value; }
        }
        public bool ThayDoiQuyDinh
        {
            get { return m_ThayDoiQuyDinh; }
            set { m_ThayDoiQuyDinh = value; }
        }
        public bool QuanLyNhanVien
        {
            get { return m_QuanLyNhanVien; }
            set { m_QuanLyNhanVien = value; }
        }
        public bool QuanLyKhachHang
        {
            get { return m_QuanLyKhachHang; }
            set { m_QuanLyKhachHang = value; }
        }
        public bool LapPhieuNhapSach
        {
            get { return m_LapPhieuNhapSach; }
            set { m_LapPhieuNhapSach = value; }
        }
        public bool LapHoaDonBanSach
        {
            get { return m_LapHoaDonBanSach; }
            set { m_LapHoaDonBanSach = value; }
        }
        public bool LapPhieuThuTien
        {
            get { return m_LapPhieuThuTien; }
            set { m_LapPhieuThuTien = value; }
        }
        public bool TraCuuSach
        {
            get { return m_TraCuuSach; }
            set { m_TraCuuSach = value; }
        }
        public bool TraCuuNhanVien
        {
            get { return m_TraCuuNhanVien; }
            set { m_TraCuuNhanVien = value; }
        }
        public bool TraCuuHoaDon
        {
            get { return m_TraCuuHoaDon; }
            set { m_TraCuuHoaDon = value; }
        }
        public bool TraCuuKhachHang
        {
            get { return m_TraCuuKhachHang; }
            set { m_TraCuuKhachHang = value; }
        }
        public bool LapBaoCaoThang
        {
            get { return m_LapBaoCaoThang; }
            set { m_LapBaoCaoThang = value; }
        }
        #endregion
        
        #region "Method"
        public DecentralizationDTO()
        {

        }
        public DecentralizationDTO(String _maChucVu, bool _Q1, bool _Q2,bool _Q3,bool _Q4,bool _Q5,bool _Q6,bool _Q7,bool _Q8,bool _Q9,bool _Q10,bool _Q11, bool _Q12,bool _Q13 )
        {
            this.maChucVu   = _maChucVu;
            this.ThietLapHeThong = _Q1;
            this.ThayDoiQuyDinh = _Q2;
            this.QuanLySach = _Q3;
            this.QuanLyNhanVien = _Q4;
            this.QuanLyKhachHang = _Q5;
            this.LapPhieuNhapSach = _Q6;
            this.LapHoaDonBanSach = _Q7;
            this.LapPhieuThuTien = _Q8;
            this.TraCuuSach = _Q9;
            this.TraCuuNhanVien = _Q10;
            this.TraCuuHoaDon = _Q11;
            this.TraCuuKhachHang = _Q12;
            this.LapBaoCaoThang = _Q13;
        }
        #endregion
    }
}
