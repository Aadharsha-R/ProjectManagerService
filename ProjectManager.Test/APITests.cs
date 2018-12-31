using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using System.Web.Http;
using System.Web.Http.Results;
using ProjectManager.API;
using ProjectManager.Entities;
using ProjectManager.API.Controllers;

namespace ProjectManager.Test
{
     [TestFixture]
    public class APITests
    {
        static int id = 0;
        [Test]
        public void Test_A_Get()
        {
            ProjectController obj = new ProjectController();
            IHttpActionResult actionresult = obj.GetTask();
            var contentResult = actionresult as OkNegotiatedContentResult<List<Task>>;
            Assert.IsNotNull(contentResult);
            id = contentResult.Content[0].TaskId;
            Assert.Greater(contentResult.Content.Count, 0); ;
        }

        [Test]
        public void Test_B_Search()
        {
            ProjectController obj = new ProjectController();
            var contentResult = obj.SearchTask(id) as OkNegotiatedContentResult<Task>;
            Assert.IsNotNull(contentResult);
            Assert.IsNotNull(contentResult.Content);
            Assert.AreEqual(contentResult.Content.TaskId, id);
        }

        [Test]
        public void Test_C_Post()
        {
            Task item = new Task() { TaskId = 1000, ParentId = 1, ProjectId = 1003, UserId = 2, TaskName = "UnitAPITestTask", ParentTask = "Task 10", Priority = 2, SDate = DateTime.Now, EDate = DateTime.Now, Status = "Started", TaskEndFlag = true };
            //Task item = new Task() { TaskId = 100, TaskName = "TestTask", ParentTask = "Task11", Priority = 2, SDate = DateTime.Now, EDate = DateTime.Now, TaskEndFlag = true };
            ProjectController obj = new ProjectController();
            var contentResult = obj.AddTask(item) as OkNegotiatedContentResult<string>; 
            Assert.IsNotNull(contentResult);
        }

        [Test]
        public void Test_D_Edit()
        {
            Task item = new Task() { TaskId = 4027, TaskName = "TestTaskUpdated", ParentTask = "Task11", Priority = 2, SDate = DateTime.Now, EDate = DateTime.Now, TaskEndFlag = true };
            //Task item = new Task() { TaskId = 4027, TaskName = "TestTaskUpdated", ParentTask = "Task11", Priority = 2, SDate = DateTime.Now, EDate = DateTime.Now, TaskEndFlag = true };
            ProjectController obj = new ProjectController();
            var contentResult = obj.UpdateTask(item) as OkNegotiatedContentResult<string>;
            Assert.IsNotNull(contentResult);
            Assert.AreEqual(contentResult.Content.ToString(), "Updated!!!");
        }

        [Test]
        public void Test_E_Remove()
        {
            ProjectController obj = new ProjectController();
            var contentResult1 = obj.RemoveTask(10) as OkResult;
            Assert.IsNotNull(contentResult1);
            var contentResult2 = obj.SearchTask(10) as OkNegotiatedContentResult<Task>;
            Assert.IsNull(contentResult2.Content);
        }


    }
}
