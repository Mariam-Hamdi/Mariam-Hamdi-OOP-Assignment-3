using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_ass_oop3.t3
{
    public class StudentStore
    {
        List<Student> students = new List<Student>();

        public void AddStudent(Student student)
        {
            students.Add(student);
        }
        public Student GetById(int id)
        {
            foreach (var i in students)
            {
                if (i.Id == id)
                {
                    return i;
                }
            }
            return null;
        }
        public List<Student> GetAll()
        {
            return students;
        }
        public void Remove(int id)
        {
            var student = GetById(id);
            if (student != null)
            {
                students.Remove(student);
            }
        }
    }
}
