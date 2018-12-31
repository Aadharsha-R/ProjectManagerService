using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ProjectManager.BusinessLib;
using ProjectManager.DataLib;
using ProjectManager.Entities;

namespace ProjectManager.API.Controllers
{
    public class ProjectController : ApiController
    {
        [Route("GetProject")]
        [HttpGet]
        public IHttpActionResult Get()
        {
            ProjectBL obj = new ProjectBL();
            return Ok(obj.GetAll());
        }

        [Route("GetUser")]
        [HttpGet]
        public IHttpActionResult GetUser()
        {
            UserBL obj = new UserBL();
            return Ok(obj.GetAll());
        }

        [Route("GetTask")]
        [HttpGet]
        public IHttpActionResult GetTask()
        {
            TaskBL obj = new TaskBL();
            return Ok(obj.GetAll());
        }

        [Route("AddProject")]
        [HttpPost]
        public IHttpActionResult AddProject(Project item)
        {
            ProjectBL obj = new ProjectBL();
            obj.AddProject(item);
            return Ok("Project Added!!");
        }

        [Route("UpdateProject")]
        [HttpPut]
        public IHttpActionResult UpdateProject(Project item)
        {
            ProjectBL obj = new ProjectBL();
            obj.UpdateProject(item);
            return Ok("Updated!!!");
        }

        [Route("AddTask")]
        [HttpPost]
        public IHttpActionResult AddTask(Task item)
        {
            TaskBL obj = new TaskBL();
            obj.AddTask(item);
            return Ok("Task Added!!");
        }

        [Route("UpdateTask")]
        [HttpPut]
        public IHttpActionResult UpdateTask(Task item)
        {
            TaskBL obj = new TaskBL();
            obj.UpdateTask(item);
            return Ok("Updated!!!");
        }


        [Route("AddUser")]
        [HttpPost]
        public IHttpActionResult AddUser(User item)
        {
            UserBL obj = new UserBL();
            obj.AddUser(item);
            return Ok("User Added!!");
        }


        [Route("UpdateUser")]
        [HttpPut]
        public IHttpActionResult UpdateUser(User item)
        {
            UserBL obj = new UserBL();
            obj.UpdateUser(item);
            return Ok("Updated!!!");
        }

        [Route("DeleteUser/{id}")]
        [HttpDelete]
        public IHttpActionResult DeleteUser(int id)
        {
            UserBL obj = new UserBL();
            obj.DeleteUser(id);
            return Ok("Deleted!!!");
        }

        [Route("SearchTask/{id}")]
        [HttpGet]
        public IHttpActionResult SearchTask(int Id)
        {
            TaskBL obj = new TaskBL();
            return Ok(obj.GetById(Id));
        }

        [Route("Delete")]
        public IHttpActionResult RemoveTask(int Id)
        {
            TaskBL obj = new TaskBL();
            obj.DeleteTask(Id);
            return Ok();
        }

        [Route("DeleteProject/{id}")]
        [HttpDelete]
        public IHttpActionResult DeleteProject(int id)
        {
            ProjectBL obj = new ProjectBL();
            obj.DeleteProject(id);
            return Ok("Deleted!!!");
        }

    }
}