using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using ProjectManager.DataLib;
using ProjectManager.Entities;

namespace ProjectManager.BusinessLib
{
    public class ProjectBL
    {
        //[HttpGet]
        public void AddProject(Project item)
        {
            using (ProjectManagerContext db = new ProjectManagerContext())
            {
                db.Projects.Add(item);
                db.SaveChanges();
            }
        }

        public void UpdateProject(Project item)
        {
            using (ProjectManagerContext db = new ProjectManagerContext())
            {
                var Proj = db.Projects.First(i => i.ProjectId == item.ProjectId);
                //var Tsk = GetById(item.TaskId);
                if (Proj != null)
                {
                    Proj.ProjectName = item.ProjectName;
                    Proj.Priority = item.Priority;
                    Proj.SDate = item.SDate;
                    Proj.EDate = item.EDate;
                    db.Entry(Proj).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }
                //db.Entry(Tsk).CurrentValues.SetValues(item);
                //db.Tasks.AddOrUpdate(item);

            }
        }

        public void UpdateProject(int ProjID)
        {
            using (ProjectManagerContext db = new ProjectManagerContext())
            {
                var Proj = db.Projects.First(i => i.ProjectId == ProjID);
                //var Tsk = GetById(item.TaskId);
                if (Proj != null)
                {
                    Proj.TotalTasks += 1;
                    db.Entry(Proj).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }
                //db.Entry(Tsk).CurrentValues.SetValues(item);
                //db.Tasks.AddOrUpdate(item);

            }
        }

        public List<Project> GetAll()
        {
            using (ProjectManagerContext db = new ProjectManagerContext())
            {
                return db.Projects.ToList();
            }
        }

        public Project GetById(int Id)
        {
            using (ProjectManagerContext db = new ProjectManagerContext())
            {
                return db.Projects.SingleOrDefault(k => k.ProjectId == Id);
            }

        }

        public Project GetByName(string Name)
        {
            using (ProjectManagerContext db = new ProjectManagerContext())
            {
                return db.Projects.SingleOrDefault(k => k.ProjectName == Name);
            }

        }

        public void DeleteProject(int Id)
        {
            using (ProjectManagerContext db = new ProjectManagerContext())
            {
                var Prj = db.Projects.First(i => i.ProjectId == Id);
                if (Prj != null)
                {
                    db.Entry(Prj).State = System.Data.Entity.EntityState.Deleted;
                    db.SaveChanges();
                }
            }
        }
    }
}
