using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Manager_Book_Store.Data_Access_Layer;
using Manager_Book_Store.Business_Layer;
using DevExpress.XtraEditors;
using Microsoft.SqlServer.Management.Smo;
using Microsoft.SqlServer.Management.Common;
using System.IO;

namespace Manager_Book_Store.Presentation_Layer
{
    public partial class frmBackupAndRestoreDatabase : Form
    {
        private Server m_server;
        private ServerConnection m_serverCoon;
        private bool m_IsBackup;
        //
        public delegate void m_restartFormMain(object sender, FormClosedEventArgs e);
        public m_restartFormMain _restart;
       
        public frmBackupAndRestoreDatabase(bool _isBackup)
        {
            InitializeComponent();
            this.m_IsBackup = _isBackup;
        }

        private void frmBackupAndRestoreDatabase_Load(object sender, EventArgs e)
        {
            btnComplete.Visible = false;
            btnStart.Visible = true;
            labInfo.Visible = true;
            progressBar.Visible = false;
            if (m_IsBackup)
                labInfo.Text = "Bắt đầu tạo tập tin sao lưu";
            else
                labInfo.Text = "Bắt đầu phục hồi cơ sở dữ liệu";
        }

        private bool backupDatabase(String _filePath)
        {
            if (new CDataConnection().openConnection())
            {
                m_serverCoon = new ServerConnection();
                m_serverCoon.ServerInstance = CDatabase.m_ServerName;
                m_server = new Server(m_serverCoon);
                try
                {
                    Backup _backup = new Backup();
                    _backup.Action = BackupActionType.Database;
                    _backup.Database = CDatabase.m_DatabaseName;
                    _backup.Devices.AddDevice(_filePath, DeviceType.File);
                    _backup.Incremental = false;
                    _backup.PercentCompleteNotification = 10;
                    _backup.PercentComplete += new PercentCompleteEventHandler(percentComplete);
                    _backup.SqlBackup(m_server);
                    m_serverCoon.Disconnect();
                    m_serverCoon = null;
                    m_server = null;
                    //

                    return true;

                }
                catch (SmoException ex)
                {
                    //throw new SmoException(ex.Message, ex.InnerException);
                    DevExpress.XtraEditors.XtraMessageBox.Show(ex.ToString());
                    return false;
                }
                catch (IOException)
                {
                    //throw new IOException(ex.Message, ex.InnerException);
                    return false;
                }
            }
            else
            {
                return false;
            }

        }

        private bool restoreDatabase(String _filePath)
        {
            if (new CDataConnection().openConnection())
            {
                m_serverCoon = new ServerConnection();
                m_serverCoon.ServerInstance = CDatabase.m_ServerName;
                m_server = new Server(m_serverCoon);
                m_server.KillAllProcesses(CDatabase.m_DatabaseName);
                try
                {
                    Restore _restore = new Restore();

                    _restore.Devices.AddDevice(_filePath, DeviceType.File);

                    RelocateFile DataFile = new RelocateFile();
                    string MDF = _restore.ReadFileList(m_server).Rows[0][1].ToString();
                    DataFile.LogicalFileName = _restore.ReadFileList(m_server).Rows[0][0].ToString();
                    DataFile.PhysicalFileName = m_server.Databases[CDatabase.m_DatabaseName].FileGroups[0].Files[0].FileName;

                    RelocateFile LogFile = new RelocateFile();
                    string LDF = _restore.ReadFileList(m_server).Rows[1][1].ToString();
                    LogFile.LogicalFileName = _restore.ReadFileList(m_server).Rows[1][0].ToString();
                    LogFile.PhysicalFileName = m_server.Databases[CDatabase.m_DatabaseName].LogFiles[0].FileName;

                    _restore.RelocateFiles.Add(DataFile);
                    _restore.RelocateFiles.Add(LogFile);

                    _restore.Database = CDatabase.m_DatabaseName;
                    _restore.NoRecovery = false;
                    _restore.ReplaceDatabase = true;
                    _restore.PercentCompleteNotification = 10;
                    _restore.PercentComplete += new PercentCompleteEventHandler(percentComplete);
                    _restore.SqlRestore(m_server);
                    m_server.Refresh();
                    m_serverCoon.Disconnect();
                    return true;
                }
                catch (SmoException)
                {
                    //DevExpress.XtraEditors.XtraMessageBox.Show(ex.ToString());
                    // throw new SmoException(ex.Message, ex.InnerException);
                    return false;
                }
                catch (IOException)
                {
                    //throw new IOException(ex.Message, ex.InnerException);
                    return false;
                }
            }
            else
            {
                return false;
                //DevExpress.XtraEditors.XtraMessageBox.Show("Don't restore data from file");
            }
        }

        private void percentComplete(object sender, PercentCompleteEventArgs e)
        {
            this.progressBar.EditValue = e.Percent;
            if (e.Percent == 100)
            {
                btnComplete.Visible = true;
                if(m_IsBackup)
                    labInfo.Text = "Tạo tập tin sao lưu thành công!";
                else
                    labInfo.Text = "Phục hồi dữ thành công!";
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            labInfo.Text = "Vui lòng đợi trong giây lát!";
            btnStart.Visible = false;
            labInfo.Visible = true;
            progressBar.Visible = true;
            if (m_IsBackup)
            {
                saveFileBackupData.Filter = "Backup files(*.BAK)|*.BAK|All files(*.*)|(*.*)";
                saveFileBackupData.ShowDialog();
                if (!String.IsNullOrEmpty(saveFileBackupData.FileName) && !String.IsNullOrWhiteSpace(saveFileBackupData.FileName))
                {
                    if (File.Exists(saveFileBackupData.FileName))
                        File.Delete(saveFileBackupData.FileName);
                    if (!backupDatabase(saveFileBackupData.FileName))
                    {
                        btnComplete.Visible = true;
                        labInfo.Text = "Sao lưu thất bại !";
                    }
                }
                else
                {
                    btnComplete.Visible = true;
                    labInfo.Text = "Sao lưu thất bại !";
                }
            }
            else
            {
                openFileRestoreData.Filter = "Backup files(*.BAK)|*.BAK|All files(*.*)|(*.*)";
                openFileRestoreData.ShowDialog();
                if (!String.IsNullOrEmpty(openFileRestoreData.FileName) && !String.IsNullOrWhiteSpace(openFileRestoreData.FileName))
                {
                    if (!restoreDatabase(openFileRestoreData.FileName))
                    {
                        btnComplete.Visible = true;
                        labInfo.Text = "Phục hồi dữ liệu thất bại !";
                    }
                    else
                    {
                        labInfo.Text = "Chương trình sẽ được\nkhởi động lại sau 10 giây";
                        labInfo.Refresh();
                        progressBar.Visible = false;
                        picClose.Enabled = false;
                        System.Threading.Thread.Sleep(10000);
                        _restart(null, null);
                    }
                }
                else
                {
                    btnComplete.Visible = true;
                    labInfo.Text = "Phục hồi dữ liệu thất bại !";
                }
            }
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            //this.Dispose();
            this.Close();
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            //this.Dispose();
            this.Close();
        }
    }
}
