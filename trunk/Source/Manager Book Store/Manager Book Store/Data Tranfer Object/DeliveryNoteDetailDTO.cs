using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manager_Book_Store.Data_Tranfer_Object
{
    class CDeliveryNoteDetailDTO
    {
        #region "Variable"
        private String m_soHoaDon;
        private String m_maSach;
        private int m_soLuong;
        private int m_giaBan;
        private int m_thanhTien;
        #endregion
        #region "Properties"
        public System.String soHoaDon
        {
            get { return m_soHoaDon; }
            set { m_soHoaDon = value; }
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
        public int giaBan
        {
            get { return m_giaBan; }
            set { m_giaBan = value; }
        }
        public int thanhTien
        {
            get { return m_thanhTien; }
            set { m_thanhTien = value; }
        }
        #endregion
        #region "Method"
        public CDeliveryNoteDetailDTO()
        {

        }
        public CDeliveryNoteDetailDTO(String _soHoaDon, String _maSach, int _soLuong, int _giaBan, int _thanhTien)
        {
            this.soHoaDon       = _soHoaDon;
            this.maSach         = _maSach;
            this.soLuong        = _soLuong;
            this.m_giaBan       = _giaBan;
            this.thanhTien      = _thanhTien;
        }
        #endregion
    }
}
