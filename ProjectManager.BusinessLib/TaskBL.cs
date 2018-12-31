using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using ProjectManager.DataLib;
using ProjectManager.Entities;

namespace ProjectManager.BusinessLib
{
    public class TaskBL
    {
        public List<Task> GetAll()
        {
            using (ProjectManagerContext db = new ProjectManagerContext())
            {
                return db.Tasks.ToList();
            }
        }

        public void AddTask(Task item)
        {
            using (ProjectManagerContext db = new ProjectManagerContext())
            {
                db.Tasks.Add(item);
                db.SaveChanges();
                //if (item.ParentTask != null && !string.IsNullOrEmpty(item.ParentTask))
                //{
                //    ProjectBL obj = new ProjectBL();
                //    obj.UpdateProject(item.ProjectId);
                //}
            }
        }

        public void UpdateTask(Task item)
        {
            using (ProjectManagerContext db = new ProjectManagerContext())
            {
                var Task = db.Tasks.First(i => i.ProjectId == item.ProjectId);
                //var Tsk = GetById(item.TaskId);
                if (Task != null)
                {
                    Task.TaskName = item.TaskName;
                    Task.ParentTask = item.ParentTask;
                    Task.Priority = item.Priority;
                    Task.SDate = item.SDate;
                    Task.EDate = item.EDate;
                    Task.Status = item.Status;
                    Task.TaskEndFlag = item.TaskEndFlag;
                   // Task.ProjectId = item.ProjectId;
                    //Task.UserId = item.UserId;
                    db.Entry(Task).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }
                //db.Entry(Tsk).CurrentValues.SetValues(item);
                //db.Tasks.AddOrUpdate(item);
            }

        }

        public Task GetById(int Id)
        {
            using (ProjectManagerContext db = new ProjectManagerContext())
            {
                return db.Tasks.SingleOrDefault(k => k.TaskId == Id);
            }

        }

        public Task GetByName(string Name)
        {
            using (ProjectManagerContext db = new ProjectManagerContext())
            {
                return db.Tasks.SingleOrDefault(k => k.TaskName == Name);
            }

        }

        public void DeleteTask(int Id)
        {
            using (ProjectManagerContext db = new ProjectManagerContext())
            {
                var Tsk = db.Tasks.First(i => i.TaskId == Id);
                //var Tsk = GetById(item.TaskId);
                if (Tsk != null)
                {
                    db.Entry(Tsk).State = System.Data.Entity.EntityState.Deleted;
                    db.SaveChanges();
                }
            }
        }
    }
}
