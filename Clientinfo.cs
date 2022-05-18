using HotelManagementApplication.Services;
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
    public partial class Clientinfo : Form
    {
        Client_tbl model= new Client_tbl();
        ClientServices clientServices = new ClientServices();

        public Clientinfo()
        {
            InitializeComponent();
            PopulateDataGridView();
            Datelbl.Text = DateTime.Today.Day.ToString() + " - " + DateTime.Today.Month.ToString() + " - " + DateTime.Today.Year.ToString();
        }

        void Clear()
        {
            clientidtbl.Text = "Client Id";
            clientnametbl.Text = "Client Name";
            clientphonetb.Text = "Client Phone";
            clientctrytb.Text = "Country";
            model.ClientId = 0;
        }

        private void Clientinfo_Load(object sender, EventArgs e)
        {
            Datelbl.Text = Datelbl.Text.Trim();
            timer1.Start();
            PopulateDataGridView();

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            //facade design
            Facade facade = new Facade();
            model.ClientId = Convert.ToInt32(clientidtbl.Text.Trim());
            model.ClientName = clientnametbl.Text.Trim();
            model.ClientPhone = clientphonetb.Text.Trim();
            model.ClientCountry = clientctrytb.Text.Trim();

            //facade design
            facade.addClient(model);

            Clear();
            PopulateDataGridView();
            MessageBox.Show("Submitted Successfully");

        }

        void PopulateDataGridView()
        {
            ClientGridview.AutoGenerateColumns = false;
            ClientGridview.DataSource = clientServices.GetClients();
        }

        private void ClientGridview_DoubleClick(object sender, EventArgs e)
        {
            if (ClientGridview.CurrentRow.Index != -1)
            {
                model.ClientId = Convert.ToInt32(ClientGridview.CurrentRow.Cells["ClientID"].Value);
                model = clientServices.GetClientById(model.ClientId);
                clientidtbl.Text = model.ClientId.ToString();
                clientnametbl.Text = model.ClientName.ToString();
                clientphonetb.Text = model.ClientPhone.ToString();
                clientctrytb.Text = model.ClientCountry.ToString();
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this Record?", "Client Info", MessageBoxButtons.YesNo) == DialogResult.Yes)
            clientServices.DeleteClient(model);
            PopulateDataGridView();
            Clear();
            MessageBox.Show("Client Successfully Deleted");
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {

            model.ClientId = Convert.ToInt32(clientidtbl.Text.Trim());
            model.ClientName = clientnametbl.Text.Trim();
            model.ClientPhone = clientphonetb.Text.Trim();
            model.ClientCountry = clientctrytb.Text.Trim();
            clientServices.UpdateClient(model);
            Clear();
            MessageBox.Show("Client Successfully Updated");
            PopulateDataGridView();
            
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Hide();
        }

        private void refreshpb_Click(object sender, EventArgs e)
        {
            PopulateDataGridView();
        }

        private void Search_Click(object sender, EventArgs e)
        {
              
            using (HoteldbEntities1 db = new HoteldbEntities1())
            {
                var dataset = clientServices.GetClientsByName(ClientSearchtb.Text);
                ClientGridview.DataSource = dataset;
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
