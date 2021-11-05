namespace Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UP_ID : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.UserProgresses");
            AddColumn("dbo.UserProgresses", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.UserProgresses", "Id");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.UserProgresses");
            DropColumn("dbo.UserProgresses", "Id");
            AddPrimaryKey("dbo.UserProgresses", new[] { "UserId", "TipId" });
        }
    }
}
