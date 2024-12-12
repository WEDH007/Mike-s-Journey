using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace School.Classes
{
    class Grade
    {
        public Subject Subject { get; set; }
        public Student Student { get; set; }
        public int GradeNumber { get; set; }


        public Grade(Subject subject, Student student, int gradenumber)
        {
            Subject = subject;
            Student = student;
            GradeNumber = gradenumber;
        }


        public static void AssignGrade(Student student, List<Grade> gradeslist, Teacher teacher)
        {
            string prompt = "Enter the grade";
            string message = "Grade";
            int gradenumber = new Validation().Validationint(prompt, message);

            gradeslist.Add(new Grade(teacher.SubjectSpecialization, student, gradenumber));
            Console.WriteLine($"Grade has been assigned.");
        }

        public static void DisplayGradeInfoStudent(Student studentaccount, List<Grade> gradeslist)

        {
            if (gradeslist.Count == 0)
            {
                Console.WriteLine("No grades in the book.");
                Console.ReadLine();
                return;
            }
            else
            {
                foreach (Grade grade in gradeslist)
                {

                    if (grade.Student == studentaccount)
                    {
                        if (grade.GradeNumber == null)
                        {
                            Console.WriteLine($"{grade.Subject.SubjectName}: Grade has not been yet assigned.");
                        }
                        else
                        {
                            Console.WriteLine($"{grade.Subject.SubjectName}: {grade.GradeNumber}");
                        }
                    }
                }
            }



        }
    }
}


