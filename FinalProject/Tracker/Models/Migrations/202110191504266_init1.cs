namespace Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "Lastname", c => c.String());
            DropColumn("dbo.Users", "Lastame");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "Lastame", c => c.String());
            DropColumn("dbo.Users", "Lastname");
        }
    }
}
