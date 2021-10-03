using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace TestTask.Models
{
    public class SchoolContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Course> Courses { get; set; }
    }

    public class Student
    {
        [Key, Display(Name = "ID")]
        [ScaffoldColumn(false)]
        public int StudentID { get; set; }

        [Required, StringLength(40), Display(Name = "Фамилия")]
        public string LastName { get; set; }

        [Required, StringLength(20), Display(Name = "Имя")]
        public string FirstName { get; set; }

        [EnumDataType(typeof(AcademicYear)), Display(Name = "Курс")]
        public AcademicYear Year { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }

    public class Enrollment
    {
        [Key]
        public int EnrollmentID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        public decimal? Grade { get; set; }
        public virtual Course Course { get; set; }
        public virtual Student Student { get; set; }
    }

    public class Course
    {
        [Key]
        public int CourseID { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }
        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }

    public enum AcademicYear
    {
        FirstYear,
        SecondYear,
        ThirdYear,
        FourthYear
    }
}