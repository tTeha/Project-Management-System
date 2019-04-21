namespace ProjectManagementSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration25 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Admins",
                c => new
                    {
                        adminID = c.Int(nullable: false, identity: true),
                        job_description = c.String(),
                        image = c.String(),
                        first_name = c.String(),
                        last_name = c.String(),
                        email = c.String(),
                        mobile = c.String(),
                    })
                .PrimaryKey(t => t.adminID);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        customerID = c.Int(nullable: false, identity: true),
                        job_description = c.String(),
                        image = c.String(),
                        first_name = c.String(),
                        last_name = c.String(),
                        email = c.String(),
                        mobile = c.String(),
                    })
                .PrimaryKey(t => t.customerID);
            
            CreateTable(
                "dbo.Developers",
                c => new
                    {
                        developerID = c.Int(nullable: false, identity: true),
                        job_description = c.String(),
                        image = c.String(),
                        first_name = c.String(),
                        last_name = c.String(),
                        email = c.String(),
                        mobile = c.String(),
                        qualifications = c.String(),
                    })
                .PrimaryKey(t => t.developerID);
            
            CreateTable(
                "dbo.ProjectManagers",
                c => new
                    {
                        managerID = c.Int(nullable: false, identity: true),
                        job_description = c.String(),
                        image = c.String(),
                        first_name = c.String(),
                        last_name = c.String(),
                        email = c.String(),
                        mobile = c.String(),
                    })
                .PrimaryKey(t => t.managerID);
            
            CreateTable(
                "dbo.TeamLeaders",
                c => new
                    {
                        leaderID = c.Int(nullable: false, identity: true),
                        job_description = c.String(),
                        image = c.String(),
                        first_name = c.String(),
                        last_name = c.String(),
                        email = c.String(),
                        mobile = c.String(),
                    })
                .PrimaryKey(t => t.leaderID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TeamLeaders");
            DropTable("dbo.ProjectManagers");
            DropTable("dbo.Developers");
            DropTable("dbo.Customers");
            DropTable("dbo.Admins");
        }
    }
}
