using Manager_Book_Store.Data_Tranfer_Object;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace Manager_Book_Store.Data_Access_Layer
{
    class DecentralizationDAL
    {
        private DecentralizationDTO m_DecentralizationObject;
        private CDataExecute m_DecentralizationExecute;
        private SqlCommand m_cmd;

        public DecentralizationDAL()
        {
            m_DecentralizationObject = null;
            m_DecentralizationExecute = new CDataExecute();
            m_cmd = new SqlCommand();
        }

        public DecentralizationDAL(DecentralizationDTO _DecentralizationOject)
        {
            this.m_DecentralizationObject = _DecentralizationOject;
            this.m_DecentralizationExecute = new CDataExecute();
            this.m_cmd = new SqlCommand();
        }

        public bool AddDecentralizationToDatabase(DecentralizationDTO _DecentralizationOject)
        {
            m_cmd = new SqlCommand();
            m_cmd.CommandType = CommandType.StoredProcedure;
            m_cmd.CommandText = "AddDecentralizationDataToDatabase";
            m_cmd.Parameters.Add("MaCV", SqlDbType.NVarChar).Value = _DecentralizationOject.maChucVu;
            m_cmd.Parameters.Add("ThietLapHeThong", SqlDbType.Bit).Value = _DecentralizationOject.ThietLapHeThong;
            m_cmd.Parameters.Add("ThayDoiQuyDinh", SqlDbType.Bit).Value = _DecentralizationOject.ThayDoiQuyDinh;
            m_cmd.Parameters.Add("QuanLySach", SqlDbType.Bit).Value = _DecentralizationOject.QuanLySach;
            m_cmd.Parameters.Add("QuanLyNhanVien", SqlDbType.Bit).Value = _DecentralizationOject.QuanLyNhanVien;
            m_cmd.Parameters.Add("QuanLyKhachHang", SqlDbType.Bit).Value = _DecentralizationOject.QuanLyKhachHang;
            m_cmd.Parameters.Add("LapPhieuNhapSach", SqlDbType.Bit).Value = _DecentralizationOject.LapPhieuNhapSach;
            m_cmd.Parameters.Add("LapHoaDonBanSach", SqlDbType.Bit).Value = _DecentralizationOject.LapHoaDonBanSach;
            m_cmd.Parameters.Add("LapPhieuThuTien", SqlDbType.Bit).Value = _DecentralizationOject.LapPhieuThuTien;
            m_cmd.Parameters.Add("TraCuuSach", SqlDbType.Bit).Value = _DecentralizationOject.TraCuuSach;
            m_cmd.Parameters.Add("TraCuuNhanVien", SqlDbType.Bit).Value = _DecentralizationOject.TraCuuNhanVien;
            m_cmd.Parameters.Add("TraCuuHoaDon", SqlDbType.Bit).Value = _DecentralizationOject.TraCuuHoaDon;
            m_cmd.Parameters.Add("TraCuuKhachHang", SqlDbType.Bit).Value = _DecentralizationOject.TraCuuKhachHang;
            m_cmd.Parameters.Add("LapBaoCaoThang", SqlDbType.Bit).Value = _DecentralizationOject.LapBaoCaoThang;
            return m_DecentralizationExecute.updateData(m_cmd) > 0;
        }

        public bool DeleteDecentralizationDataToDatabase(DecentralizationDTO _DecentralizationOject)
        {
            m_cmd = new SqlCommand();
            m_cmd.CommandType = CommandType.StoredProcedure;
            m_cmd.CommandText = "DeleteDecentralizationDataToDatabase";
            m_cmd.Parameters.Add("MaCV", SqlDbType.NVarChar).Value = _DecentralizationOject.maChucVu;
            return m_DecentralizationExecute.updateData(m_cmd) > 0;
        }

        public bool UpdateDecentralizationToDatabase(DecentralizationDTO _DecentralizationOject)
        {
            m_cmd = new SqlCommand();
            m_cmd.CommandType = CommandType.StoredProcedure;
            m_cmd.CommandText = "UpdateDecentralizationDataToDatabase";
            m_cmd.Parameters.Add("MaCV", SqlDbType.NVarChar).Value = _DecentralizationOject.maChucVu;
            m_cmd.Parameters.Add("ThietLapHeThong", SqlDbType.Bit).Value = _DecentralizationOject.ThietLapHeThong;
            m_cmd.Parameters.Add("ThayDoiQuyDinh", SqlDbType.Bit).Value = _DecentralizationOject.ThayDoiQuyDinh;
            m_cmd.Parameters.Add("QuanLySach", SqlDbType.Bit).Value = _DecentralizationOject.QuanLySach;
            m_cmd.Parameters.Add("QuanLyNhanVien", SqlDbType.Bit).Value = _DecentralizationOject.QuanLyNhanVien;
            m_cmd.Parameters.Add("QuanLyKhachHang", SqlDbType.Bit).Value = _DecentralizationOject.QuanLyKhachHang;
            m_cmd.Parameters.Add("LapPhieuNhapSach", SqlDbType.Bit).Value = _DecentralizationOject.LapPhieuNhapSach;
            m_cmd.Parameters.Add("LapHoaDonBanSach", SqlDbType.Bit).Value = _DecentralizationOject.LapHoaDonBanSach;
            m_cmd.Parameters.Add("LapPhieuThuTien", SqlDbType.Bit).Value = _DecentralizationOject.LapPhieuThuTien;
            m_cmd.Parameters.Add("TraCuuSach", SqlDbType.Bit).Value = _DecentralizationOject.TraCuuSach;
            m_cmd.Parameters.Add("TraCuuNhanVien", SqlDbType.Bit).Value = _DecentralizationOject.TraCuuNhanVien;
            m_cmd.Parameters.Add("TraCuuHoaDon", SqlDbType.Bit).Value = _DecentralizationOject.TraCuuHoaDon;
            m_cmd.Parameters.Add("TraCuuKhachHang", SqlDbType.Bit).Value = _DecentralizationOject.TraCuuKhachHang;
            m_cmd.Parameters.Add("LapBaoCaoThang", SqlDbType.Bit).Value = _DecentralizationOject.LapBaoCaoThang;
            return m_DecentralizationExecute.updateData(m_cmd) > 0;
        }

        public DataTable getDecentralizationFromDatabase()
        {
            m_cmd = new SqlCommand();
            m_cmd.CommandType = CommandType.StoredProcedure;
            m_cmd.CommandText = "GetDecentralizationFromDatabase";
            return m_DecentralizationExecute.getData(m_cmd);
        }

        public DataTable getDecentralizationWithMaCV(DecentralizationDTO _DecentralizationOject)
        {
            m_cmd = new SqlCommand();
            m_cmd.CommandType = CommandType.StoredProcedure;
            m_cmd.CommandText = "GetDecentralizationWithMaCV";
            m_cmd.Parameters.Add("MaCV", SqlDbType.NVarChar).Value = _DecentralizationOject.maChucVu;
            return m_DecentralizationExecute.getData(m_cmd);
        }
    }
}
