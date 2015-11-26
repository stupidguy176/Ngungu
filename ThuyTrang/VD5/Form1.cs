using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess;


namespace VD5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
    
       private void bindingSourceNhomHH_PositionChanged(object sender, EventArgs e)
       {
           var cur = bindingSourceNhomHH.Current as Trang_Master;
           if (cur != null)
           {
               bindingSourceHH.DataSource = Model.GetTrang_DetailItemsByNhomHangID(cur.NhomHangID);
           }
       }

       private void ThemButton_Click(object sender, EventArgs e)
        {
           /* var cur = bindingSourceHH.Current as Trang_Detail;
            if (cur != null)
            {
                Model.InsertGeneric(cur);
            }*/
           if (txtID.Text == "")
           {
               errorProvider1.SetError(txtID, "ID chưa điền");
           }
           if (txtNhom.Text == "")
           {
               errorProvider1.SetError(txtNhom, "Nhom chưa điền");
           }
           if (txtTN.Text == "")
           {
               errorProvider1.SetError(txtTN, "Tên nhóm chưa điền");
           }
           if (txtHH.Text == "")
           {
               errorProvider1.SetError(txtHH, "Hàng hóa chưa điền");
           }
           if (txtGia.Text== "")
           {
               errorProvider1.SetError(txtGia, "Giá chưa điền");
           }
           if(txtID.Text!="" && txtNhom.Text != "" && txtTN.Text !="" && txtHH.Text !="" && txtGia.Text !="")
           {
               var sql= "INSERT INTO Trang_Master(NhomHangID, TenNhom) VALUES ("+txtID.Text+","+txtTN+")";
               var dt = "INSERT INTO Trang_Detail(HangHoa, Gia,NhomHangID) VALUES ("+txtHH+","+txtGia+"," + txtID.Text + ")";
               bindingSourceNhomHH.DataSource = Model.GetTrang_MasterItems();
           }

      }

       private void Form1_Load_1(object sender, EventArgs e)
       {
           bindingSourceNhomHH.DataSource = Model.GetTrang_MasterItems();
       }

       private void textBox2_TextChanged(object sender, EventArgs e)
       {
           errorProvider1.SetError(txtID, "");
       }

       private void txtTN_TextChanged(object sender, EventArgs e)
       {
           errorProvider1.SetError(txtTN, "");
       }

       private void txtHH_TextChanged(object sender, EventArgs e)
       {
           errorProvider1.SetError(txtHH, "");
       }

       private void txtGia_TextChanged(object sender, EventArgs e)
       {
           errorProvider1.SetError(txtGia, "");
       }

       private void txtNhom_TextChanged(object sender, EventArgs e)
       {
           errorProvider1.SetError(txtNhom, "");
       }


        
    }
}
