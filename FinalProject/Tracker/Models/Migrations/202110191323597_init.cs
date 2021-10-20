namespace Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Tips",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Lastame = c.String(),
                        Login = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.UserProgresses",
                c => new
                    {
                        UserId = c.Int(nullable: false),
                        TipId = c.Int(nullable: false),
                        DateTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => new { t.UserId, t.TipId })
                .ForeignKey("dbo.Tips", t => t.TipId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.TipId);
            
            CreateTable(
                "dbo.UserTips",
                c => new
                    {
                        User_Id = c.Int(nullable: false),
                        Tip_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.User_Id, t.Tip_Id })
                .ForeignKey("dbo.Users", t => t.User_Id, cascadeDelete: true)
                .ForeignKey("dbo.Tips", t => t.Tip_Id, cascadeDelete: true)
                .Index(t => t.User_Id)
                .Index(t => t.Tip_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserProgresses", "UserId", "dbo.Users");
            DropForeignKey("dbo.UserProgresses", "TipId", "dbo.Tips");
            DropForeignKey("dbo.UserTips", "Tip_Id", "dbo.Tips");
            DropForeignKey("dbo.UserTips", "User_Id", "dbo.Users");
            DropIndex("dbo.UserTips", new[] { "Tip_Id" });
            DropIndex("dbo.UserTips", new[] { "User_Id" });
            DropIndex("dbo.UserProgresses", new[] { "TipId" });
            DropIndex("dbo.UserProgresses", new[] { "UserId" });
            DropTable("dbo.UserTips");
            DropTable("dbo.UserProgresses");
            DropTable("dbo.Users");
            DropTable("dbo.Tips");
        }
    }
}
