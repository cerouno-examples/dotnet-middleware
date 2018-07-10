namespace SchoolWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seed : DbMigration
    {
        public override void Up()
        {
            Sql("insert into Courses(name) values ('Front-end Angular');");
            Sql("insert into Courses(name) values ('Middleware .NET');");
            Sql("insert into Courses(name) values ('Arnold C');");
        }
        
        public override void Down()
        {
        }
    }
}
