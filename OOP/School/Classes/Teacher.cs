using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace School.Classes
{
    class Teacher : Person
    {


        public string TeacherID { get; set; }
        public Subject SubjectSpecialization { get; set; }
        public int YearsofExperience { get; set; }

        public Teacher(string name, int age, string address, string teacherId, int yearsofExperience) : base(name, age, address)
        {
            TeacherID = teacherId;
            YearsofExperience = yearsofExperience;

        }

        public static void AssingSubject(List<Teacher> teacherlist, Teacher teacheraccount, List<Subject> subjectlist)
        {
            foreach (Subject i in subjectlist)
            {
                if (teacheraccount == i.Teacher)
                {
                    teacheraccount.SubjectSpecialization = i;
                }
            }
        }

        public void AssignGrade()
        {

        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Address: {Address}");
            Console.WriteLine($"Teacher ID: {TeacherID}");
            Console.WriteLine($"Subject Specialization: {SubjectSpecialization}");
            Console.WriteLine($"Years of Experience: {YearsofExperience}");
            Console.ReadLine();

        }

        public static Teacher FindCurrentTeacher(string id, List<Teacher> teacherlist)
        {

            foreach (Teacher teacher in teacherlist)
            {
                if (id == teacher.TeacherID.ToString())
                {
                    Console.Clear();
                    
                    return teacher;
                }
            }

            Console.WriteLine("No Student not found.");
            return null;


        }

        //public static bool StudentinClassChecker(Student studentaccount, Teacher teacheraccount, List<Grade> gradeslist)
        //{
        //    foreach (Subject i in studentaccount.subjectlist)
        //    {
        //        if (i == teacheraccount.SubjectSpecialization)
        //        {
        //            Grade.AssignGrade(studentaccount, gradeslist, teacheraccount);
                    
        //        }
        //    }
           
        //}
    }
}
