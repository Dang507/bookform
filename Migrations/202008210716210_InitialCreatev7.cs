namespace VuBookStorev5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreatev7 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.BookDetails", name: "AuthorID_AuthorID", newName: "AuthorID");
            RenameColumn(table: "dbo.BookDetails", name: "BT_ID_BT_ID", newName: "BT_ID");
            RenameColumn(table: "dbo.BookDetails", name: "NxbID_NxbID", newName: "NxbID");
            RenameColumn(table: "dbo.BookDetails", name: "UserID_UserID", newName: "UserID");
            RenameIndex(table: "dbo.BookDetails", name: "IX_AuthorID_AuthorID", newName: "IX_AuthorID");
            RenameIndex(table: "dbo.BookDetails", name: "IX_UserID_UserID", newName: "IX_UserID");
            RenameIndex(table: "dbo.BookDetails", name: "IX_BT_ID_BT_ID", newName: "IX_BT_ID");
            RenameIndex(table: "dbo.BookDetails", name: "IX_NxbID_NxbID", newName: "IX_NxbID");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.BookDetails", name: "IX_NxbID", newName: "IX_NxbID_NxbID");
            RenameIndex(table: "dbo.BookDetails", name: "IX_BT_ID", newName: "IX_BT_ID_BT_ID");
            RenameIndex(table: "dbo.BookDetails", name: "IX_UserID", newName: "IX_UserID_UserID");
            RenameIndex(table: "dbo.BookDetails", name: "IX_AuthorID", newName: "IX_AuthorID_AuthorID");
            RenameColumn(table: "dbo.BookDetails", name: "UserID", newName: "UserID_UserID");
            RenameColumn(table: "dbo.BookDetails", name: "NxbID", newName: "NxbID_NxbID");
            RenameColumn(table: "dbo.BookDetails", name: "BT_ID", newName: "BT_ID_BT_ID");
            RenameColumn(table: "dbo.BookDetails", name: "AuthorID", newName: "AuthorID_AuthorID");
        }
    }
}
