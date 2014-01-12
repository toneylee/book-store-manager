using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Manager_Book_Store.Data_Tranfer_Object;
using Manager_Book_Store.Business_Layer;

namespace Manager_Book_Store.Presentation_Layer
{
    public partial class frmDecentralization : Form
    {
     #region "Variable"
        private DataTable m_ChargeData;
        private CChargeBUS m_ChargeExecute;
        private DataTable m_DecentralizationData;
        private DecentralizationBUS m_DecentralizationExecute;
        private DecentralizationDTO m_DecentralizationObj;
        private bool showButtonAdd, canEditCheck, isAddOrUpdate; 

        #endregion
        public frmDecentralization()
        {
            InitializeComponent();

            m_ChargeData = new DataTable();
            m_ChargeExecute = new CChargeBUS();
            m_DecentralizationData = new DataTable();
            m_DecentralizationExecute = new DecentralizationBUS();
            m_DecentralizationObj = new DecentralizationDTO();
           
            btnSave.Enabled= false;
        }

        private void frmDecentralization_Load(object sender, EventArgs e)
        {
            //
            m_ChargeData = m_ChargeExecute.getChargeDataFromDatabase();
            grdListCharge.DataSource = m_ChargeData;
        }

        private void InitCheckEditDefault()
        {
            chkQ1.Checked = false;
            chkQ2.Checked = false;
            chkQ3.Checked = false;
            chkQ4.Checked = false;
            chkQ5.Checked = false;
            chkQ6.Checked = false;
            chkQ7.Checked = false;
            chkQ8.Checked = false;
            chkQ9.Checked = false;
            chkQ10.Checked = false;
            chkQ11.Checked = false;
            chkQ12.Checked = false;
            chkQ13.Checked = false;
        }

        private void InitCheckEdit(DataTable m_DecentralizationData)
        {
            if (m_DecentralizationData.Rows.Count > 0)
            {
                showButtonAdd = true;
                //
                String temp = m_DecentralizationData.Rows[0][2].ToString();
                if (temp.Equals("True"))
                    chkQ1.Checked = true;
                temp = m_DecentralizationData.Rows[0][3].ToString();
                if (temp.Equals("True"))
                    chkQ2.Checked = true;
                temp = m_DecentralizationData.Rows[0][4].ToString();
                if (temp.Equals("True"))
                    chkQ3.Checked = true;
                temp = m_DecentralizationData.Rows[0][5].ToString();
                if (temp.Equals("True"))
                    chkQ4.Checked = true;
                temp = m_DecentralizationData.Rows[0][6].ToString();
                if (temp.Equals("True"))
                    chkQ5.Checked = true;
                temp = m_DecentralizationData.Rows[0][7].ToString();
                if (temp.Equals("True"))
                    chkQ6.Checked = true;
                temp = m_DecentralizationData.Rows[0][8].ToString();
                if (temp.Equals("True"))
                    chkQ7.Checked = true;
                temp = m_DecentralizationData.Rows[0][9].ToString();
                if (temp.Equals("True"))
                    chkQ8.Checked = true;
                temp = m_DecentralizationData.Rows[0][10].ToString();
                if (temp.Equals("True"))
                    chkQ9.Checked = true;
                temp = m_DecentralizationData.Rows[0][11].ToString();
                if (temp.Equals("True"))
                    chkQ10.Checked = true;
                temp = m_DecentralizationData.Rows[0][12].ToString();
                if (temp.Equals("True"))
                    chkQ11.Checked = true;
                temp = m_DecentralizationData.Rows[0][13].ToString();
                if (temp.Equals("True"))
                    chkQ12.Checked = true;
                temp = m_DecentralizationData.Rows[0][14].ToString();
                if (temp.Equals("True"))
                    chkQ13.Checked = true;
            }
            else
                showButtonAdd = false;
        }

        private void InitDecentralizationObect(String _maCV)
        {
            m_DecentralizationObj = new DecentralizationDTO();
            m_DecentralizationObj.maChucVu = _maCV;
            m_DecentralizationData = m_DecentralizationExecute.getDecentralizationWithMaCV(m_DecentralizationObj);
            //
            InitCheckEditDefault();
            //
            InitCheckEdit(m_DecentralizationData);
        }

        private void grdvListCharge_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (e.FocusedRowHandle >= 0)
            {
                m_DecentralizationObj.maChucVu = grdvListCharge.GetRowCellValue(e.FocusedRowHandle, grdvListCharge.Columns["MaCV"]).ToString();

                InitDecentralizationObect(m_DecentralizationObj.maChucVu);

               if (showButtonAdd)
               {
                   btnAdd.Visible = false;
                   btnUpdate.Visible = true;
                   btnSave.Enabled = false;
                   btnCancel.Visible = false;
                   setCheckEditReadOnly(false);
               }
               else
               {
                   btnCancel.Visible = false;
                   btnAdd.Visible = true;
                   btnUpdate.Visible = false;
                   btnSave.Enabled = false;
                   setCheckEditReadOnly(false);
               }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            isAddOrUpdate = true;
            btnSave.Enabled = true;
            btnUpdate.Visible = false;
            setCheckEditReadOnly(true);
            btnCancel.Visible = true;
            btnCancel.Text = "Hủy cập nhật";

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            isAddOrUpdate = false;
            setCheckEditReadOnly(true);
            btnSave.Enabled = true;
            btnCancel.Visible = true;
            btnCancel.Text = "Hủy thêm mới";
        }

