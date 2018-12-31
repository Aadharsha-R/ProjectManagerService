using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using ProjectManager.DataLib;
using ProjectManager.Entities;

namespace ProjectManager.BusinessLib
{
    public class UserBL
    {
        public List<User> GetAll()
        {
            using (ProjectManagerContext db = new ProjectManagerContext())
            {
                return db.Users.ToList();
            }
        }

        public void AddUser(User item)
        {
            using (ProjectManagerContext db = new ProjectManagerContext())
            {
                db.Users.Add(item);
                db.SaveChanges();
            }
        }

        public void UpdateUser(User item)
        {
            using (ProjectManagerContext db = new ProjectManagerContext())
            {
                var User = db.Users.First(i => i.UserId == item.UserId);
                //var Tsk = GetById(item.TaskId);
                if (User != null)
                {
                    User.FirstName = item.FirstName;
                    User.LastName = item.LastName;
                    User.EmployeeID = item.EmployeeID;
                    db.Entry(User).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }
                //db.Entry(Tsk).CurrentValues.SetValues(item);
                //db.Tasks.AddOrUpdate(item);

            }
        }

        public void DeleteUser(int Id)
        {
            using (ProjectManagerContext db = new ProjectManagerContext())
            {
                var Usr = db.Users.First(i => i.UserId == Id);
                if (Usr != null)
                {
                    db.Entry(Usr).State = System.Data.Entity.EntityState.Deleted;
                    db.SaveChanges();
                }
            }
        }
    }
}
