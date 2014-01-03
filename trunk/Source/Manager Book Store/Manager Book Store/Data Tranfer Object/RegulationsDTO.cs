using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manager_Book_Store.Data_Tranfer_Object
{
    class CRegulationsDTO
    {
        #region "Variable"
        private int m_SoLuongNhapToiThieu;
        private int m_SoTienNoToiDa;
        private int m_SoLuongTonToiThieuSauBan;
        private int m_SoLuongTonToiDaTruocNhap;
        private int m_SuDungQuyDinh4;
        private int m_DoTuoiNhanVienToiThieu;
        private int m_DoTuoiNhanVienToiDa;
        private int m_MucLoiNhuan;
        #endregion
        #region "Properties"
        public int soLuongNhapToiThieu
        {
            get { return m_SoLuongNhapToiThieu; }
            set { m_SoLuongNhapToiThieu = value; }
        }
        public int soTienNoToiDa
        {
            get { return m_SoTienNoToiDa; }
            set { m_SoTienNoToiDa = value; }
        }
        public int soLuongTonToiThieuSauBan
        {
            get { return m_SoLuongTonToiThieuSauBan; }
            set { m_SoLuongTonToiThieuSauBan = value; }
        }
        public int soLuongTonToiDaTruocNhap
        {
            get { return m_SoLuongTonToiDaTruocNhap; }
            set { m_SoLuongTonToiDaTruocNhap = value; }
        }
        public int suDungQuyDinh4
        {
            get { return m_SuDungQuyDinh4; }
            set { m_SuDungQuyDinh4 = value; }
        }
        public int doTuoiNhanVienToiThieu
        {
            get { return m_DoTuoiNhanVienToiThieu; }
            set { m_DoTuoiNhanVienToiThieu = value; }
        }
        public int doTuoiNhanVienToiDa
        {
            get { return m_DoTuoiNhanVienToiDa; }
            set { m_DoTuoiNhanVienToiDa = value; }
        }
        public int mucLoiNhuan
        {
            get { return m_MucLoiNhuan; }
            set { m_MucLoiNhuan = value; }
        }
        #endregion
        #region "MeThod"
        public CRegulationsDTO()
        {

        }
        public CRegulationsDTO(int _soLuongNhapToiThieu,
        int _soTienNoToiDa,
        int _soLuongTonToiThieuSauBan,
        int _soLuongTonToiDaTruocNhap,
        int _suDungQuyDinh4,
        int _doTuoiNhanVienToiThieu,
        int _doTuoiNhanVienToiDa,
        int _mucLoiNhuan)
        {
            this.soLuongNhapToiThieu = _soLuongNhapToiThieu;
            this.soTienNoToiDa = _soTienNoToiDa;
            this.soLuongTonToiDaTruocNhap = _soLuongTonToiDaTruocNhap;
            this.soLuongTonToiThieuSauBan = _soLuongTonToiThieuSauBan;
            this.suDungQuyDinh4 = _suDungQuyDinh4;
            this.doTuoiNhanVienToiDa = _doTuoiNhanVienToiDa;
            this.doTuoiNhanVienToiThieu = _doTuoiNhanVienToiThieu;
            this.m_MucLoiNhuan = _mucLoiNhuan;
        }
        #endregion
    }
}
