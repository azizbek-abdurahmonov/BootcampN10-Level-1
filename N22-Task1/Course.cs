using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N22_Task1
{
    internal class Course
    {
        public Guid CourseId { get; set; }
        public string Title { get; set; }

        public Course(Guid id, string title)
        {
            CourseId = id;
            Title = title;
        }
    }
}
