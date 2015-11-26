using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vidu04
{
    public partial class HanghoaForm : Form
    {
        public HanghoaForm()
        {
            InitializeComponent();
        }

        private void HanghoaForm_Load(object sender, EventArgs e)
        {
            var db = new SqlDatabase();
            nhomHanghoaBindingSource.DataSource = db.GetList<NhomHanghoa>("Select * from NhomHanghoa");
        }

        private void nhomHanghoaBindingSource_PositionChanged(object sender, EventArgs e)
        {
            var cur = nhomHanghoaBindingSource.Current as NhomHanghoa;
            if(cur != null)
            {
                var db = new SqlDatabase();
                var sql = string.Format("select * from Hanghoa where NhomHanghoaId = {0}", cur.NhomHanghoaId);
                hanghoaBindingSource.DataSource = db.GetList<Hanghoa>(sql);
            }
        }
    }
}
