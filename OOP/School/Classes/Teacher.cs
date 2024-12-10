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

        }
    }
}
