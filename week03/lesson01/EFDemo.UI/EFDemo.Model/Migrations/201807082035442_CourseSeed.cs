namespace EFDemo.Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CourseSeed : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Courses (Name) values ('.NET Middleware')");
            Sql("INSERT INTO Courses (Name) values ('Front-End Angular')");
            Sql("INSERT INTO Courses (Name) values ('Haskell')");
            Sql("INSERT INTO Courses (Name) values ('Arnold C')");
        }
        
        public override void Down()
        {
        }
    }
}
