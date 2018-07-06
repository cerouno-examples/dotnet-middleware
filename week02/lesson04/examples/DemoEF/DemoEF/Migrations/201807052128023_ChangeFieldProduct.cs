namespace DemoEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeFieldProduct : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Products", "LastName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "LastName", c => c.String());
        }
    }
}
