using System.Collections.Generic;

namespace MyBlazorDbContext
{
    public class Course
    {
        public string Id { get; set; }
        public List<Student> Students { get; set; }
        public string Name  { get; set; }
        public string Description  { get; set; }
    }
}