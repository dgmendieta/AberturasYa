namespace AberturasYa.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CustomerRelatedModels : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Images", "ProductId", "dbo.Products");
            DropIndex("dbo.Images", new[] { "ProductId" });
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        CustomerId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 80),
                        LastName = c.String(nullable: false, maxLength: 80),
                        Email = c.String(nullable: false, maxLength: 50),
                        Phone = c.String(maxLength: 20),
                        Cellphone = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.CustomerId);
            
            AddColumn("dbo.Images", "CustomerId", c => c.Int());
            AlterColumn("dbo.Images", "ProductId", c => c.Int());
            CreateIndex("dbo.Images", "ProductId");
            CreateIndex("dbo.Images", "CustomerId");
            AddForeignKey("dbo.Images", "CustomerId", "dbo.Customers", "CustomerId");
            AddForeignKey("dbo.Images", "ProductId", "dbo.Products", "ProductId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Images", "ProductId", "dbo.Products");
            DropForeignKey("dbo.Images", "CustomerId", "dbo.Customers");
            DropIndex("dbo.Images", new[] { "CustomerId" });
            DropIndex("dbo.Images", new[] { "ProductId" });
            AlterColumn("dbo.Images", "ProductId", c => c.Int(nullable: false));
            DropColumn("dbo.Images", "CustomerId");
            DropTable("dbo.Customers");
            CreateIndex("dbo.Images", "ProductId");
            AddForeignKey("dbo.Images", "ProductId", "dbo.Products", "ProductId", cascadeDelete: true);
        }
    }
}
