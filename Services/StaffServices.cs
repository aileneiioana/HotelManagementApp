using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementApplication
{
    public class StaffServices
    {

        public void AddStaff(Staff_tbl model)
        {
            using (HoteldbEntities1 db = new HoteldbEntities1())
            {
                db.Staff_tbl.Add(model);
                db.SaveChanges();
            }
        }

        public List<Staff_tbl> Getstaff()
        {
            using (HoteldbEntities1 db = new HoteldbEntities1())
            {
               return db.Staff_tbl.ToList<Staff_tbl>();
            }
        }

        public Staff_tbl GetStaffById(int id)
        {
            using (HoteldbEntities1 db = new HoteldbEntities1())
            {
                return db.Staff_tbl.Where(x => x.StaffId == id).FirstOrDefault();
            }
        }

        public void EditStaff(Staff_tbl model)
        {
            using (HoteldbEntities1 db = new HoteldbEntities1())
            {
                db.Entry(model).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        public void DeleteStaff(Staff_tbl model)
        {
            using (HoteldbEntities1 db = new HoteldbEntities1())
            {
                var entity = db.Entry(model);
                if (entity.State == EntityState.Detached)
                    db.Staff_tbl.Attach(model);
                db.Staff_tbl.Remove(model);
                db.SaveChanges();
            }
        }
    };
}
