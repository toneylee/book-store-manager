namespace Manager_Book_Store.Report
{
    partial class rptSurvival
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
            this.xrtbBookIdValue = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrtbBookNameValue = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrtbSurvivalFirstValue = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrtbSurvivalSecondValue = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrtbSurvivalThirdValue = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrtbTitles = new DevExpress.XtraReports.UI.XRTable();
            this.xrtRTitles = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrtbSTT = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrtBookId = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrtbBookName = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrtbSurvivalFirst = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrtSurvivalSecond = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrtbSurvivalThird = new DevExpress.XtraReports.UI.XRTableCell();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.xrlbBookStoreAddress = new DevExpress.XtraReports.UI.XRLabel();
            this.xrlbBookStoreName = new DevExpress.XtraReports.UI.XRLabel();
            this.xrlbTitles = new DevExpress.XtraReports.UI.XRLabel();
            this.ReportFooter = new DevExpress.XtraReports.UI.ReportFooterBand();
            this.xrlbDateSurvival = new DevExpress.XtraReports.UI.XRLabel();
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
            this.xrtbBookIdValue,
            this.xrtbBookNameValue,
            this.xrtbSurvivalFirstValue,
            this.xrtbSurvivalSecondValue,
            this.xrtbSurvivalThirdValue});
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
            // xrtbBookIdValue
            // 
            this.xrtbBookIdValue.Name = "xrtbBookIdValue";
            this.xrtbBookIdValue.StylePriority.UseTextAlignment = false;
            this.xrtbBookIdValue.Text = "Mã sách";
            this.xrtbBookIdValue.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrtbBookIdValue.Weight = 0.9022954746477494D;
            // 
            // xrtbBookNameValue
            // 
            this.xrtbBookNameValue.Name = "xrtbBookNameValue";
            this.xrtbBookNameValue.StylePriority.UseTextAlignment = false;
            this.xrtbBookNameValue.Text = "Tên sách";
            this.xrtbBookNameValue.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrtbBookNameValue.Weight = 1.6862125672030357D;
            // 
            // xrtbSurvivalFirstValue
            // 
            this.xrtbSurvivalFirstValue.Name = "xrtbSurvivalFirstValue";
            this.xrtbSurvivalFirstValue.StylePriority.UseTextAlignment = false;
            this.xrtbSurvivalFirstValue.Text = "Tồn đầu ";
            this.xrtbSurvivalFirstValue.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrtbSurvivalFirstValue.Weight = 0.9504169579592634D;
            // 
            // xrtbSurvivalSecondValue
            // 
            this.xrtbSurvivalSecondValue.Name = "xrtbSurvivalSecondValue";
            this.xrtbSurvivalSecondValue.StylePriority.UseTextAlignment = false;
            this.xrtbSurvivalSecondValue.Text = "Phát sinh";
            this.xrtbSurvivalSecondValue.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrtbSurvivalSecondValue.Weight = 1.0626048291931183D;
            // 
            // xrtbSurvivalThirdValue
            // 
            this.xrtbSurvivalThirdValue.Name = "xrtbSurvivalThirdValue";
            this.xrtbSurvivalThirdValue.StylePriority.UseTextAlignment = false;
            this.xrtbSurvivalThirdValue.Text = "Tồn cuối";
            this.xrtbSurvivalThirdValue.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrtbSurvivalThirdValue.Weight = 0.970967479476647D;
            // 
            // xrtbTitles
            // 
            this.xrtbTitles.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.xrtbTitles.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
                        | DevExpress.XtraPrinting.BorderSide.Right)
                        | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrtbTitles.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrtbTitles.LocationFloat = new DevExpress.Utils.PointFloat(0F, 237.5834F);
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
            this.xrtBookId,
            this.xrtbBookName,
            this.xrtbSurvivalFirst,
            this.xrtSurvivalSecond,
            this.xrtbSurvivalThird});
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
            // xrtBookId
            // 
            this.xrtBookId.Name = "xrtBookId";
            this.xrtBookId.StylePriority.UseTextAlignment = false;
            this.xrtBookId.Text = "Mã sách";
            this.xrtBookId.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrtBookId.Weight = 0.9022954746477494D;
            // 
            // xrtbBookName
            // 
            this.xrtbBookName.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
                        | DevExpress.XtraPrinting.BorderSide.Right)
                        | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrtbBookName.Name = "xrtbBookName";
            this.xrtbBookName.StylePriority.UseBorders = false;
            this.xrtbBookName.StylePriority.UseTextAlignment = false;
            this.xrtbBookName.Text = "Tên sách";
            this.xrtbBookName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrtbBookName.Weight = 1.6862125672030357D;
            // 
            // xrtbSurvivalFirst
            // 
            this.xrtbSurvivalFirst.Name = "xrtbSurvivalFirst";
            this.xrtbSurvivalFirst.StylePriority.UseTextAlignment = false;
            this.xrtbSurvivalFirst.Text = "Tồn đầu ";
            this.xrtbSurvivalFirst.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrtbSurvivalFirst.Weight = 0.9504169579592634D;
            // 
            // xrtSurvivalSecond
            // 
            this.xrtSurvivalSecond.Name = "xrtSurvivalSecond";
            this.xrtSurvivalSecond.StylePriority.UseTextAlignment = false;
            this.xrtSurvivalSecond.Text = "Phát sinh";
            this.xrtSurvivalSecond.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrtSurvivalSecond.Weight = 1.0626048291931183D;
            // 
            // xrtbSurvivalThird
            // 
            this.xrtbSurvivalThird.Name = "xrtbSurvivalThird";
            this.xrtbSurvivalThird.StylePriority.UseTextAlignment = false;
            this.xrtbSurvivalThird.Text = "Tồn cuối";
            this.xrtbSurvivalThird.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrtbSurvivalThird.Weight = 0.970967479476647D;
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
            this.xrlbBookStoreAddress,
            this.xrlbBookStoreName,
            this.xrlbTitles,
            this.xrtbTitles,
            this.xrlbDateValue,
            this.xrlbDateSurvival});
            this.ReportHeader.HeightF = 262.5834F;
            this.ReportHeader.Name = "ReportHeader";
            // 
            // xrlbBookStoreAddress
            // 
            this.xrlbBookStoreAddress.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.xrlbBookStoreAddress.LocationFloat = new DevExpress.Utils.PointFloat(0F, 34.04168F);
            this.xrlbBookStoreAddress.Name = "xrlbBookStoreAddress";
            this.xrlbBookStoreAddress.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrlbBookStoreAddress.SizeF = new System.Drawing.SizeF(467.7083F, 21.95834F);
            this.xrlbBookStoreAddress.StylePriority.UseFont = false;
            this.xrlbBookStoreAddress.StylePriority.UseTextAlignment = false;
            this.xrlbBookStoreAddress.Text = "Quận 6 - Tp Hồ Chí Minh";
            this.xrlbBookStoreAddress.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrlbBookStoreName
            // 
            this.xrlbBookStoreName.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold);
            this.xrlbBookStoreName.LocationFloat = new DevExpress.Utils.PointFloat(0F, 10.00001F);
            this.xrlbBookStoreName.Name = "xrlbBookStoreName";
            this.xrlbBookStoreName.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrlbBookStoreName.SizeF = new System.Drawing.SizeF(467.7083F, 24.04167F);
            this.xrlbBookStoreName.StylePriority.UseFont = false;
            this.xrlbBookStoreName.StylePriority.UseTextAlignment = false;
            this.xrlbBookStoreName.Text = "NHÀ SÁCH TRƯỜNG TỒN";
            this.xrlbBookStoreName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrlbTitles
            // 
            this.xrlbTitles.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold);
            this.xrlbTitles.LocationFloat = new DevExpress.Utils.PointFloat(188.5417F, 125.4167F);
            this.xrlbTitles.Name = "xrlbTitles";
            this.xrlbTitles.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrlbTitles.SizeF = new System.Drawing.SizeF(292.7083F, 38.625F);
            this.xrlbTitles.StylePriority.UseFont = false;
            this.xrlbTitles.StylePriority.UseTextAlignment = false;
            this.xrlbTitles.Text = "BÁO CÁO TỒN";
            this.xrlbTitles.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // ReportFooter
            // 
            this.ReportFooter.Name = "ReportFooter";
            // 
            // xrlbDateSurvival
            // 
            this.xrlbDateSurvival.BorderColor = System.Drawing.Color.White;
            this.xrlbDateSurvival.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Italic);
            this.xrlbDateSurvival.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.xrlbDateSurvival.LocationFloat = new DevExpress.Utils.PointFloat(442.4382F, 80.54167F);
            this.xrlbDateSurvival.Name = "xrlbDateSurvival";
            this.xrlbDateSurvival.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrlbDateSurvival.SizeF = new System.Drawing.SizeF(207.5618F, 23F);
            this.xrlbDateSurvival.StylePriority.UseBorderColor = false;
            this.xrlbDateSurvival.StylePriority.UseFont = false;
            this.xrlbDateSurvival.StylePriority.UseForeColor = false;
            // 
            // xrlbDateValue
            // 
            this.xrlbDateValue.BorderColor = System.Drawing.Color.Black;
            this.xrlbDateValue.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.xrlbDateValue.ForeColor = System.Drawing.Color.OrangeRed;
            this.xrlbDateValue.LocationFloat = new DevExpress.Utils.PointFloat(256.1264F, 164.0417F);
            this.xrlbDateValue.Name = "xrlbDateValue";
            this.xrlbDateValue.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrlbDateValue.SizeF = new System.Drawing.SizeF(162.7702F, 23F);
            this.xrlbDateValue.StylePriority.UseBorderColor = false;
            this.xrlbDateValue.StylePriority.UseFont = false;
            this.xrlbDateValue.StylePriority.UseForeColor = false;
            this.xrlbDateValue.Text = "Tháng 7 năm 2013";
            // 
            // rptSurvival
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.ReportHeader,
            this.ReportFooter});
            this.Version = "13.2";
            this.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.rptSurvival_BeforePrint);
            ((System.ComponentModel.ISupportInitialize)(this.xrtbValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrtbTitles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        private DevExpress.XtraReports.UI.XRLabel xrlbTitles;
        private DevExpress.XtraReports.UI.XRTable xrtbValue;
        private DevExpress.XtraReports.UI.XRTableRow xrtbRValue;
        private DevExpress.XtraReports.UI.XRTableCell xrtSTTValue;
        private DevExpress.XtraReports.UI.XRTableCell xrtbBookIdValue;
        private DevExpress.XtraReports.UI.XRTableCell xrtbBookNameValue;
        private DevExpress.XtraReports.UI.XRTableCell xrtbSurvivalFirstValue;
        private DevExpress.XtraReports.UI.XRTableCell xrtbSurvivalSecondValue;
        private DevExpress.XtraReports.UI.XRTableCell xrtbSurvivalThirdValue;
        private DevExpress.XtraReports.UI.XRLabel xrlbBookStoreAddress;
        private DevExpress.XtraReports.UI.XRLabel xrlbBookStoreName;
        private DevExpress.XtraReports.UI.ReportFooterBand ReportFooter;
        private DevExpress.XtraReports.UI.XRTable xrtbTitles;
        private DevExpress.XtraReports.UI.XRTableRow xrtRTitles;
        private DevExpress.XtraReports.UI.XRTableCell xrtbSTT;
        private DevExpress.XtraReports.UI.XRTableCell xrtBookId;
        private DevExpress.XtraReports.UI.XRTableCell xrtbBookName;
        private DevExpress.XtraReports.UI.XRTableCell xrtbSurvivalFirst;
        private DevExpress.XtraReports.UI.XRTableCell xrtSurvivalSecond;
        private DevExpress.XtraReports.UI.XRTableCell xrtbSurvivalThird;
        private DevExpress.XtraReports.UI.XRLabel xrlbDateSurvival;
        private DevExpress.XtraReports.UI.XRLabel xrlbDateValue;
    }
}
