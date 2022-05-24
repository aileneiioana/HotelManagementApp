using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;

namespace HotelManagementApplication
{
    public class ClientServices
    {

        public void AddClient(Client_tbl client)
        {
            using (HoteldbEntities1 db = new HoteldbEntities1())
            {
                db.Client_tbl.Add(client);
                db.SaveChanges();
            }
        }

        public List<String> GetClientsNames()
        {
            using (HoteldbEntities1 db = new HoteldbEntities1())
            {
                return  db.Client_tbl.Select(x => x.ClientName).ToList();
            }
        }

        public List<Client_tbl> GetClientsByName(string name)
        {
            using (HoteldbEntities1 db = new HoteldbEntities1())
            {
                return db.Client_tbl.Where(x => x.ClientName == name).ToList();
            }
        }

            public List<Client_tbl> GetClients()
        {
            using (HoteldbEntities1 db = new HoteldbEntities1())
            {
                return db.Client_tbl.ToList<Client_tbl>();
            }
        }

        public Client_tbl GetClientById(int id)
        {
            using (HoteldbEntities1 db = new HoteldbEntities1())
            {
                return db.Client_tbl.Where(x => x.ClientId == id).FirstOrDefault();
            }
        }

        public void DeleteClient(Client_tbl model)
        {
            using (HoteldbEntities1 db = new HoteldbEntities1())
            {
                var entity = db.Entry(model);
                if (entity.State == EntityState.Detached)
                    db.Client_tbl.Attach(model);
                db.Client_tbl.Remove(model);
                db.SaveChanges();
            }
        }

        public void UpdateClient(Client_tbl model)
        {
            using (HoteldbEntities1 db = new HoteldbEntities1())
            {
                db.Entry(model).State = EntityState.Modified;
                db.SaveChanges();
            }
        }
    };
}
