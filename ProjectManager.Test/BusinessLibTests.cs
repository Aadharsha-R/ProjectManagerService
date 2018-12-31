using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using NBench.Util;
using NBench;
using ProjectManager.BusinessLib;
using ProjectManager.Entities;

namespace ProjectManager.Test
{
     public class BusinessLibTests
    {
        static int id = 0;
        static int TaskCount = 0;
        static int ProjectCount = 0;
        static int UserCount = 0;
        static int AddDelTestId = 0;
        static string Name = string.Empty;


        [Test]
        public void Test_A_GetAllProject()
        {
            ProjectBL obj = new ProjectBL();
            var TestProjects = obj.GetAll();
            ProjectCount = TestProjects.Count;
            if (ProjectCount > 0)
            {
                id = TestProjects[0].ProjectId;
                Name = TestProjects[0].ProjectName;
            }
            Assert.NotZero(ProjectCount);
        }

        [Test]
        public void Test_B_GetAllUser()
        {
            UserBL obj = new UserBL();
            var TestUsers = obj.GetAll();
            UserCount = TestUsers.Count;
            if (UserCount > 0)
            {
                id = TestUsers[0].UserId;
                Name = TestUsers[0].FirstName;
            }
            Assert.NotZero(UserCount);
        }

        [Test]
        public void Test_C_GetAll()
        {
            TaskBL obj = new TaskBL();
            var TestTasks = obj.GetAll();
            TaskCount = TestTasks.Count;
            if (TaskCount > 0)
            {
                id = TestTasks[0].TaskId;
                Name = TestTasks[0].TaskName;
            }
            Assert.NotZero(TaskCount);
        }

        [Test]
        public void Test_D_GetByName()
        {
            TaskBL obj = new TaskBL();
            var TestTask = obj.GetByName(Name);
            Assert.AreEqual(TestTask.TaskName, Name);
        }

        [Test]
        public void Test_E_GetById()
        {
            //int id = 3;
            TaskBL obj = new TaskBL();
            var TestTask = obj.GetById(id);
            Assert.AreEqual(TestTask.TaskId, id);
        }

        [Test]
        public void Test_F_AddTask()
        {
            //Task item = new Task() { TaskId = 100, TaskName = "TestTask", ParentTask = "Task11", Priority = 2, SDate = DateTime.Now, EDate = DateTime.Now, TaskEndFlag = true };
            Task item = new Task() { TaskId = 1000, ParentId = 1, ProjectId = 1003, UserId = 2, TaskName = "UnitTestTask", ParentTask = "Task 10", Priority = 2, SDate = DateTime.Now, EDate = DateTime.Now, Status = "Started", TaskEndFlag = true };
            TaskBL obj = new TaskBL();
            obj.AddTask(item);
            var res = obj.GetByName("UnitTestTask");
            if (res != null)
                AddDelTestId = res.TaskId;
            Assert.IsNotNull(res);
        }

        [Test]
        public void Test_G_UpdateTask()
        {
            Task item = new Task() { TaskId = AddDelTestId, TaskName = "TestTaskUpdated", ParentTask = "Task11", Priority = 2, SDate = DateTime.Now, EDate = DateTime.Now, TaskEndFlag = true };
            TaskBL obj = new TaskBL();
            obj.UpdateTask(item);
            var res = obj.GetByName("TestTaskUpdated");
            Assert.IsNotNull(res);
        }

        [Test]
        public void Test_H_DeleteTask()
        {
            TaskBL obj = new TaskBL();
            obj.DeleteTask(AddDelTestId);
            Assert.IsNull(obj.GetById(AddDelTestId));
        }
    }
}
