namespace ProjectManagementSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Posts", "customer_customerID", "dbo.Customers");
            DropIndex("dbo.Posts", new[] { "customer_customerID" });
            AlterColumn("dbo.Posts", "Header", c => c.String(nullable: false));
            AlterColumn("dbo.Posts", "description", c => c.String(nullable: false));
            AlterColumn("dbo.Posts", "post_status", c => c.String(nullable: false));
            AlterColumn("dbo.Posts", "customer_customerID", c => c.Int(nullable: false));
            CreateIndex("dbo.Posts", "customer_customerID");
            AddForeignKey("dbo.Posts", "customer_customerID", "dbo.Customers", "customerID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Posts", "customer_customerID", "dbo.Customers");
            DropIndex("dbo.Posts", new[] { "customer_customerID" });
            AlterColumn("dbo.Posts", "customer_customerID", c => c.Int());
            AlterColumn("dbo.Posts", "post_status", c => c.String());
            AlterColumn("dbo.Posts", "description", c => c.String());
            AlterColumn("dbo.Posts", "Header", c => c.String());
            CreateIndex("dbo.Posts", "customer_customerID");
            AddForeignKey("dbo.Posts", "customer_customerID", "dbo.Customers", "customerID");
        }
    }
}
