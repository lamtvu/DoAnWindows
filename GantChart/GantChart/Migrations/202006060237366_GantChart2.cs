namespace GantChart.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class GantChart2 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Users", "ImageUrl");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "ImageUrl", c => c.String());
        }
    }
}
