namespace AberturasYa.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ImageChanges : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Images", "CategoryId", c => c.Int());
            CreateIndex("dbo.Images", "CategoryId");
            AddForeignKey("dbo.Images", "CategoryId", "dbo.Categories", "CategoryId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Images", "CategoryId", "dbo.Categories");
            DropIndex("dbo.Images", new[] { "CategoryId" });
            DropColumn("dbo.Images", "CategoryId");
        }
    }
}
