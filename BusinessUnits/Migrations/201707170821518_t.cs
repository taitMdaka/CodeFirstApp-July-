namespace BusinessUnits.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class t : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ApprovalStatus",
                c => new
                    {
                        StatusId = c.Int(nullable: false, identity: true),
                        IsApproved = c.Boolean(),
                    })
                .PrimaryKey(t => t.StatusId);
            
            CreateTable(
                "dbo.RegisteredUsers",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        Lastname = c.String(),
                        EmailAddress = c.String(),
                        Passwordhash = c.String(),
                        UserTypeId = c.Int(nullable: false),
                        GenderId = c.Int(nullable: false),
                        DepartmentId = c.Int(nullable: false),
                        StatusId = c.Int(nullable: false),
                        UserType_UserType1 = c.Int(),
                    })
                .PrimaryKey(t => t.UserId)
                .ForeignKey("dbo.ApprovalStatus", t => t.StatusId, cascadeDelete: true)
                .ForeignKey("dbo.Departments", t => t.DepartmentId, cascadeDelete: true)
                .ForeignKey("dbo.Genders", t => t.GenderId, cascadeDelete: true)
                .ForeignKey("dbo.UserTypes", t => t.UserType_UserType1)
                .Index(t => t.StatusId)
                .Index(t => t.DepartmentId)
                .Index(t => t.GenderId)
                .Index(t => t.UserType_UserType1);
            
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        DepartmentId = c.Int(nullable: false, identity: true),
                        DepartmentName = c.String(),
                    })
                .PrimaryKey(t => t.DepartmentId);
            
            CreateTable(
                "dbo.Genders",
                c => new
                    {
                        GenderId = c.Int(nullable: false, identity: true),
                        Sex = c.String(),
                    })
                .PrimaryKey(t => t.GenderId);
            
            CreateTable(
                "dbo.PhysicalAddresses",
                c => new
                    {
                        PhysicalAddressId = c.Int(nullable: false, identity: true),
                        StreetName = c.String(),
                        Unit = c.Int(nullable: false),
                        Cities_CityId = c.Int(),
                        Province_ProvinceId = c.Int(),
                        Region_RegionId = c.Int(),
                        RegisterUser_UserId = c.Int(),
                        Suburb_SuburId = c.Int(),
                    })
                .PrimaryKey(t => t.PhysicalAddressId)
                .ForeignKey("dbo.Cities", t => t.Cities_CityId)
                .ForeignKey("dbo.Provinces", t => t.Province_ProvinceId)
                .ForeignKey("dbo.Regions", t => t.Region_RegionId)
                .ForeignKey("dbo.RegisteredUsers", t => t.RegisterUser_UserId)
                .ForeignKey("dbo.Suburbs", t => t.Suburb_SuburId)
                .Index(t => t.Cities_CityId)
                .Index(t => t.Province_ProvinceId)
                .Index(t => t.Region_RegionId)
                .Index(t => t.RegisterUser_UserId)
                .Index(t => t.Suburb_SuburId);
            
            CreateTable(
                "dbo.Cities",
                c => new
                    {
                        CityId = c.Int(nullable: false, identity: true),
                        CityName = c.String(),
                    })
                .PrimaryKey(t => t.CityId);
            
            CreateTable(
                "dbo.Provinces",
                c => new
                    {
                        ProvinceId = c.Int(nullable: false, identity: true),
                        ProvinceName = c.String(),
                    })
                .PrimaryKey(t => t.ProvinceId);
            
            CreateTable(
                "dbo.Regions",
                c => new
                    {
                        RegionId = c.Int(nullable: false, identity: true),
                        RegionName = c.String(),
                    })
                .PrimaryKey(t => t.RegionId);
            
            CreateTable(
                "dbo.Suburbs",
                c => new
                    {
                        SuburId = c.Int(nullable: false, identity: true),
                        SuburbName = c.String(),
                    })
                .PrimaryKey(t => t.SuburId);
            
            CreateTable(
                "dbo.PostalAddresses",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        PostalAddress1 = c.String(),
                        PostalCode = c.String(),
                        AreaCode = c.String(),
                        PostalAddressID = c.Int(nullable: false),
                        RegisterUser_UserId = c.Int(),
                    })
                .PrimaryKey(t => t.UserId)
                .ForeignKey("dbo.RegisteredUsers", t => t.RegisterUser_UserId)
                .Index(t => t.RegisterUser_UserId);
            
            CreateTable(
                "dbo.UserLogDetails",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        UserLogDetailsId = c.Int(nullable: false),
                        Message = c.String(),
                        DateCreated = c.DateTime(nullable: false),
                        RegisterUser_UserId = c.Int(),
                    })
                .PrimaryKey(t => t.UserId)
                .ForeignKey("dbo.RegisteredUsers", t => t.RegisterUser_UserId)
                .Index(t => t.RegisterUser_UserId);
            
            CreateTable(
                "dbo.UserTypes",
                c => new
                    {
                        UserType1 = c.Int(nullable: false, identity: true),
                        descriptiom = c.String(),
                    })
                .PrimaryKey(t => t.UserType1);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.RegisteredUsers", "UserType_UserType1", "dbo.UserTypes");
            DropForeignKey("dbo.UserLogDetails", "RegisterUser_UserId", "dbo.RegisteredUsers");
            DropForeignKey("dbo.PostalAddresses", "RegisterUser_UserId", "dbo.RegisteredUsers");
            DropForeignKey("dbo.PhysicalAddresses", "Suburb_SuburId", "dbo.Suburbs");
            DropForeignKey("dbo.PhysicalAddresses", "RegisterUser_UserId", "dbo.RegisteredUsers");
            DropForeignKey("dbo.PhysicalAddresses", "Region_RegionId", "dbo.Regions");
            DropForeignKey("dbo.PhysicalAddresses", "Province_ProvinceId", "dbo.Provinces");
            DropForeignKey("dbo.PhysicalAddresses", "Cities_CityId", "dbo.Cities");
            DropForeignKey("dbo.RegisteredUsers", "GenderId", "dbo.Genders");
            DropForeignKey("dbo.RegisteredUsers", "DepartmentId", "dbo.Departments");
            DropForeignKey("dbo.RegisteredUsers", "StatusId", "dbo.ApprovalStatus");
            DropIndex("dbo.RegisteredUsers", new[] { "UserType_UserType1" });
            DropIndex("dbo.UserLogDetails", new[] { "RegisterUser_UserId" });
            DropIndex("dbo.PostalAddresses", new[] { "RegisterUser_UserId" });
            DropIndex("dbo.PhysicalAddresses", new[] { "Suburb_SuburId" });
            DropIndex("dbo.PhysicalAddresses", new[] { "RegisterUser_UserId" });
            DropIndex("dbo.PhysicalAddresses", new[] { "Region_RegionId" });
            DropIndex("dbo.PhysicalAddresses", new[] { "Province_ProvinceId" });
            DropIndex("dbo.PhysicalAddresses", new[] { "Cities_CityId" });
            DropIndex("dbo.RegisteredUsers", new[] { "GenderId" });
            DropIndex("dbo.RegisteredUsers", new[] { "DepartmentId" });
            DropIndex("dbo.RegisteredUsers", new[] { "StatusId" });
            DropTable("dbo.UserTypes");
            DropTable("dbo.UserLogDetails");
            DropTable("dbo.PostalAddresses");
            DropTable("dbo.Suburbs");
            DropTable("dbo.Regions");
            DropTable("dbo.Provinces");
            DropTable("dbo.Cities");
            DropTable("dbo.PhysicalAddresses");
            DropTable("dbo.Genders");
            DropTable("dbo.Departments");
            DropTable("dbo.RegisteredUsers");
            DropTable("dbo.ApprovalStatus");
        }
    }
}
