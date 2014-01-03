using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manager_Book_Store.Data_Tranfer_Object
{
    class CBookTitlesDTO:CBookGenreDTO
    {
        #region "variable"
        private String  m_tenDauSach;
        protected String   m_maDauSach;
        #endregion

        #region "properties"
        public String maDauSach
        {
            get { return m_maDauSach; }
            set { m_maDauSach = value; }
        }
        public String tenDauSach
        {
            get { return m_tenDauSach; }
            set { m_tenDauSach = value; }
        }
        #endregion

        #region "method"
        public CBookTitlesDTO(String _maDauSach,String _maTheLoai, String _tenDauSach)
        {
            this.m_maDauSach    = _maDauSach;
            this.m_tenDauSach   = _tenDauSach;
            this.m_maTheLoai    = _maTheLoai;
        }
        public CBookTitlesDTO(String _maTheLoai,String _tenDauSach)
        {
            this.m_tenDauSach   = _tenDauSach;
            this.m_maTheLoai    = _maTheLoai;
        }
        public CBookTitlesDTO()
        {

        }
        #endregion
    }
}
