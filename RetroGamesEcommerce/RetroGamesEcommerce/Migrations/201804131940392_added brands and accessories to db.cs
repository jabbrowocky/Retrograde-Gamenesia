namespace RetroGamesEcommerce.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedbrandsandaccessoriestodb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Accessories",
                c => new
                    {
                        AccessoryId = c.Int(nullable: false, identity: true),
                        AccessoryType = c.String(),
                        AccessoryBrand_BrandId = c.Int(),
                        AccessoryConsole_ConsoleId = c.Int(),
                    })
                .PrimaryKey(t => t.AccessoryId)
                .ForeignKey("dbo.Brands", t => t.AccessoryBrand_BrandId)
                .ForeignKey("dbo.Consoles", t => t.AccessoryConsole_ConsoleId)
                .Index(t => t.AccessoryBrand_BrandId)
                .Index(t => t.AccessoryConsole_ConsoleId);
            
            CreateTable(
                "dbo.Brands",
                c => new
                    {
                        BrandId = c.Int(nullable: false, identity: true),
                        BrandName = c.String(),
                    })
                .PrimaryKey(t => t.BrandId);
            
            AddColumn("dbo.Consoles", "BrandId_BrandId", c => c.Int());
            AddColumn("dbo.Games", "ReleaseDate", c => c.DateTime(nullable: false));
            CreateIndex("dbo.Consoles", "BrandId_BrandId");
            AddForeignKey("dbo.Consoles", "BrandId_BrandId", "dbo.Brands", "BrandId");
            DropColumn("dbo.Consoles", "CompanyOfOrigin");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Consoles", "CompanyOfOrigin", c => c.String());
            DropForeignKey("dbo.Accessories", "AccessoryConsole_ConsoleId", "dbo.Consoles");
            DropForeignKey("dbo.Consoles", "BrandId_BrandId", "dbo.Brands");
            DropForeignKey("dbo.Accessories", "AccessoryBrand_BrandId", "dbo.Brands");
            DropIndex("dbo.Consoles", new[] { "BrandId_BrandId" });
            DropIndex("dbo.Accessories", new[] { "AccessoryConsole_ConsoleId" });
            DropIndex("dbo.Accessories", new[] { "AccessoryBrand_BrandId" });
            DropColumn("dbo.Games", "ReleaseDate");
            DropColumn("dbo.Consoles", "BrandId_BrandId");
            DropTable("dbo.Brands");
            DropTable("dbo.Accessories");
        }
    }
}
