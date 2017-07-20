
namespace BusinessUnits.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tr : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.PhysicalAddresses", "RegisterUser_UserId", "dbo.RegisteredUsers");
            DropForeignKey("dbo.PhysicalAddresses", "Suburb_SuburId", "dbo.Suburbs");
            DropIndex("dbo.PhysicalAddresses", new[] { "RegisterUser_UserId" });
            DropIndex("dbo.PhysicalAddresses", new[] { "Suburb_SuburId" });
            AddColumn("dbo.PhysicalAddresses", "RegisterUser_UserId1", c => c.Int());
            AddColumn("dbo.PhysicalAddresses", "Suburb_SuburId1", c => c.Int());
            AlterColumn("dbo.PhysicalAddresses", "RegisterUser_UserId", c => c.Int(nullable: false));
            AlterColumn("dbo.PhysicalAddresses", "Suburb_SuburId", c => c.Int(nullable: false));
            CreateIndex("dbo.PhysicalAddresses", "RegisterUser_UserId1");
            CreateIndex("dbo.PhysicalAddresses", "Suburb_SuburId1");
            AddForeignKey("dbo.PhysicalAddresses", "RegisterUser_UserId1", "dbo.RegisteredUsers", "UserId");
            AddForeignKey("dbo.PhysicalAddresses", "Suburb_SuburId1", "dbo.Suburbs", "SuburId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PhysicalAddresses", "Suburb_SuburId1", "dbo.Suburbs");
            DropForeignKey("dbo.PhysicalAddresses", "RegisterUser_UserId1", "dbo.RegisteredUsers");
            DropIndex("dbo.PhysicalAddresses", new[] { "Suburb_SuburId1" });
            DropIndex("dbo.PhysicalAddresses", new[] { "RegisterUser_UserId1" });
            AlterColumn("dbo.PhysicalAddresses", "Suburb_SuburId", c => c.Int());
            AlterColumn("dbo.PhysicalAddresses", "RegisterUser_UserId", c => c.Int());
            DropColumn("dbo.PhysicalAddresses", "Suburb_SuburId1");
            DropColumn("dbo.PhysicalAddresses", "RegisterUser_UserId1");
            CreateIndex("dbo.PhysicalAddresses", "Suburb_SuburId");
            CreateIndex("dbo.PhysicalAddresses", "RegisterUser_UserId");
            AddForeignKey("dbo.PhysicalAddresses", "Suburb_SuburId", "dbo.Suburbs", "SuburId");
            AddForeignKey("dbo.PhysicalAddresses", "RegisterUser_UserId", "dbo.RegisteredUsers", "UserId");
        }
    }
}
