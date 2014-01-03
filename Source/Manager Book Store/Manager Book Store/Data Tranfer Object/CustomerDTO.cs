using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manager_Book_Store.Data_Tranfer_Object
{
    public class CCustomerDTO
    {
        #region "Variable"
        private String m_maKhachHang;
        private String m_tenKhachHang;
        private String m_gioiTinh;
        private DateTime m_ngaySinh;
        private String m_diaChi;
        private String m_soDienThoai;
        private String m_Email;
        private int    m_tienNo;
        #endregion
        #region "Properties"
        public System.String maKhachHang
        {
            get { return m_maKhachHang; }
            set { m_maKhachHang = value; }
        }

        public System.String tenKhachHang
        {
            get { return m_tenKhachHang; }
            set { m_tenKhachHang = value; }
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
        public System.String diaChi
        {
            get { return m_diaChi; }
            set { m_diaChi = value; }
        }
        public System.String Email
        {
            get { return m_Email; }
            set { m_Email = value; }
        }
        public int tienNo
        {
            get { return m_tienNo; }
            set { m_tienNo = value; }
        }
        #endregion
        #region "Method"
        public CCustomerDTO()
        {

        }
        public CCustomerDTO(String _maKhachHang, String _tenKhachHang, String _gioiTinh, DateTime _ngaySinh,
            String _diaChi,String _soDienThoai, String _email, int _tienNo)
        {
            this.m_maKhachHang  = _maKhachHang;
            this.m_tenKhachHang = _tenKhachHang;
            this.m_gioiTinh     = _gioiTinh;
            this.m_ngaySinh     = _ngaySinh;
            this.m_soDienThoai  = _soDienThoai;
            this.m_Email        = _email;
            this.m_diaChi       = _diaChi;
            this.m_tienNo       = _tienNo;
        }
        #endregion
    }
}
