using HotelManagementApplicationlication;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagementApplication
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void singoutpb_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.Show();
            this.Hide();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void staffpb_Click(object sender, EventArgs e)
        {
            StaffInfo staff = new StaffInfo();
            staff.Show();
            this.Hide();
        }

        private void reservationpb_Click(object sender, EventArgs e)
        {
            ReservationInfo res = new ReservationInfo();
            res.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void clientpb_Click(object sender, EventArgs e)
        {
            Clientinfo res = new Clientinfo();
            res.Show();
            this.Hide();
        }

        private void roompb_Click(object sender, EventArgs e)
        {
            RoomInfo res = new RoomInfo();
            res.Show();
            this.Hide();
        }
    }
}
