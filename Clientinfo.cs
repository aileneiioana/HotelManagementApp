using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
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
            clientctrytb.Text = "Client Phone";
            model.ClientId = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Datelbl.Text = DateTime.Now.ToString();
        }

        private void Clientinfo_Load(object sender, EventArgs e)
        {
            Datelbl.Text = Datelbl.Text.Trim();
            timer1.Start();
            PopulateDataGridView();

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            model.ClientId = Convert.ToInt32(clientidtbl.Text.Trim());
            model.ClientName = clientnametbl.Text.Trim();
            model.ClentPhone = clientphonetb.Text.Trim();
            model.ClientCountry = clientctrytb.Text.Trim();
            using (HoteldbEntities1 db = new HoteldbEntities1())
            {
                db.Client_tbl.Add(model);
                db.SaveChanges();
            }
            Clear();
            PopulateDataGridView();
            MessageBox.Show("Submitted Successfully");

        }

        void PopulateDataGridView()
        {
            ClientGridview.AutoGenerateColumns = false;

            using (HoteldbEntities1 db = new HoteldbEntities1())
            {
                ClientGridview.DataSource = db.Client_tbl.ToList<Client_tbl>();
            }
        }

        private void ClientGridview_DoubleClick(object sender, EventArgs e)
        {
            if (ClientGridview.CurrentRow.Index != -1)
            {
                model.ClientId = Convert.ToInt32(ClientGridview.CurrentRow.Cells["ClientID"].Value);
                using (HoteldbEntities1 db = new HoteldbEntities1())
                {
                    model = db.Client_tbl.Where(x => x.ClientId == model.ClientId).FirstOrDefault();
                    clientidtbl.Text = model.ClientId.ToString();
                    clientnametbl.Text = model.ClientName.ToString();
                    clientphonetb.Text = model.ClentPhone.ToString();
                    clientctrytb.Text = model.ClientCountry.ToString();
                }
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this Record?", "Client Info", MessageBoxButtons.YesNo) == DialogResult.Yes)
                using (HoteldbEntities1 db = new HoteldbEntities1())
                {
                    var entity = db.Entry(model);
                    if (entity.State == EntityState.Detached)
                        db.Client_tbl.Attach(model);
                    db.Client_tbl.Remove(model);
                    db.SaveChanges();
                    PopulateDataGridView();
                    Clear();
                    MessageBox.Show("Client Successfully Deleted");
                }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {

            model.ClientId = Convert.ToInt32(clientidtbl.Text.Trim());
            model.ClientName = clientnametbl.Text.Trim();
            model.ClentPhone = clientphonetb.Text.Trim();
            model.ClientCountry = clientctrytb.Text.Trim();
            using (HoteldbEntities1 db = new HoteldbEntities1())
                {
                    db.Entry(model).State = EntityState.Modified;
                    db.SaveChanges();
                }
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
                var dataset = db.Client_tbl.Where(x => x.ClientName == ClientSearchtb.Text).Select(x => new { x.ClientId, x.ClientName, x.ClentPhone, x.ClientCountry}).ToList();
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
