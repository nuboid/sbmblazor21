using System;
using System.Collections.Generic;
using MyBlazorDbContext;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace TestDB
{
    class Program
    {
        static void Main(string[] args)
        {
            SelectCoursesWithStudents();


            Console.ReadKey();
        }

        private static void SelectCoursesWithStudents()
        {
            using (var db = new MyDbContext())
            {
                var query = db.Courses.Include(c => c.Students);
                var list = query.ToList();
                foreach (var c in list)
                {
                    Console.WriteLine(c.Name);
                    foreach (var s in c.Students)
                    {
                        Console.WriteLine(" " + s.Name);
                    }
                }
            }
        }


        private static void CreateCourseWithOneStudent()
        {
            using (var db = new MyDbContext())
            {
                var s = db.Students.Add(new Student
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "Kurt",
                    Birthdate = DateTime.Now,
                });

                var c = db.Courses.Add(new Course
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "Blazor",
                });

                c.Entity.Students = new List<Student>
                {
                    s.Entity
                };

                db.SaveChanges();
            }
        }
    }
}
