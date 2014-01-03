namespace Manager_Book_Store.Presentation_Layer
{
    partial class ucLogin
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtUser = new DevExpress.XtraEditors.TextEdit();
            this.txtpass = new DevExpress.XtraEditors.TextEdit();
            this.labUser = new DevExpress.XtraEditors.LabelControl();
            this.labPass = new DevExpress.XtraEditors.LabelControl();
            this.btnOk = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.picUser = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUser.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtpass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUser.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUser
            // 
            this.txtUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUser.Location = new System.Drawing.Point(270, 192);
            this.txtUser.Name = "txtUser";
            this.txtUser.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtUser.Properties.Appearance.Options.UseFont = true;
            this.txtUser.Properties.NullText = "ThanhTrang";
            this.txtUser.Size = new System.Drawing.Size(215, 22);
            this.txtUser.TabIndex = 0;
            // 
            // txtpass
            // 
            this.txtpass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtpass.Location = new System.Drawing.Point(270, 232);
            this.txtpass.Name = "txtpass";
            this.txtpass.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtpass.Properties.Appearance.Options.UseFont = true;
            this.txtpass.Properties.NullText = "thanhtrang";
            this.txtpass.Properties.UseSystemPasswordChar = true;
            this.txtpass.Size = new System.Drawing.Size(216, 22);
            this.txtpass.TabIndex = 1;
            // 
            // labUser
            // 
            this.labUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labUser.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labUser.Location = new System.Drawing.Point(175, 195);
            this.labUser.Name = "labUser";
            this.labUser.Size = new System.Drawing.Size(84, 14);
            this.labUser.TabIndex = 2;
            this.labUser.Text = "Tên đăng nhập";
            // 
            // labPass
            // 
            this.labPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labPass.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labPass.Location = new System.Drawing.Point(175, 235);
            this.labPass.Name = "labPass";
            this.labPass.Size = new System.Drawing.Size(50, 14);
            this.labPass.TabIndex = 2;
            this.labPass.Text = "Mật khẩu";
            // 
            // btnOk
            // 
            this.btnOk.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOk.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnOk.Appearance.Options.UseFont = true;
            this.btnOk.Location = new System.Drawing.Point(317, 290);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "Đăng nhập";
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnCancel.Appearance.Options.UseFont = true;
            this.btnCancel.Location = new System.Drawing.Point(407, 290);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Hủy ";
            // 
            // picUser
            // 
            this.picUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picUser.EditValue = global::Manager_Book_Store.Properties.Resources.Users;
            this.picUser.Location = new System.Drawing.Point(180, 44);
            this.picUser.Name = "picUser";
            this.picUser.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            this.picUser.Properties.Appearance.Image = global::Manager_Book_Store.Properties.Resources.bg3;
            this.picUser.Properties.Appearance.Options.UseBackColor = true;
            this.picUser.Properties.Appearance.Options.UseImage = true;
            this.picUser.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.picUser.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.picUser.Size = new System.Drawing.Size(201, 138);
            this.picUser.TabIndex = 3;
            // 
            // frmLogin
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.picUser);
            this.Controls.Add(this.labPass);
            this.Controls.Add(this.labUser);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.txtUser);
            this.DoubleBuffered = true;
            this.Name = "frmLogin";
            this.Size = new System.Drawing.Size(687, 447);
            ((System.ComponentModel.ISupportInitialize)(this.txtUser.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtpass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUser.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtUser;
        private DevExpress.XtraEditors.TextEdit txtpass;
        private DevExpress.XtraEditors.LabelControl labUser;
        private DevExpress.XtraEditors.LabelControl labPass;
        private DevExpress.XtraEditors.PictureEdit picUser;
        private DevExpress.XtraEditors.SimpleButton btnOk;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
    }
}
