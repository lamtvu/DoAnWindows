namespace GantChart.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Gantchart3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "ImageUrl", c => c.Binary());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "ImageUrl");
        }
    }
}
