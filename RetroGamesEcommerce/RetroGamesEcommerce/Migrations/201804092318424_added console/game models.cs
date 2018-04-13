namespace RetroGamesEcommerce.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedconsolegamemodels : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Consoles",
                c => new
                    {
                        ConsoleId = c.Int(nullable: false, identity: true),
                        ConsoleName = c.String(),
                        CompanyOfOrigin = c.String(),
                        ReleaseDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ConsoleId);
            
            CreateTable(
                "dbo.Games",
                c => new
                    {
                        GameId = c.Int(nullable: false, identity: true),
                        GameName = c.String(),
                        ConsoleId_ConsoleId = c.Int(),
                    })
                .PrimaryKey(t => t.GameId)
                .ForeignKey("dbo.Consoles", t => t.ConsoleId_ConsoleId)
                .Index(t => t.ConsoleId_ConsoleId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Games", "ConsoleId_ConsoleId", "dbo.Consoles");
            DropIndex("dbo.Games", new[] { "ConsoleId_ConsoleId" });
            DropTable("dbo.Games");
            DropTable("dbo.Consoles");
        }
    }
}
