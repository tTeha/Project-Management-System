using ProjectManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProjectManagementSystem.ADL
{
    public class ProjectContext : DbContext
    {

        public ProjectContext() : base("PMSDatabase")
        { }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Developer> Developer { get; set; }
        public DbSet<ProjectManager> ProjectManager { get; set; }
        public DbSet<TeamLeader> TeamLeader { get; set; }
        public DbSet<Admin> Admin { get; set; }

    }
}