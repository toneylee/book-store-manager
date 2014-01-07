using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.SqlServer.Management.Smo;
using Microsoft.SqlServer.Management.Common;
using Microsoft.Win32;
using System.IO;
using Manager_Book_Store.Data_Access_Layer;
using DevExpress.XtraEditors;

namespace Manager_Book_Store.Business_Layer
{
    class CBackupAndRestoreDataBUS
    {
        private CBackupAndRestoreDataDAL m_backupAndRestore;
        public CBackupAndRestoreDataBUS()
        {
           m_backupAndRestore = new CBackupAndRestoreDataDAL();
        }
        public bool BackupDatabase(String _filePath)
        {
            return m_backupAndRestore.BackupDatabase(_filePath);
        }
        public bool RestoreDatabase(String _filePath)
        {
            return m_backupAndRestore.RestoreDatabase(_filePath);
        }
    }
}
