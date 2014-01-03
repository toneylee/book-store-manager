namespace Manager_Book_Store.Presentation_Layer
{
    partial class frmEmployeeSearch
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
            this.panSearchTitles = new DevExpress.XtraEditors.PanelControl();
            this.labBookGenreTitle = new DevExpress.XtraEditors.LabelControl();
            this.txtContentSearch = new DevExpress.XtraEditors.TextEdit();
            this.panView = new DevExpress.XtraEditors.PanelControl();
            this.grdListEmployee = new DevExpress.XtraGrid.GridControl();
            this.grdvListEmployee = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.EmployeeSno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EmployeeId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EmployeeName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EmployeeBirthday = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rdateEmployeeBirthday = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.EmployeeDateToWork = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EmployeeGender = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EmployeeAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EmployeeEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EmployeePhonNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EmployeeDebit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.navBarControl = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarGroup = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarGroupControlContainer = new DevExpress.XtraNavBar.NavBarGroupControlContainer();
            this.xtraScrollableControl1 = new DevExpress.XtraEditors.XtraScrollableControl();
            this.chkEnableChoseCharge = new DevExpress.XtraEditors.CheckEdit();
            this.lkCharge = new DevExpress.XtraEditors.LookUpEdit();
            this.cmbGender = new DevExpress.XtraEditors.ComboBoxEdit();
            this.raGChose = new DevExpress.XtraEditors.RadioGroup();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labGender = new DevExpress.XtraEditors.LabelControl();
            this.chkEnableSearchFast = new DevExpress.XtraEditors.CheckEdit();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.panSearchContent = new DevExpress.XtraEditors.PanelControl();
            this.grpSearchContent = new DevExpress.XtraEditors.GroupControl();
            this.labContentSearch = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panSearchTitles)).BeginInit();
            this.panSearchTitles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtContentSearch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panView)).BeginInit();
            this.panView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdListEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdvListEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdateEmployeeBirthday)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdateEmployeeBirthday.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl)).BeginInit();
            this.navBarControl.SuspendLayout();
            this.navBarGroupControlContainer.SuspendLayout();
            this.xtraScrollableControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkEnableChoseCharge.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkCharge.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbGender.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.raGChose.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkEnableSearchFast.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panSearchContent)).BeginInit();
            this.panSearchContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpSearchContent)).BeginInit();
            this.grpSearchContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // panSearchTitles
            // 
            this.panSearchTitles.Controls.Add(this.labBookGenreTitle);
            this.panSearchTitles.Dock = System.Windows.Forms.DockStyle.Top;
            this.panSearchTitles.Location = new System.Drawing.Point(0, 0);
            this.panSearchTitles.Name = "panSearchTitles";
            this.panSearchTitles.Size = new System.Drawing.Size(910, 40);
            this.panSearchTitles.TabIndex = 8;
            // 
            // labBookGenreTitle
            // 
            this.labBookGenreTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labBookGenreTitle.Appearance.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.labBookGenreTitle.Appearance.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.labBookGenreTitle.Location = new System.Drawing.Point(356, 1);
            this.labBookGenreTitle.Name = "labBookGenreTitle";
            this.labBookGenreTitle.Size = new System.Drawing.Size(255, 32);
            this.labBookGenreTitle.TabIndex = 2;
            this.labBookGenreTitle.Text = "TÌM KIẾM NHÂN VIÊN";
            // 
            // txtContentSearch
            // 
            this.txtContentSearch.Location = new System.Drawing.Point(41, 46);
            this.txtContentSearch.Name = "txtContentSearch";
            this.txtContentSearch.Size = new System.Drawing.Size(263, 20);
            this.txtContentSearch.TabIndex = 0;
            this.txtContentSearch.TextChanged += new System.EventHandler(this.txtContentSearch_TextChanged);
            // 
            // panView
            // 
            this.panView.Controls.Add(this.grdListEmployee);
            this.panView.Controls.Add(this.navBarControl);
            this.panView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panView.Location = new System.Drawing.Point(0, 121);
            this.panView.Name = "panView";
            this.panView.Size = new System.Drawing.Size(910, 405);
            this.panView.TabIndex = 10;
            // 
            // grdListEmployee
            // 
            this.grdListEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdListEmployee.Location = new System.Drawing.Point(265, 2);
            this.grdListEmployee.MainView = this.grdvListEmployee;
            this.grdListEmployee.Name = "grdListEmployee";
            this.grdListEmployee.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rdateEmployeeBirthday});
            this.grdListEmployee.Size = new System.Drawing.Size(643, 401);
            this.grdListEmployee.TabIndex = 3;
            this.grdListEmployee.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdvListEmployee});
            // 
            // grdvListEmployee
            // 
            this.grdvListEmployee.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.EmployeeSno,
            this.EmployeeId,
            this.EmployeeName,
            this.EmployeeBirthday,
            this.EmployeeDateToWork,
            this.EmployeeGender,
            this.EmployeeAddress,
            this.EmployeeEmail,
            this.EmployeePhonNumber,
            this.EmployeeDebit});
            this.grdvListEmployee.GridControl = this.grdListEmployee;
            this.grdvListEmployee.Name = "grdvListEmployee";
            this.grdvListEmployee.OptionsView.ShowGroupPanel = false;
            // 
            // EmployeeSno
            // 
            this.EmployeeSno.Caption = "STT";
            this.EmployeeSno.FieldName = "STT";
            this.EmployeeSno.Name = "EmployeeSno";
            this.EmployeeSno.OptionsColumn.ReadOnly = true;
            this.EmployeeSno.Visible = true;
            this.EmployeeSno.VisibleIndex = 0;
            this.EmployeeSno.Width = 38;
            // 
            // EmployeeId
            // 
            this.EmployeeId.Caption = "Mã nhân viên";
            this.EmployeeId.FieldName = "MaNV";
            this.EmployeeId.Name = "EmployeeId";
            this.EmployeeId.OptionsColumn.ReadOnly = true;
            this.EmployeeId.Visible = true;
            this.EmployeeId.VisibleIndex = 1;
            this.EmployeeId.Width = 58;
            // 
            // EmployeeName
            // 
            this.EmployeeName.Caption = "Tên nhân viên";
            this.EmployeeName.FieldName = "TenNV";
            this.EmployeeName.Name = "EmployeeName";
            this.EmployeeName.OptionsColumn.ReadOnly = true;
            this.EmployeeName.Visible = true;
            this.EmployeeName.VisibleIndex = 2;
            this.EmployeeName.Width = 58;
            // 
            // EmployeeBirthday
            // 
            this.EmployeeBirthday.Caption = "Ngày sinh";
            this.EmployeeBirthday.ColumnEdit = this.rdateEmployeeBirthday;
            this.EmployeeBirthday.FieldName = "NgaySinh";
            this.EmployeeBirthday.Name = "EmployeeBirthday";
            this.EmployeeBirthday.OptionsColumn.ReadOnly = true;
            this.EmployeeBirthday.Visible = true;
            this.EmployeeBirthday.VisibleIndex = 3;
            this.EmployeeBirthday.Width = 58;
            // 
            // rdateEmployeeBirthday
            // 
            this.rdateEmployeeBirthday.AutoHeight = false;
            this.rdateEmployeeBirthday.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rdateEmployeeBirthday.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rdateEmployeeBirthday.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.rdateEmployeeBirthday.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.rdateEmployeeBirthday.EditFormat.FormatString = "dd/MM/yyyy";
            this.rdateEmployeeBirthday.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.rdateEmployeeBirthday.Mask.EditMask = "dd/MM/yyyy";
            this.rdateEmployeeBirthday.Name = "rdateEmployeeBirthday";
            // 
            // EmployeeDateToWork
            // 
            this.EmployeeDateToWork.Caption = "Ngày vào làm";
            this.EmployeeDateToWork.FieldName = "NgayVaoLam";
            this.EmployeeDateToWork.Name = "EmployeeDateToWork";
            this.EmployeeDateToWork.Visible = true;
            this.EmployeeDateToWork.VisibleIndex = 9;
            // 
            // EmployeeGender
            // 
            this.EmployeeGender.Caption = "Giới tính";
            this.EmployeeGender.FieldName = "GioiTinh";
            this.EmployeeGender.Name = "EmployeeGender";
            this.EmployeeGender.OptionsColumn.ReadOnly = true;
            this.EmployeeGender.Visible = true;
            this.EmployeeGender.VisibleIndex = 4;
            this.EmployeeGender.Width = 58;
            // 
            // EmployeeAddress
            // 
            this.EmployeeAddress.Caption = "Địa chỉ";
            this.EmployeeAddress.FieldName = "DiaChi";
            this.EmployeeAddress.Name = "EmployeeAddress";
            this.EmployeeAddress.OptionsColumn.ReadOnly = true;
            this.EmployeeAddress.Visible = true;
            this.EmployeeAddress.VisibleIndex = 5;
            this.EmployeeAddress.Width = 58;
            // 
            // EmployeeEmail
            // 
            this.EmployeeEmail.Caption = "Email";
            this.EmployeeEmail.FieldName = "Email";
            this.EmployeeEmail.Name = "EmployeeEmail";
            this.EmployeeEmail.OptionsColumn.ReadOnly = true;
            this.EmployeeEmail.Visible = true;
            this.EmployeeEmail.VisibleIndex = 6;
            this.EmployeeEmail.Width = 58;
            // 
            // EmployeePhonNumber
            // 
            this.EmployeePhonNumber.Caption = "Số điện thoại";
            this.EmployeePhonNumber.FieldName = "DienThoai";
            this.EmployeePhonNumber.Name = "EmployeePhonNumber";
            this.EmployeePhonNumber.OptionsColumn.ReadOnly = true;
            this.EmployeePhonNumber.Visible = true;
            this.EmployeePhonNumber.VisibleIndex = 7;
            this.EmployeePhonNumber.Width = 73;
            // 
            // EmployeeDebit
            // 
            this.EmployeeDebit.Caption = "Chức vụ";
            this.EmployeeDebit.FieldName = "TenCV";
            this.EmployeeDebit.Name = "EmployeeDebit";
            this.EmployeeDebit.OptionsColumn.ReadOnly = true;
            this.EmployeeDebit.Visible = true;
            this.EmployeeDebit.VisibleIndex = 8;
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
            this.navBarControl.Size = new System.Drawing.Size(263, 401);
            this.navBarControl.TabIndex = 1;
            this.navBarControl.Text = "navBarControl1";
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
            this.navBarGroupControlContainer.Size = new System.Drawing.Size(263, 298);
            this.navBarGroupControlContainer.TabIndex = 0;
            // 
            // xtraScrollableControl1
            // 
            this.xtraScrollableControl1.Controls.Add(this.chkEnableChoseCharge);
            this.xtraScrollableControl1.Controls.Add(this.lkCharge);
            this.xtraScrollableControl1.Controls.Add(this.cmbGender);
            this.xtraScrollableControl1.Controls.Add(this.raGChose);
            this.xtraScrollableControl1.Controls.Add(this.labelControl1);
            this.xtraScrollableControl1.Controls.Add(this.labGender);
            this.xtraScrollableControl1.Controls.Add(this.chkEnableSearchFast);
            this.xtraScrollableControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraScrollableControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraScrollableControl1.Name = "xtraScrollableControl1";
            this.xtraScrollableControl1.Size = new System.Drawing.Size(263, 298);
            this.xtraScrollableControl1.TabIndex = 0;
            // 
            // chkEnableChoseCharge
            // 
            this.chkEnableChoseCharge.EditValue = true;
            this.chkEnableChoseCharge.Location = new System.Drawing.Point(4, 29);
            this.chkEnableChoseCharge.Name = "chkEnableChoseCharge";
            this.chkEnableChoseCharge.Properties.Caption = "checkEdit1";
            this.chkEnableChoseCharge.Size = new System.Drawing.Size(20, 19);
            this.chkEnableChoseCharge.TabIndex = 5;
            this.chkEnableChoseCharge.CheckedChanged += new System.EventHandler(this.chkEnableChoseCharge_CheckedChanged);
            // 
            // lkCharge
            // 
            this.lkCharge.Location = new System.Drawing.Point(30, 30);
            this.lkCharge.Name = "lkCharge";
            this.lkCharge.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkCharge.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("STT", "STT"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenCV", "Chức vụ")});
            this.lkCharge.Properties.NullText = "";
            this.lkCharge.Size = new System.Drawing.Size(182, 20);
            this.lkCharge.TabIndex = 4;
            this.lkCharge.TextChanged += new System.EventHandler(this.lkCharge_TextChanged);
            // 
            // cmbGender
            // 
            this.cmbGender.Location = new System.Drawing.Point(30, 91);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbGender.Properties.Items.AddRange(new object[] {
            "Tất cả",
            "Nam",
            "Nữ"});
            this.cmbGender.Size = new System.Drawing.Size(182, 20);
            this.cmbGender.TabIndex = 3;
            this.cmbGender.TextChanged += new System.EventHandler(this.cmbGender_TextChanged);
            // 
            // raGChose
            // 
            this.raGChose.Location = new System.Drawing.Point(-2, 127);
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
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(33, 7);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(40, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Chức vụ";
            // 
            // labGender
            // 
            this.labGender.Location = new System.Drawing.Point(33, 67);
            this.labGender.Name = "labGender";
            this.labGender.Size = new System.Drawing.Size(38, 13);
            this.labGender.TabIndex = 0;
            this.labGender.Text = "Giới tính";
            // 
            // chkEnableSearchFast
            // 
            this.chkEnableSearchFast.Location = new System.Drawing.Point(8, 298);
            this.chkEnableSearchFast.Name = "chkEnableSearchFast";
            this.chkEnableSearchFast.Properties.Caption = "Bật chế độ tìm kiếm nhanh";
            this.chkEnableSearchFast.Size = new System.Drawing.Size(252, 19);
            this.chkEnableSearchFast.TabIndex = 1;
            this.chkEnableSearchFast.CheckedChanged += new System.EventHandler(this.chkEnableSearchFast_CheckedChanged);
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
            // panSearchContent
            // 
            this.panSearchContent.Controls.Add(this.grpSearchContent);
            this.panSearchContent.Dock = System.Windows.Forms.DockStyle.Top;
            this.panSearchContent.Location = new System.Drawing.Point(0, 40);
            this.panSearchContent.Name = "panSearchContent";
            this.panSearchContent.Size = new System.Drawing.Size(910, 81);
            this.panSearchContent.TabIndex = 9;
            // 
            // grpSearchContent
            // 
            this.grpSearchContent.Controls.Add(this.btnSearch);
            this.grpSearchContent.Controls.Add(this.txtContentSearch);
            this.grpSearchContent.Controls.Add(this.labContentSearch);
            this.grpSearchContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpSearchContent.Location = new System.Drawing.Point(2, 2);
            this.grpSearchContent.Name = "grpSearchContent";
            this.grpSearchContent.Size = new System.Drawing.Size(906, 77);
            this.grpSearchContent.TabIndex = 3;
            // 
            // labContentSearch
            // 
            this.labContentSearch.Location = new System.Drawing.Point(12, 25);
            this.labContentSearch.Name = "labContentSearch";
            this.labContentSearch.Size = new System.Drawing.Size(69, 13);
            this.labContentSearch.TabIndex = 1;
            this.labContentSearch.Text = "Nhập nội dung";
            // 
            // frmEmployeeSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 526);
            this.Controls.Add(this.panView);
            this.Controls.Add(this.panSearchContent);
            this.Controls.Add(this.panSearchTitles);
            this.Name = "frmEmployeeSearch";
            this.Text = "Tìm kiếm nhân viên";
            this.Load += new System.EventHandler(this.frmEmployeeSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panSearchTitles)).EndInit();
            this.panSearchTitles.ResumeLayout(false);
            this.panSearchTitles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtContentSearch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panView)).EndInit();
            this.panView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdListEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdvListEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdateEmployeeBirthday.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdateEmployeeBirthday)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl)).EndInit();
            this.navBarControl.ResumeLayout(false);
            this.navBarGroupControlContainer.ResumeLayout(false);
            this.xtraScrollableControl1.ResumeLayout(false);
            this.xtraScrollableControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkEnableChoseCharge.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkCharge.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbGender.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.raGChose.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkEnableSearchFast.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panSearchContent)).EndInit();
            this.panSearchContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpSearchContent)).EndInit();
            this.grpSearchContent.ResumeLayout(false);
            this.grpSearchContent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panSearchTitles;
        private DevExpress.XtraEditors.LabelControl labBookGenreTitle;
        private DevExpress.XtraEditors.TextEdit txtContentSearch;
        private DevExpress.XtraEditors.PanelControl panView;
        private DevExpress.XtraNavBar.NavBarControl navBarControl;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup;
        private DevExpress.XtraNavBar.NavBarGroupControlContainer navBarGroupControlContainer;
        private DevExpress.XtraEditors.XtraScrollableControl xtraScrollableControl1;
        private DevExpress.XtraEditors.ComboBoxEdit cmbGender;
        private DevExpress.XtraEditors.RadioGroup raGChose;
        private DevExpress.XtraEditors.LabelControl labGender;
        private DevExpress.XtraEditors.CheckEdit chkEnableSearchFast;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraEditors.PanelControl panSearchContent;
        private DevExpress.XtraEditors.GroupControl grpSearchContent;
        private DevExpress.XtraEditors.LabelControl labContentSearch;
        private DevExpress.XtraGrid.GridControl grdListEmployee;
        private DevExpress.XtraGrid.Views.Grid.GridView grdvListEmployee;
        private DevExpress.XtraGrid.Columns.GridColumn EmployeeSno;
        private DevExpress.XtraGrid.Columns.GridColumn EmployeeId;
        private DevExpress.XtraGrid.Columns.GridColumn EmployeeName;
        private DevExpress.XtraGrid.Columns.GridColumn EmployeeBirthday;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit rdateEmployeeBirthday;
        private DevExpress.XtraGrid.Columns.GridColumn EmployeeDateToWork;
        private DevExpress.XtraGrid.Columns.GridColumn EmployeeGender;
        private DevExpress.XtraGrid.Columns.GridColumn EmployeeAddress;
        private DevExpress.XtraGrid.Columns.GridColumn EmployeeEmail;
        private DevExpress.XtraGrid.Columns.GridColumn EmployeePhonNumber;
        private DevExpress.XtraGrid.Columns.GridColumn EmployeeDebit;
        private DevExpress.XtraEditors.LookUpEdit lkCharge;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.CheckEdit chkEnableChoseCharge;
    }
}