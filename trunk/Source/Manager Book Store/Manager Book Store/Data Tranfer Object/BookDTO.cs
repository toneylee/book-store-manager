using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manager_Book_Store.Data_Tranfer_Object
{
    class CBookDTO:CBookTitlesDTO
    {
        #region "variable"
        protected String       m_maSach;
        protected String       m_maNhaXuatBan;
        protected int       m_namXuatBan;
        protected decimal   m_giaNhap;
        protected int       m_soLuong;

        #endregion

        #region "properties"
        public String maSach
        {
            get { return m_maSach; }
            set { m_maSach = value; }
        }
        public String maNhaXuatBan
        {
            get { return m_maNhaXuatBan; }
            set { m_maNhaXuatBan = value; }
        }
        public int namXuatBan
        {
            get { return m_namXuatBan; }
            set { m_namXuatBan = value; }
        }
        public decimal giaNhap
        {
            get { return m_giaNhap; }
            set { m_giaNhap = value; }
        }
        public int soLuong
        {
            get { return m_soLuong; }
            set { m_soLuong = value; }
        }
        #endregion

        #region "method"
        public CBookDTO(String _maSach,String _maDauSach, String _maNhaXuatBan, int  _namXuatBan, decimal _giaNhap, int _soLuong)
        {
            this.m_maSach       = _maSach;
            this.m_maDauSach    = _maDauSach;
            this.m_maNhaXuatBan = _maNhaXuatBan;
            this.m_namXuatBan   = _namXuatBan;
            this.m_giaNhap      = _giaNhap;
            this.m_soLuong      = _soLuong;
        }
        public CBookDTO(String _maDauSach, String _maNhaXuatBan, int  _namXuatBan, decimal _giaNhap, int _soLuong)
        {
            this.m_maDauSach = _maDauSach;
            this.m_maNhaXuatBan = _maNhaXuatBan;
            this.m_namXuatBan = _namXuatBan;
            this.m_giaNhap = _giaNhap;
            this.m_soLuong = _soLuong;
        }
        public CBookDTO()
        {

        }
        #endregion

    }
}
