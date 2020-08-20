namespace VuBookStorev5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreatev3 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.BookDetails", "NxbID_NxbID", "dbo.Nxbs");
            DropIndex("dbo.BookDetails", new[] { "NxbID_NxbID" });
            AddColumn("dbo.Nxbs", "BookID_BookID", c => c.String(maxLength: 128));
            CreateIndex("dbo.Nxbs", "BookID_BookID");
            AddForeignKey("dbo.Nxbs", "BookID_BookID", "dbo.BookDetails", "BookID");
            DropColumn("dbo.BookDetails", "NxbID_NxbID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.BookDetails", "NxbID_NxbID", c => c.String(maxLength: 128));
            DropForeignKey("dbo.Nxbs", "BookID_BookID", "dbo.BookDetails");
            DropIndex("dbo.Nxbs", new[] { "BookID_BookID" });
            DropColumn("dbo.Nxbs", "BookID_BookID");
            CreateIndex("dbo.BookDetails", "NxbID_NxbID");
            AddForeignKey("dbo.BookDetails", "NxbID_NxbID", "dbo.Nxbs", "NxbID");
        }
    }
}
