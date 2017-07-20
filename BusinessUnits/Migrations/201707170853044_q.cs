namespace BusinessUnits.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class q : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.PhysicalAddresses", "Cities_CityId", "dbo.Cities");
            DropForeignKey("dbo.PhysicalAddresses", "Province_ProvinceId", "dbo.Provinces");
            DropForeignKey("dbo.PhysicalAddresses", "Region_RegionId", "dbo.Regions");
            DropForeignKey("dbo.PhysicalAddresses", "RegisterUser_UserId", "dbo.RegisteredUsers");
            DropIndex("dbo.PhysicalAddresses", new[] { "Cities_CityId" });
            DropIndex("dbo.PhysicalAddresses", new[] { "Province_ProvinceId" });
            DropIndex("dbo.PhysicalAddresses", new[] { "Region_RegionId" });
            DropIndex("dbo.PhysicalAddresses", new[] { "RegisterUser_UserId" });
            RenameColumn(table: "dbo.PhysicalAddresses", name: "Cities_CityId", newName: "CityId");
            RenameColumn(table: "dbo.PhysicalAddresses", name: "Province_ProvinceId", newName: "ProvinceId");
            RenameColumn(table: "dbo.PhysicalAddresses", name: "Region_RegionId", newName: "RegionId");
            RenameColumn(table: "dbo.PhysicalAddresses", name: "RegisterUser_UserId", newName: "UserId");
            AddColumn("dbo.PhysicalAddresses", "SuburbId", c => c.Int(nullable: false));
            AlterColumn("dbo.PhysicalAddresses", "CityId", c => c.Int(nullable: false));
            AlterColumn("dbo.PhysicalAddresses", "ProvinceId", c => c.Int(nullable: false));
            AlterColumn("dbo.PhysicalAddresses", "RegionId", c => c.Int(nullable: false));
            AlterColumn("dbo.PhysicalAddresses", "UserId", c => c.Int(nullable: false));
            CreateIndex("dbo.PhysicalAddresses", "CityId");
            CreateIndex("dbo.PhysicalAddresses", "ProvinceId");
            CreateIndex("dbo.PhysicalAddresses", "RegionId");
            CreateIndex("dbo.PhysicalAddresses", "UserId");
            AddForeignKey("dbo.PhysicalAddresses", "CityId", "dbo.Cities", "CityId", cascadeDelete: true);
            AddForeignKey("dbo.PhysicalAddresses", "ProvinceId", "dbo.Provinces", "ProvinceId", cascadeDelete: true);
            AddForeignKey("dbo.PhysicalAddresses", "RegionId", "dbo.Regions", "RegionId", cascadeDelete: true);
            AddForeignKey("dbo.PhysicalAddresses", "UserId", "dbo.RegisteredUsers", "UserId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PhysicalAddresses", "UserId", "dbo.RegisteredUsers");
            DropForeignKey("dbo.PhysicalAddresses", "RegionId", "dbo.Regions");
            DropForeignKey("dbo.PhysicalAddresses", "ProvinceId", "dbo.Provinces");
            DropForeignKey("dbo.PhysicalAddresses", "CityId", "dbo.Cities");
            DropIndex("dbo.PhysicalAddresses", new[] { "UserId" });
            DropIndex("dbo.PhysicalAddresses", new[] { "RegionId" });
            DropIndex("dbo.PhysicalAddresses", new[] { "ProvinceId" });
            DropIndex("dbo.PhysicalAddresses", new[] { "CityId" });
            AlterColumn("dbo.PhysicalAddresses", "UserId", c => c.Int());
            AlterColumn("dbo.PhysicalAddresses", "RegionId", c => c.Int());
            AlterColumn("dbo.PhysicalAddresses", "ProvinceId", c => c.Int());
            AlterColumn("dbo.PhysicalAddresses", "CityId", c => c.Int());
            DropColumn("dbo.PhysicalAddresses", "SuburbId");
            RenameColumn(table: "dbo.PhysicalAddresses", name: "UserId", newName: "RegisterUser_UserId");
            RenameColumn(table: "dbo.PhysicalAddresses", name: "RegionId", newName: "Region_RegionId");
            RenameColumn(table: "dbo.PhysicalAddresses", name: "ProvinceId", newName: "Province_ProvinceId");
            RenameColumn(table: "dbo.PhysicalAddresses", name: "CityId", newName: "Cities_CityId");
            CreateIndex("dbo.PhysicalAddresses", "RegisterUser_UserId");
            CreateIndex("dbo.PhysicalAddresses", "Region_RegionId");
            CreateIndex("dbo.PhysicalAddresses", "Province_ProvinceId");
            CreateIndex("dbo.PhysicalAddresses", "Cities_CityId");
            AddForeignKey("dbo.PhysicalAddresses", "RegisterUser_UserId", "dbo.RegisteredUsers", "UserId");
            AddForeignKey("dbo.PhysicalAddresses", "Region_RegionId", "dbo.Regions", "RegionId");
            AddForeignKey("dbo.PhysicalAddresses", "Province_ProvinceId", "dbo.Provinces", "ProvinceId");
            AddForeignKey("dbo.PhysicalAddresses", "Cities_CityId", "dbo.Cities", "CityId");
        }
    }
}
