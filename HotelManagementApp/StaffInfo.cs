using HotelManagementApplicationlication;
using log4net;
using log4net.Config;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagementApplication
{
    public partial class StaffInfo : Form
    {
        Staff_tbl model = new Staff_tbl();
        StaffServices staffService = new StaffServices();
        Singleton s = Singleton.Instance;

        public StaffInfo()
        {
            InitializeComponent();
            PopulateDataGridView();
            Datelb.Text = DateTime.Today.Day.ToString() + " - " + DateTime.Today.Month.ToString() + " - " + DateTime.Today.Year.ToString();
        }

        void Clear()
        {
            StaffIdtb.Text = "Staff Id";
            StaffNametb.Text = "Staff Name";
            PhoneNumbertb.Text = "Phone Number";
            Passwordtb.Text = "Password";
            Gendercb.Text = "Gender";   
            model.StaffId = 0;
        }
        private void AddStaffBtn_Click(object sender, EventArgs e)
        {
           
            model.StaffId= Convert.ToInt32(StaffIdtb.Text.Trim());
            model.Staffname= StaffNametb.Text.Trim();
            model.Staffphone=PhoneNumbertb.Text.Trim();
            model.Staffpassword=Passwordtb.Text.Trim();
            model.Gender=Gendercb.Text.Trim();
            staffService.AddStaff(model);
            Clear();
            MessageBox.Show("Staff Successfully Added");
            PopulateDataGridView();
            s.printLoggInfo("Staff Added " + model.Staffname);

        }
         void PopulateDataGridView()
        {
              StaffView.DataSource = staffService.Getstaff();
        }

        private void StaffView_DoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(StaffView.CurrentRow.Index != -1)
            {
                model.StaffId=Convert.ToInt32(StaffView.CurrentRow.Cells["StaffId"].Value);
                model=staffService.GetStaffById(model.StaffId);
                StaffIdtb.Text = model.StaffId.ToString();
                StaffNametb.Text = model.Staffname;
                PhoneNumbertb.Text = model.Staffphone;
                Passwordtb.Text= model.Staffpassword;
                Gendercb.Text = model.Gender;

            } 
        }

        private void EditStaffBtn_Click(object sender, EventArgs e)
        {
            model.StaffId = Convert.ToInt32(StaffIdtb.Text.Trim());
            model.Staffname = StaffNametb.Text.Trim();
            model.Staffphone = PhoneNumbertb.Text.Trim();
            model.Staffpassword = Passwordtb.Text.Trim();
            model.Gender = Gendercb.Text.Trim();
            staffService.EditStaff(model);
            Clear();
            MessageBox.Show("Staff Successfully Updated");
            s.printLoggInfo("Staff Eddited " + model.Staffname);
            PopulateDataGridView();
        }

        private void DeleteStaffBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this Record?", "Staff Info", MessageBoxButtons.YesNo) == DialogResult.Yes) { 
            staffService.DeleteStaff(model);
            PopulateDataGridView();
            Clear();
            MessageBox.Show("Staff Successfully Deleted");
            s.printLoggInfo("Staff Deleted " + model.Staffname);
            }
            else s.printLoggError("Staff can't be deleted " + model.Staffname);
        }

        private void refreshpb_Click(object sender, EventArgs e)
        {
            PopulateDataGridView();
        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Hide();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            using (HoteldbEntities1 db = new HoteldbEntities1())
            {
                var dataset = staffService.GetStaffByName(Searchtb.Text);
               StaffView.DataSource = dataset;
               
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Hide();
        }
    }
}
