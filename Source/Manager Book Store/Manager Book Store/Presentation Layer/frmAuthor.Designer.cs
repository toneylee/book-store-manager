namespace Manager_Book_Store.Presentation_Layer
{
    partial class frmAuthor
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
            this.panelAuthorExecute = new DevExpress.XtraEditors.PanelControl();
            this.btnCacelOfUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.panelAuthorDetail = new DevExpress.XtraEditors.PanelControl();
            this.txtAuthorId = new DevExpress.XtraEditors.TextEdit();
            this.txtAuthorAddress = new DevExpress.XtraEditors.TextEdit();
            this.txtAuthorName = new DevExpress.XtraEditors.TextEdit();
            this.labAuthorId = new DevExpress.XtraEditors.LabelControl();
            this.labAuthorAddress = new DevExpress.XtraEditors.LabelControl();
            this.labAuthorName = new DevExpress.XtraEditors.LabelControl();
            this.grdListAuthor = new DevExpress.XtraGrid.GridControl();
            this.grdvListAuthor = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.AuthorSno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.AuthorId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rtxtAuthorId = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.AuthorName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rtxtAuthorName = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.AuthorAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rtxtAuthorAddress = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.panelAuthorTitle = new DevExpress.XtraEditors.PanelControl();
            this.labAuthorTitle = new DevExpress.XtraEditors.LabelControl();
            this.navBarAuthorLookAt = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarGAuthorLookAt = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarGroupControlContainer1 = new DevExpress.XtraNavBar.NavBarGroupControlContainer();
            this.txtAuthorNameLA = new DevExpress.XtraEditors.TextEdit();
            this.labAuthorNameLA = new DevExpress.XtraEditors.LabelControl();
            this.panelAuthorView = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelAuthorExecute)).BeginInit();
            this.panelAuthorExecute.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelAuthorDetail)).BeginInit();
            this.panelAuthorDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAuthorId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAuthorAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAuthorName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdListAuthor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdvListAuthor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rtxtAuthorId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rtxtAuthorName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rtxtAuthorAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelAuthorTitle)).BeginInit();
            this.panelAuthorTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navBarAuthorLookAt)).BeginInit();
            this.navBarAuthorLookAt.SuspendLayout();
            this.navBarGroupControlContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAuthorNameLA.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelAuthorView)).BeginInit();
            this.panelAuthorView.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelAuthorExecute
            // 
            this.panelAuthorExecute.Controls.Add(this.btnCacelOfUpdate);
            this.panelAuthorExecute.Controls.Add(this.btnUpdate);
            this.panelAuthorExecute.Controls.Add(this.btnCancel);
            this.panelAuthorExecute.Controls.Add(this.btnSave);
            this.panelAuthorExecute.Controls.Add(this.btnDelete);
            this.panelAuthorExecute.Controls.Add(this.btnAdd);
            this.panelAuthorExecute.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelAuthorExecute.Location = new System.Drawing.Point(0, 363);
            this.panelAuthorExecute.Name = "panelAuthorExecute";
            this.panelAuthorExecute.Size = new System.Drawing.Size(760, 54);
            this.panelAuthorExecute.TabIndex = 0;
            // 
            // btnCacelOfUpdate
            // 
            this.btnCacelOfUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCacelOfUpdate.Location = new System.Drawing.Point(252, 9);
            this.btnCacelOfUpdate.Name = "btnCacelOfUpdate";
            this.btnCacelOfUpdate.Size = new System.Drawing.Size(75, 31);
            this.btnCacelOfUpdate.TabIndex = 6;
            this.btnCacelOfUpdate.Text = "Hủy thao tác";
            this.btnCacelOfUpdate.Visible = false;
            this.btnCacelOfUpdate.Click += new System.EventHandler(this.btnCacelOfUpdate_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.Location = new System.Drawing.Point(252, 9);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 31);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(146, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 34);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Hủy thêm mới";
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(458, 7);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 33);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Lưu xuống";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Location = new System.Drawing.Point(353, 7);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 33);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Xóa bỏ";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(146, 7);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 33);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Thêm mới";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panelAuthorDetail
            // 
            this.panelAuthorDetail.Controls.Add(this.txtAuthorId);
            this.panelAuthorDetail.Controls.Add(this.txtAuthorAddress);
            this.panelAuthorDetail.Controls.Add(this.txtAuthorName);
            this.panelAuthorDetail.Controls.Add(this.labAuthorId);
            this.panelAuthorDetail.Controls.Add(this.labAuthorAddress);
            this.panelAuthorDetail.Controls.Add(this.labAuthorName);
            this.panelAuthorDetail.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAuthorDetail.Location = new System.Drawing.Point(2, 2);
            this.panelAuthorDetail.Name = "panelAuthorDetail";
            this.panelAuthorDetail.Size = new System.Drawing.Size(531, 74);
            this.panelAuthorDetail.TabIndex = 1;
            // 
            // txtAuthorId
            // 
            this.txtAuthorId.Location = new System.Drawing.Point(114, 10);
            this.txtAuthorId.Name = "txtAuthorId";
            this.txtAuthorId.Properties.ReadOnly = true;
            this.txtAuthorId.Size = new System.Drawing.Size(147, 20);
            this.txtAuthorId.TabIndex = 1;
            // 
            // txtAuthorAddress
            // 
            this.txtAuthorAddress.Location = new System.Drawing.Point(114, 42);
            this.txtAuthorAddress.Name = "txtAuthorAddress";
            this.txtAuthorAddress.Properties.ReadOnly = true;
            this.txtAuthorAddress.Size = new System.Drawing.Size(393, 20);
            this.txtAuthorAddress.TabIndex = 1;
            this.txtAuthorAddress.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAuthorName_KeyPress);
            // 
            // txtAuthorName
            // 
            this.txtAuthorName.Location = new System.Drawing.Point(369, 10);
            this.txtAuthorName.Name = "txtAuthorName";
            this.txtAuthorName.Properties.ReadOnly = true;
            this.txtAuthorName.Size = new System.Drawing.Size(138, 20);
            this.txtAuthorName.TabIndex = 0;
            this.txtAuthorName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAuthorName_KeyPress);
            // 
            // labAuthorId
            // 
            this.labAuthorId.Location = new System.Drawing.Point(24, 13);
            this.labAuthorId.Name = "labAuthorId";
            this.labAuthorId.Size = new System.Drawing.Size(53, 13);
            this.labAuthorId.TabIndex = 0;
            this.labAuthorId.Text = "Mã tác giả:";
            // 
            // labAuthorAddress
            // 
            this.labAuthorAddress.Location = new System.Drawing.Point(24, 45);
            this.labAuthorAddress.Name = "labAuthorAddress";
            this.labAuthorAddress.Size = new System.Drawing.Size(36, 13);
            this.labAuthorAddress.TabIndex = 0;
            this.labAuthorAddress.Text = "Địa chỉ:";
            // 
            // labAuthorName
            // 
            this.labAuthorName.Location = new System.Drawing.Point(289, 13);
            this.labAuthorName.Name = "labAuthorName";
            this.labAuthorName.Size = new System.Drawing.Size(57, 13);
            this.labAuthorName.TabIndex = 0;
            this.labAuthorName.Text = "Tên tác giả:";
            // 
            // grdListAuthor
            // 
            this.grdListAuthor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdListAuthor.Location = new System.Drawing.Point(2, 76);
            this.grdListAuthor.MainView = this.grdvListAuthor;
            this.grdListAuthor.Name = "grdListAuthor";
            this.grdListAuthor.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rtxtAuthorId,
            this.rtxtAuthorName,
            this.rtxtAuthorAddress});
            this.grdListAuthor.Size = new System.Drawing.Size(531, 242);
            this.grdListAuthor.TabIndex = 0;
            this.grdListAuthor.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdvListAuthor});
            // 
            // grdvListAuthor
            // 
            this.grdvListAuthor.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.AuthorSno,
            this.AuthorId,
            this.AuthorName,
            this.AuthorAddress});
            this.grdvListAuthor.GridControl = this.grdListAuthor;
            this.grdvListAuthor.Name = "grdvListAuthor";
            this.grdvListAuthor.OptionsView.ShowGroupPanel = false;
            this.grdvListAuthor.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.grdvListAuthor_FocusedRowChanged);
            // 
            // AuthorSno
            // 
            this.AuthorSno.AppearanceCell.Options.UseTextOptions = true;
            this.AuthorSno.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.AuthorSno.Caption = "STT";
            this.AuthorSno.FieldName = "STT";
            this.AuthorSno.Name = "AuthorSno";
            this.AuthorSno.Visible = true;
            this.AuthorSno.VisibleIndex = 0;
            this.AuthorSno.Width = 40;
            // 
            // AuthorId
            // 
            this.AuthorId.Caption = "Mã tác giả";
            this.AuthorId.ColumnEdit = this.rtxtAuthorId;
            this.AuthorId.FieldName = "MaTG";
            this.AuthorId.Name = "AuthorId";
            this.AuthorId.Visible = true;
            this.AuthorId.VisibleIndex = 1;
            this.AuthorId.Width = 337;
            // 
            // rtxtAuthorId
            // 
            this.rtxtAuthorId.AutoHeight = false;
            this.rtxtAuthorId.Name = "rtxtAuthorId";
            this.rtxtAuthorId.ReadOnly = true;
            // 
            // AuthorName
            // 
            this.AuthorName.Caption = "Tên tác giả";
            this.AuthorName.ColumnEdit = this.rtxtAuthorName;
            this.AuthorName.FieldName = "TenTG";
            this.AuthorName.Name = "AuthorName";
            this.AuthorName.Visible = true;
            this.AuthorName.VisibleIndex = 2;
            this.AuthorName.Width = 337;
            // 
            // rtxtAuthorName
            // 
            this.rtxtAuthorName.AutoHeight = false;
            this.rtxtAuthorName.Name = "rtxtAuthorName";
            this.rtxtAuthorName.ReadOnly = true;
            // 
            // AuthorAddress
            // 
            this.AuthorAddress.Caption = "Địa chỉ";
            this.AuthorAddress.ColumnEdit = this.rtxtAuthorAddress;
            this.AuthorAddress.FieldName = "DiaChi";
            this.AuthorAddress.Name = "AuthorAddress";
            this.AuthorAddress.Visible = true;
            this.AuthorAddress.VisibleIndex = 3;
            this.AuthorAddress.Width = 342;
            // 
            // rtxtAuthorAddress
            // 
            this.rtxtAuthorAddress.AutoHeight = false;
            this.rtxtAuthorAddress.Name = "rtxtAuthorAddress";
            this.rtxtAuthorAddress.ReadOnly = true;
            // 
            // panelAuthorTitle
            // 
            this.panelAuthorTitle.Controls.Add(this.labAuthorTitle);
            this.panelAuthorTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAuthorTitle.Location = new System.Drawing.Point(0, 0);
            this.panelAuthorTitle.Name = "panelAuthorTitle";
            this.panelAuthorTitle.Size = new System.Drawing.Size(760, 43);
            this.panelAuthorTitle.TabIndex = 2;
            // 
            // labAuthorTitle
            // 
            this.labAuthorTitle.Appearance.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.labAuthorTitle.Appearance.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.labAuthorTitle.Location = new System.Drawing.Point(252, 7);
            this.labAuthorTitle.Name = "labAuthorTitle";
            this.labAuthorTitle.Size = new System.Drawing.Size(244, 32);
            this.labAuthorTitle.TabIndex = 1;
            this.labAuthorTitle.Text = "DANH SÁCH TÁC GIẢ";
            // 
            // navBarAuthorLookAt
            // 
            this.navBarAuthorLookAt.ActiveGroup = this.navBarGAuthorLookAt;
            this.navBarAuthorLookAt.Controls.Add(this.navBarGroupControlContainer1);
            this.navBarAuthorLookAt.Dock = System.Windows.Forms.DockStyle.Right;
            this.navBarAuthorLookAt.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGAuthorLookAt});
            this.navBarAuthorLookAt.Location = new System.Drawing.Point(533, 2);
            this.navBarAuthorLookAt.Name = "navBarAuthorLookAt";
            this.navBarAuthorLookAt.OptionsNavPane.ExpandedWidth = 225;
            this.navBarAuthorLookAt.PaintStyleKind = DevExpress.XtraNavBar.NavBarViewKind.NavigationPane;
            this.navBarAuthorLookAt.Size = new System.Drawing.Size(225, 316);
            this.navBarAuthorLookAt.TabIndex = 0;
            this.navBarAuthorLookAt.Text = "navBarControl1";
            // 
            // navBarGAuthorLookAt
            // 
            this.navBarGAuthorLookAt.Caption = "Tìm nhanh";
            this.navBarGAuthorLookAt.ControlContainer = this.navBarGroupControlContainer1;
            this.navBarGAuthorLookAt.Expanded = true;
            this.navBarGAuthorLookAt.GroupClientHeight = 80;
            this.navBarGAuthorLookAt.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.ControlContainer;
            this.navBarGAuthorLookAt.Name = "navBarGAuthorLookAt";
            // 
            // navBarGroupControlContainer1
            // 
            this.navBarGroupControlContainer1.Controls.Add(this.txtAuthorNameLA);
            this.navBarGroupControlContainer1.Controls.Add(this.labAuthorNameLA);
            this.navBarGroupControlContainer1.Name = "navBarGroupControlContainer1";
            this.navBarGroupControlContainer1.Size = new System.Drawing.Size(225, 213);
            this.navBarGroupControlContainer1.TabIndex = 0;
            // 
            // txtAuthorNameLA
            // 
            this.txtAuthorNameLA.Location = new System.Drawing.Point(77, 37);
            this.txtAuthorNameLA.Name = "txtAuthorNameLA";
            this.txtAuthorNameLA.Size = new System.Drawing.Size(138, 20);
            this.txtAuthorNameLA.TabIndex = 2;
            this.txtAuthorNameLA.TextChanged += new System.EventHandler(this.txtAuthorNameLA_TextChanged);
            // 
            // labAuthorNameLA
            // 
            this.labAuthorNameLA.Location = new System.Drawing.Point(19, 18);
            this.labAuthorNameLA.Name = "labAuthorNameLA";
            this.labAuthorNameLA.Size = new System.Drawing.Size(57, 13);
            this.labAuthorNameLA.TabIndex = 1;
            this.labAuthorNameLA.Text = "Tên tác giả:";
            // 
            // panelAuthorView
            // 
            this.panelAuthorView.Controls.Add(this.grdListAuthor);
            this.panelAuthorView.Controls.Add(this.panelAuthorDetail);
            this.panelAuthorView.Controls.Add(this.navBarAuthorLookAt);
            this.panelAuthorView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAuthorView.Location = new System.Drawing.Point(0, 43);
            this.panelAuthorView.Name = "panelAuthorView";
            this.panelAuthorView.Size = new System.Drawing.Size(760, 320);
            this.panelAuthorView.TabIndex = 4;
            // 
            // frmAuthor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 417);
            this.Controls.Add(this.panelAuthorView);
            this.Controls.Add(this.panelAuthorTitle);
            this.Controls.Add(this.panelAuthorExecute);
            this.Name = "frmAuthor";
            this.Text = "Quản lý tác giả";
            this.Load += new System.EventHandler(this.frmAuthor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelAuthorExecute)).EndInit();
            this.panelAuthorExecute.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelAuthorDetail)).EndInit();
            this.panelAuthorDetail.ResumeLayout(false);
            this.panelAuthorDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAuthorId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAuthorAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAuthorName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdListAuthor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdvListAuthor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rtxtAuthorId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rtxtAuthorName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rtxtAuthorAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelAuthorTitle)).EndInit();
            this.panelAuthorTitle.ResumeLayout(false);
            this.panelAuthorTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navBarAuthorLookAt)).EndInit();
            this.navBarAuthorLookAt.ResumeLayout(false);
            this.navBarGroupControlContainer1.ResumeLayout(false);
            this.navBarGroupControlContainer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAuthorNameLA.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelAuthorView)).EndInit();
            this.panelAuthorView.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelAuthorExecute;
        private DevExpress.XtraEditors.PanelControl panelAuthorDetail;
        private DevExpress.XtraGrid.GridControl grdListAuthor;
        private DevExpress.XtraGrid.Views.Grid.GridView grdvListAuthor;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.TextEdit txtAuthorName;
        private DevExpress.XtraEditors.LabelControl labAuthorName;
        private DevExpress.XtraGrid.Columns.GridColumn AuthorId;
        private DevExpress.XtraGrid.Columns.GridColumn AuthorName;
        private DevExpress.XtraEditors.PanelControl panelAuthorTitle;
        private DevExpress.XtraNavBar.NavBarControl navBarAuthorLookAt;
        private DevExpress.XtraNavBar.NavBarGroup navBarGAuthorLookAt;
        private DevExpress.XtraEditors.PanelControl panelAuthorView;
        private DevExpress.XtraEditors.TextEdit txtAuthorId;
        private DevExpress.XtraEditors.TextEdit txtAuthorAddress;
        private DevExpress.XtraEditors.LabelControl labAuthorId;
        private DevExpress.XtraEditors.LabelControl labAuthorAddress;
        private DevExpress.XtraEditors.LabelControl labAuthorTitle;
        private DevExpress.XtraNavBar.NavBarGroupControlContainer navBarGroupControlContainer1;
        private DevExpress.XtraEditors.TextEdit txtAuthorNameLA;
        private DevExpress.XtraEditors.LabelControl labAuthorNameLA;
        private DevExpress.XtraGrid.Columns.GridColumn AuthorSno;
        private DevExpress.XtraGrid.Columns.GridColumn AuthorAddress;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit rtxtAuthorId;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit rtxtAuthorName;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit rtxtAuthorAddress;
        private DevExpress.XtraEditors.SimpleButton btnCacelOfUpdate;
    }
}