﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProjectManager.BusinessLib;
using ProjectManager.DataLib;
using ProjectManager.Entities;
using System.Data.Entity;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string input;
                //Database.SetInitializer(new DropCreateDatabaseIfModelChanges<ProjectManagerContext>());
                //Console.WriteLine("Select the Action No.");
                //Console.WriteLine("1.Add Task");
                //Console.WriteLine("2.Update Task");
                //Console.WriteLine("3.Search Task");
                //Console.WriteLine("4.Delete Task");
                //Console.WriteLine("5.Exit");
                //input = Console.ReadLine();
                TaskBL obj = new TaskBL();
                List<Task> abc = obj.GetAll();
                foreach (Task t in abc)
                {
                    Console.WriteLine(t.TaskId);
                }
                ProjectBL obj2 = new ProjectBL();
                List<Project> abc2 = obj2.GetAll();
                foreach (Project t in abc2)
                {
                    Console.WriteLine(t.ProjectId);
                }
                UserBL obj3 = new UserBL();
                List<User> abc3 = obj3.GetAll();
                foreach (User t in abc3)
                {
                    Console.WriteLine(t.UserId);
                }
                Console.ReadLine();
           

                //switch (input)
                //{
                //    case "1":
                //        obj.AddTask(new TaskManager.Entities.Task() { TaskId = 2, TaskName = "Task22", ParentTask = "Task11", Priority = 2, SDate = DateTime.Now, EDate = DateTime.Now, TaskEndFlag = true });
                //        break;
                //    case "2":
                //        Console.WriteLine("Enter Task Id");
                //        string ID_Update = Console.ReadLine();
                //        TaskManager.Entities.Task TskUpdate = obj.GetById(Convert.ToInt32(ID_Update));
                //        Console.WriteLine("Task Details Before Update:");
                //        Console.WriteLine("Task ID : " + TskUpdate.TaskId.ToString() + "\n"
                //            + "Task Name : " + TskUpdate.TaskName.ToString() + "\n"
                //            + "Priority : " + TskUpdate.Priority.ToString() + "\n");
                //        Console.WriteLine("Enter New TaskName");
                //        TskUpdate.TaskName = Console.ReadLine();
                //        obj.UpdateTask(TskUpdate);
                //        TskUpdate = obj.GetById(Convert.ToInt32(ID_Update));
                //        Console.WriteLine("Task Details After Update:");
                //        Console.WriteLine("Task ID : " + TskUpdate.TaskId.ToString() + "\n"
                //            + "Task Name : " + TskUpdate.TaskName.ToString() + "\n"
                //            + "Priority : " + TskUpdate.Priority.ToString() + "\n");
                //        Console.ReadLine();
                //        break;
                //    case "3":
                //        Console.WriteLine("Enter Task Id to Search");
                //        String ID = Console.ReadLine();
                //        TaskManager.Entities.Task TskSearch = obj.GetById(Convert.ToInt32(ID));
                //        Console.WriteLine("Task Details:");
                //        Console.WriteLine("Task ID : " + TskSearch.TaskId.ToString() + "/n"
                //            + "Task Name : " + TskSearch.TaskName.ToString() + "/n"
                //            + "Priority : " + TskSearch.Priority.ToString() + "/n"
                //            );
                //        break;
                //    case "4":
                //        Console.WriteLine("Enter Task Id to Delete");
                //        String ID_Del = Console.ReadLine();
                //        obj.DeleteTask(Convert.ToInt32(ID_Del));
                //        break;
                //    case "5":
                //        break;
                //    default:
                //        break;
                //}
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }
    }
}
