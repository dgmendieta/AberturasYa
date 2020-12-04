namespace AberturasYa.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateDB3 : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Products ( Name, Description, Stock, CreatedAt, Price, Discount, IsActive, IsWebActive, IsSale, Code, BarCode, SubCategoryId) " +
                               "VALUES ('Ventanas 100 x 100 cm', 'Ventana Serie 20 100 x 100 cm color gris', 10, '" + DateTime.Now + "', 2500, 10, 1, 1, 1, 100100, 100100100, 15)");
            Sql("INSERT INTO Products ( Name, Description, Stock, CreatedAt, Price, Discount, IsActive, IsWebActive, IsSale, Code, BarCode, SubCategoryId) " +
                                "VALUES ('Ventanas 120 x 100 cm', 'Ventana Serie 20 120 x 100 cm color gris', 8, '" + DateTime.Now + "', 2800, 10, 1, 1, 1, 120100, 120100100, 15)");
            Sql("INSERT INTO Products ( Name, Description, Stock, CreatedAt, Price, Discount, IsActive, IsWebActive, IsSale, Code, BarCode, SubCategoryId) " +
                                "VALUES ('Puerta Mitad Vidrio', 'Puerta Mitad Vidrio color gris', 1, '" + DateTime.Now + "', 7500, 10, 1, 1, 1, 080200, 080200100, 17)");
            Sql("INSERT INTO Products ( Name, Description, Stock, CreatedAt, Price, Discount, IsActive, IsWebActive, IsSale, Code, BarCode, SubCategoryId) " +
                                "VALUES ('Mampara Vidrio 120 x 180 cm', 'Mampara Vidrio Templado 8 mm,  120 x 180 cm', 1, '" + DateTime.Now + "', 22500, 10, 1, 1, 1, 120180, 120180500, 19)");


           
        }

        public override void Down()
        {
        }
    }
}
