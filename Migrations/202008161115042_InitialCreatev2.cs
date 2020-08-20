namespace VuBookStorev5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreatev2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.BookDetails", "BT_ID_BT_ID", c => c.String(maxLength: 128));
            CreateIndex("dbo.BookDetails", "BT_ID_BT_ID");
            AddForeignKey("dbo.BookDetails", "BT_ID_BT_ID", "dbo.BookTitles", "BT_ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.BookDetails", "BT_ID_BT_ID", "dbo.BookTitles");
            DropIndex("dbo.BookDetails", new[] { "BT_ID_BT_ID" });
            DropColumn("dbo.BookDetails", "BT_ID_BT_ID");
        }
    }
}
