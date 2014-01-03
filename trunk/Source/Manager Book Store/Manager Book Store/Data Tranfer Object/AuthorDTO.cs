using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manager_Book_Store.Data_Tranfer_Object
{
    class CAuthorDTO
    {
        #region "variable"
        protected String m_maTacGia;
        protected String m_tenTacGia;
        protected String m_diaChi;

        #endregion

        #region "properties"
        public String maTacGia
        {
            get { return m_maTacGia; }
            set { m_maTacGia = value; }
        }
        public String tenTacGia
        {
            get { return m_tenTacGia; }
            set { m_tenTacGia = value; }
        }
        public String diaChi
        {
            get { return m_diaChi; }
            set { m_diaChi = value; }
        }
        #endregion

        #region "method"
        public CAuthorDTO(String _maTacGia, String _tenTacGia, String _diaChi)
        {
            this.m_maTacGia     = _maTacGia;
            this.m_tenTacGia    = _tenTacGia;
            this.m_diaChi       = _diaChi;
        }
        public CAuthorDTO(String _maTacGia, String _diaChi)
        {
            this.m_tenTacGia = _maTacGia;
            this.m_diaChi    = _diaChi;
        }
        public CAuthorDTO()
        {

        }
        #endregion
    }
}
