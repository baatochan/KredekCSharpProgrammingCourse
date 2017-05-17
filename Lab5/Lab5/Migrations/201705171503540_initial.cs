namespace Lab5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        BookID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Author = c.String(),
                        ISBN = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Publisher = c.String(),
                        YearOfPublishion = c.Int(),
                        Info = c.String(),
                        CategoryID = c.Int(),
                        BranchID = c.Int(),
                    })
                .PrimaryKey(t => t.BookID)
                .ForeignKey("dbo.Branches", t => t.BranchID)
                .ForeignKey("dbo.Categories", t => t.CategoryID)
                .Index(t => t.CategoryID)
                .Index(t => t.BranchID);
            
            CreateTable(
                "dbo.Branches",
                c => new
                    {
                        BranchID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        AddressLine1 = c.String(),
                        PostalCode = c.String(),
                        City = c.String(),
                        Phone = c.Int(),
                    })
                .PrimaryKey(t => t.BranchID);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CategoryID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.CategoryID);
            
            CreateTable(
                "dbo.Reservations",
                c => new
                    {
                        ReservationID = c.Int(nullable: false, identity: true),
                        ClientID = c.Int(nullable: false),
                        BookID = c.Int(nullable: false),
                        DateOfReservation = c.DateTime(),
                        DateOfPickup = c.DateTime(),
                        DateOfReturn = c.DateTime(),
                    })
                .PrimaryKey(t => t.ReservationID)
                .ForeignKey("dbo.Books", t => t.BookID, cascadeDelete: true)
                .ForeignKey("dbo.Clients", t => t.ClientID, cascadeDelete: true)
                .Index(t => t.ClientID)
                .Index(t => t.BookID);
            
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        ClientID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Surname = c.String(),
                        AddressLine1 = c.String(),
                        PostalCode = c.String(),
                        City = c.String(),
                        Phone = c.Int(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.ClientID);
            
            CreateTable(
                "dbo.Librarians",
                c => new
                    {
                        LibrarianID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Surname = c.String(),
                        HireDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.LibrarianID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reservations", "ClientID", "dbo.Clients");
            DropForeignKey("dbo.Reservations", "BookID", "dbo.Books");
            DropForeignKey("dbo.Books", "CategoryID", "dbo.Categories");
            DropForeignKey("dbo.Books", "BranchID", "dbo.Branches");
            DropIndex("dbo.Reservations", new[] { "BookID" });
            DropIndex("dbo.Reservations", new[] { "ClientID" });
            DropIndex("dbo.Books", new[] { "BranchID" });
            DropIndex("dbo.Books", new[] { "CategoryID" });
            DropTable("dbo.Librarians");
            DropTable("dbo.Clients");
            DropTable("dbo.Reservations");
            DropTable("dbo.Categories");
            DropTable("dbo.Branches");
            DropTable("dbo.Books");
        }
    }
}
