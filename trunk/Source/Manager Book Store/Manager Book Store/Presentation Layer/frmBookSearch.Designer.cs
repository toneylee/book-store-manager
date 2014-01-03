namespace Manager_Book_Store.Presentation_Layer
{
    partial class frmBookSearch
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
            this.labContentSearch = new DevExpress.XtraEditors.LabelControl();
            this.panSearchContent = new DevExpress.XtraEditors.PanelControl();
            this.grpSearchContent = new DevExpress.XtraEditors.GroupControl();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.panView = new DevExpress.XtraEditors.PanelControl();
            this.grdListBook = new DevExpress.XtraGrid.GridControl();
            this.grdvListBook = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.BookSno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BookId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BookName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BookGenreName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.AuthorName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PublisherName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Year = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Prices = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Quantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.navBarControl = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarGroup = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarGroupControlContainer = new DevExpress.XtraNavBar.NavBarGroupControlContainer();
            this.xtraScrollableControl1 = new DevExpress.XtraEditors.XtraScrollableControl();
            this.chkEnableChoseBookGenre = new DevExpress.XtraEditors.CheckEdit();
            this.chkEnableChoseAuthor = new DevExpress.XtraEditors.CheckEdit();
            this.chkEnableChosePublisher = new DevExpress.XtraEditors.CheckEdit();
            this.spYear = new DevExpress.XtraEditors.SpinEdit();
            this.spPrice = new DevExpress.XtraEditors.SpinEdit();
            this.spQuatityLimit = new DevExpress.XtraEditors.SpinEdit();
            this.lkPublisherName = new DevExpress.XtraEditors.LookUpEdit();
            this.lkAuthorName = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labYear = new DevExpress.XtraEditors.LabelControl();
            this.labQuantityLimit = new DevExpress.XtraEditors.LabelControl();
            this.lkBookGenreName = new DevExpress.XtraEditors.LookUpEdit();
            this.chkEnableSearchFast = new DevExpress.XtraEditors.CheckEdit();
            this.labChosePublisher = new DevExpress.XtraEditors.LabelControl();
            this.labChoseAuthor = new DevExpress.XtraEditors.LabelControl();
            this.labChoseBookGenre = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panSearchTitles)).BeginInit();
            this.panSearchTitles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtContentSearch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panSearchContent)).BeginInit();
            this.panSearchContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpSearchContent)).BeginInit();
            this.grpSearchContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panView)).BeginInit();
            this.panView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdListBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdvListBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl)).BeginInit();
            this.navBarControl.SuspendLayout();
            this.navBarGroupControlContainer.SuspendLayout();
            this.xtraScrollableControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkEnableChoseBookGenre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkEnableChoseAuthor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkEnableChosePublisher.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spYear.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spQuatityLimit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkPublisherName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkAuthorName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkBookGenreName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkEnableSearchFast.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panSearchTitles
            // 
            this.panSearchTitles.Controls.Add(this.labBookGenreTitle);
            this.panSearchTitles.Dock = System.Windows.Forms.DockStyle.Top;
            this.panSearchTitles.Location = new System.Drawing.Point(0, 0);
            this.panSearchTitles.Name = "panSearchTitles";
            this.panSearchTitles.Size = new System.Drawing.Size(1004, 40);
            this.panSearchTitles.TabIndex = 0;
            // 
            // labBookGenreTitle
            // 
            this.labBookGenreTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labBookGenreTitle.Appearance.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.labBookGenreTitle.Appearance.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.labBookGenreTitle.Location = new System.Drawing.Point(403, 1);
            this.labBookGenreTitle.Name = "labBookGenreTitle";
            this.labBookGenreTitle.Size = new System.Drawing.Size(182, 32);
            this.labBookGenreTitle.TabIndex = 2;
            this.labBookGenreTitle.Text = "TÌM KIẾM SÁCH";
            // 
            // txtContentSearch
            // 
            this.txtContentSearch.Location = new System.Drawing.Point(41, 46);
            this.txtContentSearch.Name = "txtContentSearch";
            this.txtContentSearch.Size = new System.Drawing.Size(263, 20);
            this.txtContentSearch.TabIndex = 0;
            this.txtContentSearch.TextChanged += new System.EventHandler(this.txtContentSearch_TextChanged);
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
            this.panSearchContent.Size = new System.Drawing.Size(1004, 81);
            this.panSearchContent.TabIndex = 3;
            // 
            // grpSearchContent
            // 
            this.grpSearchContent.Controls.Add(this.btnSearch);
            this.grpSearchContent.Controls.Add(this.txtContentSearch);
            this.grpSearchContent.Controls.Add(this.labContentSearch);
            this.grpSearchContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpSearchContent.Location = new System.Drawing.Point(2, 2);
            this.grpSearchContent.Name = "grpSearchContent";
            this.grpSearchContent.Size = new System.Drawing.Size(1000, 77);
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
            // panView
            // 
            this.panView.Controls.Add(this.grdListBook);
            this.panView.Controls.Add(this.navBarControl);
            this.panView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panView.Location = new System.Drawing.Point(0, 121);
            this.panView.Name = "panView";
            this.panView.Size = new System.Drawing.Size(1004, 361);
            this.panView.TabIndex = 4;
            // 
            // grdListBook
            // 
            this.grdListBook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdListBook.Location = new System.Drawing.Point(265, 2);
            this.grdListBook.MainView = this.grdvListBook;
            this.grdListBook.Name = "grdListBook";
            this.grdListBook.Size = new System.Drawing.Size(737, 357);
            this.grdListBook.TabIndex = 2;
            this.grdListBook.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdvListBook});
            // 
            // grdvListBook
            // 
            this.grdvListBook.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.BookSno,
            this.BookId,
            this.BookName,
            this.BookGenreName,
            this.AuthorName,
            this.PublisherName,
            this.Year,
            this.Prices,
            this.Quantity});
            this.grdvListBook.GridControl = this.grdListBook;
            this.grdvListBook.Name = "grdvListBook";
            this.grdvListBook.OptionsView.ShowGroupPanel = false;
            // 
            // BookSno
            // 
            this.BookSno.Caption = "STT";
            this.BookSno.FieldName = "STT";
            this.BookSno.Name = "BookSno";
            this.BookSno.Visible = true;
            this.BookSno.VisibleIndex = 0;
            this.BookSno.Width = 50;
            // 
            // BookId
            // 
            this.BookId.Caption = "Mã sách";
            this.BookId.FieldName = "MaSach";
            this.BookId.Name = "BookId";
            this.BookId.Visible = true;
            this.BookId.VisibleIndex = 1;
            this.BookId.Width = 125;
            // 
            // BookName
            // 
            this.BookName.Caption = "Tên sách";
            this.BookName.FieldName = "TenSach";
            this.BookName.Name = "BookName";
            this.BookName.Visible = true;
            this.BookName.VisibleIndex = 2;
            this.BookName.Width = 125;
            // 
            // BookGenreName
            // 
            this.BookGenreName.Caption = "Thể loại";
            this.BookGenreName.FieldName = "TenTL";
            this.BookGenreName.Name = "BookGenreName";
            this.BookGenreName.Visible = true;
            this.BookGenreName.VisibleIndex = 3;
            this.BookGenreName.Width = 125;
            // 
            // AuthorName
            // 
            this.AuthorName.Caption = "Tác giả";
            this.AuthorName.FieldName = "NhomTG";
            this.AuthorName.Name = "AuthorName";
            this.AuthorName.Visible = true;
            this.AuthorName.VisibleIndex = 4;
            this.AuthorName.Width = 125;
            // 
            // PublisherName
            // 
            this.PublisherName.Caption = "Nhà xuất bản";
            this.PublisherName.FieldName = "TenNXB";
            this.PublisherName.Name = "PublisherName";
            this.PublisherName.Visible = true;
            this.PublisherName.VisibleIndex = 5;
            this.PublisherName.Width = 125;
            // 
            // Year
            // 
            this.Year.Caption = "Năm xuất bản";
            this.Year.FieldName = "NamXB";
            this.Year.Name = "Year";
            this.Year.Visible = true;
            this.Year.VisibleIndex = 6;
            this.Year.Width = 125;
            // 
            // Prices
            // 
            this.Prices.Caption = "Giá nhập";
            this.Prices.FieldName = "GiaNhap";
            this.Prices.Name = "Prices";
            this.Prices.Visible = true;
            this.Prices.VisibleIndex = 7;
            this.Prices.Width = 125;
            // 
            // Quantity
            // 
            this.Quantity.Caption = "Số lượng tồn";
            this.Quantity.FieldName = "SoLuong";
            this.Quantity.Name = "Quantity";
            this.Quantity.Visible = true;
            this.Quantity.VisibleIndex = 8;
            this.Quantity.Width = 131;
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
            this.navBarControl.Size = new System.Drawing.Size(263, 357);
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
            this.navBarGroupControlContainer.Size = new System.Drawing.Size(263, 254);
            this.navBarGroupControlContainer.TabIndex = 0;
            // 
            // xtraScrollableControl1
            // 
            this.xtraScrollableControl1.Controls.Add(this.chkEnableChoseBookGenre);
            this.xtraScrollableControl1.Controls.Add(this.chkEnableChoseAuthor);
            this.xtraScrollableControl1.Controls.Add(this.chkEnableChosePublisher);
            this.xtraScrollableControl1.Controls.Add(this.spYear);
            this.xtraScrollableControl1.Controls.Add(this.spPrice);
            this.xtraScrollableControl1.Controls.Add(this.spQuatityLimit);
            this.xtraScrollableControl1.Controls.Add(this.lkPublisherName);
            this.xtraScrollableControl1.Controls.Add(this.lkAuthorName);
            this.xtraScrollableControl1.Controls.Add(this.labelControl1);
            this.xtraScrollableControl1.Controls.Add(this.labYear);
            this.xtraScrollableControl1.Controls.Add(this.labQuantityLimit);
            this.xtraScrollableControl1.Controls.Add(this.lkBookGenreName);
            this.xtraScrollableControl1.Controls.Add(this.chkEnableSearchFast);
            this.xtraScrollableControl1.Controls.Add(this.labChosePublisher);
            this.xtraScrollableControl1.Controls.Add(this.labChoseAuthor);
            this.xtraScrollableControl1.Controls.Add(this.labChoseBookGenre);
            this.xtraScrollableControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraScrollableControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraScrollableControl1.Name = "xtraScrollableControl1";
            this.xtraScrollableControl1.Size = new System.Drawing.Size(263, 254);
            this.xtraScrollableControl1.TabIndex = 0;
            // 
            // chkEnableChoseBookGenre
            // 
            this.chkEnableChoseBookGenre.EditValue = true;
            this.chkEnableChoseBookGenre.Location = new System.Drawing.Point(10, 46);
            this.chkEnableChoseBookGenre.Name = "chkEnableChoseBookGenre";
            this.chkEnableChoseBookGenre.Properties.Caption = "";
            this.chkEnableChoseBookGenre.Size = new System.Drawing.Size(24, 19);
            this.chkEnableChoseBookGenre.TabIndex = 3;
            this.chkEnableChoseBookGenre.CheckedChanged += new System.EventHandler(this.chkEnableChoseBookGenre_CheckedChanged);
            // 
            // chkEnableChoseAuthor
            // 
            this.chkEnableChoseAuthor.EditValue = true;
            this.chkEnableChoseAuthor.Location = new System.Drawing.Point(10, 109);
            this.chkEnableChoseAuthor.Name = "chkEnableChoseAuthor";
            this.chkEnableChoseAuthor.Properties.Caption = "";
            this.chkEnableChoseAuthor.Size = new System.Drawing.Size(25, 19);
            this.chkEnableChoseAuthor.TabIndex = 3;
            this.chkEnableChoseAuthor.CheckedChanged += new System.EventHandler(this.chkEnableChoseAuthor_CheckedChanged);
            // 
            // chkEnableChosePublisher
            // 
            this.chkEnableChosePublisher.EditValue = true;
            this.chkEnableChosePublisher.Location = new System.Drawing.Point(10, 167);
            this.chkEnableChosePublisher.Name = "chkEnableChosePublisher";
            this.chkEnableChosePublisher.Properties.Caption = "";
            this.chkEnableChosePublisher.Size = new System.Drawing.Size(22, 19);
            this.chkEnableChosePublisher.TabIndex = 3;
            this.chkEnableChosePublisher.CheckedChanged += new System.EventHandler(this.chkEnableChosePublisher_CheckedChanged);
            // 
            // spYear
            // 
            this.spYear.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spYear.Location = new System.Drawing.Point(128, 267);
            this.spYear.Name = "spYear";
            this.spYear.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spYear.Size = new System.Drawing.Size(104, 20);
            this.spYear.TabIndex = 0;
            this.spYear.TextChanged += new System.EventHandler(this.spYear_TextChanged);
            // 
            // spPrice
            // 
            this.spPrice.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spPrice.Location = new System.Drawing.Point(128, 237);
            this.spPrice.Name = "spPrice";
            this.spPrice.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spPrice.Size = new System.Drawing.Size(104, 20);
            this.spPrice.TabIndex = 0;
            this.spPrice.TextChanged += new System.EventHandler(this.spPrice_TextChanged);
            // 
            // spQuatityLimit
            // 
            this.spQuatityLimit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spQuatityLimit.Location = new System.Drawing.Point(128, 205);
            this.spQuatityLimit.Name = "spQuatityLimit";
            this.spQuatityLimit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spQuatityLimit.Size = new System.Drawing.Size(104, 20);
            this.spQuatityLimit.TabIndex = 0;
            this.spQuatityLimit.TextChanged += new System.EventHandler(this.spQuatityLimit_TextChanged);
            // 
            // lkPublisherName
            // 
            this.lkPublisherName.EditValue = "";
            this.lkPublisherName.Location = new System.Drawing.Point(38, 167);
            this.lkPublisherName.Name = "lkPublisherName";
            this.lkPublisherName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkPublisherName.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("STT", "STT"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenNXB", "Nhà xuất bản")});
            this.lkPublisherName.Properties.NullText = "";
            this.lkPublisherName.Size = new System.Drawing.Size(194, 20);
            this.lkPublisherName.TabIndex = 2;
            this.lkPublisherName.EditValueChanged += new System.EventHandler(this.lkPublisherName_EditValueChanged);
            // 
            // lkAuthorName
            // 
            this.lkAuthorName.EditValue = "";
            this.lkAuthorName.Location = new System.Drawing.Point(38, 108);
            this.lkAuthorName.Name = "lkAuthorName";
            this.lkAuthorName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkAuthorName.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("STT", "STT"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenTG", "Tác giả")});
            this.lkAuthorName.Properties.NullText = "";
            this.lkAuthorName.Size = new System.Drawing.Size(194, 20);
            this.lkAuthorName.TabIndex = 2;
            this.lkAuthorName.EditValueChanged += new System.EventHandler(this.lkAuthorName_EditValueChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(10, 240);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(61, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Giá nhập >=";
            // 
            // labYear
            // 
            this.labYear.Location = new System.Drawing.Point(10, 270);
            this.labYear.Name = "labYear";
            this.labYear.Size = new System.Drawing.Size(86, 13);
            this.labYear.TabIndex = 0;
            this.labYear.Text = "Năm xuất bản >=";
            // 
            // labQuantityLimit
            // 
            this.labQuantityLimit.Location = new System.Drawing.Point(10, 208);
            this.labQuantityLimit.Name = "labQuantityLimit";
            this.labQuantityLimit.Size = new System.Drawing.Size(61, 13);
            this.labQuantityLimit.TabIndex = 0;
            this.labQuantityLimit.Text = "Số lượng >=";
            // 
            // lkBookGenreName
            // 
            this.lkBookGenreName.EditValue = "";
            this.lkBookGenreName.Location = new System.Drawing.Point(38, 45);
            this.lkBookGenreName.Name = "lkBookGenreName";
            this.lkBookGenreName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkBookGenreName.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("STT", "STT"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenTL", "Thể loại")});
            this.lkBookGenreName.Properties.NullText = "";
            this.lkBookGenreName.Size = new System.Drawing.Size(194, 20);
            this.lkBookGenreName.TabIndex = 2;
            this.lkBookGenreName.EditValueChanged += new System.EventHandler(this.lkBookGenreName_EditValueChanged);
            // 
            // chkEnableSearchFast
            // 
            this.chkEnableSearchFast.Location = new System.Drawing.Point(3, 305);
            this.chkEnableSearchFast.Name = "chkEnableSearchFast";
            this.chkEnableSearchFast.Properties.Caption = "Bật chế độ tìm kiếm nhanh";
            this.chkEnableSearchFast.Size = new System.Drawing.Size(252, 19);
            this.chkEnableSearchFast.TabIndex = 1;
            // 
            // labChosePublisher
            // 
            this.labChosePublisher.Location = new System.Drawing.Point(10, 144);
            this.labChosePublisher.Name = "labChosePublisher";
            this.labChosePublisher.Size = new System.Drawing.Size(92, 13);
            this.labChosePublisher.TabIndex = 0;
            this.labChosePublisher.Text = "Chọn nhà xuất bản";
            // 
            // labChoseAuthor
            // 
            this.labChoseAuthor.Location = new System.Drawing.Point(10, 81);
            this.labChoseAuthor.Name = "labChoseAuthor";
            this.labChoseAuthor.Size = new System.Drawing.Size(60, 13);
            this.labChoseAuthor.TabIndex = 0;
            this.labChoseAuthor.Text = "Chọn tác giả";
            // 
            // labChoseBookGenre
            // 
            this.labChoseBookGenre.Location = new System.Drawing.Point(9, 17);
            this.labChoseBookGenre.Name = "labChoseBookGenre";
            this.labChoseBookGenre.Size = new System.Drawing.Size(63, 13);
            this.labChoseBookGenre.TabIndex = 0;
            this.labChoseBookGenre.Text = "Chọn thể loại";
            // 
            // frmBookSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 482);
            this.Controls.Add(this.panView);
            this.Controls.Add(this.panSearchContent);
            this.Controls.Add(this.panSearchTitles);
            this.Name = "frmBookSearch";
            this.Text = "Tìm kiếm sách";
            this.Load += new System.EventHandler(this.frmBookSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panSearchTitles)).EndInit();
            this.panSearchTitles.ResumeLayout(false);
            this.panSearchTitles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtContentSearch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panSearchContent)).EndInit();
            this.panSearchContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpSearchContent)).EndInit();
            this.grpSearchContent.ResumeLayout(false);
            this.grpSearchContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panView)).EndInit();
            this.panView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdListBook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdvListBook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl)).EndInit();
            this.navBarControl.ResumeLayout(false);
            this.navBarGroupControlContainer.ResumeLayout(false);
            this.xtraScrollableControl1.ResumeLayout(false);
            this.xtraScrollableControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkEnableChoseBookGenre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkEnableChoseAuthor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkEnableChosePublisher.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spYear.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spQuatityLimit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkPublisherName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkAuthorName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkBookGenreName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkEnableSearchFast.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panSearchTitles;
        private DevExpress.XtraEditors.LabelControl labContentSearch;
        private DevExpress.XtraEditors.TextEdit txtContentSearch;
        private DevExpress.XtraEditors.LabelControl labBookGenreTitle;
        private DevExpress.XtraEditors.PanelControl panSearchContent;
        private DevExpress.XtraEditors.GroupControl grpSearchContent;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraEditors.PanelControl panView;
        private DevExpress.XtraGrid.GridControl grdListBook;
        private DevExpress.XtraGrid.Views.Grid.GridView grdvListBook;
        private DevExpress.XtraNavBar.NavBarControl navBarControl;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup;
        private DevExpress.XtraNavBar.NavBarGroupControlContainer navBarGroupControlContainer;
        private DevExpress.XtraEditors.XtraScrollableControl xtraScrollableControl1;
        private DevExpress.XtraEditors.LabelControl labChoseBookGenre;
        private DevExpress.XtraEditors.LookUpEdit lkBookGenreName;
        private DevExpress.XtraEditors.CheckEdit chkEnableSearchFast;
        private DevExpress.XtraEditors.SpinEdit spYear;
        private DevExpress.XtraEditors.SpinEdit spQuatityLimit;
        private DevExpress.XtraEditors.LookUpEdit lkPublisherName;
        private DevExpress.XtraEditors.LookUpEdit lkAuthorName;
        private DevExpress.XtraEditors.LabelControl labYear;
        private DevExpress.XtraEditors.LabelControl labQuantityLimit;
        private DevExpress.XtraEditors.LabelControl labChosePublisher;
        private DevExpress.XtraEditors.LabelControl labChoseAuthor;
        private DevExpress.XtraGrid.Columns.GridColumn BookSno;
        private DevExpress.XtraGrid.Columns.GridColumn BookId;
        private DevExpress.XtraGrid.Columns.GridColumn BookName;
        private DevExpress.XtraGrid.Columns.GridColumn BookGenreName;
        private DevExpress.XtraGrid.Columns.GridColumn AuthorName;
        private DevExpress.XtraGrid.Columns.GridColumn PublisherName;
        private DevExpress.XtraGrid.Columns.GridColumn Year;
        private DevExpress.XtraGrid.Columns.GridColumn Prices;
        private DevExpress.XtraGrid.Columns.GridColumn Quantity;
        private DevExpress.XtraEditors.SpinEdit spPrice;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.CheckEdit chkEnableChoseBookGenre;
        private DevExpress.XtraEditors.CheckEdit chkEnableChoseAuthor;
        private DevExpress.XtraEditors.CheckEdit chkEnableChosePublisher;

    }
}