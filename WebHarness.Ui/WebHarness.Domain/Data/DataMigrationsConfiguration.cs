using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using WebHarness.Domain.Entities;

namespace WebHarness.Domain.Data
{
    public class DataMigrationsConfiguration: DbMigrationsConfiguration<DataContext>
    {
        public DataMigrationsConfiguration()
        {
            ContextKey = "WebHarness.Domain.Data.DataContext";
            AutomaticMigrationDataLossAllowed = true;
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(DataContext context)
        {
            var courses = new List<Course>
            {
                new Course {Name = "Math"},
                new Course {Name = "History"},
                new Course {Name = "Science"}
            };

            var students = new List<Student>
            {
                new Student {Course = courses[0], DateOfBirth = DateTime.Today, FirstName = "John", LastName = "Doe"},
                new Student {Course = courses[1], DateOfBirth = DateTime.Today.AddDays(1), FirstName = "Jane", LastName = "Doe"},
                new Student {Course = courses[2], DateOfBirth = DateTime.Today.AddDays(2), FirstName = "Tom", LastName = "Doe"}
            };

            context.Courses.AddRange(courses);
            context.Students.AddRange(students);

            context.SaveChanges();
        }
    }
}
