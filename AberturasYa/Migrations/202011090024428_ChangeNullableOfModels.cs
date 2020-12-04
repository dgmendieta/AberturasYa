namespace AberturasYa.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeNullableOfModels : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Products", "SubCategoryId", "dbo.SubCategories");
            DropIndex("dbo.Products", new[] { "SubCategoryId" });
            AlterColumn("dbo.Products", "Stock", c => c.Double());
            AlterColumn("dbo.Products", "Discount", c => c.Double());
            AlterColumn("dbo.Products", "BarCode", c => c.Int());
            AlterColumn("dbo.Products", "SubCategoryId", c => c.Int());
            CreateIndex("dbo.Products", "SubCategoryId");
            AddForeignKey("dbo.Products", "SubCategoryId", "dbo.SubCategories", "SubCategoryId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "SubCategoryId", "dbo.SubCategories");
            DropIndex("dbo.Products", new[] { "SubCategoryId" });
            AlterColumn("dbo.Products", "SubCategoryId", c => c.Int(nullable: false));
            AlterColumn("dbo.Products", "BarCode", c => c.Int(nullable: false));
            AlterColumn("dbo.Products", "Discount", c => c.Double(nullable: false));
            AlterColumn("dbo.Products", "Stock", c => c.Double(nullable: false));
            CreateIndex("dbo.Products", "SubCategoryId");
            AddForeignKey("dbo.Products", "SubCategoryId", "dbo.SubCategories", "SubCategoryId", cascadeDelete: true);
        }
    }
}
