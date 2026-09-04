using System.Collections.Generic;

namespace CoachingMangementSystem
{
    internal static class DataStore
    {
        internal static List<Student> Students = new List<Student>();
        internal static List<Teacher> Teachers = new List<Teacher>();
        internal static List<Subject> Subjects = new List<Subject>();
        internal static List<ClassInfo> Classes = new List<ClassInfo>();
        internal static List<Mark> Marks = new List<Mark>();

        internal static List<Person> Users = new List<Person>();

        internal static void AddStudent(Student student)
        {
            Students.Add(student);
            Users.Add(student);
        }

        internal static void AddTeacher(Teacher teacher)
        {
            Teachers.Add(teacher);
            Users.Add(teacher);
        }

        internal static bool SearchStudent(string id, out Student student)
        {
            foreach (Student s in Students)
            {
                if (s.Id == id)
                {
                    student = s;
                    return true;
                }
            }

            student = null;
            return false;
        }

        internal static bool SearchTeacher(string id, out Teacher teacher)
        {
            foreach (Teacher t in Teachers)
            {
                if (t.Id == id)
                {
                    teacher = t;
                    return true;
                }
            }

            teacher = null;
            return false;
        }
    }
}
