using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_ass_oop3.t3
{
    internal class CourseStore
    {
        List<Course> courses= new List<Course>();

        public void AddCourse(Course course)
        {
            courses.Add(course);
        }
        public Course GetById(int id)
        {
            foreach (var i in courses)
            {
                if (i.Id == id)
                {
                    return i;
                }
            }
            return null;
        }
        public List<Course> GetAll()
        {
            return courses;
        }
        public void Remove(int id)
        {
            var course = GetById(id);
            if (course != null)
            {
                courses.Remove(course);
            }
        }
    }
}
