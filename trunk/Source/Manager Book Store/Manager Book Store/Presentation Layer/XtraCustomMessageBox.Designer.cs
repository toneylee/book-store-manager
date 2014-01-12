namespace Manager_Book_Store.Presentation_Layer
{
    partial class XtraCustomMessageBox
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
            this.btnAccept = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.labInfo = new DevExpress.XtraEditors.LabelControl();
            this.panelExecute = new DevExpress.XtraEditors.PanelControl();
            this.panelView = new DevExpress.XtraEditors.PanelControl();
            this.panelLine = new DevExpress.XtraEditors.PanelControl();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelExecute)).BeginInit();
            this.panelExecute.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelView)).BeginInit();
            this.panelView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelLine)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(70, 9);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(70, 24);
            this.btnAccept.TabIndex = 0;
            this.btnAccept.Text = "Có";
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(172, 9);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(71, 24);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Không";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // labInfo
            // 
            this.labInfo.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.labInfo.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Vertical;
            this.labInfo.LineVisible = true;
            this.labInfo.Location = new System.Drawing.Point(43, 23);
            this.labInfo.Name = "labInfo";
            this.labInfo.Size = new System.Drawing.Size(232, 39);
            this.labInfo.TabIndex = 1;
            this.labInfo.Text = "Nội dungnddddddddddddddddddddddddddddddddddddddddddddddddđ\r\n";
            // 
            // panelExecute
            // 
            this.panelExecute.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelExecute.Controls.Add(this.btnOK);
            this.panelExecute.Controls.Add(this.btnAccept);
            this.panelExecute.Controls.Add(this.btnCancel);
            this.panelExecute.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelExecute.Location = new System.Drawing.Point(0, 85);
            this.panelExecute.Name = "panelExecute";
            this.panelExecute.Size = new System.Drawing.Size(324, 45);
            this.panelExecute.TabIndex = 2;
            // 
            // panelView
            // 
            this.panelView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelView.Controls.Add(this.panelLine);
            this.panelView.Controls.Add(this.labInfo);
            this.panelView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelView.Location = new System.Drawing.Point(0, 0);
            this.panelView.Name = "panelView";
            this.panelView.Size = new System.Drawing.Size(324, 85);
            this.panelView.TabIndex = 1;
            // 
            // panelLine
            // 
            this.panelLine.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelLine.Location = new System.Drawing.Point(0, 83);
            this.panelLine.Name = "panelLine";
            this.panelLine.Size = new System.Drawing.Size(324, 2);
            this.panelLine.TabIndex = 2;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(121, 10);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "Vâng";
            // 
            // XtraCustomMessageBox
            // 
            this.AcceptButton = this.btnAccept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(324, 130);
            this.ControlBox = false;
            this.Controls.Add(this.panelView);
            this.Controls.Add(this.panelExecute);
            this.Name = "XtraCustomMessageBox";
            ((System.ComponentModel.ISupportInitialize)(this.panelExecute)).EndInit();
            this.panelExecute.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelView)).EndInit();
            this.panelView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelLine)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnAccept;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.LabelControl labInfo;
        private DevExpress.XtraEditors.PanelControl panelExecute;
        private DevExpress.XtraEditors.PanelControl panelView;
        private DevExpress.XtraEditors.PanelControl panelLine;
        private DevExpress.XtraEditors.SimpleButton btnOK;
    }
}