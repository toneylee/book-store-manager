using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manager_Book_Store.Data_Tranfer_Object
{
    class CSurvivalDTO
    {
        #region "Variable"
        private String m_maTonKho;
        private String m_maSach;
        private int m_tonDau;
        private int m_tonCuoi;
        private int m_tonPhatSinh;
        private DateTime m_thangNam;
        #endregion
        #region Properties
        public System.String maTonKho
        {
            get { return m_maTonKho; }
            set { m_maTonKho = value; }
        }
        public System.String maSach
        {
            get { return m_maSach; }
            set { m_maSach = value; }
        }
        public int noDau
        {
            get { return m_tonDau; }
            set { m_tonDau = value; }
        }
        public int noPhatSinh
        {
            get { return m_tonPhatSinh; }
            set { m_tonPhatSinh = value; }
        }
        public int noCuoi
        {
            get { return m_tonCuoi; }
            set { m_tonCuoi = value; }
        }
        public System.DateTime thangNam
        {
            get { return m_thangNam; }
            set { m_thangNam = value; }
        }
        #endregion
        #region "Method"
        public CSurvivalDTO()
        {

        }
        public CSurvivalDTO(String _maTonKho, String _maSach, int _tonDau, int _tonPhatSinh, int _tonCuoi, DateTime _thangNam)
        {
            this.m_maTonKho = _maTonKho;
            this.m_maSach = _maSach;
            this.m_tonDau = _tonDau;
            this.m_tonCuoi = _tonCuoi;
            this.m_tonPhatSinh = _tonPhatSinh;
            this.m_thangNam = _thangNam;
        }
        #endregion
    }
}
