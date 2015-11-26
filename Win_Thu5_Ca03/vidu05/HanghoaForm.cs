using DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vidu05
{
    public partial class HanghoaForm : Form
    {
        
        public HanghoaForm()
        {
            InitializeComponent();
        }

        private void HanghoaForm_Load(object sender, EventArgs e)
        {
            nhomHanghoaBindingSource.DataSource = Model.GetNhomHanghoaItems();
        }

        private void nhomHanghoaBindingSource_PositionChanged(object sender, EventArgs e)
        {
            var cur = nhomHanghoaBindingSource.Current as NhomHanghoa;
            if(cur != null)
            {
                hanghoaBindingSource.DataSource = Model.GetHanghoaItemsByNhomHanghoaId(cur.NhomHanghoaId);
            }
        }

        private void ThemButton_Click(object sender, EventArgs e)
        {
            var cur = hanghoaBindingSource.Current as Hanghoa;
            if (cur != null)
            {
                Model.InsertHanghoa(cur);
            }
        }

        private void XoaButton_Click(object sender, EventArgs e)
        {
            var cur = hanghoaBindingSource.Current as Hanghoa;
            if (cur != null)
            {
                Model.DeleteHanghoa(cur);
            }
        }
    }
}
