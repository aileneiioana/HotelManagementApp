using HotelManagementApplicationlication;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace HotelManagementApplication
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }

        int startpoint = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startpoint += 1;
            SpalshPBar.Value = startpoint;
            if(SpalshPBar.Value == 100)
            {
                SpalshPBar.Value = 0;
                timer1.Stop();
                Form1 Login = new Form1();
                Login.Show();
                this.Hide();
            }
        }

        private void SplashForm_Load(object sender, EventArgs e)
        {
            this.timer1.Start();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
