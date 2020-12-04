namespace AberturasYa.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateDb2 : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO SubCategories ( Name, CategoryId) VALUES ('Aluminio', 7)");
            Sql("INSERT INTO SubCategories ( Name, CategoryId) VALUES ('Madera', 7)");
            Sql("INSERT INTO SubCategories ( Name, CategoryId) VALUES ('Aluminio', 8)");
            Sql("INSERT INTO SubCategories ( Name, CategoryId) VALUES ('Madera', 8)");
            Sql("INSERT INTO SubCategories ( Name, CategoryId) VALUES ('Vidrio Templado', 9)");
            Sql("INSERT INTO SubCategories ( Name, CategoryId) VALUES ('Acrílico', 9)");

           
        }

        public override void Down()
        {
        }
    }
}
