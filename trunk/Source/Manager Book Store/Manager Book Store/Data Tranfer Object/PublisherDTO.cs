using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manager_Book_Store.Data_Tranfer_Object
{
    class CPublisherDTO
    {
        #region "variable"
        protected String m_maNhaXuatBan;
        private String m_tenNhaXuatBan;
        private String m_diaChi;
        #endregion

        #region "properties"
        public String maNhaXuatBan
        {
            get { return m_maNhaXuatBan; }
            set { m_maNhaXuatBan = value; }
        }
        public String tenNhaXuatBan
        {
            get { return m_tenNhaXuatBan; }
            set { m_tenNhaXuatBan = value; }
        }
        public String diaChi
        {
            get { return m_diaChi; }
            set { m_diaChi = value; }
        }
        #endregion

        #region "method"
        public CPublisherDTO(String _maNhaXuatBan, String _tenNhaXuatBan, String _diaChi)
        {
            this.m_maNhaXuatBan = _maNhaXuatBan;
            this.m_tenNhaXuatBan = _tenNhaXuatBan;
            this.m_diaChi = _diaChi;
        }
        public CPublisherDTO(String _tenNhaXuatBan, String _diaChi)
        {
            this.m_tenNhaXuatBan = _tenNhaXuatBan;
            this.m_diaChi = _diaChi;
        }
        public CPublisherDTO()
        {

        }
        #endregion
        
    }
}
