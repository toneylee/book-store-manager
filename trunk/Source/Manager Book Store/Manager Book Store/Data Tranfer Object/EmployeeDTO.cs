using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manager_Book_Store.Data_Tranfer_Object
{
    class CEmployeeDTO
    {
        #region "Variable"
        private String m_maNhanVien;
        private String m_tenNhanVien;
        private String m_gioiTinh;
        private DateTime m_ngaySinh;
        private String m_soDienThoai;
        private String m_diaChi;
        private String m_email;
        private DateTime m_ngayVaoLam;
        private String m_maChucVu;
        private String m_tenDangNhap;
        private String m_matKhau;
        #endregion
        #region "Properties"
        public System.String maNhanVien
        {
            get { return m_maNhanVien; }
            set { m_maNhanVien = value; }
        }

        public System.String tenNhanVien
        {
            get { return m_tenNhanVien; }
            set { m_tenNhanVien = value; }
        }

        public System.String gioiTinh
        {
            get { return m_gioiTinh; }
            set { m_gioiTinh = value; }
        }

        public System.DateTime ngaySinh
        {
            get { return m_ngaySinh; }
            set { m_ngaySinh = value; }
        }
        public System.String soDienThoai
        {
            get { return m_soDienThoai; }
            set { m_soDienThoai = value; }
        }
        public System.String email
        {
            get { return m_email; }
            set { m_email = value; }
        }
        public System.String diaChi
        {
            get { return m_diaChi; }
            set { m_diaChi = value; }
        }
        public System.DateTime ngayVaoLam
        {
            get { return m_ngayVaoLam; }
            set { m_ngayVaoLam = value; }
        }

        public System.String maChucVu
        {
            get { return m_maChucVu; }
            set { m_maChucVu = value; }
        }

        public System.String tenDangNhap
        {
            get { return m_tenDangNhap; }
            set { m_tenDangNhap = value; }
        }

        public System.String matKhau
        {
            get { return m_matKhau; }
            set { m_matKhau = value; }
        }
        #endregion
        #region "Method"
        public CEmployeeDTO()
        {

        }
        public CEmployeeDTO(String _maNhanVien, String _tenNhanVien, String _gioiTinh, DateTime _ngaySinh,
            String _soDienThoai, String _diaChi, DateTime _ngayVaoLam, String _maChucVu, String _tenDangNhap, String _matKhau, String _email)
        {
            this.m_maNhanVien   = _maNhanVien;
            this.m_tenNhanVien  = _tenNhanVien;
            this.m_gioiTinh     = _gioiTinh;
            this.m_ngaySinh     = _ngaySinh;
            this.m_soDienThoai  = _soDienThoai;
            this.m_diaChi       = _diaChi;
            this.m_ngayVaoLam   = _ngayVaoLam;
            this.m_maChucVu     = _maChucVu;
            this.m_tenDangNhap  = _tenDangNhap;
            this.m_matKhau      = _matKhau;
            this.m_email        = _email;
        }
        #endregion
    }
}
