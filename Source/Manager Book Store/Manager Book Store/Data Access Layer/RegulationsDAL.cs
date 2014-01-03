using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Manager_Book_Store.Data_Tranfer_Object;
using System.Data.SqlClient;
using System.Data;
namespace Manager_Book_Store.Data_Access_Layer
{
    class CRegulationsDAL
    {
         private CRegulationsDTO m_RegulationsObject;
        private CDataExecute  m_RegulationsExecute;
        private SqlCommand    m_cmd;

        public CRegulationsDAL(CRegulationsDTO _RegulationsObject)
        {
            m_RegulationsObject  =_RegulationsObject;
            m_RegulationsExecute = new CDataExecute();
            m_cmd           = new SqlCommand();
        }
        public CRegulationsDAL()
        {
            m_RegulationsObject  = null;
            m_RegulationsExecute = new CDataExecute();
            m_cmd           = new SqlCommand();
        }
        public bool AddRegulationsToDatabase(CRegulationsDTO _RegulationsObject)
        {
            m_cmd = new SqlCommand();
            m_cmd.CommandType = CommandType.StoredProcedure;
            m_cmd.CommandText = "AddRegulationsDataToDatabase";
            m_cmd.Parameters.Add("SoLuongNhapToiThieu", SqlDbType.Int).Value = _RegulationsObject.soLuongNhapToiThieu;
            m_cmd.Parameters.Add("SoTienNoToiDa", SqlDbType.Int).Value = _RegulationsObject.soTienNoToiDa;
            m_cmd.Parameters.Add("SoLuongTonToiThieuSauBan", SqlDbType.Int).Value = _RegulationsObject.soLuongTonToiThieuSauBan;
            m_cmd.Parameters.Add("SoLuongTonToiDaTruocNhap", SqlDbType.Int).Value = _RegulationsObject.soLuongTonToiDaTruocNhap;
            m_cmd.Parameters.Add("SuDungQuyDinh4", SqlDbType.Bit).Value = _RegulationsObject.suDungQuyDinh4;
            m_cmd.Parameters.Add("DoTuoiNhanVienToiThieu", SqlDbType.Int).Value = _RegulationsObject.doTuoiNhanVienToiThieu;
            m_cmd.Parameters.Add("DoTuoiNhanVienToiDa", SqlDbType.Int).Value = _RegulationsObject.doTuoiNhanVienToiDa;
            m_cmd.Parameters.Add("MucLoiNhuan", SqlDbType.Int).Value = _RegulationsObject.mucLoiNhuan;
            return m_RegulationsExecute.updateData(m_cmd) > 0;
        }
        public bool UpdateRegulationsToDatabase(CRegulationsDTO _RegulationsObject)
        {
            m_cmd = new SqlCommand();
            m_cmd.CommandType = CommandType.StoredProcedure;
            m_cmd.CommandText = "UpdateRegulationsDataToDatabase";
            m_cmd = new SqlCommand();
            m_cmd.CommandType = CommandType.StoredProcedure;
            m_cmd.CommandText = "UpdateRegulationsDataToDatabase";
            m_cmd.Parameters.Add("SoLuongNhapToiThieu", SqlDbType.Int).Value = _RegulationsObject.soLuongNhapToiThieu;
            m_cmd.Parameters.Add("SoTienNoToiDa", SqlDbType.Int).Value = _RegulationsObject.soTienNoToiDa;
            m_cmd.Parameters.Add("SoLuongTonToiThieuSauBan", SqlDbType.Int).Value = _RegulationsObject.soLuongTonToiThieuSauBan;
            m_cmd.Parameters.Add("SoLuongTonToiDaTruocNhap", SqlDbType.Int).Value = _RegulationsObject.soLuongTonToiDaTruocNhap;
            m_cmd.Parameters.Add("SuDungQuyDinh4", SqlDbType.Bit).Value = _RegulationsObject.suDungQuyDinh4;
            m_cmd.Parameters.Add("DoTuoiNhanVienToiThieu", SqlDbType.Int).Value = _RegulationsObject.doTuoiNhanVienToiThieu;
            m_cmd.Parameters.Add("DoTuoiNhanVienToiDa", SqlDbType.Int).Value = _RegulationsObject.doTuoiNhanVienToiDa;
            m_cmd.Parameters.Add("MucLoiNhuan", SqlDbType.Int).Value = _RegulationsObject.mucLoiNhuan;
            return m_RegulationsExecute.updateData(m_cmd) > 0;
        }
        public DataTable getRegulationsDataFromDatabase()
        {
            m_cmd = new SqlCommand();
            //SqlCommand sqlCommand = new SqlCommand();
            m_cmd.CommandType = CommandType.StoredProcedure;
            m_cmd.CommandText = "GetRegulationsDataFromDatabase";
            return m_RegulationsExecute.getData(m_cmd);
        }
        public int getRegulationsDataByRuleFromDatabase(String _tenQuyDinh)
        {
            m_cmd = new SqlCommand();
            //m_cmd.CommandType = CommandType.StoredProcedure;
            //m_cmd.CommandText = "GetRegulationsDataByNameFromDatabase";
            m_cmd.CommandText = "Select " + _tenQuyDinh + " from QUYDINH";
            //m_cmd.Parameters.Add("TenQuyDinh", SqlDbType.NVarChar).Value = _tenQuyDinh;
            String _value = m_RegulationsExecute.getMaxId(m_cmd);
            if (_value != "")
            {
                if (_value.ToLower().Equals("True".ToLower()))
                    return 1;
                else if (_value.ToLower().Equals("False".ToLower()))
                    return 0;
                return int.Parse(_value);
            }
            else
                return -1;
        }
    }
}
