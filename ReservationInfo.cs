using HotelManagementApplicationlication;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Core.Objects.DataClasses;
using System.Data.Entity.SqlServer;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagementApplication
{
    public partial class ReservationInfo : Form
    {
        Reservation_tbl model = new Reservation_tbl();

        DateTime Today;
        public ReservationInfo()
        {
            InitializeComponent();
            PopulateDataGridView();
            fillClientcb();
            fillRoomcb();
            Datelb.Text = DateTime.Today.Day.ToString() + " - " + DateTime.Today.Month.ToString() + " - " + DateTime.Today.Year.ToString();
        }
        void Clear()
        {
            ReservationIdtb.Text = "Reservation Id";
            clientcb.Text = "Client Name";
            roomnumbercb.Text = "Room Number";
            model.ResId = 0;
        }
        void fillClientcb()
        {

            using (HoteldbEntities1 db = new HoteldbEntities1())
            {
                var dataset = db.Client_tbl.Select(x => x.ClientName).ToList();
                clientcb.DataSource = dataset;

            }
        }

        void fillRoomcb()
        {
            using (HoteldbEntities1 db = new HoteldbEntities1())
            {
                var dataset = db.Room_tbl.Where(x => x.RoomFree == "free").Select(x =>  x.RoomId ).ToList();
                roomnumbercb.DataSource = dataset;

            }
        }
        void PopulateDataGridView()
        {
            using (HoteldbEntities1 db = new HoteldbEntities1())
            {
                ResView.DataSource = db.Reservation_tbl.ToList<Reservation_tbl>();
            }
        }

        private void AddResBtn_Click(object sender, EventArgs e)
        {
            var model = new Reservation_tbl {
                ResId = int.Parse(ReservationIdtb.Text),
                Client=clientcb.Text,
                Room=int.Parse(roomnumbercb.Text),
                DateIn=dateInTimePicker.Text,
                DateOut=dateOutTimePicker.Text
            };
            using (HoteldbEntities1 db = new HoteldbEntities1())
            {
                db.Reservation_tbl.Add(model);
                db.SaveChanges();
            }
            Clear();
            MessageBox.Show("Reservation Successfully Added");
            int.TryParse(model.Room.ToString(), out int id);
            updateRoomState(id, "busy");
            PopulateDataGridView();
            
        }

        private void EditResfBtn_Click(object sender, EventArgs e)
        {
            var model = new Reservation_tbl
            {
                ResId = int.Parse(ReservationIdtb.Text),
                Client = clientcb.Text,
                Room = int.Parse(roomnumbercb.Text),
                DateIn = dateInTimePicker.Text,
                DateOut = dateOutTimePicker.Text
            };
            using (HoteldbEntities1 db = new HoteldbEntities1())
            {
                db.Entry(model).State = EntityState.Modified;
                db.SaveChanges();
            }
            Clear();
            MessageBox.Show("Reservation Successfully Edited");
            PopulateDataGridView();
        }

        private void DeleteResfBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this Record?", "Reservation Info", MessageBoxButtons.YesNo) == DialogResult.Yes)
                using (HoteldbEntities1 db = new HoteldbEntities1())
                {
                    var entity = db.Entry(model);
                    if (entity.State == EntityState.Detached)
                        db.Reservation_tbl.Attach(model);
                    db.Reservation_tbl.Remove(model);
                    db.SaveChanges();
                    PopulateDataGridView();
                    Clear();
                    MessageBox.Show("Reservation Successfully Deleted");
                    int.TryParse(model.Room.ToString(), out int id);
                    updateRoomState(id, "free");
                }
        }

        private void refreshpb_Click(object sender, EventArgs e)
        {
            PopulateDataGridView();
        }

        private void ResView_DoubleClick(object sender, EventArgs e)
        {
            if (ResView.CurrentRow.Index != -1)
            {
                model.ResId = Convert.ToInt32(ResView.CurrentRow.Cells["ResId"].Value);
                using (HoteldbEntities1 db = new HoteldbEntities1())
                {
                    model = db.Reservation_tbl.Where(x => x.ResId == model.ResId).FirstOrDefault();
                    ReservationIdtb.Text = model.ResId.ToString();
                    clientcb.Text = model.Client;
                    roomnumbercb.Text = model.Room.ToString();
                }
            }
        }

        private void Datelb_Click(object sender, EventArgs e)
        {

        }

        private void Search_Click(object sender, EventArgs e)
        {
         
            int.TryParse(Searchtb.Text.Trim(), out int id);
            using (HoteldbEntities1 db = new HoteldbEntities1())
            {
                var dataset = db.Reservation_tbl.Where(x => x.ResId == id).Select(x => new { x.ResId, x.Client, x.Room, x.DateIn, x.DateOut }).ToList();
                ResView.DataSource = dataset;
            }
        }


        private void Backbtn_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Hide();
        }


         void updateRoomState(int id, string state)
         {
             using (HoteldbEntities1 db = new HoteldbEntities1())
             {
                 var rm = db.Room_tbl.Where(f => f.RoomId == id).FirstOrDefault();
                 rm.RoomFree = state;
                 if (rm != null)
                 {
                     db.Entry(rm).State = EntityState.Modified; 
                    db.SaveChanges();
                }
             }
             fillRoomcb();
         }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Hide();
        }
    }
}
