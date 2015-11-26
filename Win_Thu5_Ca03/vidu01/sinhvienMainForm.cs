using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vidu01
{
    public partial class sinhvienMainForm : Form
    {
        public sinhvienMainForm()
        {
            InitializeComponent();
        }
        public List<Sinhvien> data = new List<Sinhvien>();
        List<Lop> lopItems = new List<Lop>();
        private void sinhvienMainForm_Load(object sender, EventArgs e)
        {
            //lopItems.Add(new Lop() { 
            //    LopId = 1,
            //    TenLop = "cntt k37",
            //    GVCN = "A"
            //});
            //lopItems.Add(new Lop()
            //{
            //    LopId = 2,
            //    TenLop = "cntt k38",
            //    GVCN = "B"
            //});
            //lopItems.Add(new Lop()
            //{
            //    LopId = 3,
            //    TenLop = "cntt k39",
            //    GVCN = "C"
            //});
            var db = new SqlDatabase();
            lopItems = db.GetList<Lop>("select * from lop");

            //lopItems = DataExtensions.GetList<Lop>(db, "select * from Lop");

            lopBindingSource.DataSource = lopItems;
            sinhvienBindingSource.DataSource = data;
        }

        private void ThemButton_Click(object sender, EventArgs e)
        {
            var item = new Sinhvien
            {
            };
            data.Add(item);

            sinhvienBindingSource.DataSource = typeof(Sinhvien);
            sinhvienBindingSource.DataSource = data;
        }

        private void XoaButton_Click(object sender, EventArgs e)
        {
            var cur = sinhvienBindingSource.Current;
            if (cur == null)
                return;
            sinhvienBindingSource.RemoveCurrent();
        }

        private void GhiFileButton_Click(object sender, EventArgs e)
        {
            using(var sw = new StreamWriter("sinhvien.txt"))
            {
                var dataString = JsonConvert.SerializeObject(data);
                sw.Write(dataString);
                sw.Close();
            }
        }

        private void DocFileButton_Click(object sender, EventArgs e)
        {
            using(var sr = new StreamReader("sinhvien.txt"))
            {
                var dataString = sr.ReadToEnd();
                data = JsonConvert.DeserializeObject<List<Sinhvien>>(dataString);
                sinhvienBindingSource.DataSource = data;
                sr.Close();
            }
        }

        private void DocDB_Click(object sender, EventArgs e)
        {
            var db = new SqlDatabase();
            var data = db.GetList<Sinhvien>("select * from sinhvien");
            sinhvienBindingSource.DataSource = data;
        }
    }
}
