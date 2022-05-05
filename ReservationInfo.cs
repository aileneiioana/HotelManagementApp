using HotelManagementApplicationlication;
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
    public partial class ReservationInfo : Form
    {
        Reservation_tbl model = new Reservation_tbl();
        public ReservationInfo()
        {
            InitializeComponent();
            PopulateDataGridView();
            fillClientcb();
            fillRoomcb();   
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
           // updateRoomState(int.Parse(roomnumbercb.Text), "busy");
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
                    // updateRoomState(int.Parse(roomnumbercb.Text), "free");
                }
        }

        private void refreshpb_Click(object sender, EventArgs e)
        {
            PopulateDataGridView();
        }

        /* void updateRoomState(int id, string state)
         {
             using (HoteldbEntities1 db = new HoteldbEntities1())
             {
                 var rm = db.Room_tbl.Where(f => f.RoomId == id).FirstOrDefault();
                 if (rm != null)
                 {
                     rm.RoomFree = state;
                     db.Entry(rm).State = EntityState.Modified;
                     db.Room_tbl.Attach(rm);
                     db.SaveChanges();
                 }
             }
             fillRoomcb();
         }*/


    }
}
