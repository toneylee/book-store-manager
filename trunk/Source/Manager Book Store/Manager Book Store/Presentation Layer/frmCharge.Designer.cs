namespace Manager_Book_Store.Presentation_Layer
{
    partial class frmCharge
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
            this.panelChargeTitle = new DevExpress.XtraEditors.PanelControl();
            this.labChargeTitle = new DevExpress.XtraEditors.LabelControl();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.panelChargeExecute = new DevExpress.XtraEditors.PanelControl();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.panelChargeView = new DevExpress.XtraEditors.PanelControl();
            this.grdListCharge = new DevExpress.XtraGrid.GridControl();
            this.grdvListCharge = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ChargeSNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ChargeId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rtxtChargeId = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.ChargeName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rtxtChargeName = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.panelChargeDetail = new DevExpress.XtraEditors.PanelControl();
            this.labChargeId = new DevExpress.XtraEditors.LabelControl();
            this.labBookGenreName = new DevExpress.XtraEditors.LabelControl();
            this.txtChargeId = new DevExpress.XtraEditors.TextEdit();
            this.txtChargeName = new DevExpress.XtraEditors.TextEdit();
            this.navBarChargeLookAt = new DevExpress.XtraNavBar.NavBarControl();
            this.nvarBarGChargeLookAt = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarGroupControlContainer = new DevExpress.XtraNavBar.NavBarGroupControlContainer();
            this.txtChargeNameLA = new DevExpress.XtraEditors.TextEdit();
            this.labChargeNameLA = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelChargeTitle)).BeginInit();
            this.panelChargeTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelChargeExecute)).BeginInit();
            this.panelChargeExecute.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelChargeView)).BeginInit();
            this.panelChargeView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdListCharge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdvListCharge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rtxtChargeId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rtxtChargeName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelChargeDetail)).BeginInit();
            this.panelChargeDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtChargeId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtChargeName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarChargeLookAt)).BeginInit();
            this.navBarChargeLookAt.SuspendLayout();
            this.navBarGroupControlContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtChargeNameLA.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelChargeTitle
            // 
            this.panelChargeTitle.Controls.Add(this.labChargeTitle);
            this.panelChargeTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelChargeTitle.Location = new System.Drawing.Point(0, 0);
            this.panelChargeTitle.Name = "panelChargeTitle";
            this.panelChargeTitle.Size = new System.Drawing.Size(864, 39);
            this.panelChargeTitle.TabIndex = 9;
            // 
            // labChargeTitle
            // 
            this.labChargeTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labChargeTitle.Appearance.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.labChargeTitle.Appearance.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.labChargeTitle.Location = new System.Drawing.Point(286, 3);
            this.labChargeTitle.Name = "labChargeTitle";
            this.labChargeTitle.Size = new System.Drawing.Size(256, 32);
            this.labChargeTitle.TabIndex = 0;
            this.labChargeTitle.Text = "DANH SÁCH CHỨC VỤ";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.Location = new System.Drawing.Point(355, 12);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 31);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(231, 12);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(92, 31);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Hủy thêm mới";
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(570, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 31);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Lưu xuống";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panelChargeExecute
            // 
            this.panelChargeExecute.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelChargeExecute.Controls.Add(this.btnUpdate);
            this.panelChargeExecute.Controls.Add(this.btnSave);
            this.panelChargeExecute.Controls.Add(this.btnCancel);
            this.panelChargeExecute.Controls.Add(this.btnAdd);
            this.panelChargeExecute.Controls.Add(this.btnDelete);
            this.panelChargeExecute.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelChargeExecute.Location = new System.Drawing.Point(0, 362);
            this.panelChargeExecute.Name = "panelChargeExecute";
            this.panelChargeExecute.Size = new System.Drawing.Size(864, 55);
            this.panelChargeExecute.TabIndex = 7;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(248, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 31);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Thêm mới";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Location = new System.Drawing.Point(467, 12);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 31);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Xóa bỏ";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // panelChargeView
            // 
            this.panelChargeView.AllowDrop = true;
            this.panelChargeView.AllowTouchScroll = true;
            this.panelChargeView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelChargeView.Controls.Add(this.grdListCharge);
            this.panelChargeView.Controls.Add(this.panelChargeDetail);
            this.panelChargeView.Controls.Add(this.navBarChargeLookAt);
            this.panelChargeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChargeView.FireScrollEventOnMouseWheel = true;
            this.panelChargeView.Location = new System.Drawing.Point(0, 39);
            this.panelChargeView.Name = "panelChargeView";
            this.panelChargeView.Size = new System.Drawing.Size(864, 323);
            this.panelChargeView.TabIndex = 10;
            // 
            // grdListCharge
            // 
            this.grdListCharge.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdListCharge.Location = new System.Drawing.Point(0, 36);
            this.grdListCharge.MainView = this.grdvListCharge;
            this.grdListCharge.Name = "grdListCharge";
            this.grdListCharge.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rtxtChargeName,
            this.rtxtChargeId});
            this.grdListCharge.Size = new System.Drawing.Size(645, 287);
            this.grdListCharge.TabIndex = 1;
            this.grdListCharge.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdvListCharge});
            // 
            // grdvListCharge
            // 
            this.grdvListCharge.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ChargeSNo,
            this.ChargeId,
            this.ChargeName});
            this.grdvListCharge.GridControl = this.grdListCharge;
            this.grdvListCharge.Name = "grdvListCharge";
            this.grdvListCharge.OptionsView.ShowGroupPanel = false;
            this.grdvListCharge.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.grdvListCharge_FocusedRowChanged);
            // 
            // ChargeSNo
            // 
            this.ChargeSNo.Caption = "STT";
            this.ChargeSNo.FieldName = "STT";
            this.ChargeSNo.Name = "ChargeSNo";
            this.ChargeSNo.Visible = true;
            this.ChargeSNo.VisibleIndex = 0;
            this.ChargeSNo.Width = 42;
            // 
            // ChargeId
            // 
            this.ChargeId.Caption = "Mã chức vụ";
            this.ChargeId.ColumnEdit = this.rtxtChargeId;
            this.ChargeId.FieldName = "MaCV";
            this.ChargeId.Name = "ChargeId";
            this.ChargeId.Visible = true;
            this.ChargeId.VisibleIndex = 1;
            this.ChargeId.Width = 505;
            // 
            // rtxtChargeId
            // 
            this.rtxtChargeId.AutoHeight = false;
            this.rtxtChargeId.Name = "rtxtChargeId";
            this.rtxtChargeId.ReadOnly = true;
            // 
            // ChargeName
            // 
            this.ChargeName.Caption = "Tên chức vụ";
            this.ChargeName.ColumnEdit = this.rtxtChargeName;
            this.ChargeName.FieldName = "TenCV";
            this.ChargeName.Name = "ChargeName";
            this.ChargeName.Visible = true;
            this.ChargeName.VisibleIndex = 2;
            this.ChargeName.Width = 508;
            // 
            // rtxtChargeName
            // 
            this.rtxtChargeName.AutoHeight = false;
            this.rtxtChargeName.Name = "rtxtChargeName";
            this.rtxtChargeName.ReadOnly = true;
            // 
            // panelChargeDetail
            // 
            this.panelChargeDetail.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelChargeDetail.Controls.Add(this.labChargeId);
            this.panelChargeDetail.Controls.Add(this.labBookGenreName);
            this.panelChargeDetail.Controls.Add(this.txtChargeId);
            this.panelChargeDetail.Controls.Add(this.txtChargeName);
            this.panelChargeDetail.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelChargeDetail.Location = new System.Drawing.Point(0, 0);
            this.panelChargeDetail.Name = "panelChargeDetail";
            this.panelChargeDetail.Size = new System.Drawing.Size(645, 36);
            this.panelChargeDetail.TabIndex = 6;
            // 
            // labChargeId
            // 
            this.labChargeId.Location = new System.Drawing.Point(22, 9);
            this.labChargeId.Name = "labChargeId";
            this.labChargeId.Size = new System.Drawing.Size(59, 13);
            this.labChargeId.TabIndex = 4;
            this.labChargeId.Text = "Mã chức vụ:";
            // 
            // labBookGenreName
            // 
            this.labBookGenreName.Location = new System.Drawing.Point(312, 9);
            this.labBookGenreName.Name = "labBookGenreName";
            this.labBookGenreName.Size = new System.Drawing.Size(63, 13);
            this.labBookGenreName.TabIndex = 2;
            this.labBookGenreName.Text = "Tên chức vụ:";
            // 
            // txtChargeId
            // 
            this.txtChargeId.Location = new System.Drawing.Point(112, 6);
            this.txtChargeId.Name = "txtChargeId";
            this.txtChargeId.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtChargeId.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.txtChargeId.Properties.ReadOnly = true;
            this.txtChargeId.Size = new System.Drawing.Size(179, 20);
            this.txtChargeId.TabIndex = 5;
            // 
            // txtChargeName
            // 
            this.txtChargeName.Location = new System.Drawing.Point(426, 6);
            this.txtChargeName.Name = "txtChargeName";
            this.txtChargeName.Size = new System.Drawing.Size(184, 20);
            this.txtChargeName.TabIndex = 3;
            // 
            // navBarChargeLookAt
            // 
            this.navBarChargeLookAt.ActiveGroup = this.nvarBarGChargeLookAt;
            this.navBarChargeLookAt.Controls.Add(this.navBarGroupControlContainer);
            this.navBarChargeLookAt.Dock = System.Windows.Forms.DockStyle.Right;
            this.navBarChargeLookAt.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.nvarBarGChargeLookAt});
            this.navBarChargeLookAt.Location = new System.Drawing.Point(645, 0);
            this.navBarChargeLookAt.Name = "navBarChargeLookAt";
            this.navBarChargeLookAt.OptionsNavPane.ExpandedWidth = 219;
            this.navBarChargeLookAt.PaintStyleKind = DevExpress.XtraNavBar.NavBarViewKind.NavigationPane;
            this.navBarChargeLookAt.ShowGroupHint = false;
            this.navBarChargeLookAt.ShowLinkHint = false;
            this.navBarChargeLookAt.Size = new System.Drawing.Size(219, 323);
            this.navBarChargeLookAt.TabIndex = 7;
            this.navBarChargeLookAt.Text = "navBarControl1";
            // 
            // nvarBarGChargeLookAt
            // 
            this.nvarBarGChargeLookAt.Caption = "Tìm nhanh";
            this.nvarBarGChargeLookAt.ControlContainer = this.navBarGroupControlContainer;
            this.nvarBarGChargeLookAt.Expanded = true;
            this.nvarBarGChargeLookAt.GroupClientHeight = 80;
            this.nvarBarGChargeLookAt.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.ControlContainer;
            this.nvarBarGChargeLookAt.Name = "nvarBarGChargeLookAt";
            // 
            // navBarGroupControlContainer
            // 
            this.navBarGroupControlContainer.Controls.Add(this.txtChargeNameLA);
            this.navBarGroupControlContainer.Controls.Add(this.labChargeNameLA);
            this.navBarGroupControlContainer.Name = "navBarGroupControlContainer";
            this.navBarGroupControlContainer.Size = new System.Drawing.Size(219, 220);
            this.navBarGroupControlContainer.TabIndex = 0;
            // 
            // txtChargeNameLA
            // 
            this.txtChargeNameLA.Location = new System.Drawing.Point(43, 34);
            this.txtChargeNameLA.Name = "txtChargeNameLA";
            this.txtChargeNameLA.Size = new System.Drawing.Size(153, 20);
            this.txtChargeNameLA.TabIndex = 3;
            this.txtChargeNameLA.TextChanged += new System.EventHandler(this.txtChargeNameLA_TextChanged);
            // 
            // labChargeNameLA
            // 
            this.labChargeNameLA.Location = new System.Drawing.Point(6, 15);
            this.labChargeNameLA.Name = "labChargeNameLA";
            this.labChargeNameLA.Size = new System.Drawing.Size(85, 13);
            this.labChargeNameLA.TabIndex = 2;
            this.labChargeNameLA.Text = "Nhập tên chức vụ";
            // 
            // frmCharge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 417);
            this.Controls.Add(this.panelChargeView);
            this.Controls.Add(this.panelChargeTitle);
            this.Controls.Add(this.panelChargeExecute);
            this.Name = "frmCharge";
            this.Text = "Quản lý chức vụ";
            this.Load += new System.EventHandler(this.frmForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelChargeTitle)).EndInit();
            this.panelChargeTitle.ResumeLayout(false);
            this.panelChargeTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelChargeExecute)).EndInit();
            this.panelChargeExecute.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelChargeView)).EndInit();
            this.panelChargeView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdListCharge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdvListCharge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rtxtChargeId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rtxtChargeName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelChargeDetail)).EndInit();
            this.panelChargeDetail.ResumeLayout(false);
            this.panelChargeDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtChargeId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtChargeName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarChargeLookAt)).EndInit();
            this.navBarChargeLookAt.ResumeLayout(false);
            this.navBarGroupControlContainer.ResumeLayout(false);
            this.navBarGroupControlContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtChargeNameLA.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelChargeTitle;
        private DevExpress.XtraEditors.LabelControl labChargeTitle;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.PanelControl panelChargeExecute;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.PanelControl panelChargeView;
        private DevExpress.XtraGrid.GridControl grdListCharge;
        private DevExpress.XtraGrid.Views.Grid.GridView grdvListCharge;
        private DevExpress.XtraGrid.Columns.GridColumn ChargeSNo;
        private DevExpress.XtraGrid.Columns.GridColumn ChargeId;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit rtxtChargeId;
        private DevExpress.XtraGrid.Columns.GridColumn ChargeName;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit rtxtChargeName;
        private DevExpress.XtraEditors.PanelControl panelChargeDetail;
        private DevExpress.XtraEditors.LabelControl labChargeId;
        private DevExpress.XtraEditors.LabelControl labBookGenreName;
        private DevExpress.XtraEditors.TextEdit txtChargeId;
        private DevExpress.XtraEditors.TextEdit txtChargeName;
        private DevExpress.XtraNavBar.NavBarControl navBarChargeLookAt;
        private DevExpress.XtraNavBar.NavBarGroup nvarBarGChargeLookAt;
        private DevExpress.XtraNavBar.NavBarGroupControlContainer navBarGroupControlContainer;
        private DevExpress.XtraEditors.TextEdit txtChargeNameLA;
        private DevExpress.XtraEditors.LabelControl labChargeNameLA;
    }
}