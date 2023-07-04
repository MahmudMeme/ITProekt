namespace GameAndGamer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedDBSETS : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Games",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        ImgUrl = c.String(),
                        GenreId = c.Int(nullable: false),
                        Rating = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Developer = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Genres", t => t.GenreId, cascadeDelete: true)
                .Index(t => t.GenreId);
            
            CreateTable(
                "dbo.Genres",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Players",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        InGameName = c.String(nullable: false),
                        Age = c.Int(nullable: false),
                        Gender = c.String(nullable: false),
                        Description = c.String(),
                        UID = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PlayerGames",
                c => new
                    {
                        Player_Id = c.Int(nullable: false),
                        Game_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Player_Id, t.Game_Id })
                .ForeignKey("dbo.Players", t => t.Player_Id, cascadeDelete: true)
                .ForeignKey("dbo.Games", t => t.Game_Id, cascadeDelete: true)
                .Index(t => t.Player_Id)
                .Index(t => t.Game_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PlayerGames", "Game_Id", "dbo.Games");
            DropForeignKey("dbo.PlayerGames", "Player_Id", "dbo.Players");
            DropForeignKey("dbo.Games", "GenreId", "dbo.Genres");
            DropIndex("dbo.PlayerGames", new[] { "Game_Id" });
            DropIndex("dbo.PlayerGames", new[] { "Player_Id" });
            DropIndex("dbo.Games", new[] { "GenreId" });
            DropTable("dbo.PlayerGames");
            DropTable("dbo.Players");
            DropTable("dbo.Genres");
            DropTable("dbo.Games");
        }
    }
}
