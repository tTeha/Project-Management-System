namespace ProjectManagementSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration3 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Admins", "job_description", c => c.String(nullable: false));
            AlterColumn("dbo.Admins", "image", c => c.String(nullable: false));
            AlterColumn("dbo.Admins", "first_name", c => c.String(nullable: false));
            AlterColumn("dbo.Admins", "last_name", c => c.String(nullable: false));
            AlterColumn("dbo.Admins", "email", c => c.String(nullable: false));
            AlterColumn("dbo.Admins", "mobile", c => c.String(nullable: false));
            AlterColumn("dbo.Customers", "job_description", c => c.String(nullable: false));
            AlterColumn("dbo.Customers", "image", c => c.String(nullable: false));
            AlterColumn("dbo.Customers", "first_name", c => c.String(nullable: false));
            AlterColumn("dbo.Customers", "last_name", c => c.String(nullable: false));
            AlterColumn("dbo.Customers", "email", c => c.String(nullable: false));
            AlterColumn("dbo.Customers", "mobile", c => c.String(nullable: false));
            AlterColumn("dbo.Developers", "job_description", c => c.String(nullable: false));
            AlterColumn("dbo.Developers", "image", c => c.String(nullable: false));
            AlterColumn("dbo.Developers", "first_name", c => c.String(nullable: false));
            AlterColumn("dbo.Developers", "last_name", c => c.String(nullable: false));
            AlterColumn("dbo.Developers", "email", c => c.String(nullable: false));
            AlterColumn("dbo.Developers", "mobile", c => c.String(nullable: false));
            AlterColumn("dbo.Developers", "qualifications", c => c.String(nullable: false));
            AlterColumn("dbo.Developers", "experience", c => c.String(nullable: false));
            AlterColumn("dbo.TeamLeaders", "job_description", c => c.String(nullable: false));
            AlterColumn("dbo.TeamLeaders", "image", c => c.String(nullable: false));
            AlterColumn("dbo.TeamLeaders", "first_name", c => c.String(nullable: false));
            AlterColumn("dbo.TeamLeaders", "last_name", c => c.String(nullable: false));
            AlterColumn("dbo.TeamLeaders", "email", c => c.String(nullable: false));
            AlterColumn("dbo.TeamLeaders", "mobile", c => c.String(nullable: false));
            AlterColumn("dbo.TeamLeaders", "qualifications", c => c.String(nullable: false));
            AlterColumn("dbo.TeamLeaders", "experience", c => c.String(nullable: false));
            AlterColumn("dbo.ProjectManagers", "job_description", c => c.String(nullable: false));
            AlterColumn("dbo.ProjectManagers", "image", c => c.String(nullable: false));
            AlterColumn("dbo.ProjectManagers", "first_name", c => c.String(nullable: false));
            AlterColumn("dbo.ProjectManagers", "last_name", c => c.String(nullable: false));
            AlterColumn("dbo.ProjectManagers", "email", c => c.String(nullable: false));
            AlterColumn("dbo.ProjectManagers", "mobile", c => c.String(nullable: false));
            AlterColumn("dbo.ProjectManagers", "qualifications", c => c.String(nullable: false));
            AlterColumn("dbo.ProjectManagers", "experience", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ProjectManagers", "experience", c => c.String());
            AlterColumn("dbo.ProjectManagers", "qualifications", c => c.String());
            AlterColumn("dbo.ProjectManagers", "mobile", c => c.String());
            AlterColumn("dbo.ProjectManagers", "email", c => c.String());
            AlterColumn("dbo.ProjectManagers", "last_name", c => c.String());
            AlterColumn("dbo.ProjectManagers", "first_name", c => c.String());
            AlterColumn("dbo.ProjectManagers", "image", c => c.String());
            AlterColumn("dbo.ProjectManagers", "job_description", c => c.String());
            AlterColumn("dbo.TeamLeaders", "experience", c => c.String());
            AlterColumn("dbo.TeamLeaders", "qualifications", c => c.String());
            AlterColumn("dbo.TeamLeaders", "mobile", c => c.String());
            AlterColumn("dbo.TeamLeaders", "email", c => c.String());
            AlterColumn("dbo.TeamLeaders", "last_name", c => c.String());
            AlterColumn("dbo.TeamLeaders", "first_name", c => c.String());
            AlterColumn("dbo.TeamLeaders", "image", c => c.String());
            AlterColumn("dbo.TeamLeaders", "job_description", c => c.String());
            AlterColumn("dbo.Developers", "experience", c => c.String());
            AlterColumn("dbo.Developers", "qualifications", c => c.String());
            AlterColumn("dbo.Developers", "mobile", c => c.String());
            AlterColumn("dbo.Developers", "email", c => c.String());
            AlterColumn("dbo.Developers", "last_name", c => c.String());
            AlterColumn("dbo.Developers", "first_name", c => c.String());
            AlterColumn("dbo.Developers", "image", c => c.String());
            AlterColumn("dbo.Developers", "job_description", c => c.String());
            AlterColumn("dbo.Customers", "mobile", c => c.String());
            AlterColumn("dbo.Customers", "email", c => c.String());
            AlterColumn("dbo.Customers", "last_name", c => c.String());
            AlterColumn("dbo.Customers", "first_name", c => c.String());
            AlterColumn("dbo.Customers", "image", c => c.String());
            AlterColumn("dbo.Customers", "job_description", c => c.String());
            AlterColumn("dbo.Admins", "mobile", c => c.String());
            AlterColumn("dbo.Admins", "email", c => c.String());
            AlterColumn("dbo.Admins", "last_name", c => c.String());
            AlterColumn("dbo.Admins", "first_name", c => c.String());
            AlterColumn("dbo.Admins", "image", c => c.String());
            AlterColumn("dbo.Admins", "job_description", c => c.String());
        }
    }
}
