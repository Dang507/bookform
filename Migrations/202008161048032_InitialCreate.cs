namespace VuBookStorev5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Authors",
                c => new
                    {
                        AuthorID = c.String(nullable: false, maxLength: 128),
                        AuthorName = c.String(),
                    })
                .PrimaryKey(t => t.AuthorID);
            
            CreateTable(
                "dbo.BookDetails",
                c => new
                    {
                        BookID = c.String(nullable: false, maxLength: 128),
                        BookName = c.String(),
                        AuthorID_AuthorID = c.String(maxLength: 128),
                        NxbID_NxbID = c.String(maxLength: 128),
                        UserID_UserID = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.BookID)
                .ForeignKey("dbo.Authors", t => t.AuthorID_AuthorID)
                .ForeignKey("dbo.Nxbs", t => t.NxbID_NxbID)
                .ForeignKey("dbo.Users", t => t.UserID_UserID)
                .Index(t => t.AuthorID_AuthorID)
                .Index(t => t.NxbID_NxbID)
                .Index(t => t.UserID_UserID);
            
            CreateTable(
                "dbo.Nxbs",
                c => new
                    {
                        NxbID = c.String(nullable: false, maxLength: 128),
                        NxbName = c.String(),
                    })
                .PrimaryKey(t => t.NxbID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserID = c.String(nullable: false, maxLength: 128),
                        UserName = c.String(nullable: false),
                        UserPhone = c.Int(nullable: false),
                        UngayDK = c.DateTime(nullable: false),
                        UngayHetHan = c.DateTime(nullable: false),
                        Zipcode = c.Int(nullable: false),
                        UserEmail = c.String(),
                    })
                .PrimaryKey(t => t.UserID);
            
            CreateTable(
                "dbo.BookTitles",
                c => new
                    {
                        BT_ID = c.String(nullable: false, maxLength: 128),
                        BT_Name = c.String(),
                    })
                .PrimaryKey(t => t.BT_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.BookDetails", "UserID_UserID", "dbo.Users");
            DropForeignKey("dbo.BookDetails", "NxbID_NxbID", "dbo.Nxbs");
            DropForeignKey("dbo.BookDetails", "AuthorID_AuthorID", "dbo.Authors");
            DropIndex("dbo.BookDetails", new[] { "UserID_UserID" });
            DropIndex("dbo.BookDetails", new[] { "NxbID_NxbID" });
            DropIndex("dbo.BookDetails", new[] { "AuthorID_AuthorID" });
            DropTable("dbo.BookTitles");
            DropTable("dbo.Users");
            DropTable("dbo.Nxbs");
            DropTable("dbo.BookDetails");
            DropTable("dbo.Authors");
        }
    }
}
