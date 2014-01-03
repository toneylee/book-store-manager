using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Manager_Book_Store.Report
{
    public partial class frmReceiptNoteReport : Form
    {
        public frmReceiptNoteReport()
        {
            InitializeComponent();
        }
        public frmReceiptNoteReport(DataTable _listBook,String _ReceiptNoteId, decimal _totalAmount, decimal _totalQuantity)
        {
            rptReceiptNote _rptReceiptNote = new rptReceiptNote();
            InitializeComponent();
            _rptReceiptNote.LoadDataToReport(
                                              _totalAmount.ToString(),
                                              _totalQuantity.ToString(),
                                              _ReceiptNoteId);
            _rptReceiptNote.DataSource = _listBook;
            docReceiptNoteView.PrintingSystem = _rptReceiptNote.PrintingSystem;
            _rptReceiptNote.CreateDocument();
        }
    }
}
