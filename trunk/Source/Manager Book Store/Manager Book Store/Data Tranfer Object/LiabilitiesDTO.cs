using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manager_Book_Store.Data_Tranfer_Object
{
    class CLiabilitiesDTO
    {
        #region "Variable"
        private String m_maCongNo;
        private String m_maKH;
        private int m_noDau;
        private int m_noCuoi;
        private int m_noPhatSinh;
        private DateTime m_thangNam;
        #endregion
        #region Properties
        public System.String maCongNo
        {
            get { return m_maCongNo; }
            set { m_maCongNo = value; }
        }
        public System.String maKH
        {
            get { return m_maKH; }
            set { m_maKH = value; }
        }
        public int noDau
        {
            get { return m_noDau; }
            set { m_noDau = value; }
        }
        public int noPhatSinh
        {
            get { return m_noPhatSinh; }
            set { m_noPhatSinh = value; }
        }
        public int noCuoi
        {
            get { return m_noCuoi; }
            set { m_noCuoi = value; }
        }
        public System.DateTime thangNam
        {
            get { return m_thangNam; }
            set { m_thangNam = value; }
        }
        #endregion
        #region "Method"
        public CLiabilitiesDTO()
        {

        }
        public CLiabilitiesDTO(String _maCongNo, String _maKH, int _noDau, int _noPhatSinh, int _noCuoi, DateTime _thangNam)
        {
            this.m_maCongNo = _maCongNo;
            this.m_maKH = _maKH;
            this.m_noDau = _noDau;
            this.m_noCuoi = _noCuoi;
            this.m_noPhatSinh = _noPhatSinh;
            this.m_thangNam = _thangNam;
        }
        #endregion
    }
}
