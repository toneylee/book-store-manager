namespace Manager_Book_Store.Presentation_Layer
{
    partial class frmBookTitle
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
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.AuthorID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.AuthorNames = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdListBookTitles = new DevExpress.XtraGrid.GridControl();
            this.grdvListBookTitles = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.BookTiltesSno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BookTitlesId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rtxtBookTitlesId = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.BookTitlesName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rtxtBookTitlesName = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.AuthorName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rtxtAuthorName = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.BookGenreName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rtxtBookGenreName = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repositoryItemCheckedComboBoxEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckedComboBoxEdit();
            this.labBookTitles = new DevExpress.XtraEditors.LabelControl();
            this.panelBooTitlesT = new DevExpress.XtraEditors.PanelControl();
            this.panelBookTitlesExecute = new DevExpress.XtraEditors.PanelControl();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancelOfUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.panelDataDetails = new DevExpress.XtraEditors.PanelControl();
            this.panelBookTitleView = new DevExpress.XtraEditors.PanelControl();
            this.panelBookTitlesDetail = new DevExpress.XtraEditors.PanelControl();
            this.btnAddAuthor = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddBookGenre = new DevExpress.XtraEditors.SimpleButton();
            this.lkBookGenreName = new DevExpress.XtraEditors.LookUpEdit();
            this.chkCmbAuthorName = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            this.labAuthorName = new DevExpress.XtraEditors.LabelControl();
            this.labBookGenreName = new DevExpress.XtraEditors.LabelControl();
            this.labBookTitleId = new DevExpress.XtraEditors.LabelControl();
            this.labBookTitlesName = new DevExpress.XtraEditors.LabelControl();
            this.txtBookTitlesId = new DevExpress.XtraEditors.TextEdit();
            this.txtBookTitlesName = new DevExpress.XtraEditors.TextEdit();
            this.navBarBookTitlesLookAt = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarGBookTitlesLookAt = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarGroupControlContainer1 = new DevExpress.XtraNavBar.NavBarGroupControlContainer();
            this.labBooktitlesNameLA = new DevExpress.XtraEditors.LabelControl();
            this.txtBootitlesNameLA = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdListBookTitles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdvListBookTitles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rtxtBookTitlesId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rtxtBookTitlesName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rtxtAuthorName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rtxtBookGenreName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckedComboBoxEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelBooTitlesT)).BeginInit();
            this.panelBooTitlesT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelBookTitlesExecute)).BeginInit();
            this.panelBookTitlesExecute.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelDataDetails)).BeginInit();
            this.panelDataDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelBookTitleView)).BeginInit();
            this.panelBookTitleView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelBookTitlesDetail)).BeginInit();
            this.panelBookTitlesDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkBookGenreName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkCmbAuthorName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBookTitlesId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBookTitlesName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarBookTitlesLookAt)).BeginInit();
            this.navBarBookTitlesLookAt.SuspendLayout();
            this.navBarGroupControlContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBootitlesNameLA.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.AuthorID,
            this.AuthorNames});
            this.gridView1.GridControl = this.grdListBookTitles;
            this.gridView1.Name = "gridView1";
            // 
            // AuthorID
            // 
            this.AuthorID.Caption = "Mã tác giả";
            this.AuthorID.FieldName = "MaTG";
            this.AuthorID.Name = "AuthorID";
            this.AuthorID.Visible = true;
            this.AuthorID.VisibleIndex = 0;
            // 
            // AuthorNames
            // 
            this.AuthorNames.Caption = "Tên tác giả";
            this.AuthorNames.FieldName = "TenTG";
            this.AuthorNames.Name = "AuthorNames";
            this.AuthorNames.Visible = true;
            this.AuthorNames.VisibleIndex = 1;
            // 
            // grdListBookTitles
            // 
            this.grdListBookTitles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdListBookTitles.Location = new System.Drawing.Point(2, 102);
            this.grdListBookTitles.MainView = this.grdvListBookTitles;
            this.grdListBookTitles.Name = "grdListBookTitles";
            this.grdListBookTitles.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rtxtBookTitlesName,
            this.rtxtBookTitlesId,
            this.repositoryItemCheckedComboBoxEdit1,
            this.rtxtAuthorName,
            this.rtxtBookGenreName});
            this.grdListBookTitles.Size = new System.Drawing.Size(675, 261);
            this.grdListBookTitles.TabIndex = 8;
            this.grdListBookTitles.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdvListBookTitles,
            this.gridView1});
            // 
            // grdvListBookTitles
            // 
            this.grdvListBookTitles.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.BookTiltesSno,
            this.BookTitlesId,
            this.BookTitlesName,
            this.AuthorName,
            this.BookGenreName});
            this.grdvListBookTitles.GridControl = this.grdListBookTitles;
            this.grdvListBookTitles.Name = "grdvListBookTitles";
            this.grdvListBookTitles.OptionsPrint.PrintDetails = true;
            this.grdvListBookTitles.OptionsPrint.PrintFilterInfo = true;
            this.grdvListBookTitles.OptionsPrint.PrintSelectedRowsOnly = true;
            this.grdvListBookTitles.OptionsView.ShowGroupPanel = false;
            this.grdvListBookTitles.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.grdvListBookTitles_FocusedRowChanged);
            // 
            // BookTiltesSno
            // 
            this.BookTiltesSno.Caption = "STT";
            this.BookTiltesSno.FieldName = "STT";
            this.BookTiltesSno.Name = "BookTiltesSno";
            this.BookTiltesSno.Visible = true;
            this.BookTiltesSno.VisibleIndex = 0;
            this.BookTiltesSno.Width = 36;
            // 
            // BookTitlesId
            // 
            this.BookTitlesId.Caption = "Mã đầu sách";
            this.BookTitlesId.ColumnEdit = this.rtxtBookTitlesId;
            this.BookTitlesId.FieldName = "MaDauSach";
            this.BookTitlesId.Name = "BookTitlesId";
            this.BookTitlesId.Visible = true;
            this.BookTitlesId.VisibleIndex = 1;
            this.BookTitlesId.Width = 254;
            // 
            // rtxtBookTitlesId
            // 
            this.rtxtBookTitlesId.AutoHeight = false;
            this.rtxtBookTitlesId.Name = "rtxtBookTitlesId";
            this.rtxtBookTitlesId.ReadOnly = true;
            // 
            // BookTitlesName
            // 
            this.BookTitlesName.Caption = "Tên đầu sách";
            this.BookTitlesName.ColumnEdit = this.rtxtBookTitlesName;
            this.BookTitlesName.FieldName = "TenSach";
            this.BookTitlesName.Name = "BookTitlesName";
            this.BookTitlesName.Visible = true;
            this.BookTitlesName.VisibleIndex = 2;
            this.BookTitlesName.Width = 254;
            // 
            // rtxtBookTitlesName
            // 
            this.rtxtBookTitlesName.AutoHeight = false;
            this.rtxtBookTitlesName.Name = "rtxtBookTitlesName";
            this.rtxtBookTitlesName.ReadOnly = true;
            // 
            // AuthorName
            // 
            this.AuthorName.Caption = "Tác giả";
            this.AuthorName.ColumnEdit = this.rtxtAuthorName;
            this.AuthorName.FieldName = "NhomTG";
            this.AuthorName.Name = "AuthorName";
            this.AuthorName.Visible = true;
            this.AuthorName.VisibleIndex = 3;
            this.AuthorName.Width = 254;
            // 
            // rtxtAuthorName
            // 
            this.rtxtAuthorName.AutoHeight = false;
            this.rtxtAuthorName.Name = "rtxtAuthorName";
            this.rtxtAuthorName.ReadOnly = true;
            // 
            // BookGenreName
            // 
            this.BookGenreName.Caption = "Thể loại";
            this.BookGenreName.ColumnEdit = this.rtxtBookGenreName;
            this.BookGenreName.FieldName = "TenTL";
            this.BookGenreName.Name = "BookGenreName";
            this.BookGenreName.Visible = true;
            this.BookGenreName.VisibleIndex = 4;
            this.BookGenreName.Width = 258;
            // 
            // rtxtBookGenreName
            // 
            this.rtxtBookGenreName.AutoHeight = false;
            this.rtxtBookGenreName.Name = "rtxtBookGenreName";
            this.rtxtBookGenreName.ReadOnly = true;
            // 
            // repositoryItemCheckedComboBoxEdit1
            // 
            this.repositoryItemCheckedComboBoxEdit1.AutoHeight = false;
            this.repositoryItemCheckedComboBoxEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemCheckedComboBoxEdit1.Items.AddRange(new DevExpress.XtraEditors.Controls.CheckedListBoxItem[] {
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(null, "Lê Đức Sang"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(null, "Trần Thị Thanh Trang"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(null, "Lê Đức Sang"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(null, "Trần Thị Thanh Trang"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(null, "Lê Đức Sang")});
            this.repositoryItemCheckedComboBoxEdit1.Name = "repositoryItemCheckedComboBoxEdit1";
            // 
            // labBookTitles
            // 
            this.labBookTitles.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labBookTitles.Appearance.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.labBookTitles.Appearance.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.labBookTitles.Location = new System.Drawing.Point(312, 6);
            this.labBookTitles.Name = "labBookTitles";
            this.labBookTitles.Size = new System.Drawing.Size(271, 32);
            this.labBookTitles.TabIndex = 0;
            this.labBookTitles.Text = "DANH SÁCH ĐẦU SÁCH";
            // 
            // panelBooTitlesT
            // 
            this.panelBooTitlesT.Controls.Add(this.labBookTitles);
            this.panelBooTitlesT.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBooTitlesT.Location = new System.Drawing.Point(0, 0);
            this.panelBooTitlesT.Name = "panelBooTitlesT";
            this.panelBooTitlesT.Size = new System.Drawing.Size(933, 39);
            this.panelBooTitlesT.TabIndex = 7;
            // 
            // panelBookTitlesExecute
            // 
            this.panelBookTitlesExecute.Controls.Add(this.btnAdd);
            this.panelBookTitlesExecute.Controls.Add(this.btnCancelOfUpdate);
            this.panelBookTitlesExecute.Controls.Add(this.btnSave);
            this.panelBookTitlesExecute.Controls.Add(this.btnDelete);
            this.panelBookTitlesExecute.Controls.Add(this.btnUpdate);
            this.panelBookTitlesExecute.Controls.Add(this.btnCancel);
            this.panelBookTitlesExecute.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBookTitlesExecute.Location = new System.Drawing.Point(0, 408);
            this.panelBookTitlesExecute.Name = "panelBookTitlesExecute";
            this.panelBookTitlesExecute.Size = new System.Drawing.Size(933, 53);
            this.panelBookTitlesExecute.TabIndex = 8;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(244, 6);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(89, 37);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Thêm mới";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancelOfUpdate
            // 
            this.btnCancelOfUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelOfUpdate.Location = new System.Drawing.Point(364, 5);
            this.btnCancelOfUpdate.Name = "btnCancelOfUpdate";
            this.btnCancelOfUpdate.Size = new System.Drawing.Size(93, 37);
            this.btnCancelOfUpdate.TabIndex = 6;
            this.btnCancelOfUpdate.Text = "Hủy thao tác";
            this.btnCancelOfUpdate.Visible = false;
            this.btnCancelOfUpdate.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(596, 7);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(83, 36);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Lưu xuống";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Location = new System.Drawing.Point(483, 6);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(86, 36);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Xóa bỏ";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.Location = new System.Drawing.Point(364, 5);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(93, 37);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(244, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(89, 37);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Hủy thao tác";
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // panelDataDetails
            // 
            this.panelDataDetails.Controls.Add(this.panelBookTitleView);
            this.panelDataDetails.Controls.Add(this.navBarBookTitlesLookAt);
            this.panelDataDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDataDetails.Location = new System.Drawing.Point(0, 39);
            this.panelDataDetails.Name = "panelDataDetails";
            this.panelDataDetails.Size = new System.Drawing.Size(933, 369);
            this.panelDataDetails.TabIndex = 9;
            // 
            // panelBookTitleView
            // 
            this.panelBookTitleView.Controls.Add(this.grdListBookTitles);
            this.panelBookTitleView.Controls.Add(this.panelBookTitlesDetail);
            this.panelBookTitleView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBookTitleView.Location = new System.Drawing.Point(2, 2);
            this.panelBookTitleView.Name = "panelBookTitleView";
            this.panelBookTitleView.Size = new System.Drawing.Size(679, 365);
            this.panelBookTitleView.TabIndex = 1;
            // 
            // panelBookTitlesDetail
            // 
            this.panelBookTitlesDetail.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelBookTitlesDetail.Controls.Add(this.btnAddAuthor);
            this.panelBookTitlesDetail.Controls.Add(this.btnAddBookGenre);
            this.panelBookTitlesDetail.Controls.Add(this.lkBookGenreName);
            this.panelBookTitlesDetail.Controls.Add(this.chkCmbAuthorName);
            this.panelBookTitlesDetail.Controls.Add(this.labAuthorName);
            this.panelBookTitlesDetail.Controls.Add(this.labBookGenreName);
            this.panelBookTitlesDetail.Controls.Add(this.labBookTitleId);
            this.panelBookTitlesDetail.Controls.Add(this.labBookTitlesName);
            this.panelBookTitlesDetail.Controls.Add(this.txtBookTitlesId);
            this.panelBookTitlesDetail.Controls.Add(this.txtBookTitlesName);
            this.panelBookTitlesDetail.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBookTitlesDetail.Location = new System.Drawing.Point(2, 2);
            this.panelBookTitlesDetail.Name = "panelBookTitlesDetail";
            this.panelBookTitlesDetail.Size = new System.Drawing.Size(675, 100);
            this.panelBookTitlesDetail.TabIndex = 7;
            // 
            // btnAddAuthor
            // 
            this.btnAddAuthor.Location = new System.Drawing.Point(586, 66);
            this.btnAddAuthor.Name = "btnAddAuthor";
            this.btnAddAuthor.Size = new System.Drawing.Size(75, 23);
            this.btnAddAuthor.TabIndex = 9;
            this.btnAddAuthor.Text = "Thêm mới";
            this.btnAddAuthor.Click += new System.EventHandler(this.btnAddAuthor_Click);
            // 
            // btnAddBookGenre
            // 
            this.btnAddBookGenre.Location = new System.Drawing.Point(586, 3);
            this.btnAddBookGenre.Name = "btnAddBookGenre";
            this.btnAddBookGenre.Size = new System.Drawing.Size(75, 23);
            this.btnAddBookGenre.TabIndex = 9;
            this.btnAddBookGenre.Text = "Thêm mới";
            this.btnAddBookGenre.Click += new System.EventHandler(this.btnAddBookGenre_Click);
            // 
            // lkBookGenreName
            // 
            this.lkBookGenreName.Location = new System.Drawing.Point(360, 6);
            this.lkBookGenreName.Name = "lkBookGenreName";
            this.lkBookGenreName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkBookGenreName.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenTL", "Thể loại")});
            this.lkBookGenreName.Properties.NullText = "";
            this.lkBookGenreName.Properties.ReadOnly = true;
            this.lkBookGenreName.Size = new System.Drawing.Size(197, 20);
            this.lkBookGenreName.TabIndex = 8;
            // 
            // chkCmbAuthorName
            // 
            this.chkCmbAuthorName.EditValue = "";
            this.chkCmbAuthorName.Location = new System.Drawing.Point(121, 69);
            this.chkCmbAuthorName.Name = "chkCmbAuthorName";
            this.chkCmbAuthorName.Properties.AllowMultiSelect = true;
            this.chkCmbAuthorName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.chkCmbAuthorName.Properties.ReadOnly = true;
            this.chkCmbAuthorName.Size = new System.Drawing.Size(436, 20);
            this.chkCmbAuthorName.TabIndex = 7;
            this.chkCmbAuthorName.EditValueChanged += new System.EventHandler(this.chkCmbAuthorName_EditValueChanged);
            this.chkCmbAuthorName.TextChanged += new System.EventHandler(this.chkCmbAuthorName_TextChanged);
            // 
            // labAuthorName
            // 
            this.labAuthorName.Location = new System.Drawing.Point(24, 70);
            this.labAuthorName.Name = "labAuthorName";
            this.labAuthorName.Size = new System.Drawing.Size(38, 13);
            this.labAuthorName.TabIndex = 4;
            this.labAuthorName.Text = "Tác giả:";
            // 
            // labBookGenreName
            // 
            this.labBookGenreName.Location = new System.Drawing.Point(294, 9);
            this.labBookGenreName.Name = "labBookGenreName";
            this.labBookGenreName.Size = new System.Drawing.Size(41, 13);
            this.labBookGenreName.TabIndex = 2;
            this.labBookGenreName.Text = "Thể loại:";
            // 
            // labBookTitleId
            // 
            this.labBookTitleId.Location = new System.Drawing.Point(24, 9);
            this.labBookTitleId.Name = "labBookTitleId";
            this.labBookTitleId.Size = new System.Drawing.Size(64, 13);
            this.labBookTitleId.TabIndex = 4;
            this.labBookTitleId.Text = "Mã đầu sách:";
            // 
            // labBookTitlesName
            // 
            this.labBookTitlesName.Location = new System.Drawing.Point(24, 40);
            this.labBookTitlesName.Name = "labBookTitlesName";
            this.labBookTitlesName.Size = new System.Drawing.Size(68, 13);
            this.labBookTitlesName.TabIndex = 2;
            this.labBookTitlesName.Text = "Tên đầu sách:";
            // 
            // txtBookTitlesId
            // 
            this.txtBookTitlesId.Location = new System.Drawing.Point(120, 6);
            this.txtBookTitlesId.Name = "txtBookTitlesId";
            this.txtBookTitlesId.Properties.ReadOnly = true;
            this.txtBookTitlesId.Size = new System.Drawing.Size(148, 20);
            this.txtBookTitlesId.TabIndex = 5;
            // 
            // txtBookTitlesName
            // 
            this.txtBookTitlesName.Location = new System.Drawing.Point(121, 37);
            this.txtBookTitlesName.Name = "txtBookTitlesName";
            this.txtBookTitlesName.Properties.ReadOnly = true;
            this.txtBookTitlesName.Size = new System.Drawing.Size(436, 20);
            this.txtBookTitlesName.TabIndex = 3;
            // 
            // navBarBookTitlesLookAt
            // 
            this.navBarBookTitlesLookAt.ActiveGroup = this.navBarGBookTitlesLookAt;
            this.navBarBookTitlesLookAt.Controls.Add(this.navBarGroupControlContainer1);
            this.navBarBookTitlesLookAt.Dock = System.Windows.Forms.DockStyle.Right;
            this.navBarBookTitlesLookAt.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGBookTitlesLookAt});
            this.navBarBookTitlesLookAt.Location = new System.Drawing.Point(681, 2);
            this.navBarBookTitlesLookAt.Name = "navBarBookTitlesLookAt";
            this.navBarBookTitlesLookAt.OptionsNavPane.ExpandedWidth = 250;
            this.navBarBookTitlesLookAt.PaintStyleKind = DevExpress.XtraNavBar.NavBarViewKind.NavigationPane;
            this.navBarBookTitlesLookAt.Size = new System.Drawing.Size(250, 365);
            this.navBarBookTitlesLookAt.StoreDefaultPaintStyleName = true;
            this.navBarBookTitlesLookAt.TabIndex = 0;
            this.navBarBookTitlesLookAt.Text = "navBarControl1";
            // 
            // navBarGBookTitlesLookAt
            // 
            this.navBarGBookTitlesLookAt.Caption = "Tìm nhanh";
            this.navBarGBookTitlesLookAt.ControlContainer = this.navBarGroupControlContainer1;
            this.navBarGBookTitlesLookAt.Expanded = true;
            this.navBarGBookTitlesLookAt.GroupClientHeight = 80;
            this.navBarGBookTitlesLookAt.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.ControlContainer;
            this.navBarGBookTitlesLookAt.Name = "navBarGBookTitlesLookAt";
            // 
            // navBarGroupControlContainer1
            // 
            this.navBarGroupControlContainer1.Controls.Add(this.labBooktitlesNameLA);
            this.navBarGroupControlContainer1.Controls.Add(this.txtBootitlesNameLA);
            this.navBarGroupControlContainer1.Name = "navBarGroupControlContainer1";
            this.navBarGroupControlContainer1.Size = new System.Drawing.Size(250, 262);
            this.navBarGroupControlContainer1.TabIndex = 0;
            // 
            // labBooktitlesNameLA
            // 
            this.labBooktitlesNameLA.Location = new System.Drawing.Point(6, 19);
            this.labBooktitlesNameLA.Name = "labBooktitlesNameLA";
            this.labBooktitlesNameLA.Size = new System.Drawing.Size(69, 13);
            this.labBooktitlesNameLA.TabIndex = 2;
            this.labBooktitlesNameLA.Text = "Nhập tên sách";
            // 
            // txtBootitlesNameLA
            // 
            this.txtBootitlesNameLA.Location = new System.Drawing.Point(41, 38);
            this.txtBootitlesNameLA.Name = "txtBootitlesNameLA";
            this.txtBootitlesNameLA.Size = new System.Drawing.Size(152, 20);
            this.txtBootitlesNameLA.TabIndex = 3;
            // 
            // frmBookTitle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 461);
            this.Controls.Add(this.panelDataDetails);
            this.Controls.Add(this.panelBookTitlesExecute);
            this.Controls.Add(this.panelBooTitlesT);
            this.Name = "frmBookTitle";
            this.Text = "Quản lý đầu sách";
            this.Load += new System.EventHandler(this.frmBookTitles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdListBookTitles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdvListBookTitles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rtxtBookTitlesId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rtxtBookTitlesName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rtxtAuthorName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rtxtBookGenreName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckedComboBoxEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelBooTitlesT)).EndInit();
            this.panelBooTitlesT.ResumeLayout(false);
            this.panelBooTitlesT.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelBookTitlesExecute)).EndInit();
            this.panelBookTitlesExecute.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelDataDetails)).EndInit();
            this.panelDataDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelBookTitleView)).EndInit();
            this.panelBookTitleView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelBookTitlesDetail)).EndInit();
            this.panelBookTitlesDetail.ResumeLayout(false);
            this.panelBookTitlesDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkBookGenreName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkCmbAuthorName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBookTitlesId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBookTitlesName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarBookTitlesLookAt)).EndInit();
            this.navBarBookTitlesLookAt.ResumeLayout(false);
            this.navBarGroupControlContainer1.ResumeLayout(false);
            this.navBarGroupControlContainer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBootitlesNameLA.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labBookTitles;
        private DevExpress.XtraEditors.PanelControl panelBooTitlesT;
        private DevExpress.XtraEditors.PanelControl panelBookTitlesExecute;
        private DevExpress.XtraEditors.PanelControl panelDataDetails;
        private DevExpress.XtraEditors.PanelControl panelBookTitleView;
        private DevExpress.XtraNavBar.NavBarControl navBarBookTitlesLookAt;
        private DevExpress.XtraNavBar.NavBarGroup navBarGBookTitlesLookAt;
        private DevExpress.XtraEditors.PanelControl panelBookTitlesDetail;
        private DevExpress.XtraEditors.LabelControl labBookTitleId;
        private DevExpress.XtraEditors.LabelControl labBookTitlesName;
        private DevExpress.XtraEditors.TextEdit txtBookTitlesId;
        private DevExpress.XtraEditors.TextEdit txtBookTitlesName;
        private DevExpress.XtraGrid.GridControl grdListBookTitles;
        private DevExpress.XtraGrid.Views.Grid.GridView grdvListBookTitles;
        private DevExpress.XtraGrid.Columns.GridColumn BookTitlesId;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit rtxtBookTitlesId;
        private DevExpress.XtraGrid.Columns.GridColumn BookTitlesName;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit rtxtBookTitlesName;
        private DevExpress.XtraGrid.Columns.GridColumn AuthorName;
        private DevExpress.XtraGrid.Columns.GridColumn BookGenreName;
        private DevExpress.XtraEditors.LabelControl labAuthorName;
        private DevExpress.XtraEditors.LabelControl labBookGenreName;
        private DevExpress.XtraNavBar.NavBarGroupControlContainer navBarGroupControlContainer1;
        private DevExpress.XtraEditors.LabelControl labBooktitlesNameLA;
        private DevExpress.XtraEditors.TextEdit txtBootitlesNameLA;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckedComboBoxEdit repositoryItemCheckedComboBoxEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn AuthorID;
        private DevExpress.XtraGrid.Columns.GridColumn AuthorNames;
        private DevExpress.XtraEditors.CheckedComboBoxEdit chkCmbAuthorName;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit rtxtAuthorName;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit rtxtBookGenreName;
        private DevExpress.XtraEditors.LookUpEdit lkBookGenreName;
        private DevExpress.XtraGrid.Columns.GridColumn BookTiltesSno;
        private DevExpress.XtraEditors.SimpleButton btnCancelOfUpdate;
        private DevExpress.XtraEditors.SimpleButton btnAddAuthor;
        private DevExpress.XtraEditors.SimpleButton btnAddBookGenre;
    }
}