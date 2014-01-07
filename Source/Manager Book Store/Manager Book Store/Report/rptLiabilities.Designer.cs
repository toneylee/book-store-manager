namespace Manager_Book_Store.Report
{
    partial class rptLiabilities
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrtbValue = new DevExpress.XtraReports.UI.XRTable();
            this.xrtbRValue = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrtSTTValue = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrtbCustomerIdValue = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrtbCustomerNameValue = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrtbLiabilitiesFirstValue = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrtbLiabilitiesSecondValue = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrtbLiabilitiesThirdValue = new DevExpress.XtraReports.UI.XRTableCell();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.xrtbTitles = new DevExpress.XtraReports.UI.XRTable();
            this.xrtRTitles = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrtbSTT = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrtCustomerId = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrtbCustomerName = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrtbLiabilitiesFirst = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrtLiabilitiesSecond = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrtbLiabilitiesThird = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrlbCustomerStoreName = new DevExpress.XtraReports.UI.XRLabel();
            this.xrlbCustomerStoreAddress = new DevExpress.XtraReports.UI.XRLabel();
            this.xrlbTitles = new DevExpress.XtraReports.UI.XRLabel();
            this.xrlbDateLiabilities = new DevExpress.XtraReports.UI.XRLabel();
            this.xrlbDateValue = new DevExpress.XtraReports.UI.XRLabel();
            ((System.ComponentModel.ISupportInitialize)(this.xrtbValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrtbTitles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrtbValue});
            this.Detail.HeightF = 25F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrtbValue
            // 
            this.xrtbValue.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.xrtbValue.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right)
                        | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrtbValue.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.xrtbValue.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrtbValue.Name = "xrtbValue";
            this.xrtbValue.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrtbRValue});
            this.xrtbValue.SizeF = new System.Drawing.SizeF(650F, 25F);
            this.xrtbValue.StylePriority.UseBorderColor = false;
            this.xrtbValue.StylePriority.UseBorders = false;
            this.xrtbValue.StylePriority.UseFont = false;
            // 
            // xrtbRValue
            // 
            this.xrtbRValue.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrtSTTValue,
            this.xrtbCustomerIdValue,
            this.xrtbCustomerNameValue,
            this.xrtbLiabilitiesFirstValue,
            this.xrtbLiabilitiesSecondValue,
            this.xrtbLiabilitiesThirdValue});
            this.xrtbRValue.Name = "xrtbRValue";
            this.xrtbRValue.Weight = 1D;
            // 
            // xrtSTTValue
            // 
            this.xrtSTTValue.Name = "xrtSTTValue";
            this.xrtSTTValue.StylePriority.UseTextAlignment = false;
            this.xrtSTTValue.Text = "STT";
            this.xrtSTTValue.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrtSTTValue.Weight = 0.41708673693034248D;
            // 
            // xrtbCustomerIdValue
            // 
            this.xrtbCustomerIdValue.Name = "xrtbCustomerIdValue";
            this.xrtbCustomerIdValue.StylePriority.UseTextAlignment = false;
            this.xrtbCustomerIdValue.Text = "Mã khách hàng";
            this.xrtbCustomerIdValue.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrtbCustomerIdValue.Weight = 0.9022954746477494D;
            // 
            // xrtbCustomerNameValue
            // 
            this.xrtbCustomerNameValue.Name = "xrtbCustomerNameValue";
            this.xrtbCustomerNameValue.StylePriority.UseTextAlignment = false;
            this.xrtbCustomerNameValue.Text = "Tên khách hàng";
            this.xrtbCustomerNameValue.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrtbCustomerNameValue.Weight = 1.6862125672030357D;
            // 
            // xrtbLiabilitiesFirstValue
            // 
            this.xrtbLiabilitiesFirstValue.Name = "xrtbLiabilitiesFirstValue";
            this.xrtbLiabilitiesFirstValue.StylePriority.UseTextAlignment = false;
            this.xrtbLiabilitiesFirstValue.Text = "Nợ đầu ";
            this.xrtbLiabilitiesFirstValue.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrtbLiabilitiesFirstValue.Weight = 0.9504169579592634D;
            // 
            // xrtbLiabilitiesSecondValue
            // 
            this.xrtbLiabilitiesSecondValue.Name = "xrtbLiabilitiesSecondValue";
            this.xrtbLiabilitiesSecondValue.StylePriority.UseTextAlignment = false;
            this.xrtbLiabilitiesSecondValue.Text = "Phát sinh";
            this.xrtbLiabilitiesSecondValue.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrtbLiabilitiesSecondValue.Weight = 1.0626048291931183D;
            // 
            // xrtbLiabilitiesThirdValue
            // 
            this.xrtbLiabilitiesThirdValue.Name = "xrtbLiabilitiesThirdValue";
            this.xrtbLiabilitiesThirdValue.StylePriority.UseTextAlignment = false;
            this.xrtbLiabilitiesThirdValue.Text = "Nợ cuối";
            this.xrtbLiabilitiesThirdValue.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrtbLiabilitiesThirdValue.Weight = 0.970967479476647D;
            // 
            // TopMargin
            // 
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // BottomMargin
            // 
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrtbTitles,
            this.xrlbCustomerStoreName,
            this.xrlbCustomerStoreAddress,
            this.xrlbTitles,
            this.xrlbDateLiabilities,
            this.xrlbDateValue});
            this.ReportHeader.HeightF = 248.9583F;
            this.ReportHeader.Name = "ReportHeader";
            // 
            // xrtbTitles
            // 
            this.xrtbTitles.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.xrtbTitles.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
                        | DevExpress.XtraPrinting.BorderSide.Right)
                        | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrtbTitles.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrtbTitles.LocationFloat = new DevExpress.Utils.PointFloat(3.178914E-05F, 223.9583F);
            this.xrtbTitles.Name = "xrtbTitles";
            this.xrtbTitles.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrtRTitles});
            this.xrtbTitles.SizeF = new System.Drawing.SizeF(650F, 25F);
            this.xrtbTitles.StylePriority.UseBorderColor = false;
            this.xrtbTitles.StylePriority.UseBorders = false;
            this.xrtbTitles.StylePriority.UseFont = false;
            // 
            // xrtRTitles
            // 
            this.xrtRTitles.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrtbSTT,
            this.xrtCustomerId,
            this.xrtbCustomerName,
            this.xrtbLiabilitiesFirst,
            this.xrtLiabilitiesSecond,
            this.xrtbLiabilitiesThird});
            this.xrtRTitles.Name = "xrtRTitles";
            this.xrtRTitles.Weight = 1D;
            // 
            // xrtbSTT
            // 
            this.xrtbSTT.Name = "xrtbSTT";
            this.xrtbSTT.StylePriority.UseTextAlignment = false;
            this.xrtbSTT.Text = "STT";
            this.xrtbSTT.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrtbSTT.Weight = 0.41708673693034248D;
            // 
            // xrtCustomerId
            // 
            this.xrtCustomerId.Name = "xrtCustomerId";
            this.xrtCustomerId.StylePriority.UseTextAlignment = false;
            this.xrtCustomerId.Text = "Mã khách hàng";
            this.xrtCustomerId.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrtCustomerId.Weight = 0.9022954746477494D;
            // 
            // xrtbCustomerName
            // 
            this.xrtbCustomerName.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
                        | DevExpress.XtraPrinting.BorderSide.Right)
                        | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrtbCustomerName.Name = "xrtbCustomerName";
            this.xrtbCustomerName.StylePriority.UseBorders = false;
            this.xrtbCustomerName.StylePriority.UseTextAlignment = false;
            this.xrtbCustomerName.Text = "Tên khách hàng";
            this.xrtbCustomerName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrtbCustomerName.Weight = 1.6862125672030357D;
            // 
            // xrtbLiabilitiesFirst
            // 
            this.xrtbLiabilitiesFirst.Name = "xrtbLiabilitiesFirst";
            this.xrtbLiabilitiesFirst.StylePriority.UseTextAlignment = false;
            this.xrtbLiabilitiesFirst.Text = "Nợ đầu ";
            this.xrtbLiabilitiesFirst.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrtbLiabilitiesFirst.Weight = 0.9504169579592634D;
            // 
            // xrtLiabilitiesSecond
            // 
            this.xrtLiabilitiesSecond.Name = "xrtLiabilitiesSecond";
            this.xrtLiabilitiesSecond.StylePriority.UseTextAlignment = false;
            this.xrtLiabilitiesSecond.Text = "Phát sinh";
            this.xrtLiabilitiesSecond.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrtLiabilitiesSecond.Weight = 1.0626048291931183D;
            // 
            // xrtbLiabilitiesThird
            // 
            this.xrtbLiabilitiesThird.Name = "xrtbLiabilitiesThird";
            this.xrtbLiabilitiesThird.StylePriority.UseTextAlignment = false;
            this.xrtbLiabilitiesThird.Text = "Nợ cuối";
            this.xrtbLiabilitiesThird.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrtbLiabilitiesThird.Weight = 0.970967479476647D;
            // 
            // xrlbCustomerStoreName
            // 
            this.xrlbCustomerStoreName.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold);
            this.xrlbCustomerStoreName.LocationFloat = new DevExpress.Utils.PointFloat(0F, 13.04166F);
            this.xrlbCustomerStoreName.Name = "xrlbCustomerStoreName";
            this.xrlbCustomerStoreName.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrlbCustomerStoreName.SizeF = new System.Drawing.SizeF(467.7083F, 24.04167F);
            this.xrlbCustomerStoreName.StylePriority.UseFont = false;
            this.xrlbCustomerStoreName.StylePriority.UseTextAlignment = false;
            this.xrlbCustomerStoreName.Text = "NHÀ SÁCH TRƯỜNG TỒN";
            this.xrlbCustomerStoreName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrlbCustomerStoreAddress
            // 
            this.xrlbCustomerStoreAddress.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.xrlbCustomerStoreAddress.LocationFloat = new DevExpress.Utils.PointFloat(0F, 37.08333F);
            this.xrlbCustomerStoreAddress.Name = "xrlbCustomerStoreAddress";
            this.xrlbCustomerStoreAddress.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrlbCustomerStoreAddress.SizeF = new System.Drawing.SizeF(467.7083F, 21.95834F);
            this.xrlbCustomerStoreAddress.StylePriority.UseFont = false;
            this.xrlbCustomerStoreAddress.StylePriority.UseTextAlignment = false;
            this.xrlbCustomerStoreAddress.Text = "Quận 6 - Tp Hồ Chí Minh";
            this.xrlbCustomerStoreAddress.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrlbTitles
            // 
            this.xrlbTitles.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold);
            this.xrlbTitles.LocationFloat = new DevExpress.Utils.PointFloat(188.5417F, 128.4583F);
            this.xrlbTitles.Name = "xrlbTitles";
            this.xrlbTitles.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrlbTitles.SizeF = new System.Drawing.SizeF(292.7083F, 38.625F);
            this.xrlbTitles.StylePriority.UseFont = false;
            this.xrlbTitles.StylePriority.UseTextAlignment = false;
            this.xrlbTitles.Text = "BÁO CÁO CÔNG NỢ";
            this.xrlbTitles.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrlbDateLiabilities
            // 
            this.xrlbDateLiabilities.BorderColor = System.Drawing.Color.White;
            this.xrlbDateLiabilities.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Italic);
            this.xrlbDateLiabilities.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.xrlbDateLiabilities.LocationFloat = new DevExpress.Utils.PointFloat(442.4382F, 83.58332F);
            this.xrlbDateLiabilities.Name = "xrlbDateLiabilities";
            this.xrlbDateLiabilities.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrlbDateLiabilities.SizeF = new System.Drawing.SizeF(207.5618F, 23F);
            this.xrlbDateLiabilities.StylePriority.UseBorderColor = false;
            this.xrlbDateLiabilities.StylePriority.UseFont = false;
            this.xrlbDateLiabilities.StylePriority.UseForeColor = false;
            // 
            // xrlbDateValue
            // 
            this.xrlbDateValue.BorderColor = System.Drawing.Color.Black;
            this.xrlbDateValue.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.xrlbDateValue.ForeColor = System.Drawing.Color.OrangeRed;
            this.xrlbDateValue.LocationFloat = new DevExpress.Utils.PointFloat(256.1264F, 167.0833F);
            this.xrlbDateValue.Name = "xrlbDateValue";
            this.xrlbDateValue.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrlbDateValue.SizeF = new System.Drawing.SizeF(162.7702F, 23F);
            this.xrlbDateValue.StylePriority.UseBorderColor = false;
            this.xrlbDateValue.StylePriority.UseFont = false;
            this.xrlbDateValue.StylePriority.UseForeColor = false;
            this.xrlbDateValue.Text = "Tháng 7 năm 2013";
            // 
            // rptLiabilities
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.ReportHeader});
            this.Version = "13.2";
            this.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.rptLiabilities_BeforePrint);
            ((System.ComponentModel.ISupportInitialize)(this.xrtbValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrtbTitles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        private DevExpress.XtraReports.UI.XRLabel xrlbCustomerStoreName;
        private DevExpress.XtraReports.UI.XRLabel xrlbCustomerStoreAddress;
        private DevExpress.XtraReports.UI.XRLabel xrlbTitles;
        private DevExpress.XtraReports.UI.XRLabel xrlbDateLiabilities;
        private DevExpress.XtraReports.UI.XRLabel xrlbDateValue;
        private DevExpress.XtraReports.UI.XRTable xrtbTitles;
        private DevExpress.XtraReports.UI.XRTableRow xrtRTitles;
        private DevExpress.XtraReports.UI.XRTableCell xrtbSTT;
        private DevExpress.XtraReports.UI.XRTableCell xrtCustomerId;
        private DevExpress.XtraReports.UI.XRTableCell xrtbCustomerName;
        private DevExpress.XtraReports.UI.XRTableCell xrtbLiabilitiesFirst;
        private DevExpress.XtraReports.UI.XRTableCell xrtLiabilitiesSecond;
        private DevExpress.XtraReports.UI.XRTableCell xrtbLiabilitiesThird;
        private DevExpress.XtraReports.UI.XRTable xrtbValue;
        private DevExpress.XtraReports.UI.XRTableRow xrtbRValue;
        private DevExpress.XtraReports.UI.XRTableCell xrtSTTValue;
        private DevExpress.XtraReports.UI.XRTableCell xrtbCustomerIdValue;
        private DevExpress.XtraReports.UI.XRTableCell xrtbCustomerNameValue;
        private DevExpress.XtraReports.UI.XRTableCell xrtbLiabilitiesFirstValue;
        private DevExpress.XtraReports.UI.XRTableCell xrtbLiabilitiesSecondValue;
        private DevExpress.XtraReports.UI.XRTableCell xrtbLiabilitiesThirdValue;
    }
}
