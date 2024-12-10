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

        public void AssignGrade()
        {

        }

        public void DisplayGradeInfo()
        {


        }
    }
}
