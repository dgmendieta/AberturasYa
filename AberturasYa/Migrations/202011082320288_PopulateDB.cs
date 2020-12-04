namespace AberturasYa.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    using System.Web.Mvc.Ajax;

    public partial class PopulateDB : DbMigration
    {
        public override void Up()
            
        {
            Sql("INSERT INTO Categories ( Name) VALUES ('Ventanas')");
            Sql("INSERT INTO Categories ( Name) VALUES ('Puertas')");
            Sql("INSERT INTO Categories ( Name) VALUES ('Mamparas')");

          
        }
        
        public override void Down()
        {
        }
    }
}
