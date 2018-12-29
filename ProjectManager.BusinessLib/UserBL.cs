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
    }
}
