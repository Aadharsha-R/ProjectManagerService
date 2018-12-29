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

        //[Route("AddTask")]
        //public IHttpActionResult AddTask(Project item)
        //{
        //    TaskBL obj = new TaskBL();
        //    obj.AddTask(item);
        //    return Ok();
        //}
        [Route("UpdateTask")]
        [HttpPut]
        public IHttpActionResult Edit(Project item)
        {
            ProjectBL obj = new ProjectBL();
            obj.UpdateProject(item);
            return Ok("Updated!!!");
        }
        
       // [HttpGet]
        public IHttpActionResult Search(int Id)
        {
            ProjectBL obj = new ProjectBL();
            return Ok(obj.GetById(Id));
        }

    }
}