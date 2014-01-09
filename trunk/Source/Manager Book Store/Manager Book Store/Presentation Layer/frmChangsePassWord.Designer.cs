namespace Manager_Book_Store.Presentation_Layer
{
    partial class frmChangePassWord
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
            this.panelEmployeeView = new DevExpress.XtraEditors.PanelControl();
            this.panelCChangePass = new DevExpress.XtraEditors.PanelControl();
            this.btnOk = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.txtPassReplay = new DevExpress.XtraEditors.TextEdit();
            this.txtPassNew = new DevExpress.XtraEditors.TextEdit();
            this.lblPassNew = new DevExpress.XtraEditors.LabelControl();
            this.lbbPass = new DevExpress.XtraEditors.LabelControl();
            this.panEmployeeViewDatail = new DevExpress.XtraEditors.PanelControl();
            this.labPassOld = new DevExpress.XtraEditors.LabelControl();
            this.txtPassOld = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelEmployeeView)).BeginInit();
            this.panelEmployeeView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelCChangePass)).BeginInit();
            this.panelCChangePass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassReplay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassNew.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panEmployeeViewDatail)).BeginInit();
            this.panEmployeeViewDatail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassOld.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEmployeeView
            // 
            this.panelEmployeeView.Controls.Add(this.panelCChangePass);
            this.panelEmployeeView.Controls.Add(this.panEmployeeViewDatail);
            this.panelEmployeeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEmployeeView.Location = new System.Drawing.Point(0, 0);
            this.panelEmployeeView.Name = "panelEmployeeView";
            this.panelEmployeeView.Size = new System.Drawing.Size(442, 170);
            this.panelEmployeeView.TabIndex = 9;
            // 
            // panelCChangePass
            // 
            this.panelCChangePass.Controls.Add(this.btnOk);
            this.panelCChangePass.Controls.Add(this.btnCancel);
            this.panelCChangePass.Controls.Add(this.txtPassReplay);
            this.panelCChangePass.Controls.Add(this.txtPassNew);
            this.panelCChangePass.Controls.Add(this.lblPassNew);
            this.panelCChangePass.Controls.Add(this.lbbPass);
            this.panelCChangePass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCChangePass.Location = new System.Drawing.Point(2, 49);
            this.panelCChangePass.Name = "panelCChangePass";
            this.panelCChangePass.Size = new System.Drawing.Size(438, 119);
            this.panelCChangePass.TabIndex = 3;
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.Location = new System.Drawing.Point(135, 78);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 31);
            this.btnOk.TabIndex = 26;
            this.btnOk.Text = "Chấp nhận";
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(257, 78);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 31);
            this.btnCancel.TabIndex = 25;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtPassReplay
            // 
            this.txtPassReplay.Location = new System.Drawing.Point(153, 42);
            this.txtPassReplay.Name = "txtPassReplay";
            this.txtPassReplay.Properties.NullText = "mật khẩu";
            this.txtPassReplay.Properties.UseSystemPasswordChar = true;
            this.txtPassReplay.Size = new System.Drawing.Size(215, 20);
            this.txtPassReplay.TabIndex = 24;
            this.txtPassReplay.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassReplay_KeyDown);
            // 
            // txtPassNew
            // 
            this.txtPassNew.Location = new System.Drawing.Point(153, 11);
            this.txtPassNew.Name = "txtPassNew";
            this.txtPassNew.Properties.NullText = "mật khẩu";
            this.txtPassNew.Properties.UseSystemPasswordChar = true;
            this.txtPassNew.Size = new System.Drawing.Size(215, 20);
            this.txtPassNew.TabIndex = 23;
            // 
            // lblPassNew
            // 
            this.lblPassNew.Location = new System.Drawing.Point(27, 14);
            this.lblPassNew.Name = "lblPassNew";
            this.lblPassNew.Size = new System.Drawing.Size(67, 13);
            this.lblPassNew.TabIndex = 20;
            this.lblPassNew.Text = "Mật khẩu mới:";
            // 
            // lbbPass
            // 
            this.lbbPass.Location = new System.Drawing.Point(27, 49);
            this.lbbPass.Name = "lbbPass";
            this.lbbPass.Size = new System.Drawing.Size(108, 13);
            this.lbbPass.TabIndex = 19;
            this.lbbPass.Text = "Xác nhận lại mật khẩu:";
            // 
            // panEmployeeViewDatail
            // 
            this.panEmployeeViewDatail.Controls.Add(this.labPassOld);
            this.panEmployeeViewDatail.Controls.Add(this.txtPassOld);
            this.panEmployeeViewDatail.Dock = System.Windows.Forms.DockStyle.Top;
            this.panEmployeeViewDatail.Location = new System.Drawing.Point(2, 2);
            this.panEmployeeViewDatail.Name = "panEmployeeViewDatail";
            this.panEmployeeViewDatail.Size = new System.Drawing.Size(438, 47);
            this.panEmployeeViewDatail.TabIndex = 2;
            // 
            // labPassOld
            // 
            this.labPassOld.Location = new System.Drawing.Point(27, 18);
            this.labPassOld.Name = "labPassOld";
            this.labPassOld.Size = new System.Drawing.Size(62, 13);
            this.labPassOld.TabIndex = 13;
            this.labPassOld.Text = "Mật khẩu cũ:";
            // 
            // txtPassOld
            // 
            this.txtPassOld.Location = new System.Drawing.Point(153, 15);
            this.txtPassOld.Name = "txtPassOld";
            this.txtPassOld.Properties.Appearance.Options.UseFont = true;
            this.txtPassOld.Properties.UseSystemPasswordChar = true;
            this.txtPassOld.Size = new System.Drawing.Size(215, 20);
            this.txtPassOld.TabIndex = 15;
            // 
            // frmChangePassWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 170);
            this.Controls.Add(this.panelEmployeeView);
            this.Name = "frmChangePassWord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Đổi mật khẩu";
            ((System.ComponentModel.ISupportInitialize)(this.panelEmployeeView)).EndInit();
            this.panelEmployeeView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelCChangePass)).EndInit();
            this.panelCChangePass.ResumeLayout(false);
            this.panelCChangePass.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassReplay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassNew.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panEmployeeViewDatail)).EndInit();
            this.panEmployeeViewDatail.ResumeLayout(false);
            this.panEmployeeViewDatail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassOld.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelEmployeeView;
        private DevExpress.XtraEditors.PanelControl panelCChangePass;
        private DevExpress.XtraEditors.LabelControl lblPassNew;
        private DevExpress.XtraEditors.LabelControl lbbPass;
        private DevExpress.XtraEditors.TextEdit txtPassReplay;
        private DevExpress.XtraEditors.TextEdit txtPassNew;
        private DevExpress.XtraEditors.PanelControl panEmployeeViewDatail;
        private DevExpress.XtraEditors.LabelControl labPassOld;
        private DevExpress.XtraEditors.TextEdit txtPassOld;
        private DevExpress.XtraEditors.SimpleButton btnOk;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
    }
}