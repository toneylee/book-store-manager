namespace Manager_Book_Store.Presentation_Layer
{
    partial class frmCustomerSearch
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.navBarGroup = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarGroupControlContainer = new DevExpress.XtraNavBar.NavBarGroupControlContainer();
            this.xtraScrollableControl1 = new DevExpress.XtraEditors.XtraScrollableControl();
            this.cmbGender = new DevExpress.XtraEditors.ComboBoxEdit();
            this.raGChose = new DevExpress.XtraEditors.RadioGroup();
            this.spDebits = new DevExpress.XtraEditors.SpinEdit();
            this.labGender = new DevExpress.XtraEditors.LabelControl();
            this.labDebits = new DevExpress.XtraEditors.LabelControl();
            this.chkEnableSearchFast = new DevExpress.XtraEditors.CheckEdit();
            this.navBarControl = new DevExpress.XtraNavBar.NavBarControl();
            this.txtContentSearch = new DevExpress.XtraEditors.TextEdit();
            this.grpSearchContent = new DevExpress.XtraEditors.GroupControl();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.labContentSearch = new DevExpress.XtraEditors.LabelControl();
            this.panSearchContent = new DevExpress.XtraEditors.PanelControl();
            this.panSearchTitles = new DevExpress.XtraEditors.PanelControl();
            this.labBookGenreTitle = new DevExpress.XtraEditors.LabelControl();
            this.panView = new DevExpress.XtraEditors.PanelControl();
            this.grdListCustomer = new DevExpress.XtraGrid.GridControl();
            this.grdvListCustomer = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.CustomerSno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CustomerId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CustomeName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CustomerBirthday = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rdateCustomerBirthday = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.CustomerGender = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CustomerAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CustomerEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CustomerPhonNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CustomerDebit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.navBarGroupControlContainer.SuspendLayout();
            this.xtraScrollableControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbGender.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.raGChose.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spDebits.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkEnableSearchFast.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl)).BeginInit();
            this.navBarControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtContentSearch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpSearchContent)).BeginInit();
            this.grpSearchContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panSearchContent)).BeginInit();
            this.panSearchContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panSearchTitles)).BeginInit();
            this.panSearchTitles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panView)).BeginInit();
            this.panView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdListCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdvListCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdateCustomerBirthday)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdateCustomerBirthday.CalendarTimeProperties)).BeginInit();
            this.SuspendLayout();
            // 
            // navBarGroup
            // 
            this.navBarGroup.Caption = "Tùy chọn";
            this.navBarGroup.ControlContainer = this.navBarGroupControlContainer;
            this.navBarGroup.Expanded = true;
            this.navBarGroup.GroupClientHeight = 80;
            this.navBarGroup.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.ControlContainer;
            this.navBarGroup.Name = "navBarGroup";
            // 
            // navBarGroupControlContainer
            // 
            this.navBarGroupControlContainer.Controls.Add(this.xtraScrollableControl1);
            this.navBarGroupControlContainer.Name = "navBarGroupControlContainer";
            this.navBarGroupControlContainer.Size = new System.Drawing.Size(263, 285);
            this.navBarGroupControlContainer.TabIndex = 0;
            // 
            // xtraScrollableControl1
            // 
            this.xtraScrollableControl1.Controls.Add(this.cmbGender);
            this.xtraScrollableControl1.Controls.Add(this.raGChose);
            this.xtraScrollableControl1.Controls.Add(this.spDebits);
            this.xtraScrollableControl1.Controls.Add(this.labGender);
            this.xtraScrollableControl1.Controls.Add(this.labDebits);
            this.xtraScrollableControl1.Controls.Add(this.chkEnableSearchFast);
            this.xtraScrollableControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraScrollableControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraScrollableControl1.Name = "xtraScrollableControl1";
            this.xtraScrollableControl1.Size = new System.Drawing.Size(263, 285);
            this.xtraScrollableControl1.TabIndex = 0;
            // 
            // cmbGender
            // 
            this.cmbGender.Location = new System.Drawing.Point(6, 37);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbGender.Properties.Items.AddRange(new object[] {
            "Tất cả",
            "Nam",
            "Nữ"});
            this.cmbGender.Size = new System.Drawing.Size(182, 20);
            this.cmbGender.TabIndex = 3;
            this.cmbGender.SelectedIndexChanged += new System.EventHandler(this.cmbGender_SelectedIndexChanged);
            // 
            // raGChose
            // 
            this.raGChose.Location = new System.Drawing.Point(-2, 70);
            this.raGChose.Name = "raGChose";
            this.raGChose.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Tìm theo tên khách hàng"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(2, "Tìm theo địa chỉ"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(3, "Tìm theo Email"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(4, "Tìm theo số điện thoại"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Bỏ chọn")});
            this.raGChose.Size = new System.Drawing.Size(265, 163);
            this.raGChose.TabIndex = 2;
            this.raGChose.SelectedIndexChanged += new System.EventHandler(this.raGChose_SelectedIndexChanged);
            // 
            // spDebits
            // 
            this.spDebits.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spDebits.Location = new System.Drawing.Point(128, 250);
            this.spDebits.Name = "spDebits";
            this.spDebits.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spDebits.Size = new System.Drawing.Size(104, 20);
            this.spDebits.TabIndex = 0;
            this.spDebits.TextChanged += new System.EventHandler(this.spDebits_TextChanged);
            // 
            // labGender
            // 
            this.labGender.Location = new System.Drawing.Point(9, 10);
            this.labGender.Name = "labGender";
            this.labGender.Size = new System.Drawing.Size(38, 13);
            this.labGender.TabIndex = 0;
            this.labGender.Text = "Giới tính";
            // 
            // labDebits
            // 
            this.labDebits.Location = new System.Drawing.Point(10, 253);
            this.labDebits.Name = "labDebits";
            this.labDebits.Size = new System.Drawing.Size(54, 13);
            this.labDebits.TabIndex = 0;
            this.labDebits.Text = "Tiền nợ >=";
            // 
            // chkEnableSearchFast
            // 
            this.chkEnableSearchFast.Location = new System.Drawing.Point(8, 280);
            this.chkEnableSearchFast.Name = "chkEnableSearchFast";
            this.chkEnableSearchFast.Properties.Caption = "Bật chế độ tìm kiếm nhanh";
            this.chkEnableSearchFast.Size = new System.Drawing.Size(252, 19);
            this.chkEnableSearchFast.TabIndex = 1;
            // 
            // navBarControl
            // 
            this.navBarControl.ActiveGroup = this.navBarGroup;
            this.navBarControl.Controls.Add(this.navBarGroupControlContainer);
            this.navBarControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.navBarControl.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroup});
            this.navBarControl.Location = new System.Drawing.Point(2, 2);
            this.navBarControl.Name = "navBarControl";
            this.navBarControl.OptionsNavPane.ExpandedWidth = 263;
            this.navBarControl.PaintStyleKind = DevExpress.XtraNavBar.NavBarViewKind.NavigationPane;
            this.navBarControl.Size = new System.Drawing.Size(263, 388);
            this.navBarControl.TabIndex = 1;
            this.navBarControl.Text = "navBarControl1";
            // 
            // txtContentSearch
            // 
            this.txtContentSearch.Location = new System.Drawing.Point(41, 46);
            this.txtContentSearch.Name = "txtContentSearch";
            this.txtContentSearch.Size = new System.Drawing.Size(263, 20);
            this.txtContentSearch.TabIndex = 0;
            this.txtContentSearch.TextChanged += new System.EventHandler(this.txtContentSearch_TextChanged);
            this.txtContentSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContentSearch_KeyPress);
            // 
            // grpSearchContent
            // 
            this.grpSearchContent.Controls.Add(this.btnSearch);
            this.grpSearchContent.Controls.Add(this.txtContentSearch);
            this.grpSearchContent.Controls.Add(this.labContentSearch);
            this.grpSearchContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpSearchContent.Location = new System.Drawing.Point(2, 2);
            this.grpSearchContent.Name = "grpSearchContent";
            this.grpSearchContent.Size = new System.Drawing.Size(1063, 77);
            this.grpSearchContent.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(340, 40);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 26);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // labContentSearch
            // 
            this.labContentSearch.Location = new System.Drawing.Point(12, 25);
            this.labContentSearch.Name = "labContentSearch";
            this.labContentSearch.Size = new System.Drawing.Size(69, 13);
            this.labContentSearch.TabIndex = 1;
            this.labContentSearch.Text = "Nhập nội dung";
            // 
            // panSearchContent
            // 
            this.panSearchContent.Controls.Add(this.grpSearchContent);
            this.panSearchContent.Dock = System.Windows.Forms.DockStyle.Top;
            this.panSearchContent.Location = new System.Drawing.Point(0, 40);
            this.panSearchContent.Name = "panSearchContent";
            this.panSearchContent.Size = new System.Drawing.Size(1067, 81);
            this.panSearchContent.TabIndex = 6;
            // 
            // panSearchTitles
            // 
            this.panSearchTitles.Controls.Add(this.labBookGenreTitle);
            this.panSearchTitles.Dock = System.Windows.Forms.DockStyle.Top;
            this.panSearchTitles.Location = new System.Drawing.Point(0, 0);
            this.panSearchTitles.Name = "panSearchTitles";
            this.panSearchTitles.Size = new System.Drawing.Size(1067, 40);
            this.panSearchTitles.TabIndex = 5;
            // 
            // labBookGenreTitle
            // 
            this.labBookGenreTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labBookGenreTitle.Appearance.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.labBookGenreTitle.Appearance.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.labBookGenreTitle.Location = new System.Drawing.Point(434, 1);
            this.labBookGenreTitle.Name = "labBookGenreTitle";
            this.labBookGenreTitle.Size = new System.Drawing.Size(281, 32);
            this.labBookGenreTitle.TabIndex = 2;
            this.labBookGenreTitle.Text = "TÌM KIẾM KHÁCH HÀNG";
            // 
            // panView
            // 
            this.panView.Controls.Add(this.grdListCustomer);
            this.panView.Controls.Add(this.navBarControl);
            this.panView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panView.Location = new System.Drawing.Point(0, 121);
            this.panView.Name = "panView";
            this.panView.Size = new System.Drawing.Size(1067, 392);
            this.panView.TabIndex = 7;
            // 
            // grdListCustomer
            // 
            this.grdListCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdListCustomer.Location = new System.Drawing.Point(265, 2);
            this.grdListCustomer.MainView = this.grdvListCustomer;
            this.grdListCustomer.Name = "grdListCustomer";
            this.grdListCustomer.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rdateCustomerBirthday});
            this.grdListCustomer.Size = new System.Drawing.Size(800, 388);
            this.grdListCustomer.TabIndex = 3;
            this.grdListCustomer.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdvListCustomer});
            // 
            // grdvListCustomer
            // 
            this.grdvListCustomer.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.CustomerSno,
            this.CustomerId,
            this.CustomeName,
            this.CustomerBirthday,
            this.CustomerGender,
            this.CustomerAddress,
            this.CustomerEmail,
            this.CustomerPhonNumber,
            this.CustomerDebit});
            this.grdvListCustomer.GridControl = this.grdListCustomer;
            this.grdvListCustomer.Name = "grdvListCustomer";
            this.grdvListCustomer.OptionsView.ShowGroupPanel = false;
            // 
            // CustomerSno
            // 
            this.CustomerSno.Caption = "STT";
            this.CustomerSno.FieldName = "STT";
            this.CustomerSno.Name = "CustomerSno";
            this.CustomerSno.OptionsColumn.ReadOnly = true;
            this.CustomerSno.Visible = true;
            this.CustomerSno.VisibleIndex = 0;
            this.CustomerSno.Width = 38;
            // 
            // CustomerId
            // 
            this.CustomerId.Caption = "Mã khách hàng";
            this.CustomerId.FieldName = "MaKH";
            this.CustomerId.Name = "CustomerId";
            this.CustomerId.OptionsColumn.ReadOnly = true;
            this.CustomerId.Visible = true;
            this.CustomerId.VisibleIndex = 1;
            this.CustomerId.Width = 58;
            // 
            // CustomeName
            // 
            this.CustomeName.Caption = "Tên khách hàng";
            this.CustomeName.FieldName = "TenKH";
            this.CustomeName.Name = "CustomeName";
            this.CustomeName.OptionsColumn.ReadOnly = true;
            this.CustomeName.Visible = true;
            this.CustomeName.VisibleIndex = 2;
            this.CustomeName.Width = 58;
            // 
            // CustomerBirthday
            // 
            this.CustomerBirthday.Caption = "Ngày sinh";
            this.CustomerBirthday.ColumnEdit = this.rdateCustomerBirthday;
            this.CustomerBirthday.FieldName = "NgaySinh";
            this.CustomerBirthday.Name = "CustomerBirthday";
            this.CustomerBirthday.OptionsColumn.ReadOnly = true;
            this.CustomerBirthday.Visible = true;
            this.CustomerBirthday.VisibleIndex = 3;
            this.CustomerBirthday.Width = 58;
            // 
            // rdateCustomerBirthday
            // 
            this.rdateCustomerBirthday.AutoHeight = false;
            this.rdateCustomerBirthday.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rdateCustomerBirthday.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rdateCustomerBirthday.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.rdateCustomerBirthday.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.rdateCustomerBirthday.EditFormat.FormatString = "dd/MM/yyyy";
            this.rdateCustomerBirthday.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.rdateCustomerBirthday.Mask.EditMask = "dd/MM/yyyy";
            this.rdateCustomerBirthday.Name = "rdateCustomerBirthday";
            // 
            // CustomerGender
            // 
            this.CustomerGender.Caption = "Giới tính";
            this.CustomerGender.FieldName = "GioiTinh";
            this.CustomerGender.Name = "CustomerGender";
            this.CustomerGender.OptionsColumn.ReadOnly = true;
            this.CustomerGender.Visible = true;
            this.CustomerGender.VisibleIndex = 4;
            this.CustomerGender.Width = 58;
            // 
            // CustomerAddress
            // 
            this.CustomerAddress.Caption = "Địa chỉ";
            this.CustomerAddress.FieldName = "DiaChi";
            this.CustomerAddress.Name = "CustomerAddress";
            this.CustomerAddress.OptionsColumn.ReadOnly = true;
            this.CustomerAddress.Visible = true;
            this.CustomerAddress.VisibleIndex = 5;
            this.CustomerAddress.Width = 58;
            // 
            // CustomerEmail
            // 
            this.CustomerEmail.Caption = "Email";
            this.CustomerEmail.FieldName = "Email";
            this.CustomerEmail.Name = "CustomerEmail";
            this.CustomerEmail.OptionsColumn.ReadOnly = true;
            this.CustomerEmail.Visible = true;
            this.CustomerEmail.VisibleIndex = 6;
            this.CustomerEmail.Width = 58;
            // 
            // CustomerPhonNumber
            // 
            this.CustomerPhonNumber.Caption = "Số điện thoại";
            this.CustomerPhonNumber.FieldName = "SoDienThoai";
            this.CustomerPhonNumber.Name = "CustomerPhonNumber";
            this.CustomerPhonNumber.OptionsColumn.ReadOnly = true;
            this.CustomerPhonNumber.Visible = true;
            this.CustomerPhonNumber.VisibleIndex = 7;
            this.CustomerPhonNumber.Width = 73;
            // 
            // CustomerDebit
            // 
            this.CustomerDebit.Caption = "Tiền nợ";
            this.CustomerDebit.FieldName = "TienNo";
            this.CustomerDebit.Name = "CustomerDebit";
            this.CustomerDebit.OptionsColumn.ReadOnly = true;
            this.CustomerDebit.Visible = true;
            this.CustomerDebit.VisibleIndex = 8;
            // 
            // frmCustomerSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 513);
            this.Controls.Add(this.panView);
            this.Controls.Add(this.panSearchContent);
            this.Controls.Add(this.panSearchTitles);
            this.Name = "frmCustomerSearch";
            this.Text = "Tìm kiếm khách hàng";
            this.Load += new System.EventHandler(this.frmCustomerSearch_Load);
            this.navBarGroupControlContainer.ResumeLayout(false);
            this.xtraScrollableControl1.ResumeLayout(false);
            this.xtraScrollableControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbGender.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.raGChose.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spDebits.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkEnableSearchFast.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl)).EndInit();
            this.navBarControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtContentSearch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpSearchContent)).EndInit();
            this.grpSearchContent.ResumeLayout(false);
            this.grpSearchContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panSearchContent)).EndInit();
            this.panSearchContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panSearchTitles)).EndInit();
            this.panSearchTitles.ResumeLayout(false);
            this.panSearchTitles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panView)).EndInit();
            this.panView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdListCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdvListCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdateCustomerBirthday.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdateCustomerBirthday)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraNavBar.NavBarGroup navBarGroup;
        private DevExpress.XtraNavBar.NavBarGroupControlContainer navBarGroupControlContainer;
        private DevExpress.XtraEditors.XtraScrollableControl xtraScrollableControl1;
        private DevExpress.XtraEditors.SpinEdit spDebits;
        private DevExpress.XtraEditors.LabelControl labDebits;
        private DevExpress.XtraEditors.CheckEdit chkEnableSearchFast;
        private DevExpress.XtraNavBar.NavBarControl navBarControl;
        private DevExpress.XtraEditors.TextEdit txtContentSearch;
        private DevExpress.XtraEditors.GroupControl grpSearchContent;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraEditors.LabelControl labContentSearch;
        private DevExpress.XtraEditors.PanelControl panSearchContent;
        private DevExpress.XtraEditors.PanelControl panSearchTitles;
        private DevExpress.XtraEditors.LabelControl labBookGenreTitle;
        private DevExpress.XtraEditors.PanelControl panView;
        private DevExpress.XtraEditors.ComboBoxEdit cmbGender;
        private DevExpress.XtraEditors.RadioGroup raGChose;
        private DevExpress.XtraEditors.LabelControl labGender;
        private DevExpress.XtraGrid.GridControl grdListCustomer;
        private DevExpress.XtraGrid.Views.Grid.GridView grdvListCustomer;
        private DevExpress.XtraGrid.Columns.GridColumn CustomerSno;
        private DevExpress.XtraGrid.Columns.GridColumn CustomerId;
        private DevExpress.XtraGrid.Columns.GridColumn CustomeName;
        private DevExpress.XtraGrid.Columns.GridColumn CustomerBirthday;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit rdateCustomerBirthday;
        private DevExpress.XtraGrid.Columns.GridColumn CustomerGender;
        private DevExpress.XtraGrid.Columns.GridColumn CustomerAddress;
        private DevExpress.XtraGrid.Columns.GridColumn CustomerEmail;
        private DevExpress.XtraGrid.Columns.GridColumn CustomerPhonNumber;
        private DevExpress.XtraGrid.Columns.GridColumn CustomerDebit;
    }
}