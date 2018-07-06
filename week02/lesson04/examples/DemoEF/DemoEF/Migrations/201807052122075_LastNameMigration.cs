namespace DemoEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class LastNameMigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "LastName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "LastName");
        }
    }
}
