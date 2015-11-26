using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vidu03
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new sinhvienMainForm());

            //var f = new Form();
            //f.Text = "tuấn";
           
            //var b = new Button();
            //b.Text = "tèo";
            //b.Location = new System.Drawing.Point(100, 143);
            //b.Size = new System.Drawing.Size(75, 23);

            //b.Click += (object sender, EventArgs e) =>
            //{
            //    MessageBox.Show("Chào Tuấn, tèo");
            //};
            //f.Controls.Add(b);
            //Application.Run(f);
        }
    }
}
