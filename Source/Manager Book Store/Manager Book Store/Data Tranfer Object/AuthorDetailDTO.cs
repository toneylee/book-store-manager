using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manager_Book_Store.Data_Tranfer_Object
{
    class CAuthorDetailDTO:CAuthorDTO
    {
        #region "variable"
        private String m_maDauSach;
        #endregion
        #region "properties"
        public String maDauSach
        {
            get { return m_maDauSach; }
            set { m_maDauSach = value; }
        }
        #endregion
        #region "method"
        public CAuthorDetailDTO(String _maDauSach, String _maTacGia)
        {
            this.m_maTacGia     = _maTacGia;
            this.m_maDauSach    = _maDauSach;
        }
        public CAuthorDetailDTO()
        {

        }
        #endregion
    }
}
