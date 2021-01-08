namespace MVCMidTerm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CourseAndCourseStatusData : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into Courses(CourseName,CourseDescription,TutorName,CourseRating) values ('ASP.NET Core', 'ASP.NET Core for Beginners', 'Brughen Patel', 10)");
            Sql("Insert into Courses(CourseName,CourseDescription,TutorName,CourseRating) values ('Azure Cloud Development', 'Azure Cloud Development', 'Alan Rodrigues', 8)");
            Sql("Insert into Courses(CourseName,CourseDescription,TutorName,CourseRating) values ('CompTIA Certification', 'CompTIA Certification', 'Mike Meyers', 7)");
            Sql("Insert into Courses(CourseName,CourseDescription,TutorName,CourseRating) values ('C# Basics for beginners', 'C# Basics for beginners', 'Mosh Hamedani', 2)");
            
            Sql("Insert into CourseStatus(Status) Values('In-Progress')");
            Sql("Insert into CourseStatus(Status) Values('Completed')");

            AlterColumn("dbo.Students", "Grade", c => c.String(nullable: false, maxLength: 2));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Students", "Grade", c => c.String(nullable: false, maxLength: 30));
        }
    }
}
