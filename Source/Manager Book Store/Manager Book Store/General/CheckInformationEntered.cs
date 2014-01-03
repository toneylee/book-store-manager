using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Manager_Book_Store.General
{
    class CheckInformationEntered
    {
        public static void checkCharacterInput(KeyPressEventArgs _event, bool _allow)
        {
            if (_allow)
            {
                if (char.IsDigit(_event.KeyChar) || char.IsSymbol(_event.KeyChar) || char.IsPunctuation(_event.KeyChar))
                {
                    _event.Handled = true;
                    return;
                }
            }
            else
            {
                if ((char.IsLetter(_event.KeyChar) && _event.KeyChar != '.') || char.IsSymbol(_event.KeyChar) || char.IsPunctuation(_event.KeyChar))
                {
                    _event.Handled = true;
                    return;
                }
            }
        }
        public static bool checkDataInput(Control _control, String _erroContent, ref DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider _dxErroControl)
        {
            if (String.IsNullOrEmpty(_control.Text) || String.IsNullOrWhiteSpace(_control.Text))
            {
                _dxErroControl.SetError(_control, _erroContent);
                return false;
            }
            else
            {
                _dxErroControl.ClearErrors();
                return true;
            }
        }
    }
}
