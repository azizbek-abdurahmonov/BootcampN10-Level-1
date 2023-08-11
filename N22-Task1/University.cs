using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N22_Task1
{
    internal class University<TStudent, TId, TGrade> where TStudent : Student<TId, TGrade>
    {
        public List<TStudent> Students { get; set; } = new List<TStudent>();
        public List<Course> Courses { get; set; } = new List<Course>();

        public void EnrollStudent(TStudent student, Course course)
        {
            Students.Add(student);
            Courses.Add(course);
        }

        public void Display()
        {
            for(var i = 0; i<Students.Count; i++)
            {
                Console.WriteLine($"{Students[i]} - {Courses[i].Title}");
            }
        }
    }
}
