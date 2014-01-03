using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Manager_Book_Store.Data_Tranfer_Object;
using QUANLYCUAHANGSACH.Report;

namespace Manager_Book_Store.Report
{
    public partial class frmDeliveryReport : Form
    {
        public frmDeliveryReport()
        {
            InitializeComponent();
        }
        public frmDeliveryReport(DataTable _listBook, CCustomerDTO _customerObject, String _deliveryNoteId, decimal _totalAmount, decimal _totalQuantity)
        {
            InitializeComponent();
            rptDeliveryNote _rptDeliveryNote = new rptDeliveryNote();
            _rptDeliveryNote.LoadDataToReport(_customerObject.tenKhachHang,
                                              _customerObject.diaChi,
                                              _totalAmount.ToString(),
                                              _totalQuantity.ToString(),
                                              _deliveryNoteId,
                                              _customerObject.Email,
                                              _customerObject.soDienThoai);
            _rptDeliveryNote.DataSource = _listBook;
            docDeliveryNoteView.PrintingSystem = _rptDeliveryNote.PrintingSystem;
            _rptDeliveryNote.CreateDocument();
        }
    }
}
