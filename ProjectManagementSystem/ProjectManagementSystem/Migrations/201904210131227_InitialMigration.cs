namespace ProjectManagementSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Developers", "experience", c => c.String());
            AddColumn("dbo.ProjectManagers", "qualifications", c => c.String());
            AddColumn("dbo.ProjectManagers", "experience", c => c.String());
            AddColumn("dbo.TeamLeaders", "qualifications", c => c.String());
            AddColumn("dbo.TeamLeaders", "experience", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.TeamLeaders", "experience");
            DropColumn("dbo.TeamLeaders", "qualifications");
            DropColumn("dbo.ProjectManagers", "experience");
            DropColumn("dbo.ProjectManagers", "qualifications");
            DropColumn("dbo.Developers", "experience");
        }
    }
}