        private void setCheckEditReadOnly(bool _b)
        {
            if (!_b)
            {
                chkQ1.Properties.ReadOnly = true;
                chkQ2.Properties.ReadOnly = true;
                chkQ3.Properties.ReadOnly = true;
                chkQ4.Properties.ReadOnly = true;
                chkQ5.Properties.ReadOnly = true;
                chkQ6.Properties.ReadOnly = true;
                chkQ7.Properties.ReadOnly = true;
                chkQ8.Properties.ReadOnly = true;
                chkQ9.Properties.ReadOnly = true;
                chkQ10.Properties.ReadOnly = true;
                chkQ11.Properties.ReadOnly = true;
                chkQ12.Properties.ReadOnly = true;
                chkQ13.Properties.ReadOnly = true;
            }
            else {
                chkQ1.Properties.ReadOnly = false;
                chkQ2.Properties.ReadOnly = false;
                chkQ3.Properties.ReadOnly = false;
                chkQ4.Properties.ReadOnly = false;
                chkQ5.Properties.ReadOnly = false;
                chkQ6.Properties.ReadOnly = false;
                chkQ7.Properties.ReadOnly = false;
                chkQ8.Properties.ReadOnly = false;
                chkQ9.Properties.ReadOnly = false;
                chkQ10.Properties.ReadOnly = false;
                chkQ11.Properties.ReadOnly = false;
                chkQ12.Properties.ReadOnly = false;
                chkQ13.Properties.ReadOnly = false;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            canEditCheck = false;
            setCheckEditReadOnly(canEditCheck);
            btnSave.Enabled = false;
            btnUpdate.Visible = true;
            btnAdd.Visible = true;
            btnCancel.Visible = false;
            if (isAddOrUpdate == true && showButtonAdd == false)
            {
                //Cap nhat
                btnAdd.Visible = false;
            }
            else 
            {
                //Them moi
                btnUpdate.Visible = false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            setCheckEditReadOnly(false);
            btnSave.Enabled = false;
            btnAdd.Visible = false;
            btnUpdate.Visible = true;
            btnCancel.Visible = false;

            setCheckEditValue();
            if (isAddOrUpdate)
            {
                updateDecentralization();
            }
            else
            {
                addDecentralization();
            }
        }

        private void updateDecentralization()
        {
            try
            {

                if (m_DecentralizationExecute.UpdateDecentralizationToDatabase(m_DecentralizationObj))
                {
                    InitDecentralizationObect(m_DecentralizationObj.maChucVu);
                }
                else
                {
                    XtraCustomMessageBox.Show("Cập nhật thất bại!", "Thông báo",true);
                }
            }
            catch (System.Exception) { }
        }

        private void addDecentralization()
        {
            try
            {
                if (m_DecentralizationExecute.AddDecentralizationToDatabase(m_DecentralizationObj))
                {
                    InitDecentralizationObect(m_DecentralizationObj.maChucVu);
                }
                else
                {
                    XtraCustomMessageBox.Show("Thêm mới thất bại!", "Thông báo",true);
                }
            }
            catch (System.Exception)
            {
               
            }
        }

        private void setCheckEditValue()
        {
            m_DecentralizationObj.ThietLapHeThong = chkQ1.Checked;
            m_DecentralizationObj.ThayDoiQuyDinh = chkQ2.Checked;
            m_DecentralizationObj.QuanLySach = chkQ3.Checked;
            m_DecentralizationObj.QuanLyNhanVien = chkQ4.Checked;
            m_DecentralizationObj.QuanLyKhachHang = chkQ5.Checked;
            m_DecentralizationObj.LapPhieuNhapSach = chkQ6.Checked;
            m_DecentralizationObj.LapHoaDonBanSach = chkQ7.Checked;
            m_DecentralizationObj.LapPhieuThuTien = chkQ8.Checked;
            m_DecentralizationObj.TraCuuSach = chkQ9.Checked;
            m_DecentralizationObj.TraCuuNhanVien = chkQ10.Checked;
            m_DecentralizationObj.TraCuuHoaDon = chkQ11.Checked;
            m_DecentralizationObj.TraCuuKhachHang = chkQ12.Checked;
            m_DecentralizationObj.LapBaoCaoThang = chkQ13.Checked;
        }
    }
}
