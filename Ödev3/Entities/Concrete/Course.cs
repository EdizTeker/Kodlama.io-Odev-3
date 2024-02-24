using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workspace.Entities.Concrete

{
    public class Course
    {
        public string CourseName { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public string Category { get; set; }
        public string Instructor { get; set; }
        public int CompletionPercantage { get; set; }
        public int CourseID { get; set; }

    }



}