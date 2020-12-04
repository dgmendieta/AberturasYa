namespace AberturasYa.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateDB4 : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Images ( Url, Name, ProductId) VALUES ('Content/Images/Ventana1.jpg', 'Ventana Aluminio 1', 2)");
            Sql("INSERT INTO Images ( Url, Name, ProductId) VALUES ('Content/Images/Ventana2.jpg', 'Ventana Aluminio 2', 3)");
            Sql("INSERT INTO Images ( Url, Name, ProductId) VALUES ('Content/Images/Ventana3.jpg', 'Ventana Aluminio 3', 4)");
            Sql("INSERT INTO Images ( Url, Name, ProductId) VALUES ('Content/Images/Ventana4.jpg', 'Ventana Aluminio 4', 5)");

        }

        public override void Down()
        {
        }
    }
}
