using System;
using System.Collections.Generic;

namespace MyBlazorDbContext
{
    public class Student
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime Birthdate { get; set; }
        public List<Course> Courses { get; set; }
    }
}