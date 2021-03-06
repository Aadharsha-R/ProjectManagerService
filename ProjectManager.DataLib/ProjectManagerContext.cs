﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using ProjectManager.Entities;

namespace ProjectManager.DataLib
{
   public class ProjectManagerContext :DbContext
    {
        public ProjectManagerContext():base("name=ProjectManagerConn")
        {
        }
        public DbSet <Task> Tasks { get; set; }
        public DbSet <Project> Projects { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
