namespace ProjectManagementSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.JdEvaluationByTLs",
                c => new
                    {
                        leaderID = c.Int(nullable: false),
                        developerID = c.Int(nullable: false),
                        evaluation = c.String(),
                    })
                .PrimaryKey(t => new { t.leaderID, t.developerID })
                .ForeignKey("dbo.Developers", t => t.developerID, cascadeDelete: true)
                .ForeignKey("dbo.TeamLeaders", t => t.leaderID, cascadeDelete: true)
                .Index(t => t.leaderID)
                .Index(t => t.developerID);
            
            CreateTable(
                "dbo.PmStuffRequests",
                c => new
                    {
                        leaderID = c.Int(nullable: false),
                        managerID = c.Int(nullable: false),
                        request_status = c.String(),
                    })
                .PrimaryKey(t => new { t.leaderID, t.managerID })
                .ForeignKey("dbo.ProjectManagers", t => t.managerID, cascadeDelete: true)
                .ForeignKey("dbo.TeamLeaders", t => t.leaderID, cascadeDelete: true)
                .Index(t => t.leaderID)
                .Index(t => t.managerID);
            
            CreateTable(
                "dbo.leaveProjectRequests",
                c => new
                    {
                        developerID = c.Int(nullable: false),
                        postID = c.Int(nullable: false),
                        managerID = c.Int(nullable: false),
                        leave_request = c.String(),
                    })
                .PrimaryKey(t => new { t.developerID, t.postID, t.managerID })
                .ForeignKey("dbo.Developers", t => t.developerID, cascadeDelete: true)
                .ForeignKey("dbo.Posts", t => t.postID, cascadeDelete: true)
                .ForeignKey("dbo.ProjectManagers", t => t.managerID, cascadeDelete: true)
                .Index(t => t.developerID)
                .Index(t => t.postID)
                .Index(t => t.managerID);
            
            CreateTable(
                "dbo.Posts",
                c => new
                    {
                        postID = c.Int(nullable: false, identity: true),
                        Header = c.String(),
                        description = c.String(),
                        created_date = c.DateTime(nullable: false),
                        updated_date = c.DateTime(nullable: false),
                        post_status = c.String(),
                        deliever_time = c.DateTime(nullable: false),
                        price = c.Int(nullable: false),
                        customer_customerID = c.Int(),
                        PM_managerID = c.Int(),
                    })
                .PrimaryKey(t => t.postID)
                .ForeignKey("dbo.Customers", t => t.customer_customerID)
                .ForeignKey("dbo.ProjectManagers", t => t.PM_managerID)
                .Index(t => t.customer_customerID)
                .Index(t => t.PM_managerID);
            
            CreateTable(
                "dbo.PmProjectApplies",
                c => new
                    {
                        managerID = c.Int(nullable: false),
                        postID = c.Int(nullable: false),
                        Response = c.String(),
                    })
                .PrimaryKey(t => new { t.managerID, t.postID })
                .ForeignKey("dbo.Posts", t => t.postID, cascadeDelete: true)
                .ForeignKey("dbo.ProjectManagers", t => t.managerID, cascadeDelete: true)
                .Index(t => t.managerID)
                .Index(t => t.postID);
            
            CreateTable(
                "dbo.PostComments",
                c => new
                    {
                        managerID = c.Int(nullable: false),
                        postID = c.Int(nullable: false),
                        Comment = c.String(),
                    })
                .PrimaryKey(t => new { t.managerID, t.postID })
                .ForeignKey("dbo.Posts", t => t.postID, cascadeDelete: true)
                .ForeignKey("dbo.ProjectManagers", t => t.managerID, cascadeDelete: true)
                .Index(t => t.managerID)
                .Index(t => t.postID);
            
            CreateTable(
                "dbo.RemoveJDbyTLrequests",
                c => new
                    {
                        leaderID = c.Int(nullable: false),
                        developerID = c.Int(nullable: false),
                        managerID = c.Int(nullable: false),
                        remove_request = c.String(),
                    })
                .PrimaryKey(t => new { t.leaderID, t.developerID, t.managerID })
                .ForeignKey("dbo.Developers", t => t.developerID, cascadeDelete: true)
                .ForeignKey("dbo.ProjectManagers", t => t.managerID, cascadeDelete: true)
                .ForeignKey("dbo.TeamLeaders", t => t.leaderID, cascadeDelete: true)
                .Index(t => t.leaderID)
                .Index(t => t.developerID)
                .Index(t => t.managerID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PmStuffRequests", "leaderID", "dbo.TeamLeaders");
            DropForeignKey("dbo.RemoveJDbyTLrequests", "leaderID", "dbo.TeamLeaders");
            DropForeignKey("dbo.RemoveJDbyTLrequests", "managerID", "dbo.ProjectManagers");
            DropForeignKey("dbo.RemoveJDbyTLrequests", "developerID", "dbo.Developers");
            DropForeignKey("dbo.PmStuffRequests", "managerID", "dbo.ProjectManagers");
            DropForeignKey("dbo.leaveProjectRequests", "managerID", "dbo.ProjectManagers");
            DropForeignKey("dbo.PostComments", "managerID", "dbo.ProjectManagers");
            DropForeignKey("dbo.PostComments", "postID", "dbo.Posts");
            DropForeignKey("dbo.PmProjectApplies", "managerID", "dbo.ProjectManagers");
            DropForeignKey("dbo.PmProjectApplies", "postID", "dbo.Posts");
            DropForeignKey("dbo.Posts", "PM_managerID", "dbo.ProjectManagers");
            DropForeignKey("dbo.leaveProjectRequests", "postID", "dbo.Posts");
            DropForeignKey("dbo.Posts", "customer_customerID", "dbo.Customers");
            DropForeignKey("dbo.leaveProjectRequests", "developerID", "dbo.Developers");
            DropForeignKey("dbo.JdEvaluationByTLs", "leaderID", "dbo.TeamLeaders");
            DropForeignKey("dbo.JdEvaluationByTLs", "developerID", "dbo.Developers");
            DropIndex("dbo.RemoveJDbyTLrequests", new[] { "managerID" });
            DropIndex("dbo.RemoveJDbyTLrequests", new[] { "developerID" });
            DropIndex("dbo.RemoveJDbyTLrequests", new[] { "leaderID" });
            DropIndex("dbo.PostComments", new[] { "postID" });
            DropIndex("dbo.PostComments", new[] { "managerID" });
            DropIndex("dbo.PmProjectApplies", new[] { "postID" });
            DropIndex("dbo.PmProjectApplies", new[] { "managerID" });
            DropIndex("dbo.Posts", new[] { "PM_managerID" });
            DropIndex("dbo.Posts", new[] { "customer_customerID" });
            DropIndex("dbo.leaveProjectRequests", new[] { "managerID" });
            DropIndex("dbo.leaveProjectRequests", new[] { "postID" });
            DropIndex("dbo.leaveProjectRequests", new[] { "developerID" });
            DropIndex("dbo.PmStuffRequests", new[] { "managerID" });
            DropIndex("dbo.PmStuffRequests", new[] { "leaderID" });
            DropIndex("dbo.JdEvaluationByTLs", new[] { "developerID" });
            DropIndex("dbo.JdEvaluationByTLs", new[] { "leaderID" });
            DropTable("dbo.RemoveJDbyTLrequests");
            DropTable("dbo.PostComments");
            DropTable("dbo.PmProjectApplies");
            DropTable("dbo.Posts");
            DropTable("dbo.leaveProjectRequests");
            DropTable("dbo.PmStuffRequests");
            DropTable("dbo.JdEvaluationByTLs");
        }
    }
}
