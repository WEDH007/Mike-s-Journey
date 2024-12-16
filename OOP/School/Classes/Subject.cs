using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace School.Classes
{
    class Subject
    {
        public string SubjectName { get; set; }
        public Teacher Teacher{ get; set; }

        public List<Student>? StudentList = new List<Student>();

        public Subject(string subjectname, Teacher teacher, List<Student> studentlist)
        {
            SubjectName = subjectname;
            Teacher = teacher;
            StudentList = studentlist;
        }

        public static string GetSubjectChoices(List<Subject> subjectlist)
        {

            string subjectchoices = null;
            for (int index = 0; index < subjectlist.Count; index++)
            {
                string choice = ($"{index}: {subjectlist[index].SubjectName}\n");
                subjectchoices = subjectchoices + choice;
            }
            return subjectchoices;
        }

        public void AssignTeacher()
        {

        }

        public void AddStudenttoSubject(Student student)
        {
            StudentList.Add(student);
        }


    }
}
