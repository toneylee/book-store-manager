namespace Manager_Book_Store.Presentation_Layer
{
    partial class frmBackupAndRestoreDatabase
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
            this.saveFileBackupData = new System.Windows.Forms.SaveFileDialog();
            this.openFileRestoreData = new System.Windows.Forms.OpenFileDialog();
            this.progressBar = new DevExpress.XtraEditors.ProgressBarControl();
            this.labInfo = new DevExpress.XtraEditors.LabelControl();
            this.btnStart = new DevExpress.XtraEditors.SimpleButton();
            this.btnComplete = new DevExpress.XtraEditors.SimpleButton();
            this.picClose = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileRestoreData
            // 
            this.openFileRestoreData.FileName = "openFileDialog1";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(42, 45);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(174, 18);
            this.progressBar.TabIndex = 0;
            // 
            // labInfo
            // 
            this.labInfo.Appearance.ForeColor = System.Drawing.Color.SteelBlue;
            this.labInfo.Location = new System.Drawing.Point(34, 22);
            this.labInfo.Name = "labInfo";
            this.labInfo.Size = new System.Drawing.Size(121, 13);
            this.labInfo.TabIndex = 1;
            this.labInfo.Text = "Vui lòng đợi trong giây lát\r\n";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(82, 54);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Bắt đầu";
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnComplete
            // 
            this.btnComplete.Location = new System.Drawing.Point(82, 74);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(93, 23);
            this.btnComplete.TabIndex = 2;
            this.btnComplete.Text = "Hoàn thành";
            this.btnComplete.Click += new System.EventHandler(this.btnComplete_Click);
            // 
            // picClose
            // 
            this.picClose.EditValue = global::Manager_Book_Store.Properties.Resources.close;
            this.picClose.Location = new System.Drawing.Point(236, -1);
            this.picClose.Name = "picClose";
            this.picClose.Properties.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.picClose.Properties.Appearance.Options.UseBackColor = true;
            this.picClose.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.picClose.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.picClose.Size = new System.Drawing.Size(25, 21);
            this.picClose.TabIndex = 3;
            this.picClose.Click += new System.EventHandler(this.picClose_Click);
            // 
            // frmBackupAndRestoreDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 114);
            this.ControlBox = false;
            this.Controls.Add(this.picClose);
            this.Controls.Add(this.btnComplete);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.labInfo);
            this.Controls.Add(this.progressBar);
            this.Name = "frmBackupAndRestoreDatabase";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.frmBackupAndRestoreDatabase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.progressBar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SaveFileDialog saveFileBackupData;
        private System.Windows.Forms.OpenFileDialog openFileRestoreData;
        private DevExpress.XtraEditors.ProgressBarControl progressBar;
        private DevExpress.XtraEditors.LabelControl labInfo;
        private DevExpress.XtraEditors.SimpleButton btnStart;
        private DevExpress.XtraEditors.SimpleButton btnComplete;
        private DevExpress.XtraEditors.PictureEdit picClose;
    }
}