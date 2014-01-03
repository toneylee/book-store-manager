using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Manager_Book_Store.Business_Layer;
using Manager_Book_Store.Data_Tranfer_Object;

namespace Manager_Book_Store.Presentation_Layer
{
    public partial class frmRegulations : Form
    {
        #region "Variable"
        private CRegulationsBUS m_RegulationsExecute;
        private CRegulationsDTO m_RegulationsObject;
        private bool m_enableAdd;
        #endregion
        public frmRegulations()
        {
            InitializeComponent();
            m_enableAdd = false;
        }

        private void frmRegulations_Load(object sender, EventArgs e)
        {
            m_RegulationsExecute = new CRegulationsBUS();
            if (m_RegulationsExecute.getRegulationsDataByRuleFromDatabase("SoTienNoToiDa") >= 0)
            {
                spDebitMaximum.EditValue = m_RegulationsExecute.getRegulationsDataByRuleFromDatabase("SoTienNoToiDa");
                spMinimumQuantityImport.EditValue = m_RegulationsExecute.getRegulationsDataByRuleFromDatabase("SoLuongNhapToiThieu");
                spMinimumSurvival.EditValue = m_RegulationsExecute.getRegulationsDataByRuleFromDatabase("SoLuongTonToiThieuSauBan");
                spMaximumSurvival.EditValue = m_RegulationsExecute.getRegulationsDataByRuleFromDatabase("SoLuongTonToiDaTruocNhap");
                spMinimumAge.EditValue = m_RegulationsExecute.getRegulationsDataByRuleFromDatabase("DoTuoiNhanVienToiThieu");
                spMaximumAge.EditValue = m_RegulationsExecute.getRegulationsDataByRuleFromDatabase("DoTuoiNhanVienToiDa");
                spProfit.EditValue = m_RegulationsExecute.getRegulationsDataByRuleFromDatabase("MucLoiNhuan");
                if (m_RegulationsExecute.getRegulationsDataByRuleFromDatabase("SuDungQuyDinh4") == 0)
                    chkUseRegulationsFour.Checked = false;
                else
                    chkUseRegulationsFour.Checked = true;
                m_enableAdd = false;
                btnAdd.Visible = false;
            }
            else
            {
                m_enableAdd = true;
                btnUpdate.Visible = false;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int _enableRegulations = 0;
            if (chkUseRegulationsFour.Checked)
                _enableRegulations = 1;
            m_RegulationsObject = new CRegulationsDTO((int)spMinimumQuantityImport.Value, (int)spDebitMaximum.Value, (int)spMinimumSurvival.Value,
                (int)spMaximumSurvival.Value, _enableRegulations, (int)spMinimumAge.Value, (int)spMaximumAge.Value, (int)spProfit.Value);
            m_RegulationsExecute.UpdateRegulationsToDatabase(m_RegulationsObject);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (m_enableAdd)
            {
                int _enableRegulations = 0;
                if (chkUseRegulationsFour.Checked)
                    _enableRegulations = 1;
                m_RegulationsObject = new CRegulationsDTO((int)spMinimumQuantityImport.Value, (int)spDebitMaximum.Value, (int)spMinimumSurvival.Value,
                    (int)spMaximumSurvival.Value, _enableRegulations, (int)spMinimumAge.Value, (int)spMaximumAge.Value, (int)spProfit.Value);
                m_RegulationsExecute.AddRegulationsToDatabase(m_RegulationsObject);
                btnAdd.Visible = false;
                btnUpdate.Visible = true;
            }
        }
    }
}
