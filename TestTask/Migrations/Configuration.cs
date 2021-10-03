namespace TestTask.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using TestTask.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<TestTask.Models.SchoolContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(SchoolContext context)
        {

            context.Students.AddOrUpdate(
                 new Student
                 {
                     FirstName = "Иван",
                     LastName = "Иванов",
                     Year = AcademicYear.FirstYear
                 },
                 new Student
                 {
                     FirstName = "Петр",
                     LastName = "Петров",
                     Year = AcademicYear.FirstYear
                 },
                 new Student
                 {
                     FirstName = "Павел",
                     LastName = "Павлов",
                     Year = AcademicYear.SecondYear
                 },
                 new Student
                 {
                     FirstName = "Мария",
                     LastName = "Иванова",
                     Year = AcademicYear.SecondYear
                 },
                 new Student
                 {
                     FirstName = "Екатерина",
                     LastName = "Васильева",
                     Year = AcademicYear.ThirdYear
                 },
                 new Student
                 {
                     FirstName = "Илон",
                     LastName = "Маск",
                     Year = AcademicYear.ThirdYear
                 },
                 new Student
                 {
                     FirstName = "Джефф",
                     LastName = "Безос",
                     Year = AcademicYear.ThirdYear
                 },
                 new Student
                 {
                     FirstName = "Степан",
                     LastName = "Степанов",
                     Year = AcademicYear.ThirdYear
                 }
                 );

            context.SaveChanges();

            context.Courses.AddOrUpdate(
                new Course { Title = "Физика", Credits = 3 },
                new Course { Title = "Химия", Credits = 3 },
                new Course { Title = "Программирование", Credits = 3 },
                new Course { Title = "Python", Credits = 4 },
                new Course { Title = "JS", Credits = 4 },
                new Course { Title = "C++", Credits = 3 },
                new Course { Title = "SQL", Credits = 4 }
                );

            context.SaveChanges();

            context.Enrollments.AddOrUpdate(
                new Enrollment { StudentID = 1, CourseID = 1, Grade = 1 },
                new Enrollment { StudentID = 1, CourseID = 2, Grade = 3 },
                new Enrollment { StudentID = 1, CourseID = 3, Grade = 1 },
                new Enrollment { StudentID = 2, CourseID = 4, Grade = 2 },
                new Enrollment { StudentID = 2, CourseID = 5, Grade = 4 },
                new Enrollment { StudentID = 2, CourseID = 6, Grade = 4 },
                new Enrollment { StudentID = 3, CourseID = 1 },
                new Enrollment { StudentID = 4, CourseID = 1 },
                new Enrollment { StudentID = 4, CourseID = 2, Grade = 4 },
                new Enrollment { StudentID = 5, CourseID = 3, Grade = 3 },
                new Enrollment { StudentID = 6, CourseID = 4 },
                new Enrollment { StudentID = 7, CourseID = 5, Grade = 2 }
                );

            context.SaveChanges();
        }
    }
}
