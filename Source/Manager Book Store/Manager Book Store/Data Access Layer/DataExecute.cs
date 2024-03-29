﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Manager_Book_Store.Data_Access_Layer
{
    class CDataExecute : CDataConnection
    {
        #region "variable"
        private SqlDataAdapter m_sqlDataAdapter;
        private DataTable m_dataResult;
        private SqlTransaction m_sqlTransaction;
        //private SqlCommandBuilder   m_sqlCommandBuilder;
        #endregion
        #region "method"
        public CDataExecute()
        {
            do 
            {
                if (!this.openConnection())
                {

                    DevExpress.XtraEditors.XtraMessageBox.Show("Lỗi kết nối đến cơ sở dữ liệu !\nXin vui lòng thiết lập lại kết nối...", "Thông báo");
                    Manager_Book_Store.Presentation_Layer.frmConnectionSQL _frmConnectionSQL = new Manager_Book_Store.Presentation_Layer.frmConnectionSQL();
                    _frmConnectionSQL.ShowDialog();
                }
            } while (!this.openConnection());

            this.m_sqlDataAdapter = new SqlDataAdapter();
            this.m_dataResult = new DataTable();
            this.m_sqlTransaction = null;
            //this.m_sqlCommandBuilder    = null;
        }
        public DataTable getData(SqlCommand _sqlCommand)
        {
            if (this.openConnection())
            {
                try
                {
                    this.m_cmd = _sqlCommand;
                    this.m_cmd.Connection = this.m_conn;
                    this.m_sqlDataAdapter.SelectCommand = this.m_cmd;
                    this.m_dataResult.Clear();
                    this.m_dataResult.AcceptChanges();
                    this.m_sqlDataAdapter.Fill(m_dataResult);
                }
                catch (SqlException e)
                {
                    this.m_dataResult = null;
                    DevExpress.XtraEditors.XtraMessageBox.Show(e.ToString());
                }
                finally
                {
                    this.closeConnection();
                }

            }
            if (m_dataResult.Rows.Count != 0)
                return AutoNumberedTable(m_dataResult);
            else
                return m_dataResult;
        }
        private DataTable AutoNumberedTable(DataTable SourceTable)
        {

            DataTable ResultTable = new DataTable();
            DataColumn AutoNumberColumn = new DataColumn();
            AutoNumberColumn.ColumnName = "STT";
            AutoNumberColumn.DataType = typeof(int);
            AutoNumberColumn.AutoIncrement = true;
            AutoNumberColumn.AutoIncrementSeed = 1;
            AutoNumberColumn.AutoIncrementStep = 1;
            ResultTable.Columns.Add(AutoNumberColumn);
            ResultTable.PrimaryKey = new DataColumn[] { AutoNumberColumn };
            ResultTable.Merge(SourceTable);
            return ResultTable;

        }
        public String getMaxId(SqlCommand _sqlCommand)
        {
            String _maxId = "";
            if (this.openConnection())
            {
                try
                {
                    this.m_cmd = _sqlCommand;
                    this.m_cmd.Connection = this.m_conn;
                    if (this.m_cmd.ExecuteScalar() != null)
                        _maxId = this.m_cmd.ExecuteScalar().ToString();
                }
                catch (SqlException e)
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show(e.ToString());
                }
                finally
                {
                    this.closeConnection();
                }

            }
            return _maxId;
        }

        public int updateData(SqlCommand _sqlCommand)
        {
            int _countRowChange = 0;
            if (this.openConnection())
            {
                try
                {
                    this.m_cmd = _sqlCommand;
                    this.m_cmd.Connection = this.m_conn;
                    this.m_sqlTransaction = this.m_conn.BeginTransaction();
                    this.m_cmd.Transaction = this.m_sqlTransaction;
                    _countRowChange = this.m_cmd.ExecuteNonQuery();
                    this.m_dataResult.AcceptChanges();
                    this.m_sqlTransaction.Commit();
                }
                catch (SqlException)
                {
                    //DevExpress.XtraEditors.XtraMessageBox.Show(ex.ToString());
                    if (this.m_sqlTransaction != null)
                    {
                        this.m_sqlTransaction.Rollback();
                    }

                }
                finally
                {
                    this.closeConnection();
                }
            }
            return _countRowChange;
        }

        //Ham tra ve mot chuoi String co parameter
        public String getStringExecuter(SqlCommand _sqlCommand)
        {
            try
            {
                String str = null;
                if (this.openConnection())
                {
                    this.m_cmd = _sqlCommand;
                    this.m_cmd.Connection = this.m_conn;
                    str = this.m_cmd.ExecuteScalar().ToString();
                }
                return str;
            }
            catch (SqlException)
            {
                return null;
            }
        }
        //Ham tra ve mot so co parameter
        public int getIntExecuter(SqlCommand _sqlCommand)
        {
            try
            {
                int temp = 0;
                if (this.openConnection())
                {
                    this.m_cmd = _sqlCommand;
                    this.m_cmd.Connection = this.m_conn;
                    temp = int.Parse(this.m_cmd.ExecuteScalar().ToString());
                }
                return temp;
            }
            catch (SqlException)
            {
                return -1;
            }
        }
        #endregion

    }
}

