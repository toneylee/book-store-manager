using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manager_Book_Store.Data_Tranfer_Object
{
    class CChargeDTO
    {
        #region "Variable"
        private String m_maChucVu;
        private String m_tenChucVu;
        #endregion
        #region "Properties"
        public System.String maChucVu
        {
            get { return m_maChucVu; }
            set { m_maChucVu = value; }
        }
        public System.String tenChucVu
        {
            get { return m_tenChucVu; }
            set { m_tenChucVu = value; }
        }
        #endregion
        #region "Method"
        public CChargeDTO()
        {

        }
        public CChargeDTO(String _maChucVu, String _tenChucVu)
        {
            this.maChucVu   = _maChucVu;
            this.tenChucVu = _tenChucVu;
        }
        #endregion
    }
}
