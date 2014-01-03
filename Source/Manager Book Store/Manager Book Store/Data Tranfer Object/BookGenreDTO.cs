using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manager_Book_Store.Data_Tranfer_Object
{
    public class CBookGenreDTO
    {
        #region "variable"
        protected String m_maTheLoai;
        protected String m_tenTheLoai;

        #endregion

        #region "properties"
        public String maTheLoai
        {
            get { return m_maTheLoai; }
            set { m_maTheLoai = value; }
        }
        public System.String tenTheLoai
        {
            get { return m_tenTheLoai; }
            set { m_tenTheLoai = value; }
        }
        #endregion

        #region  "method"
        public CBookGenreDTO(String _maTheLoai, String _tenTheLoai)
        {
            this.m_maTheLoai = _maTheLoai;
            this.m_tenTheLoai = _tenTheLoai;
        }
        public CBookGenreDTO(String _tenTheLoai)
        {
            this.m_tenTheLoai = _tenTheLoai;
        }
        public CBookGenreDTO()
        {

        }
        #endregion
    }
}
