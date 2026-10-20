using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_ass_oop3.t3
{
    internal class Store<T>
    {
        List<T> courses = new List<T>();

        public void  AddCourse(T course)
        {
            courses.Add(course);
        }
        public T GetById(int id)
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
        public List<T> GetAll()
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
