namespace AberturasYa.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CustomerRelatedModels1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Addresses",
                c => new
                    {
                        AddressId = c.Int(nullable: false, identity: true),
                        Street = c.String(nullable: false, maxLength: 80),
                        Number = c.String(nullable: false, maxLength: 10),
                        ApartmentNumber = c.String(),
                        Corner1 = c.String(nullable: false, maxLength: 80),
                        Corner2 = c.String(),
                        Comments = c.String(),
                        Neighborhood = c.String(),
                        Zip = c.Int(),
                        CustomerId = c.Int(),
                        CompanyId = c.Int(),
                        StateId = c.Int(),
                    })
                .PrimaryKey(t => t.AddressId)
                .ForeignKey("dbo.Companies", t => t.CompanyId)
                .ForeignKey("dbo.Customers", t => t.CustomerId)
                .ForeignKey("dbo.States", t => t.StateId)
                .Index(t => t.CustomerId)
                .Index(t => t.CompanyId)
                .Index(t => t.StateId);
            
            CreateTable(
                "dbo.Companies",
                c => new
                    {
                        CompanyId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 80),
                        LegalName = c.String(nullable: false, maxLength: 80),
                        CompanyNumber = c.Int(nullable: false),
                        CustomerId = c.Int(),
                    })
                .PrimaryKey(t => t.CompanyId)
                .ForeignKey("dbo.Customers", t => t.CustomerId)
                .Index(t => t.CustomerId);
            
            CreateTable(
                "dbo.States",
                c => new
                    {
                        StateId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 80),
                    })
                .PrimaryKey(t => t.StateId);
            
            CreateTable(
                "dbo.Cities",
                c => new
                    {
                        CityId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 80),
                        StateId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CityId)
                .ForeignKey("dbo.States", t => t.StateId, cascadeDelete: true)
                .Index(t => t.StateId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cities", "StateId", "dbo.States");
            DropForeignKey("dbo.Addresses", "StateId", "dbo.States");
            DropForeignKey("dbo.Addresses", "CustomerId", "dbo.Customers");
            DropForeignKey("dbo.Addresses", "CompanyId", "dbo.Companies");
            DropForeignKey("dbo.Companies", "CustomerId", "dbo.Customers");
            DropIndex("dbo.Cities", new[] { "StateId" });
            DropIndex("dbo.Companies", new[] { "CustomerId" });
            DropIndex("dbo.Addresses", new[] { "StateId" });
            DropIndex("dbo.Addresses", new[] { "CompanyId" });
            DropIndex("dbo.Addresses", new[] { "CustomerId" });
            DropTable("dbo.Cities");
            DropTable("dbo.States");
            DropTable("dbo.Companies");
            DropTable("dbo.Addresses");
        }
    }
}
