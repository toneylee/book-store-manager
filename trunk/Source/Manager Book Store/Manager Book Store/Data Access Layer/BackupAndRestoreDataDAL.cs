using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.SqlServer.Management.Smo;
using Microsoft.SqlServer.Management.Common;
using Microsoft.Win32;
using System.IO;

namespace Manager_Book_Store.Data_Access_Layer
{
    class CBackupAndRestoreDataDAL:CDataConnection
    {
        private Server m_server;
        private ServerConnection m_serverCoon;
        public bool BackupDatabase(String _filePath)
        {
            if (this.openConnection())
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
                    _backup.PercentComplete += new PercentCompleteEventHandler(_PercentComplete);
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

        void _PercentComplete(object sender, PercentCompleteEventArgs e)
        {
           // m_percent(e.Percent);
        }

        public bool RestoreDatabase(String _filePath)
        {
            if (this.openConnection())
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
                    _restore.PercentComplete += new PercentCompleteEventHandler(_PercentComplete);
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
    }
}
