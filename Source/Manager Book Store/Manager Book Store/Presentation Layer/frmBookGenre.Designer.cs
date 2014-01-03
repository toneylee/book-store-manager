namespace Manager_Book_Store.Presentation_Layer
{
    partial class frmBookGenre
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
            this.components = new System.ComponentModel.Container();
            this.panelBookGenreExecute = new DevExpress.XtraEditors.PanelControl();
            this.btnCacelOfUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.grdListBookGenre = new DevExpress.XtraGrid.GridControl();
            this.grdvListBookGenre = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bookGenreSNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BookGenreId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rtxtBookGenreId = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.BookGenreName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rtxtBookGenre = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.panelBookGenreView = new DevExpress.XtraEditors.PanelControl();
            this.panelBookGenreDetail = new DevExpress.XtraEditors.PanelControl();
            this.labBookGenreId = new DevExpress.XtraEditors.LabelControl();
            this.labBookGenreName = new DevExpress.XtraEditors.LabelControl();
            this.txtBookGenreId = new DevExpress.XtraEditors.TextEdit();
            this.txtBookGenreName = new DevExpress.XtraEditors.TextEdit();
            this.navBarBookGenreLookAt = new DevExpress.XtraNavBar.NavBarControl();
            this.nvarBarGBookGenreLookAt = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarGroupControlContainer1 = new DevExpress.XtraNavBar.NavBarGroupControlContainer();
            this.txtBookGenreNameLA = new DevExpress.XtraEditors.TextEdit();
            this.labBookGenreNameLA = new DevExpress.XtraEditors.LabelControl();
            this.panelBookGenreTitle = new DevExpress.XtraEditors.PanelControl();
            this.labBookGenreTitle = new DevExpress.XtraEditors.LabelControl();
            this.dxEPBookGenre = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panelBookGenreExecute)).BeginInit();
            this.panelBookGenreExecute.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdListBookGenre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdvListBookGenre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rtxtBookGenreId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rtxtBookGenre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelBookGenreView)).BeginInit();
            this.panelBookGenreView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelBookGenreDetail)).BeginInit();
            this.panelBookGenreDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBookGenreId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBookGenreName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarBookGenreLookAt)).BeginInit();
            this.navBarBookGenreLookAt.SuspendLayout();
            this.navBarGroupControlContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBookGenreNameLA.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelBookGenreTitle)).BeginInit();
            this.panelBookGenreTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dxEPBookGenre)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBookGenreExecute
            // 
            this.panelBookGenreExecute.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelBookGenreExecute.Controls.Add(this.btnCacelOfUpdate);
            this.panelBookGenreExecute.Controls.Add(this.btnUpdate);
            this.panelBookGenreExecute.Controls.Add(this.btnSave);
            this.panelBookGenreExecute.Controls.Add(this.btnCancel);
            this.panelBookGenreExecute.Controls.Add(this.btnAdd);
            this.panelBookGenreExecute.Controls.Add(this.btnDelete);
            this.panelBookGenreExecute.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBookGenreExecute.Location = new System.Drawing.Point(0, 369);
            this.panelBookGenreExecute.Name = "panelBookGenreExecute";
            this.panelBookGenreExecute.Size = new System.Drawing.Size(731, 55);
            this.panelBookGenreExecute.TabIndex = 1;
            // 
            // btnCacelOfUpdate
            // 
            this.btnCacelOfUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCacelOfUpdate.Location = new System.Drawing.Point(228, 12);
            this.btnCacelOfUpdate.Name = "btnCacelOfUpdate";
            this.btnCacelOfUpdate.Size = new System.Drawing.Size(75, 31);
            this.btnCacelOfUpdate.TabIndex = 1;
            this.btnCacelOfUpdate.Text = "Hủy thao tác";
            this.btnCacelOfUpdate.Visible = false;
            this.btnCacelOfUpdate.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.Location = new System.Drawing.Point(228, 12);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 31);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(437, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 31);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Lưu xuống";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(121, 12);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 31);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Hủy thao tác";
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(121, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 31);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Thêm mới";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Location = new System.Drawing.Point(334, 12);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 31);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Xóa bỏ";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // grdListBookGenre
            // 
            this.grdListBookGenre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdListBookGenre.Location = new System.Drawing.Point(0, 36);
            this.grdListBookGenre.MainView = this.grdvListBookGenre;
            this.grdListBookGenre.Name = "grdListBookGenre";
            this.grdListBookGenre.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rtxtBookGenre,
            this.rtxtBookGenreId});
            this.grdListBookGenre.Size = new System.Drawing.Size(512, 294);
            this.grdListBookGenre.TabIndex = 1;
            this.grdListBookGenre.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdvListBookGenre});
            // 
            // grdvListBookGenre
            // 
            this.grdvListBookGenre.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.bookGenreSNo,
            this.BookGenreId,
            this.BookGenreName});
            this.grdvListBookGenre.GridControl = this.grdListBookGenre;
            this.grdvListBookGenre.Name = "grdvListBookGenre";
            this.grdvListBookGenre.OptionsView.ShowGroupPanel = false;
            this.grdvListBookGenre.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.grdvListBookGenre_FocusedRowChanged);
            // 
            // bookGenreSNo
            // 
            this.bookGenreSNo.Caption = "STT";
            this.bookGenreSNo.FieldName = "STT";
            this.bookGenreSNo.Name = "bookGenreSNo";
            this.bookGenreSNo.Visible = true;
            this.bookGenreSNo.VisibleIndex = 0;
            this.bookGenreSNo.Width = 42;
            // 
            // BookGenreId
            // 
            this.BookGenreId.Caption = "Mã thể loại";
            this.BookGenreId.ColumnEdit = this.rtxtBookGenreId;
            this.BookGenreId.FieldName = "MaTL";
            this.BookGenreId.Name = "BookGenreId";
            this.BookGenreId.Visible = true;
            this.BookGenreId.VisibleIndex = 1;
            this.BookGenreId.Width = 505;
            // 
            // rtxtBookGenreId
            // 
            this.rtxtBookGenreId.AutoHeight = false;
            this.rtxtBookGenreId.Name = "rtxtBookGenreId";
            this.rtxtBookGenreId.ReadOnly = true;
            // 
            // BookGenreName
            // 
            this.BookGenreName.Caption = "Tên thể loại";
            this.BookGenreName.ColumnEdit = this.rtxtBookGenre;
            this.BookGenreName.FieldName = "TenTL";
            this.BookGenreName.Name = "BookGenreName";
            this.BookGenreName.Visible = true;
            this.BookGenreName.VisibleIndex = 2;
            this.BookGenreName.Width = 508;
            // 
            // rtxtBookGenre
            // 
            this.rtxtBookGenre.AutoHeight = false;
            this.rtxtBookGenre.Name = "rtxtBookGenre";
            this.rtxtBookGenre.ReadOnly = true;
            // 
            // panelBookGenreView
            // 
            this.panelBookGenreView.AllowDrop = true;
            this.panelBookGenreView.AllowTouchScroll = true;
            this.panelBookGenreView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelBookGenreView.Controls.Add(this.grdListBookGenre);
            this.panelBookGenreView.Controls.Add(this.panelBookGenreDetail);
            this.panelBookGenreView.Controls.Add(this.navBarBookGenreLookAt);
            this.panelBookGenreView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBookGenreView.FireScrollEventOnMouseWheel = true;
            this.panelBookGenreView.Location = new System.Drawing.Point(0, 39);
            this.panelBookGenreView.Name = "panelBookGenreView";
            this.panelBookGenreView.Size = new System.Drawing.Size(731, 330);
            this.panelBookGenreView.TabIndex = 2;
            // 
            // panelBookGenreDetail
            // 
            this.panelBookGenreDetail.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelBookGenreDetail.Controls.Add(this.labBookGenreId);
            this.panelBookGenreDetail.Controls.Add(this.labBookGenreName);
            this.panelBookGenreDetail.Controls.Add(this.txtBookGenreId);
            this.panelBookGenreDetail.Controls.Add(this.txtBookGenreName);
            this.panelBookGenreDetail.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBookGenreDetail.Location = new System.Drawing.Point(0, 0);
            this.panelBookGenreDetail.Name = "panelBookGenreDetail";
            this.panelBookGenreDetail.Size = new System.Drawing.Size(512, 36);
            this.panelBookGenreDetail.TabIndex = 6;
            // 
            // labBookGenreId
            // 
            this.labBookGenreId.Location = new System.Drawing.Point(24, 9);
            this.labBookGenreId.Name = "labBookGenreId";
            this.labBookGenreId.Size = new System.Drawing.Size(56, 13);
            this.labBookGenreId.TabIndex = 4;
            this.labBookGenreId.Text = "Mã thể loại:";
            // 
            // labBookGenreName
            // 
            this.labBookGenreName.Location = new System.Drawing.Point(257, 9);
            this.labBookGenreName.Name = "labBookGenreName";
            this.labBookGenreName.Size = new System.Drawing.Size(60, 13);
            this.labBookGenreName.TabIndex = 2;
            this.labBookGenreName.Text = "Tên thể loại:";
            // 
            // txtBookGenreId
            // 
            this.txtBookGenreId.Location = new System.Drawing.Point(95, 8);
            this.txtBookGenreId.Name = "txtBookGenreId";
            this.txtBookGenreId.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtBookGenreId.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.txtBookGenreId.Properties.ReadOnly = true;
            this.txtBookGenreId.Size = new System.Drawing.Size(131, 20);
            this.txtBookGenreId.TabIndex = 5;
            // 
            // txtBookGenreName
            // 
            this.txtBookGenreName.Location = new System.Drawing.Point(334, 8);
            this.txtBookGenreName.Name = "txtBookGenreName";
            this.txtBookGenreName.Size = new System.Drawing.Size(137, 20);
            this.txtBookGenreName.TabIndex = 3;
            this.txtBookGenreName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBookGenreName_KeyPress);
            // 
            // navBarBookGenreLookAt
            // 
            this.navBarBookGenreLookAt.ActiveGroup = this.nvarBarGBookGenreLookAt;
            this.navBarBookGenreLookAt.Controls.Add(this.navBarGroupControlContainer1);
            this.navBarBookGenreLookAt.Dock = System.Windows.Forms.DockStyle.Right;
            this.navBarBookGenreLookAt.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.nvarBarGBookGenreLookAt});
            this.navBarBookGenreLookAt.Location = new System.Drawing.Point(512, 0);
            this.navBarBookGenreLookAt.Name = "navBarBookGenreLookAt";
            this.navBarBookGenreLookAt.OptionsNavPane.ExpandedWidth = 219;
            this.navBarBookGenreLookAt.PaintStyleKind = DevExpress.XtraNavBar.NavBarViewKind.NavigationPane;
            this.navBarBookGenreLookAt.ShowGroupHint = false;
            this.navBarBookGenreLookAt.ShowLinkHint = false;
            this.navBarBookGenreLookAt.Size = new System.Drawing.Size(219, 330);
            this.navBarBookGenreLookAt.TabIndex = 7;
            this.navBarBookGenreLookAt.Text = "navBarControl1";
            // 
            // nvarBarGBookGenreLookAt
            // 
            this.nvarBarGBookGenreLookAt.Caption = "Tìm nhanh";
            this.nvarBarGBookGenreLookAt.ControlContainer = this.navBarGroupControlContainer1;
            this.nvarBarGBookGenreLookAt.Expanded = true;
            this.nvarBarGBookGenreLookAt.GroupClientHeight = 80;
            this.nvarBarGBookGenreLookAt.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.ControlContainer;
            this.nvarBarGBookGenreLookAt.Name = "nvarBarGBookGenreLookAt";
            // 
            // navBarGroupControlContainer1
            // 
            this.navBarGroupControlContainer1.Controls.Add(this.txtBookGenreNameLA);
            this.navBarGroupControlContainer1.Controls.Add(this.labBookGenreNameLA);
            this.navBarGroupControlContainer1.Name = "navBarGroupControlContainer1";
            this.navBarGroupControlContainer1.Size = new System.Drawing.Size(219, 227);
            this.navBarGroupControlContainer1.TabIndex = 0;
            // 
            // txtBookGenreNameLA
            // 
            this.txtBookGenreNameLA.Location = new System.Drawing.Point(43, 34);
            this.txtBookGenreNameLA.Name = "txtBookGenreNameLA";
            this.txtBookGenreNameLA.Size = new System.Drawing.Size(153, 20);
            this.txtBookGenreNameLA.TabIndex = 3;
            this.txtBookGenreNameLA.TextChanged += new System.EventHandler(this.txtBookGenreNameLA_TextChanged);
            // 
            // labBookGenreNameLA
            // 
            this.labBookGenreNameLA.Location = new System.Drawing.Point(6, 15);
            this.labBookGenreNameLA.Name = "labBookGenreNameLA";
            this.labBookGenreNameLA.Size = new System.Drawing.Size(82, 13);
            this.labBookGenreNameLA.TabIndex = 2;
            this.labBookGenreNameLA.Text = "Nhập tên thể loại";
            // 
            // panelBookGenreTitle
            // 
            this.panelBookGenreTitle.Controls.Add(this.labBookGenreTitle);
            this.panelBookGenreTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBookGenreTitle.Location = new System.Drawing.Point(0, 0);
            this.panelBookGenreTitle.Name = "panelBookGenreTitle";
            this.panelBookGenreTitle.Size = new System.Drawing.Size(731, 39);
            this.panelBookGenreTitle.TabIndex = 6;
            // 
            // labBookGenreTitle
            // 
            this.labBookGenreTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labBookGenreTitle.Appearance.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.labBookGenreTitle.Appearance.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.labBookGenreTitle.Location = new System.Drawing.Point(222, 6);
            this.labBookGenreTitle.Name = "labBookGenreTitle";
            this.labBookGenreTitle.Size = new System.Drawing.Size(256, 32);
            this.labBookGenreTitle.TabIndex = 0;
            this.labBookGenreTitle.Text = "DANH SÁCH THỂ LOẠI";
            // 
            // dxEPBookGenre
            // 
            this.dxEPBookGenre.ContainerControl = this;
            // 
            // frmBookGenre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 424);
            this.Controls.Add(this.panelBookGenreView);
            this.Controls.Add(this.panelBookGenreTitle);
            this.Controls.Add(this.panelBookGenreExecute);
            this.Name = "frmBookGenre";
            this.Text = "Quản lý thể loại";
            this.Load += new System.EventHandler(this.frmForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelBookGenreExecute)).EndInit();
            this.panelBookGenreExecute.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdListBookGenre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdvListBookGenre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rtxtBookGenreId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rtxtBookGenre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelBookGenreView)).EndInit();
            this.panelBookGenreView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelBookGenreDetail)).EndInit();
            this.panelBookGenreDetail.ResumeLayout(false);
            this.panelBookGenreDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBookGenreId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBookGenreName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarBookGenreLookAt)).EndInit();
            this.navBarBookGenreLookAt.ResumeLayout(false);
            this.navBarGroupControlContainer1.ResumeLayout(false);
            this.navBarGroupControlContainer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBookGenreNameLA.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelBookGenreTitle)).EndInit();
            this.panelBookGenreTitle.ResumeLayout(false);
            this.panelBookGenreTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dxEPBookGenre)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelBookGenreExecute;
        private DevExpress.XtraEditors.PanelControl panelBookGenreView;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.TextEdit txtBookGenreId;
        private DevExpress.XtraEditors.LabelControl labBookGenreId;
        private DevExpress.XtraEditors.TextEdit txtBookGenreName;
        private DevExpress.XtraEditors.LabelControl labBookGenreName;
        private DevExpress.XtraGrid.GridControl grdListBookGenre;
        private DevExpress.XtraGrid.Views.Grid.GridView grdvListBookGenre;
        private DevExpress.XtraGrid.Columns.GridColumn BookGenreId;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit rtxtBookGenreId;
        private DevExpress.XtraGrid.Columns.GridColumn BookGenreName;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit rtxtBookGenre;
        private DevExpress.XtraEditors.PanelControl panelBookGenreTitle;
        private DevExpress.XtraEditors.PanelControl panelBookGenreDetail;
        private DevExpress.XtraEditors.LabelControl labBookGenreTitle;
        private DevExpress.XtraNavBar.NavBarControl navBarBookGenreLookAt;
        private DevExpress.XtraNavBar.NavBarGroup nvarBarGBookGenreLookAt;
        private DevExpress.XtraNavBar.NavBarGroupControlContainer navBarGroupControlContainer1;
        private DevExpress.XtraEditors.TextEdit txtBookGenreNameLA;
        private DevExpress.XtraEditors.LabelControl labBookGenreNameLA;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private DevExpress.XtraGrid.Columns.GridColumn bookGenreSNo;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxEPBookGenre;
        private DevExpress.XtraEditors.SimpleButton btnCacelOfUpdate;

    }
}