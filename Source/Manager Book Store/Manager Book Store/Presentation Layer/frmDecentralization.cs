using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Manager_Book_Store.Business_Layer;
using Manager_Book_Store.Data_Tranfer_Object;

namespace Manager_Book_Store.Presentation_Layer
{
    public partial class frmDecentralization : DevExpress.XtraEditors.XtraForm
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
            showButtonAdd = false;
            btnSave.Visible = false;
        }

        private void frmDecentralization_Load(object sender, EventArgs e)
        {
            //
            m_ChargeData = m_ChargeExecute.getChargeDataFromDatabase();
            grdListChucVu.DataSource = m_ChargeData;
        }

        private void InitCheckEditDefault()
        {
            ckbQ1.Checked = false;
            ckbQ2.Checked = false;
            ckbQ3.Checked = false;
            ckbQ4.Checked = false;
            ckbQ5.Checked = false;
            ckbQ6.Checked = false;
            ckbQ7.Checked = false;
            ckbQ8.Checked = false;
            ckbQ9.Checked = false;
            ckbQ10.Checked = false;
            ckbQ11.Checked = false;
            ckbQ12.Checked = false;
            ckbQ13.Checked = false;
        }

        private void InitCheckEdit(DataTable m_DecentralizationData)
        {
            if (m_DecentralizationData.Rows.Count > 0)
            {
                showButtonAdd = true;
                //
                String temp = m_DecentralizationData.Rows[0][2].ToString();
                if (temp.Equals("True"))
                    ckbQ1.Checked = true;
                temp = m_DecentralizationData.Rows[0][3].ToString();
                if (temp.Equals("True"))
                    ckbQ2.Checked = true;
                temp = m_DecentralizationData.Rows[0][4].ToString();
                if (temp.Equals("True"))
                    ckbQ3.Checked = true;
                temp = m_DecentralizationData.Rows[0][5].ToString();
                if (temp.Equals("True"))
                    ckbQ4.Checked = true;
                temp = m_DecentralizationData.Rows[0][6].ToString();
                if (temp.Equals("True"))
                    ckbQ5.Checked = true;
                temp = m_DecentralizationData.Rows[0][7].ToString();
                if (temp.Equals("True"))
                    ckbQ6.Checked = true;
                temp = m_DecentralizationData.Rows[0][8].ToString();
                if (temp.Equals("True"))
                    ckbQ7.Checked = true;
                temp = m_DecentralizationData.Rows[0][9].ToString();
                if (temp.Equals("True"))
                    ckbQ8.Checked = true;
                temp = m_DecentralizationData.Rows[0][10].ToString();
                if (temp.Equals("True"))
                    ckbQ9.Checked = true;
                temp = m_DecentralizationData.Rows[0][11].ToString();
                if (temp.Equals("True"))
                    ckbQ10.Checked = true;
                temp = m_DecentralizationData.Rows[0][12].ToString();
                if (temp.Equals("True"))
                    ckbQ11.Checked = true;
                temp = m_DecentralizationData.Rows[0][13].ToString();
                if (temp.Equals("True"))
                    ckbQ12.Checked = true;
                temp = m_DecentralizationData.Rows[0][14].ToString();
                if (temp.Equals("True"))
                    ckbQ13.Checked = true;
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

        private void grdvListBook_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (e.FocusedRowHandle >= 0)
            {
                m_DecentralizationObj.maChucVu = grdvListCV.GetRowCellValue(e.FocusedRowHandle, grdvListCV.Columns["MaCV"]).ToString();

                InitDecentralizationObect(m_DecentralizationObj.maChucVu);

               if (showButtonAdd)
               {
                   btnAdd.Visible = false;
                   btnUpdate.Visible = true;
               }
               else
               {
                   btnAdd.Visible = true;
                   btnCancel.Visible = false;
                   btnAdd.Visible = true;
                   btnUpdate.Visible = false;
                   setCheckEditReadOnly(showButtonAdd);
               }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            isAddOrUpdate = true;
            btnSave.Visible = true;
            btnUpdate.Visible = false;
            canEditCheck = true;
            setCheckEditReadOnly(canEditCheck);
            btnCancel.Visible = true;
            btnCancel.Text = "Hủy cập nhật";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            isAddOrUpdate = false;
            canEditCheck = true;
            setCheckEditReadOnly(canEditCheck);
            btnSave.Visible = true;
            btnCancel.Visible = true;
            btnCancel.Text = "Hủy thêm mới";
        }

        private void setCheckEditReadOnly(bool _b)
        {
            if (!_b)
            {
                ckbQ1.Properties.ReadOnly = true;
                ckbQ2.Properties.ReadOnly = true;
                ckbQ3.Properties.ReadOnly = true;
                ckbQ4.Properties.ReadOnly = true;
                ckbQ5.Properties.ReadOnly = true;
                ckbQ6.Properties.ReadOnly = true;
                ckbQ7.Properties.ReadOnly = true;
                ckbQ8.Properties.ReadOnly = true;
                ckbQ9.Properties.ReadOnly = true;
                ckbQ10.Properties.ReadOnly = true;
                ckbQ11.Properties.ReadOnly = true;
                ckbQ12.Properties.ReadOnly = true;
                ckbQ13.Properties.ReadOnly = true;
            }
            else {
                ckbQ1.Properties.ReadOnly = false;
                ckbQ2.Properties.ReadOnly = false;
                ckbQ3.Properties.ReadOnly = false;
                ckbQ4.Properties.ReadOnly = false;
                ckbQ5.Properties.ReadOnly = false;
                ckbQ6.Properties.ReadOnly = false;
                ckbQ7.Properties.ReadOnly = false;
                ckbQ8.Properties.ReadOnly = false;
                ckbQ9.Properties.ReadOnly = false;
                ckbQ10.Properties.ReadOnly = false;
                ckbQ11.Properties.ReadOnly = false;
                ckbQ12.Properties.ReadOnly = false;
                ckbQ13.Properties.ReadOnly = false;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            canEditCheck = false;
            setCheckEditReadOnly(canEditCheck);
            btnSave.Visible = false;
            btnUpdate.Visible = true;
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
            canEditCheck = false;
            setCheckEditReadOnly(canEditCheck);
            btnSave.Visible = false;
            btnAdd.Visible = false;
            btnUpdate.Visible = true;
            btnCancel.Visible = false;

            setCheckEditValue();

            if (isAddOrUpdate)
            {
                //Cap nhat
                updateDecentralization();
            }
            else
            {
                //Them moi
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
                    XtraMessageBox.Show("Cập nhật thất bại!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                }
            }
            catch (System.Exception ex)
            {
                XtraMessageBox.Show(ex.ToString(), "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            }
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
                    XtraMessageBox.Show("Thêm mới thất bại!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                }
            }
            catch (System.Exception ex)
            {
                XtraMessageBox.Show(ex.ToString(), "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            }
        }

        private void setCheckEditValue()
        {
            m_DecentralizationObj.ThietLapHeThong = ckbQ1.Checked;
            m_DecentralizationObj.ThayDoiQuyDinh = ckbQ2.Checked;
            m_DecentralizationObj.QuanLySach = ckbQ3.Checked;
            m_DecentralizationObj.QuanLyNhanVien = ckbQ4.Checked;
            m_DecentralizationObj.QuanLyKhachHang = ckbQ5.Checked;
            m_DecentralizationObj.LapPhieuNhapSach = ckbQ6.Checked;
            m_DecentralizationObj.LapHoaDonBanSach = ckbQ7.Checked;
            m_DecentralizationObj.LapPhieuThuTien = ckbQ8.Checked;
            m_DecentralizationObj.TraCuuSach = ckbQ9.Checked;
            m_DecentralizationObj.TraCuuNhanVien = ckbQ10.Checked;
            m_DecentralizationObj.TraCuuHoaDon = ckbQ11.Checked;
            m_DecentralizationObj.TraCuuKhachHang = ckbQ12.Checked;
            m_DecentralizationObj.LapBaoCaoThang = ckbQ13.Checked;
        }
    }
}