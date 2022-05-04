using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelManagementApplication;

namespace HotelManagementApplicationlication
{
    public partial class Form1 : Form
    {
        Staff_tbl model = new Staff_tbl();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            using (HoteldbEntities db = new HoteldbEntities())
            {
                var dataset = db.Staff_tbl.Where(x => x.Staffname == usernametb.Text && x.Staffpassword == passwordtb.Text).Select(x => new { x.Staffname, x.Staffpassword }).FirstOrDefault();
                if(dataset != null)
                {
            Main mf = new Main();
            mf.Show();
            this.Hide();

                }
                else MessageBox.Show("Wrong Username or Password!");

            }

        }
    }
}
