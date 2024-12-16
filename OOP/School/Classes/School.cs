using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace School.Classes
{
    class School
    {
        public List<Student> studentlist = new List<Student>();
        public List<Teacher> teacherlist = new List<Teacher>();

        public void AddStudent()
        {

        }

        public void RemoveStudent()
        {

        }

        public void AddTeacher()
        {

        }

        public void RemoveTeacher()
        {

        }

        public static void GenerateReport<T>(List<T> list)
        {
            string x = null;
            for (int index = 0; index < list.Count; index++)
            {
                string add = ($"{index}: {list[index].Name}\n");
                x = x + add;
            }
            Console.WriteLine(x);

        }


        


        



        string subjectchoices = null;
                for (int index = 0; index<teacheraccount.SubjectSpecialization.Count; index++)
                {
                    string add = ($"{index}: {teacheraccount.SubjectSpecialization[index].SubjectName}\n");
    subjectchoices = subjectchoices + add;
                }
Console.WriteLine(subjectchoices);








    }
}
