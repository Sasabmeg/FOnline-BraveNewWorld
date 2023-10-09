using System;
using System.Collections.Generic;
using System.Text;

using System.Windows.Forms;

namespace TiledMapper.Forms
{
    public static class FormExtension
    {
        public static DialogResult ShowDialogCenter(this Form frm, IWin32Window parent)
        {
            frm.StartPosition = FormStartPosition.CenterParent;
            return frm.ShowDialog(parent);
        }
    }
}
